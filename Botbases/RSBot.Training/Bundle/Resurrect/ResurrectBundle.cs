using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Objects;
using RSBot.Core.Objects.Party;
using System.Collections.Generic;

namespace RSBot.Training.Bundle.Resurrect;

internal class ResurrectBundle : IBundle
{
    public void Invoke()
    {
        if (Game.Party == null || Game.Party.Members == null || Game.Player.HasActiveVehicle)
            return;

        if (!PlayerConfig.Get<bool>("RSBot.Skills.checkResurrectParty"))
            return;

        // لو بيعمل cast حالياً، استنى يخلص
        if (Game.Player.State.IsSkillCasting)
            return;

        foreach (var member in Game.Party.Members)
        {
            // لو مش ميت، تخطى
            if (!IsMemberDead(member))
                continue;

            // لو مش قادر يوصله، تخطى
            if (!CanReachMember(member))
                continue;

            // روح له وأحييه
            ResurrectMember(member);

            // أحيي واحد بس في كل مرة، والباقي في الـ Tick الجاي
            break;
        }
    }

    /// <summary>
    ///     تحقق هل العضو ميت
    /// </summary>
    private bool IsMemberDead(PartyMember member)
    {
        if (member.Player != null)
            return member.Player.State.LifeState == LifeState.Dead;

        return (member.HealthMana & 0x0F) == 0;
    }

    /// <summary>
    ///     تحقق هل نقدر نوصله
    /// </summary>
    private bool CanReachMember(PartyMember member)
    {
        var memberPosition = member.Player?.Movement.Source ?? member.Position;
        var myPosition = Game.Player.Movement.Source;

        if (memberPosition.DistanceTo(myPosition) > 100)
            return false;

        if (memberPosition.HasCollisionBetween(myPosition))
            return false;

        return true;
    }

    /// <summary>
    ///     روح للعضو وأحييه
    /// </summary>
    private void ResurrectMember(PartyMember member)
    {
        var memberPosition = member.Player?.Movement.Source ?? member.Position;

        var moved = Game.Player.MoveTo(memberPosition, true);
        if (!moved)
            return;

        var targetId = member.Player?.UniqueId ?? member.MemberId;
        Log.Notify($"[Resurrect] Resurrecting {member.Name}");
        SkillManager.ResurrectionSkill?.Cast(targetId, true);
    }

    public void Refresh() { }

    public void Stop() { }
}
