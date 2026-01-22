using RSBot.Party.Bundle.AutoParty;
using RSBot.Party.Bundle.Commands;
using RSBot.Party.Bundle.PartyMatching;

namespace RSBot.Party.Bundle;

internal static class Container
{
    public static AutoPartyBundle AutoParty { get; set; }
    public static PartyMatchingBundle PartyMatching { get; set; }
    public static CommandsBundle Commands { get; set; }

    public static void Refresh()
    {
        AutoParty ??= new AutoPartyBundle();
        PartyMatching ??= new PartyMatchingBundle();
        Commands ??= new CommandsBundle();

        AutoParty.Refresh();
        Commands.Refresh();
    }
}
