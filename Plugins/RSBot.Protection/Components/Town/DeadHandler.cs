using System.Linq;
using System.Threading.Tasks;
using RSBot.Core;
using RSBot.Core.Event;
using RSBot.Core.Network;
using RSBot.Core.Objects;

namespace RSBot.Protection.Components.Town;

public class DeadHandler : AbstractTownHandler
{
    public static void Initialize()
    {
        SubscribeEvents();
    }

    private static void SubscribeEvents()
    {
        EventManager.SubscribeEvent("OnPlayerDied", OnPlayerDied);
    }

    private static async void OnPlayerDied()
    {
        Log.Debug("[DeadHandler] OnPlayerDied triggered!");

        if (!Kernel.Bot.Running)
        {
            Log.Debug("[DeadHandler] Bot not running, skipping");
            return;
        }

        if (Game.Player.Level < 10)
        {
            Log.Debug("[DeadHandler] Player level < 10, auto resurrect");
            await Task.Delay(5000);
            var upPacket = new Packet(0x3053);
            upPacket.WriteByte(2);
            PacketManager.SendPacket(upPacket, PacketDestination.Server);
            return;
        }

        if (Game.Player.State.LifeState != LifeState.Dead)
        {
            Log.Debug("[DeadHandler] Player is not dead");
            return;
        }

        // ✅ الميزة الجديدة أولاً (مستقلة عن checkDead)
        Log.Debug("[DeadHandler] Checking ShouldReturnToTown...");
        if (ShouldReturnToTown())
        {
            Log.Notify("[Protection] Died outside training area - Returning to town");
            await Task.Delay(3000);
            ReturnToTown();
            return;
        }

        // باقي الكود العادي (يحتاج checkDead)
        if (!PlayerConfig.Get<bool>("RSBot.Protection.checkDead"))
        {
            Log.Debug("[DeadHandler] checkDead is disabled");
            return;
        }

        var itemsToUse = PlayerConfig.GetArray<string>("RSBot.Inventory.AutoUseAccordingToPurpose");
        var inventoryItem = Game.Player.Inventory.GetItem(
            new TypeIdFilter(3, 3, 13, 6),
            p => itemsToUse.Contains(p.Record.CodeName)
        );
        if (inventoryItem != null)
        {
            inventoryItem.Use();
            return;
        }

        var timeOut = PlayerConfig.Get("RSBot.Protection.numDeadTimeout", 30);
        Log.WarnLang("ResurrectSPointSeconds", timeOut);
        await Task.Delay(timeOut * 1000);

        if (Game.Player.State.LifeState != LifeState.Dead)
            return;

        var packet = new Packet(0x3053);
        packet.WriteByte(1);
        PacketManager.SendPacket(packet, PacketDestination.Server);
    }

    private static bool ShouldReturnToTown()
    {
        var backTownIfDeadOutside = PlayerConfig.Get<bool>("RSBot.Protection.checkBackTownIfDeadOutside", false);
        Log.Debug($"[DeadHandler] checkBackTownIfDeadOutside = {backTownIfDeadOutside}");

        if (!backTownIfDeadOutside)
            return false;

        var hasArea = HasTrainingArea();
        Log.Debug($"[DeadHandler] HasTrainingArea = {hasArea}");

        if (!hasArea)
            return false;

        var inArea = IsInTrainingArea();
        Log.Debug($"[DeadHandler] IsInTrainingArea = {inArea}");

        if (!inArea)
            return true;

        return false;
    }

    private static bool HasTrainingArea()
    {
        var region = PlayerConfig.Get<ushort>("RSBot.Area.Region", 0);
        return region != 0;
    }

    private static bool IsInTrainingArea()
    {
        var region = PlayerConfig.Get<ushort>("RSBot.Area.Region", 0);
        var x = PlayerConfig.Get<float>("RSBot.Area.X", 0);
        var y = PlayerConfig.Get<float>("RSBot.Area.Y", 0);
        var radius = PlayerConfig.Get<int>("RSBot.Area.Radius", 50);

        if (region == 0)
            return true;

        var trainingCenter = new Position(region, x, y, 0);
        var distance = Game.Player.Position.DistanceTo(trainingCenter);

        Log.Debug($"[DeadHandler] Distance from training area: {distance:F0}m");

        return distance <= (radius + 20);
    }

    private static void ReturnToTown()
    {
        Log.Debug("[DeadHandler] Sending return to town packet");
        var packet = new Packet(0x3053);
        packet.WriteByte(1);
        PacketManager.SendPacket(packet, PacketDestination.Server);
    }
}