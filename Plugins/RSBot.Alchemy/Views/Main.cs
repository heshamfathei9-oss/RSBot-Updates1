using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using RSBot.Alchemy.Bot;
using RSBot.Alchemy.Bundle.Enhance;
using RSBot.Alchemy.Bundle.Magic;
using RSBot.Alchemy.Client.ReferenceObjects;
using RSBot.Alchemy.Views.Settings;
using RSBot.Core;
using RSBot.Core.Client.ReferenceObjects;
using RSBot.Core.Event;
using RSBot.Core.Extensions;
using RSBot.Core.Objects;
using SDUI.Controls;

namespace RSBot.Alchemy.Views;

[ToolboxItem(false)]
public partial class Main : DoubleBufferedControl
{
    #region Members

    private readonly EnhanceSettingsView _enhanceSettingsView;
    private readonly MagicOptionsSettingsView _magicOptionsSettingsView;
    private readonly AttributesSettingsView _attributeSettingsView;
    private bool _isRunning = false;

    // ⭐ Timer للـ Alchemy
    private System.Timers.Timer _alchemyTimer;

    // ⭐ Bundle مباشرة بدون Botbase
    private EnhanceBundle _enhanceBundle;
    private EnhanceBundleConfig _enhanceConfig;

    #endregion Members

    #region Properties

    public bool IsRefreshing { get; private set; }
    public InventoryItem SelectedItem { get; set; }

    #endregion Properties

    #region Constructor

    public Main()
    {
        CheckForIllegalCrossThreadCalls = false;

        InitializeComponent();
        SetStyle(
            ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer,
            true
        );

        // ⭐ إنشاء Timer
        _alchemyTimer = new System.Timers.Timer();
        _alchemyTimer.Interval = 500;
        _alchemyTimer.Elapsed += AlchemyTimer_Elapsed;
        _alchemyTimer.AutoReset = true;

        // ⭐ إنشاء Bundle مباشرة
        _enhanceBundle = new EnhanceBundle();

        button1.Enabled = true;
        button1.Text = "Start Alchemy";
        button1.BackColor = System.Drawing.Color.Green;
        button1.ForeColor = System.Drawing.Color.White;

        EventManager.SubscribeEvent(
            "OnLoadCharacter",
            () =>
            {
                if (IsDisposed || Disposing)
                    return;

                ReloadItemList();
                EnableStartButton();
            }
        );

        EventManager.SubscribeEvent("OnAlchemy", new Action<AlchemyType>(OnAlchemy));

        _enhanceSettingsView = new EnhanceSettingsView { Visible = true, Dock = DockStyle.Fill };
        _magicOptionsSettingsView = new MagicOptionsSettingsView { Visible = false, Dock = DockStyle.Fill };
        _attributeSettingsView = new AttributesSettingsView { Visible = false, Dock = DockStyle.Fill };

        panelSettings.Controls.Add(_enhanceSettingsView);
        panelSettings.Controls.Add(_magicOptionsSettingsView);
        panelSettings.Controls.Add(_attributeSettingsView);
    }

    #endregion Constructor

    #region Timer

    private void AlchemyTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        if (!_isRunning || _enhanceBundle == null || _enhanceConfig == null)
            return;

