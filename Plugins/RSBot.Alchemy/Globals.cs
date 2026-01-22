using RSBot.Alchemy.Bot;
using RSBot.Alchemy.Views;

namespace RSBot.Alchemy;

internal class Globals
{
    public static Main View = new();
    public static Botbase Botbase;
    public static bool IsActive { get; set; }
}