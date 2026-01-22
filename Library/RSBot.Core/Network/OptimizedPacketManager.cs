using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RSBot.Core.Network;

public static class OptimizedPacketManager
{
    private static readonly object _lock = new();
    private static readonly ConcurrentDictionary<ushort, List<IPacketHandler>> _handlersByOpcode = new();
    private static readonly ConcurrentDictionary<ushort, List<IPacketHook>> _hooksByOpcode = new();
    private static readonly List<AwaitCallback> _callbacks = new();

    public static void RegisterHandler(IPacketHandler handler)
    {
        _handlersByOpcode.AddOrUpdate(handler.Opcode, 
            new List<IPacketHandler> { handler },
            (key, list) => { list.Add(handler); return list; });
    }

    public static void RegisterHook(IPacketHook hook)
    {
        _hooksByOpcode.AddOrUpdate(hook.Opcode,
            new List<IPacketHook> { hook },
            (key, list) => { list.Add(hook); return list; });
    }

    internal static void CallHandler(Packet packet, PacketDestination destination)
    {
        if (!_handlersByOpcode.TryGetValue(packet.Opcode, out var handlers))
            return;

        foreach (var handler in handlers.Where(h => h.Destination == destination))
        {
            handler.Invoke(packet);
            packet.SeekRead(0, SeekOrigin.Begin);
        }
    }

    internal static Packet CallHook(Packet packet, PacketDestination destination)
    {
        if (!_hooksByOpcode.TryGetValue(packet.Opcode, out var hooks))
            return packet;

        return hooks.Where(h => h.Destination == destination)
                   .Aggregate(packet, (current, hook) => hook.ReplacePacket(current));
    }

    internal static void CallCallback(Packet packet)
    {
        lock (_lock)
        {
            var matchingCallbacks = _callbacks.Where(c => c.ResponseOpcode == packet.Opcode).ToList();
            
            foreach (var callback in matchingCallbacks)
            {
                packet.SeekRead(0, SeekOrigin.Begin);
                callback.Invoke(packet);
            }

            _callbacks.RemoveAll(c => c.IsClosed);
        }
    }

    public static void SendPacket(Packet packet, PacketDestination destination, params AwaitCallback[] callbacks)
    {
        if (Kernel.Proxy == null) return;

        if (callbacks?.Length > 0)
        {
            lock (_lock)
            {
                _callbacks.AddRange(callbacks);
            }
        }

        if (!packet.Locked) packet.Lock();

        try
        {
            switch (destination)
            {
                case PacketDestination.Client when !Game.Clientless:
                    Kernel.Proxy.Client?.Send(packet);
                    break;
                case PacketDestination.Server:
                    Kernel.Proxy.Server?.Send(packet);
                    break;
            }
        }
        catch (Exception e)
        {
            Log.Fatal(e);
        }
    }
}