        try
        {
            // ⭐ استدعاء Run مباشرة
            _enhanceBundle.Run(_enhanceConfig);
        }
        catch (Exception ex)
        {
            Log.Error($"[Alchemy] Error: {ex.Message}");

            if (button1.InvokeRequired)
                button1.Invoke(new System.Action(StopAlchemy));
            else
                StopAlchemy();
        }
    }

    #endregion Timer

    #region Delegates

    internal delegate void SelectedItemChanged(InventoryItem item);
    internal event SelectedItemChanged ItemChanged;

    internal delegate void SelectedEngineChanged(InventoryItem item, AlchemyEngine alchemyEngine);
    internal event SelectedEngineChanged EngineChanged;

    #endregion Delegates

    #region Internal Classes

    internal class InventoryItemComboboxItem
    {
        public InventoryItemComboboxItem(InventoryItem inventoryItem)
        {
            InventoryItem = inventoryItem;
        }

        public InventoryItem InventoryItem { get; set; }

        public override string ToString()
        {
            return $"[{InventoryItem?.Slot}] {InventoryItem?.Record?.GetRealName()} (+{InventoryItem?.OptLevel})";
        }
    }

    #endregion Internal Classes

    #region Button Methods

    private void EnableStartButton()
    {
        if (button1.InvokeRequired)
        {
            button1.Invoke(new System.Action(EnableStartButton));
            return;
        }

        button1.Enabled = true;
        button1.Text = "Start Alchemy";
        button1.BackColor = System.Drawing.Color.Gray;
        button1.ForeColor = System.Drawing.Color.White;
    }

    private void DisableStartButton()
    {
        if (button1.InvokeRequired)
        {
            button1.Invoke(new System.Action(DisableStartButton));
            return;
        }

        button1.Enabled = false;
        button1.Text = "Start Alchemy";
        button1.BackColor = System.Drawing.Color.Gray;
        button1.ForeColor = System.Drawing.Color.White;
    }

    private void StopAlchemy()
    {
        _isRunning = false;
        _alchemyTimer.Stop();
        _enhanceBundle?.Stop();

        if (button1.InvokeRequired)
        {
            button1.Invoke(new System.Action(() =>
            {
                button1.Text = "Start Alchemy";
                button1.BackColor = System.Drawing.Color.Gray;
                button1.ForeColor = System.Drawing.Color.White;
            }));
        }
        else
        {
            button1.Text = "Start Alchemy";
            button1.BackColor = System.Drawing.Color.Gray;
            button1.ForeColor = System.Drawing.Color.White;
        }

        Log.Notify("[Alchemy] Stopped!");
    }

    #endregion Button Methods

    #region Methods

    private void OnAlchemy(AlchemyType type)
    {
        if (IsDisposed || Disposing)
            return;

        ReloadItemList();
    }

    private void ReloadItemList()
    {
        IsRefreshing = true;

        comboItem.Items.Clear();

        var items = Game
            .Player.Inventory.Where(i => i.Record.IsEquip && !i.Record.IsAvatar && !i.Record.IsJobOutfit)
            .ToList();

        try
        {
            foreach (var item in items)
            {
                var newComboItem = new InventoryItemComboboxItem(item);

                int firstSlot = 13;
                if (Game.ClientType == GameClientType.Global
                    || Game.ClientType == GameClientType.Korean
                    || Game.ClientType == GameClientType.VTC_Game
                    || Game.ClientType == GameClientType.RuSro
                    || Game.ClientType == GameClientType.Turkey
                    || Game.ClientType == GameClientType.Taiwan
                    || Game.ClientType == GameClientType.Japanese)
                    firstSlot = 17;

                if (item.Slot >= firstSlot)
                    comboItem.Items.Add(newComboItem);

                if (SelectedItem != null && item.Slot == SelectedItem.Slot)
                    comboItem.SelectedItem = newComboItem;
            }
        }
        catch (Exception e)
        {
            Log.Debug($"[Alchemy] Unknown error while reloading item list: {e.Message}");
        }
        finally
        {
            IsRefreshing = false;
        }

        if (comboItem.SelectedItem == null)
            SelectedItem = null;
    }

    private void PopulateAttributes(InventoryItem item)
    {
        listAttributes.Items.Clear();

        if (item.Attributes == 0)
            return;

        var availableAttributes = ItemAttributesInfo.GetAvailableAttributeGroupsForItem(item.Record);

        if (availableAttributes == null)
            return;

        foreach (var attribute in availableAttributes)
        {
            var slot = ItemAttributesInfo.GetAttributeSlotForItem(attribute, item.Record);
            var translation = attribute.GetTranslation();

            listAttributes.Items.Add($"{translation} +{item.Attributes.GetPercentage(slot)}%");
        }
    }

    private void PopulateMagicOptions(InventoryItem item)
    {
        listMagicOptions.Items.Clear();

        if (item.MagicOptions == null)
            return;

        foreach (var magicOption in item.MagicOptions)
        {
            var option = Game.ReferenceManager.GetMagicOption(magicOption.Id);

            if (option != null)
                listMagicOptions.Items.Add(option.GetFusingTranslation(magicOption.Value));
        }
    }

    public void AddLog(string itemName, string message)
    {
        var item = new ListViewItem(itemName);
        item.SubItems.Add(message);
        lvLog.Items.Add(item);
        lvLog.Items[lvLog.Items.Count - 1].EnsureVisible();
        Log.Notify($"[Alchemy] [{itemName}]: {message}");
    }

    #endregion Methods

    #region Events

    private void linkRefreshItemList_Click(object sender, EventArgs e)
    {
        Invoke(ReloadItemList);
    }

    private void comboItem_SelectedIndexChanged(object sender, EventArgs e)
    {
        IsRefreshing = true;

        if (comboItem.SelectedIndex < 0)
            return;

        var selectedItem = (InventoryItemComboboxItem)comboItem.Items[comboItem.SelectedIndex];
        SelectedItem = selectedItem.InventoryItem;

        if (SelectedItem == null)
            return;

        Invoke(() => PopulateAttributes(SelectedItem));
        Invoke(() => PopulateMagicOptions(SelectedItem));

        lblDegree.Text = SelectedItem.Record.Degree.ToString();
        lblOptLevel.Text = $"+{SelectedItem.OptLevel}";
        ItemChanged?.Invoke(SelectedItem);

        IsRefreshing = false;
    }

    private void radioEngine_CheckedChanged(object sender, EventArgs e)
    {
        if (radioEnhance.Checked)
            LoadEngineSettings(AlchemyEngine.Enhance);

        if (radioMagicOptions.Checked)
            LoadEngineSettings(AlchemyEngine.Magic);

        if (radioAttributes.Checked)
            LoadEngineSettings(AlchemyEngine.Attribute);
    }

    private void LoadEngineSettings(AlchemyEngine alchemyEngine)
    {
        IsRefreshing = true;

        if (_enhanceSettingsView == null || _magicOptionsSettingsView == null || _attributeSettingsView == null)
            return;

        if (alchemyEngine == AlchemyEngine.Enhance)
        {
            _enhanceSettingsView.Show();
            _magicOptionsSettingsView.Hide();
            _attributeSettingsView.Hide();
        }

        if (alchemyEngine == AlchemyEngine.Magic)
        {
            _enhanceSettingsView.Hide();
            _magicOptionsSettingsView.Show();
            _attributeSettingsView.Hide();
        }

        if (alchemyEngine == AlchemyEngine.Attribute)
        {
            _enhanceSettingsView.Hide();
            _magicOptionsSettingsView.Hide();
            _attributeSettingsView.Show();
        }

        EngineChanged?.Invoke(SelectedItem, alchemyEngine);

        IsRefreshing = false;
    }

    private void Main_Load(object sender, EventArgs e)
    {
        // فارغة
    }

    /// <summary>
    ///     ⭐ زر Start/Stop Alchemy - مستقل تماماً
    /// </summary>
    private void button1_Click_1(object sender, EventArgs e)
    {
        if (!_isRunning)
        {
            // ═══════════════════════════════════════════════════════
            // التحققات
            // ═══════════════════════════════════════════════════════

            if (SelectedItem == null)
            {
                Log.Warn("[Alchemy] Please select an item first!");
                return;
            }

            if (!radioEnhance.Checked)
            {
                Log.Warn("[Alchemy] Only Enhance is supported for now!");
                return;
            }

            var elixirs = _enhanceSettingsView.SelectedElixirs;
            if (elixirs == null || !elixirs.Any())
            {
                Log.Warn("[Alchemy] No elixirs found in inventory!");
                return;
            }

            // ═══════════════════════════════════════════════════════
            // إنشاء Config
            // ═══════════════════════════════════════════════════════

            _enhanceConfig = new EnhanceBundleConfig
            {
                Item = SelectedItem,
                UseAstralStones = _enhanceSettingsView.UseAstralStones,
                UseLuckyStones = _enhanceSettingsView.UseLuckyStones,
                UseImmortalStones = _enhanceSettingsView.UseImmortalStones,
                UseSteadyStones = _enhanceSettingsView.UseSteadyStones,
                Elixirs = elixirs,
                MaxOptLevel = _enhanceSettingsView.SelectedMaxOptLevel,
                StopIfLuckyPowderEmpty = _enhanceSettingsView.StopIfLuckyPowderEmpty,
            };

            Log.Debug($"[Alchemy] Config: Item={SelectedItem.Record?.GetRealName()}, MaxOpt={_enhanceConfig.MaxOptLevel}");

            // ═══════════════════════════════════════════════════════
            // بدء التشغيل
            // ═══════════════════════════════════════════════════════

            _isRunning = true;

            button1.Text = "Stop Alchemy";
            button1.BackColor = System.Drawing.Color.Red;
            button1.ForeColor = System.Drawing.Color.White;

            Log.Notify($"[Alchemy] Starting Enhancement on: {SelectedItem.Record?.GetRealName()} (+{SelectedItem.OptLevel})");

            // ⭐ ابدأ الـ Bundle
            _enhanceBundle.Start();

            // ⭐ ابدأ الـ Timer
            _alchemyTimer.Start();

            Log.Notify("[Alchemy] Started!");
        }
        else
        {
            // ═══════════════════════════════════════════════════════
            // إيقاف
            // ═══════════════════════════════════════════════════════

            StopAlchemy();
        }
    }

    #endregion Events
}
