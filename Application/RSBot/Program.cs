using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using CommandLine;
using CommandLine.Text;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Views;

namespace RSBot;

internal static class Program
{
    public static string AssemblyTitle = Assembly
        .GetExecutingAssembly()
        .GetCustomAttribute<AssemblyProductAttribute>()
        ?.Product;

    public static string AssemblyVersion =
        $"v{Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version}";

    public static string AssemblyDescription = Assembly
        .GetExecutingAssembly()
        .GetCustomAttribute<AssemblyDescriptionAttribute>()
        ?.Description;

    // ================= Command Line Options =================
    public class CommandLineOptions
    {
        [Option('c', "character", Required = false, HelpText = "Set the character name to use.")]
        public string Character { get; set; }

        [Option('p', "profile", Required = false, HelpText = "Set the profile name to use.")]
        public string Profile { get; set; }

        [Option("launch-client", Required = false, HelpText = "Start with client")]
        public bool LaunchClient { get; set; }

        [Option("launch-clientless", Required = false, HelpText = "Start clientless")]
        public bool LaunchClientless { get; set; }

        // ==== بيانات الحساب القادمة من المانجر (بايثون) ====
        [Option("acc-user", Required = false, HelpText = "Account username to add/update and use for autologin.")]
        public string AccountUsername { get; set; }

        [Option("acc-pass", Required = false, HelpText = "Account password.")]
        public string AccountPassword { get; set; }

        [Option("acc-server", Required = false, HelpText = "Account server name.")]
        public string AccountServer { get; set; }

        [Option("acc-channel", Required = false, HelpText = "Account channel (1..N).")]
        public byte? AccountChannel { get; set; }
    }

