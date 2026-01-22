using System.Drawing;
using System.Windows.Forms;


using ComboBox = SDUI.Controls.ComboBox;
using GroupBox = SDUI.Controls.GroupBox;
using Label = SDUI.Controls.Label;
using ListView = SDUI.Controls.ListView;
using TabControl = SDUI.Controls.TabControl;
using Panel = SDUI.Controls.Panel;
using RadioButton = SDUI.Controls.Radio;

namespace RSBot.Alchemy.Views
{
    partial class Main
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupItem = new GroupBox();
            button1 = new Button();
            lblOptLevel = new Label();
            tabControlItemInfo = new TabControl();
            tabMagicOptions = new TabPage();
            listMagicOptions = new ListBox();
            tabPageAttributes = new TabPage();
            listAttributes = new ListBox();
            comboItem = new ComboBox();
            lblOptLevelText = new Label();
            lblItemSelection = new Label();
            lblDegree = new Label();
            lblDegreeText = new Label();
            linkRefreshItemList = new Label();
            lvLog = new ListView();
            colItem = new ColumnHeader();
            colResult = new ColumnHeader();
            panelSettingsGroup = new Panel();
            panelSettings = new Panel();
            panel2 = new Panel();
            radioAttributes = new SDUI.Controls.Radio();
            radioMagicOptions = new SDUI.Controls.Radio();
            radioEnhance = new SDUI.Controls.Radio();
            groupItem.SuspendLayout();
            tabControlItemInfo.SuspendLayout();
            tabMagicOptions.SuspendLayout();
            tabPageAttributes.SuspendLayout();
            panelSettingsGroup.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupItem
            // 
            groupItem.BackColor = Color.Transparent;
            groupItem.Controls.Add(button1);
            groupItem.Controls.Add(lblOptLevel);
            groupItem.Controls.Add(tabControlItemInfo);
            groupItem.Controls.Add(comboItem);
            groupItem.Controls.Add(lblOptLevelText);
            groupItem.Controls.Add(lblItemSelection);
            groupItem.Controls.Add(lblDegree);
            groupItem.Controls.Add(lblDegreeText);
            groupItem.Controls.Add(linkRefreshItemList);
            groupItem.Location = new Point(23, 23);
            groupItem.Margin = new Padding(6, 5, 6, 5);
            groupItem.Name = "groupItem";
            groupItem.Padding = new Padding(6, 20, 6, 5);
            groupItem.Radius = 10;
            groupItem.ShadowDepth = 4;
            groupItem.Size = new Size(460, 552);
            groupItem.TabIndex = 0;
            groupItem.TabStop = false;
            groupItem.Text = "Item";
            // 
            // button1
            // 
            button1.Location = new Point(293, 219);
            button1.Name = "button1";
            button1.Size = new Size(144, 34);
            button1.TabIndex = 6;
            button1.Text = "Start Alchemy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lblOptLevel
            // 
            lblOptLevel.ApplyGradient = false;
            lblOptLevel.AutoSize = true;
            lblOptLevel.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblOptLevel.ForeColor = Color.FromArgb(0, 0, 0);
            lblOptLevel.Gradient = new Color[]
    {
    Color.Gray,
    Color.Black
    };
            lblOptLevel.GradientAnimation = false;
            lblOptLevel.Location = new Point(169, 170);
            lblOptLevel.Margin = new Padding(6, 0, 6, 0);
            lblOptLevel.Name = "lblOptLevel";
            lblOptLevel.Size = new Size(166, 23);
            lblOptLevel.TabIndex = 1;
            lblOptLevel.Text = "<no item selected>";
            // 
            // tabControlItemInfo
            // 
            tabControlItemInfo.Controls.Add(tabMagicOptions);
            tabControlItemInfo.Controls.Add(tabPageAttributes);
            tabControlItemInfo.ItemSize = new Size(80, 24);
            tabControlItemInfo.Location = new Point(13, 243);
            tabControlItemInfo.Margin = new Padding(6, 5, 6, 5);
            tabControlItemInfo.Name = "tabControlItemInfo";
            tabControlItemInfo.Radius = new Padding(4);
            tabControlItemInfo.SelectedIndex = 0;
            tabControlItemInfo.Size = new Size(434, 298);
            tabControlItemInfo.TabIndex = 5;
            // 
            // tabMagicOptions
            // 
            tabMagicOptions.BackColor = Color.White;
            tabMagicOptions.Controls.Add(listMagicOptions);
            tabMagicOptions.Location = new Point(4, 28);
            tabMagicOptions.Margin = new Padding(6, 5, 6, 5);
            tabMagicOptions.Name = "tabMagicOptions";
            tabMagicOptions.Padding = new Padding(6, 5, 6, 5);
            tabMagicOptions.Size = new Size(426, 266);
            tabMagicOptions.TabIndex = 0;
            tabMagicOptions.Text = "Blues";
            // 
            // listMagicOptions
            // 
            listMagicOptions.BorderStyle = BorderStyle.None;
            listMagicOptions.Dock = DockStyle.Fill;
            listMagicOptions.ItemHeight = 25;
            listMagicOptions.Location = new Point(6, 5);
            listMagicOptions.Margin = new Padding(6, 5, 6, 5);
            listMagicOptions.Name = "listMagicOptions";
            listMagicOptions.Size = new Size(414, 256);
            listMagicOptions.TabIndex = 2;
            // 
            // tabPageAttributes
            // 
            tabPageAttributes.BackColor = Color.White;
            tabPageAttributes.Controls.Add(listAttributes);
            tabPageAttributes.Location = new Point(4, 28);
            tabPageAttributes.Margin = new Padding(6, 5, 6, 5);
            tabPageAttributes.Name = "tabPageAttributes";
            tabPageAttributes.Padding = new Padding(6, 5, 6, 5);
            tabPageAttributes.Size = new Size(426, 266);
            tabPageAttributes.TabIndex = 1;
            tabPageAttributes.Text = "Stats";
            // 
            // listAttributes
            // 
            listAttributes.BorderStyle = BorderStyle.None;
            listAttributes.Dock = DockStyle.Fill;
            listAttributes.ItemHeight = 25;
            listAttributes.Location = new Point(6, 5);
            listAttributes.Margin = new Padding(6, 5, 6, 5);
            listAttributes.Name = "listAttributes";
            listAttributes.Size = new Size(414, 256);
            listAttributes.TabIndex = 3;
            // 
            // comboItem
            // 
            comboItem.DrawMode = DrawMode.OwnerDrawFixed;
            comboItem.DropDownHeight = 100;
            comboItem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboItem.FormattingEnabled = true;
            comboItem.IntegralHeight = false;
            comboItem.ItemHeight = 17;
            comboItem.Location = new Point(30, 78);
            comboItem.Margin = new Padding(6, 5, 6, 5);
            comboItem.Name = "comboItem";
            comboItem.Radius = 5;
            comboItem.ShadowDepth = 4F;
            comboItem.Size = new Size(363, 23);
            comboItem.TabIndex = 4;
            comboItem.SelectedIndexChanged += comboItem_SelectedIndexChanged;
            // 
            // lblOptLevelText
            // 
            lblOptLevelText.ApplyGradient = false;
            lblOptLevelText.AutoSize = true;
            lblOptLevelText.ForeColor = Color.FromArgb(0, 0, 0);
            lblOptLevelText.Gradient = new Color[]
    {
    Color.Gray,
    Color.Black
    };
            lblOptLevelText.GradientAnimation = false;
            lblOptLevelText.Location = new Point(26, 170);
            lblOptLevelText.Margin = new Padding(6, 0, 6, 0);
            lblOptLevelText.Name = "lblOptLevelText";
            lblOptLevelText.Size = new Size(122, 25);
            lblOptLevelText.TabIndex = 0;
            lblOptLevelText.Text = "&Enhancement:";
            // 
            // lblItemSelection
            // 
            lblItemSelection.ApplyGradient = false;
            lblItemSelection.AutoSize = true;
            lblItemSelection.ForeColor = Color.FromArgb(0, 0, 0);
            lblItemSelection.Gradient = new Color[]
    {
    Color.Gray,
    Color.Black
    };
            lblItemSelection.GradientAnimation = false;
            lblItemSelection.Location = new Point(26, 48);
            lblItemSelection.Margin = new Padding(6, 0, 6, 0);
            lblItemSelection.Name = "lblItemSelection";
            lblItemSelection.Size = new Size(52, 25);
            lblItemSelection.TabIndex = 3;
            lblItemSelection.Text = "Item:";
            // 
            // lblDegree
            // 
            lblDegree.ApplyGradient = false;
            lblDegree.AutoSize = true;
            lblDegree.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblDegree.ForeColor = Color.FromArgb(0, 0, 0);
            lblDegree.Gradient = new Color[]
    {
    Color.Gray,
    Color.Black
    };
            lblDegree.GradientAnimation = false;
            lblDegree.Location = new Point(169, 125);
            lblDegree.Margin = new Padding(6, 0, 6, 0);
            lblDegree.Name = "lblDegree";
            lblDegree.Size = new Size(166, 23);
            lblDegree.TabIndex = 1;
            lblDegree.Text = "<no item selected>";
            // 
            // lblDegreeText
            // 
            lblDegreeText.ApplyGradient = false;
            lblDegreeText.AutoSize = true;
            lblDegreeText.ForeColor = Color.FromArgb(0, 0, 0);
            lblDegreeText.Gradient = new Color[]
    {
    Color.Gray,
    Color.Black
    };
            lblDegreeText.GradientAnimation = false;
            lblDegreeText.Location = new Point(26, 125);
            lblDegreeText.Margin = new Padding(6, 0, 6, 0);
            lblDegreeText.Name = "lblDegreeText";
            lblDegreeText.Size = new Size(73, 25);
            lblDegreeText.TabIndex = 0;
            lblDegreeText.Text = "&Degree:";
            // 
            // linkRefreshItemList
            // 
            linkRefreshItemList.ApplyGradient = false;
            linkRefreshItemList.AutoSize = true;
            linkRefreshItemList.Cursor = Cursors.Hand;
            linkRefreshItemList.Font = new Font("Segoe UI", 15.75F);
            linkRefreshItemList.ForeColor = Color.FromArgb(0, 0, 0);
            linkRefreshItemList.Gradient = new Color[]
    {
    Color.Gray,
    Color.Black
    };
            linkRefreshItemList.GradientAnimation = false;
            linkRefreshItemList.Location = new Point(396, 67);
            linkRefreshItemList.Margin = new Padding(6, 0, 6, 0);
            linkRefreshItemList.Name = "linkRefreshItemList";
            linkRefreshItemList.Size = new Size(52, 45);
            linkRefreshItemList.TabIndex = 5;
            linkRefreshItemList.Text = "🗘";
            linkRefreshItemList.Click += linkRefreshItemList_Click;
            // 
            // lvLog
            // 
            lvLog.BackColor = Color.White;
            lvLog.Columns.AddRange(new ColumnHeader[] { colItem, colResult });
            lvLog.ForeColor = Color.FromArgb(0, 0, 0);
            lvLog.FullRowSelect = true;
            lvLog.Location = new Point(23, 585);
            lvLog.Margin = new Padding(6, 5, 6, 5);
            lvLog.Name = "lvLog";
            lvLog.Size = new Size(1083, 226);
            lvLog.TabIndex = 1;
            lvLog.UseCompatibleStateImageBehavior = false;
            lvLog.View = View.Details;
            // 
            // colItem
            // 
            colItem.Text = "Item";
            colItem.Width = 228;
            // 
            // colResult
            // 
            colResult.Text = "Message";
            colResult.Width = 500;
            // 
            // panelSettingsGroup
            // 
            panelSettingsGroup.BackColor = Color.Transparent;
            panelSettingsGroup.Border = new Padding(0, 0, 0, 0);
            panelSettingsGroup.BorderColor = Color.Transparent;
            panelSettingsGroup.Controls.Add(panelSettings);
            panelSettingsGroup.Controls.Add(panel2);
            panelSettingsGroup.Location = new Point(501, 23);
            panelSettingsGroup.Margin = new Padding(6, 5, 6, 5);
            panelSettingsGroup.Name = "panelSettingsGroup";
            panelSettingsGroup.Radius = 1;
            panelSettingsGroup.ShadowDepth = 4F;
            panelSettingsGroup.Size = new Size(606, 552);
            panelSettingsGroup.TabIndex = 7;
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.Transparent;
            panelSettings.Border = new Padding(0, 0, 0, 0);
            panelSettings.BorderColor = Color.Transparent;
            panelSettings.Dock = DockStyle.Fill;
            panelSettings.Location = new Point(0, 63);
            panelSettings.Margin = new Padding(0);
            panelSettings.Name = "panelSettings";
            panelSettings.Radius = 0;
            panelSettings.ShadowDepth = 4F;
            panelSettings.Size = new Size(606, 489);
            panelSettings.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Border = new Padding(0, 0, 0, 0);
            panel2.BorderColor = Color.Transparent;
            panel2.Controls.Add(radioAttributes);
            panel2.Controls.Add(radioMagicOptions);
            panel2.Controls.Add(radioEnhance);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(6, 5, 6, 5);
            panel2.Name = "panel2";
            panel2.Radius = 1;
            panel2.ShadowDepth = 4F;
            panel2.Size = new Size(606, 63);
            panel2.TabIndex = 0;
            // 
            // radioAttributes
            // 
            radioAttributes.AutoSize = true;
            radioAttributes.Location = new Point(336, 13);
            radioAttributes.Margin = new Padding(0);
            radioAttributes.Name = "radioAttributes";
            radioAttributes.Ripple = true;
            radioAttributes.Size = new Size(72, 30);
            radioAttributes.TabIndex = 2;
            radioAttributes.Text = "Stats";
            radioAttributes.CheckedChanged += radioEngine_CheckedChanged;
            // 
            // radioMagicOptions
            // 
            radioMagicOptions.AutoSize = true;
            radioMagicOptions.Location = new Point(193, 13);
            radioMagicOptions.Margin = new Padding(0);
            radioMagicOptions.Name = "radioMagicOptions";
            radioMagicOptions.Ripple = true;
            radioMagicOptions.Size = new Size(76, 30);
            radioMagicOptions.TabIndex = 1;
            radioMagicOptions.Text = "Blues";
            radioMagicOptions.CheckedChanged += radioEngine_CheckedChanged;
            // 
            // radioEnhance
            // 
            radioEnhance.AutoSize = true;
            radioEnhance.Checked = true;
            radioEnhance.Location = new Point(14, 13);
            radioEnhance.Margin = new Padding(0);
            radioEnhance.Name = "radioEnhance";
            radioEnhance.Ripple = true;
            radioEnhance.Size = new Size(130, 30);
            radioEnhance.TabIndex = 0;
            radioEnhance.TabStop = true;
            radioEnhance.Text = "Enhance (+)";
            radioEnhance.CheckedChanged += radioEngine_CheckedChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSettingsGroup);
            Controls.Add(lvLog);
            Controls.Add(groupItem);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Main";
            Size = new Size(1130, 838);
            Load += Main_Load;
            groupItem.ResumeLayout(false);
            groupItem.PerformLayout();
            tabControlItemInfo.ResumeLayout(false);
            tabMagicOptions.ResumeLayout(false);
            tabPageAttributes.ResumeLayout(false);
            panelSettingsGroup.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupItem;
        private Label linkRefreshItemList;
        private ComboBox comboItem;
        private ListView lvLog;
        private System.Windows.Forms.ColumnHeader colItem;
        private System.Windows.Forms.ColumnHeader colResult;
        private Label lblOptLevelText;
        private Label lblDegree;
        private Label lblDegreeText;
        private Label lblOptLevel;
        private ListBox listMagicOptions;
        private TabControl tabControlItemInfo;
        private TabPage tabPageAttributes;
        private TabPage tabMagicOptions;
        private Label lblItemSelection;
        private ListBox listAttributes;
        private Panel panelSettingsGroup;
        private Panel panel2;
        private RadioButton radioEnhance;
        private RadioButton radioMagicOptions;
        private Panel panelSettings;
        private RadioButton radioAttributes;
        private Button button1;
    }
}
