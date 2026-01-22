using System.Windows.Forms;
using RSBot.Alchemy.Bot;
using RSBot.Alchemy.Subscriber;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Plugins;

namespace RSBot.Alchemy;

public class Bootstrap : IPlugin
{
    public static bool IsActive { get; set; }

    public string InternalName => "RSBot.Alchemy";

    public string DisplayName => "Alchemy";

    public bool DisplayAsTab => true;

    public int Index => 10;

    public bool RequireIngame => true;

    public Control View => Globals.View;

    public void Initialize()
    {
        AlchemyEventsSubscriber.Subscribe();
        Globals.Botbase = new Botbase();
        Log.Notify("[Alchemy] Plugin initialized!");
    }

    public void Translate()
    {
        LanguageManager.Translate(View, Kernel.Language);
    }

    public void OnLoadCharacter()
    {
        // تحميل بيانات الشخصية
    }
}