    private static void DisplayHelp(ParserResult<CommandLineOptions> result)
    {
        var helpText = HelpText.AutoBuild(
            result,
            h =>
            {
                h.AdditionalNewLineAfterOption = false;
                h.AddDashesToOption = true;
                return HelpText.DefaultParsingErrorsHandler(result, h);
            }
        );
        MessageBox.Show(
            helpText,
            AssemblyTitle + " " + AssemblyVersion,
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    [STAThread]
    private static void Main(string[] args)
    {
        var parser = new Parser(with => with.HelpWriter = Console.Out);
        var parserResult = parser.ParseArguments<CommandLineOptions>(args);

        parserResult
            .WithParsed(RunOptions)
            .WithNotParsed(errs =>
            {
                DisplayHelp(parserResult);
                Environment.Exit(1);
            });

        CultureInfo.CurrentCulture = new CultureInfo("en-US");
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

        Main mainForm = new Main();
        
        // تكييف حجم النافذة مع دقة الشاشة
        var screen = Screen.PrimaryScreen;
        var screenWidth = screen.WorkingArea.Width;
        var screenHeight = screen.WorkingArea.Height;
        
        // حساب حجم مناسب (80% من الشاشة)
        var formWidth = (int)(screenWidth * 0.8);
        var formHeight = (int)(screenHeight * 0.8);
        
        // تحديد الحد الأدنى والأقصى للحجم
        formWidth = Math.Max(1000, Math.Min(formWidth, 1600));
        formHeight = Math.Max(700, Math.Min(formHeight, 1200));
        
        mainForm.Size = new System.Drawing.Size(formWidth, formHeight);
        mainForm.StartPosition = FormStartPosition.CenterScreen;
        
        SplashScreen splashScreen = new SplashScreen(mainForm);
        splashScreen.ShowDialog();

        Application.Run(mainForm);
    }

    // ========= معالجة البراميترز القادمة من المانجر =========
    private static void RunOptions(CommandLineOptions options)
    {
        // ----- Launch mode (client / clientless) -----
        if (options.LaunchClient)
        {
            Kernel.LaunchMode = "client";
            Log.Debug("Launching with client dictated by launch parameters");
        }
        else if (options.LaunchClientless)
        {
            Kernel.LaunchMode = "clientless";
            Log.Debug("Launching client as clientless dictated by launch parameters");
        }

        // ----- Profile -----
        if (!string.IsNullOrEmpty(options.Profile))
        {
            var profile = options.Profile;
            if (ProfileManager.ProfileExists(profile))
                ProfileManager.SetSelectedProfile(profile);
            else
                ProfileManager.Add(profile);

            ProfileManager.IsProfileLoadedByArgs = true;
            Log.Debug($"Selected profile by args: {profile}");
        }

        // ----- Character (فقط نخزن الاسم، من غير تغيير منطق الأوتو سيلكت) -----
        if (!string.IsNullOrEmpty(options.Character))
        {
            var character = options.Character;
            ProfileManager.SelectedCharacter = character;
            Log.Debug($"Selected character by args: {character}");
        }

        // ----- إنشاء / تحديث الحساب من acc-user / acc-pass / acc-server -----
        if (!string.IsNullOrWhiteSpace(options.AccountUsername))
        {
            HandleAccountArgsWithReflection(options);
        }
    }

    /// <summary>
    /// يتعامل مع acc-user / acc-pass / acc-server / acc-channel + character
    /// باستخدام Reflection للوصول إلى RSBot.General.Components.Accounts و RSBot.General.Models.Account
    /// حتى لو كانوا internal.
    /// ويضع الحساب المرسل من المانجر في أول القائمة ويجعله حساب الـ AutoLogin.
    /// </summary>
    private static void HandleAccountArgsWithReflection(CommandLineOptions options)
    {
        try
        {
            // تحميل RSBot.General.dll
            Assembly generalAsm = null;

            string asmPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RSBot.General.dll");
            if (File.Exists(asmPath))
            {
                generalAsm = Assembly.LoadFrom(asmPath);
            }
            else
            {
                generalAsm = AppDomain.CurrentDomain
                    .GetAssemblies()
                    .FirstOrDefault(a => a.GetName().Name.Equals("RSBot.General", StringComparison.OrdinalIgnoreCase));
            }

            if (generalAsm == null)
            {
                Log.Warn("[Args] RSBot.General.dll not found. Skipping account arguments.");
                return;
            }

            // الحصول على الكلاسات بالاسم
            var accountsType = generalAsm.GetType("RSBot.General.Components.Accounts", throwOnError: false);
            var accountType = generalAsm.GetType("RSBot.General.Models.Account", throwOnError: false);

            if (accountsType == null || accountType == null)
            {
                Log.Warn("[Args] Accounts or Account type not found in RSBot.General. Skipping account args.");
                return;
            }

            // استدعاء Accounts.Load()
            accountsType.GetMethod("Load", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static)
                        ?.Invoke(null, null);

            // الحصول على Accounts.SavedAccounts كـ IList
            var savedProp = accountsType.GetProperty(
                "SavedAccounts",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

            var saved = savedProp?.GetValue(null) as IList;
            if (saved == null)
            {
                Log.Warn("[Args] Accounts.SavedAccounts is null or not a list.");
                return;
            }

            string unameLower = options.AccountUsername.ToLowerInvariant();
            object existingAccount = null;
            int existingIndex = -1;

            // البحث عن حساب موجود بنفس اليوزر
            for (int i = 0; i < saved.Count; i++)
            {
                var acc = saved[i];
                var unameProp = acc.GetType().GetProperty("Username");
                var unameVal = unameProp?.GetValue(acc) as string;

                if (!string.IsNullOrEmpty(unameVal) &&
                    string.Equals(unameVal, unameLower, StringComparison.OrdinalIgnoreCase))
                {
                    existingAccount = acc;
                    existingIndex = i;
                    break;
                }
            }

            string charName = string.IsNullOrWhiteSpace(options.Character)
                ? string.Empty
                : options.Character;

            if (existingAccount == null)
            {
                // إنشاء Account جديد
                var account = Activator.CreateInstance(accountType);

                accountType.GetProperty("Username")?.SetValue(account, unameLower);
                accountType.GetProperty("Password")?.SetValue(account, options.AccountPassword ?? string.Empty);
                accountType.GetProperty("SecondaryPassword")?.SetValue(account, string.Empty);
                accountType.GetProperty("Servername")?.SetValue(account, options.AccountServer ?? string.Empty);
                accountType.GetProperty("SelectedCharacter")?.SetValue(account, charName);

                byte channel = options.AccountChannel ?? (byte)1;
                accountType.GetProperty("Channel")?.SetValue(account, channel);

                // خصية Characters: List<string>(4)
                var charsProp = accountType.GetProperty("Characters");
                if (charsProp != null && charsProp.CanWrite)
                {
                    var listType = typeof(List<string>);
                    var charsList = Activator.CreateInstance(listType, 4);
                    charsProp.SetValue(account, charsList);
                }

                // نضع الحساب أول عنصر في القائمة
                saved.Insert(0, account);
                existingAccount = account;

                Log.Debug($"[Args] Added new account '{unameLower}' from command line (as first in list).");
            }
            else
            {
                // تحديث بيانات الحساب الموجود
                var type = existingAccount.GetType();

                if (options.AccountPassword != null)
                    type.GetProperty("Password")?.SetValue(existingAccount, options.AccountPassword);

                if (options.AccountServer != null)
                    type.GetProperty("Servername")?.SetValue(existingAccount, options.AccountServer);

                if (options.AccountChannel != null)
                    type.GetProperty("Channel")?.SetValue(existingAccount, options.AccountChannel.Value);

                if (!string.IsNullOrWhiteSpace(options.Character))
                    type.GetProperty("SelectedCharacter")?.SetValue(existingAccount, options.Character);

                // نقله لأول عنصر إن لم يكن هناك
                if (existingIndex > 0)
                {
                    saved.RemoveAt(existingIndex);
                    saved.Insert(0, existingAccount);
                }

                Log.Debug($"[Args] Updated account '{unameLower}' from command line and moved to top.");
            }

            // استدعاء Accounts.Save()
            accountsType.GetMethod("Save", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static)
                        ?.Invoke(null, null);

            // تفعيل AutoLogin على هذا الحساب
            GlobalConfig.Set("RSBot.General.EnableAutomatedLogin", true);
            GlobalConfig.Set("RSBot.General.AutoLoginAccountUsername", unameLower);
            GlobalConfig.Save();

            Log.Debug($"[Args] AutoLogin set to account: {unameLower}");
        }
        catch (Exception ex)
        {
            Log.Warn($"[Args] Error handling account arguments: {ex}");
        }
    }
}
