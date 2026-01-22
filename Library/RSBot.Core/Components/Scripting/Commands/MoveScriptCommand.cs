using System;
using System.Collections.Generic;
using System.Threading;
using RSBot.Core.Objects;

namespace RSBot.Core.Components.Scripting.Commands;

internal class MoveScriptCommand : IScriptCommand
{
    #region Properties

    public string Name => "move";
    public bool IsBusy { get; private set; }
    public static bool MustDismount { get; set; }

    // الحد الأقصى لكل خطوة
    private const float MaxStepDistance = 80f;

    // الحد الأقصى للانتظار (بالمللي ثانية)
    private const int MoveTimeout = 10000;

    public Dictionary<string, string> Arguments => new()
    {
        { "XOffset", "The X offset" },
        { "YOffset", "The Y offset" },
        { "ZOffset", "The Z offset" },
        { "XSector", "The X sector" },
        { "YSector", "The Y sector" },
    };

    #endregion

    #region Methods

    public bool Execute(string[] arguments = null)
    {
        if (arguments == null || arguments.Length != Arguments.Count)
        {
            Log.Warn("[Script] Invalid move command: Invalid arguments.");
            return false;
        }

        if (IsBusy)
            return false;

        try
        {
            IsBusy = true;

            // انتظار انتهاء أي Action
            WaitForPlayerReady();

            const int retryAttempts = 5;
            var stepRetryCounter = 0;

            while (!ExecuteMove(arguments))
            {
                if (!IsBusy)
                    return false;

                if (stepRetryCounter++ >= retryAttempts)
                {
                    Log.Warn("[Script] Move command failed after max retries!");
                    return false;
                }

                Log.Debug($"[Script] Retry {stepRetryCounter}/{retryAttempts}...");
                Thread.Sleep(1000);
            }

            return true;
        }
        finally
        {
            IsBusy = false;
        }
    }

    private bool ExecuteMove(IReadOnlyList<string> arguments)
    {
        // تحويل المعاملات
        if (!float.TryParse(arguments[0], out var xOffset) ||
            !float.TryParse(arguments[1], out var yOffset) ||
            !float.TryParse(arguments[2], out var zOffset) ||
            !byte.TryParse(arguments[3], out var xSector) ||
            !byte.TryParse(arguments[4], out var ySector))
        {
            return false;
        }

        Position currentPos = Game.Player.Position;
        Position targetPos = new(xSector, ySector, xOffset, yOffset, zOffset);

        // استخدام Speed Drug و Mount
        PrepareForMovement();

        var distance = targetPos.DistanceTo(currentPos);

        Log.Debug($"[Script] Moving to {targetPos.Region} - Distance: {distance:F0}m");

        // لو المسافة بعيدة، قسمها
        if (distance > MaxStepDistance)
        {
            return MoveInSteps(currentPos, targetPos);
        }

        // لو قريبة، تحرك مباشرة
        return ExecuteSingleMove(targetPos);
    }

    /// <summary>
    /// تقسيم المسافة الطويلة لخطوات
    /// </summary>
    private bool MoveInSteps(Position from, Position to)
    {
        var totalDistance = from.DistanceTo(to);
        var steps = (int)Math.Ceiling(totalDistance / MaxStepDistance);

        Log.Notify($"[Script] Long distance ({totalDistance:F0}m) - Splitting into {steps} steps");

        Position currentPos = from;

        for (int i = 1; i <= steps; i++)
        {
            if (!IsBusy || !ScriptManager.Running)
                return false;

            // حساب النقطة الوسيطة
            float progress = (float)i / steps;
            Position nextPos = InterpolatePosition(from, to, progress);

            Log.Debug($"[Script] Step {i}/{steps}");

            // التحرك
            if (!ExecuteSingleMove(nextPos))
            {
                Log.Warn($"[Script] Step {i} failed, retrying...");
                Thread.Sleep(500);

                // محاولة ثانية
                if (!ExecuteSingleMove(nextPos))
                    return false;
            }

            // انتظار الوصول
            if (!WaitForArrival(nextPos))
            {
                Log.Warn($"[Script] Timeout at step {i}");
                return false;
            }

            currentPos = nextPos;
        }

        return true;
    }

