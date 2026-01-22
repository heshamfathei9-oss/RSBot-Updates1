using RSBot.Core.Components;
using RSBot.Core.Event;
using RSBot.Core.Objects.Spawn;

namespace RSBot.Core.Network.Handler.Agent.Action;

internal class ActionSelectResponse : IPacketHandler
{
    public ushort Opcode => 0xB045;
    public PacketDestination Destination => PacketDestination.Client;

    public void Invoke(Packet packet)
    {
        if (packet.ReadByte() != 0x01)
            return;

        var uniqueId = packet.ReadUInt();

        // ✅ حاول تجيب الـ entity من SpawnManager
        SpawnManager.TryGetEntity<SpawnedBionic>(uniqueId, out var entity);

        // ✅ لو موجود في SpawnManager
        if (entity != null)
        {
            Game.SelectedEntity = entity;

            if (entity is SpawnedMonster)
            {
                var hasHealth = packet.ReadBool();
                if (hasHealth)
                    entity.Health = packet.ReadInt();
            }
            else if (entity is SpawnedNpcNpc)
            {
                var hasHealth = packet.ReadBool();
                if (hasHealth)
                    entity.Health = packet.ReadInt();
            }

            EventManager.FireEvent("OnSelectEntity", entity);
        }
        else
        {
            // ✅ لو مش موجود (لاعب أو حاجة مش في SpawnManager)
            // خلّي الـ packet يعدي للـ Client عشان يعرض الـ Stats
            Log.Debug($"Selected entity [{uniqueId}] not in SpawnManager, allowing client to handle it");

            // مش لازم نعمل حاجة، الـ Client هيتعامل معاه
        }
    }
}
