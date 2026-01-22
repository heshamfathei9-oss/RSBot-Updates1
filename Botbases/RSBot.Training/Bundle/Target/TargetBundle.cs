using System.Collections.Generic;
using System.Linq;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Event;
using RSBot.Core.Extensions;
using RSBot.Core.Objects;
using RSBot.Core.Objects.Spawn;

namespace RSBot.Training.Bundle.Target;

internal class TargetBundle : IBundle
{
    private const int BLACKLIST_TIMEOUT = 5_000;

    #region Fields

    private Dictionary<uint, int> _blacklist;

    #endregion Fields

    #region Constructor

    public TargetBundle()
    {
        SubscribeEvents();
    }

    #endregion Constructor

    #region Events

    private void OnTargetBehindObstacle()
    {
        if (Game.SelectedEntity == null)
            return;

        var selectedEntityUniqueId = Game.SelectedEntity.UniqueId;
        Game.SelectedEntity?.TryDeselect();
        Game.SelectedEntity = null;

        Bundles.Movement.LastEntityWasBehindObstacle = true;

        if (_blacklist?.TryAdd(selectedEntityUniqueId, Kernel.TickCount) == true)
            Log.Debug($"Add mob [{selectedEntityUniqueId}] to blacklist for {BLACKLIST_TIMEOUT}ms");
    }

    #endregion Events

    #region Methods

    private void SubscribeEvents()
    {
        EventManager.SubscribeEvent("OnTargetBehindObstacle", OnTargetBehindObstacle);
    }

    /// <summary>
    ///     Invokes this instance.
    /// </summary>
    public void Invoke()
    {
        // تنظيف القائمة السوداء من الوحوش المنتهية مدتها
        _blacklist?.RemoveAll(
            (uniqueId, tick) =>
            {
                var flag = Kernel.TickCount - tick > BLACKLIST_TIMEOUT;
                if (flag)
                    Log.Debug($"Removed mob [{uniqueId}] from blacklist!");

                return flag;
            }
        );

        // حالة الطوارئ: إذا كان هناك وحوش تهاجم اللاعب
        var attacker = GetFromCurrentAttackers();
        if (attacker != null && Game.SelectedEntity == null)
        {
            Log.Debug("[TargetBundle] Emergency situation: Attacking the weaker mob first!");

            if (attacker.TrySelect())
                Bundles.Movement.LastEntityWasBehindObstacle = false;

            return;
        }

        // تبديل الهدف للوحش الأضعف إذا كان هناك وحش أضعف يهاجم
        if (
            attacker != null
            && SpawnManager.TryGetEntity<SpawnedMonster>(Game.SelectedEntity.UniqueId, out var selectedMonster)
            && (byte)attacker.Rarity < (byte)selectedMonster.Rarity
        )
        {
            Log.Debug("[TargetBundle] Emergency situation: Found a weaker mob to attack first, switching target!");

            if (attacker.TrySelect())
                Bundles.Movement.LastEntityWasBehindObstacle = false;

            return;
        }

        // ✅ التعديل: فحص إذا كان الهدف ليس وحش (NPC أو لاعب أو غيره)
        if (Game.SelectedEntity != null && Game.SelectedEntity is not SpawnedMonster)
        {
            Log.Debug("[TargetBundle] Selected entity is not a monster, deselecting...");
            Game.SelectedEntity.TryDeselect();
            Game.SelectedEntity = null;
        }

        // وضع الـ Warlock: تجاهل الوحوش التي عليها تأثيرات
        var warlockModeEnabled = PlayerConfig.Get("RSBot.Skills.checkWarlockMode", false);
        if (warlockModeEnabled && Game.SelectedEntity?.State.HasTwoDots() == true)
            return;

        // إذا كان الهدف الحالي حي، استمر في مهاجمته
        if (Game.SelectedEntity?.State.LifeState == LifeState.Alive)
            return;

        // البحث عن أقرب وحش
        var monster = GetNearestEnemy();
        if (monster == null)
            return;

        // التأكد من أن الوحش في منطقة التدريب
        if (!Container.Bot.Area.IsInSight(monster))
            return;

        // تحديد الوحش الجديد
        if (monster.TrySelect())
            Bundles.Movement.LastEntityWasBehindObstacle = false;
    }

    /// <summary>
    ///     الحصول على الوحش الأضعف من الوحوش التي تهاجم اللاعب
    /// </summary>
    private SpawnedMonster GetFromCurrentAttackers()
    {
        var attackWeakerFirst = PlayerConfig.Get<bool>("RSBot.Training.checkAttackWeakerFirst");
        if (!attackWeakerFirst || !IsEmergencySituation())
            return null;

        if (
            !SpawnManager.TryGetEntities<SpawnedMonster>(
                e => e.AttackingPlayer && e.State.LifeState == LifeState.Alive,
                out var entities
            )
        )
            return null;

        return entities
            .OrderBy(e => (byte)e.Rarity)
            .ThenBy(e => e.Record.Level)
            .ThenByDescending(e => e.Position.DistanceToPlayer())
            .FirstOrDefault();
    }

    /// <summary>
    ///     فحص إذا كانت هناك حالة طوارئ
    /// </summary>
    private bool IsEmergencySituation()
    {
        return SpawnManager.Any<SpawnedMonster>(e =>
            e.AttackingPlayer && e.State.LifeState == LifeState.Alive && Bundles.Avoidance.AvoidMonster(e.Rarity)
        );
    }

    /// <summary>
    ///     الحصول على أقرب وحش
    /// </summary>
    private SpawnedMonster GetNearestEnemy()
    {
        var warlockModeEnabled = PlayerConfig.Get<bool>("RSBot.Skills.checkWarlockMode");
        var ignorePillar = PlayerConfig.Get<bool>("RSBot.Training.checkBoxDimensionPillar");

        if (
            !SpawnManager.TryGetEntities<SpawnedMonster>(
                m =>
                    m.State.LifeState == LifeState.Alive
                    && !(warlockModeEnabled && m.State.HasTwoDots())
                    && m.IsBehindObstacle == false
                    && (_blacklist == null || !_blacklist.ContainsKey(m.UniqueId))
                    && (m.AttackingPlayer || !Bundles.Avoidance.AvoidMonster(m.Rarity))
                    && Container.Bot.Area.IsInSight(m)
                    && !m.Record.IsPandora
                    && !(m.Record.IsDimensionPillar && ignorePillar)
                    && !m.Record.IsSummonFlower,
                out var entities
            )
        )
            return default;

        return entities
            .OrderBy(m => m.Movement.Source.DistanceTo(Container.Bot.Area.Position))
            .ThenBy(m => Bundles.Avoidance.PreferMonster(m.Rarity))
            .ThenByDescending(m => m.AttackingPlayer)
            .FirstOrDefault();
    }

    /// <summary>
    ///     تحديث البيانات عند بدء البوت
    /// </summary>
    public void Refresh()
    {
        _blacklist = new Dictionary<uint, int>(8);
    }

    /// <summary>
    ///     إيقاف البوت
    /// </summary>
    public void Stop()
    {
        _blacklist = null;
    }

    #endregion Methods
}