    /// <summary>
    /// حساب نقطة وسيطة
    /// </summary>
    private Position InterpolatePosition(Position from, Position to, float t)
    {
        t = Math.Clamp(t, 0f, 1f);

        // لو نفس الـ Region
        if (from.Region == to.Region)
        {
            float fromX = Convert.ToSingle(from.XOffset);
            float fromY = Convert.ToSingle(from.YOffset);
            float fromZ = Convert.ToSingle(from.ZOffset);

            float toX = Convert.ToSingle(to.XOffset);
            float toY = Convert.ToSingle(to.YOffset);
            float toZ = Convert.ToSingle(to.ZOffset);

            return new Position(
                from.Region.X,
                from.Region.Y,
                Lerp(fromX, toX, t),
                Lerp(fromY, toY, t),
                Lerp(fromZ, toZ, t)
            );
        }

        // لو Regions مختلفة - استخدم World coordinates
        float worldFromX = Convert.ToSingle(from.X);
        float worldFromY = Convert.ToSingle(from.Y);
        float worldFromZ = Convert.ToSingle(from.Z);

        float worldToX = Convert.ToSingle(to.X);
        float worldToY = Convert.ToSingle(to.Y);
        float worldToZ = Convert.ToSingle(to.Z);

        float worldX = Lerp(worldFromX, worldToX, t);
        float worldY = Lerp(worldFromY, worldToY, t);
        float worldZ = Lerp(worldFromZ, worldToZ, t);

        return Position.FromWorld(worldX, worldY, worldZ);
    }

    /// <summary>
    /// دالة Lerp - دالة واحدة فقط!
    /// </summary>
    private float Lerp(float a, float b, float t) => a + (b - a) * t;

    /// <summary>
    /// تنفيذ حركة واحدة
    /// </summary>
    private bool ExecuteSingleMove(Position target)
    {
        if (MustDismount)
        {
            MustDismount = false;
            Game.Player.Vehicle?.Dismount();
            Thread.Sleep(500);
        }

        return Game.Player.MoveTo(target);
    }

    /// <summary>
    /// انتظار الوصول للهدف
    /// </summary>
    private bool WaitForArrival(Position target, float tolerance = 15f)
    {
        int elapsed = 0;

        while (elapsed < MoveTimeout)
        {
            if (!IsBusy || !ScriptManager.Running)
                return false;

            // هل وصلنا؟
            var distance = Game.Player.Position.DistanceTo(target);
            if (distance <= tolerance)
                return true;

            // هل اللاعب توقف؟
            if (!Game.Player.Movement.Moving && elapsed > 2000)
            {
                Log.Debug("[Script] Player stopped moving, checking position...");
                if (distance <= tolerance * 2)
                    return true;
            }

            Thread.Sleep(200);
            elapsed += 200;
        }

        return false;
    }

    /// <summary>
    /// تحضير اللاعب للحركة (Speed Drug + Mount)
    /// </summary>
    private void PrepareForMovement()
    {
        // ✅ Speed Drug القديم
        if (PlayerConfig.Get("RSBot.Training.checkUseSpeedDrug", true))
        {
            UseSpeedDrug();
        }

        // ✅ Speed Drug الجديد (لما يروح منطقة التدريب)
        if (PlayerConfig.Get("RSBot.Training.checkUseSpeedOnWalkback", false))
        {
            UseSpeedDrug();
        }

        // Mount
        if (PlayerConfig.Get("RSBot.Training.checkUseMount", true))
        {
            UseMount();
        }
    }

    private void UseSpeedDrug()
    {
        if (Game.Player.HasActiveVehicle || Game.Player.InAction)
            return;

        // تحقق من عدم وجود buff سرعة
        var hasSpeedBuff = Game.Player.State.ActiveBuffs
            .FindIndex(p => p.Record.Params.Contains(1752396901)) >= 0;

        if (hasSpeedBuff)
            return;

        var speedItem = Game.Player.Inventory.GetItem(
            new TypeIdFilter(3, 3, 13, 1),
            p => p.Record.Desc1.Contains("_SPEED_")
        );

        speedItem?.Use();
    }

    private void UseMount()
    {
        if (Game.Player.HasActiveVehicle || Game.Player.InAction)
            return;

        // Fellow
        Game.Player.SummonFellow();
        var fellow = Game.Player.Fellow;

        if (fellow != null)
        {
            fellow.CastSkill("P2SKILL_SPECIAL_SP_GET_A");

            if (Game.Player.Position.DistanceTo(fellow.Position) <= 5.0)
            {
                fellow.Mount();
                return;
            }
        }

        // Vehicle
        if (!Game.Player.IsInDungeon)
        {
            Game.Player.SummonVehicle();
        }
    }

    private void WaitForPlayerReady()
    {
        while (Game.Player.InAction && IsBusy)
        {
            Thread.Sleep(100);
        }
    }

    public void Stop()
    {
        IsBusy = false;
    }

    #endregion
}
