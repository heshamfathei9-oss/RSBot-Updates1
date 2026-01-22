namespace RSBot.Training.Views
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Avoid", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Prefer", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Berserk", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("No custom behavior", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("General");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Champion");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Giant");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("General (party)");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Champion (party)");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Giant (party)");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Unique");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Strong");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Elite");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Event");
            groupBox2 = new SDUI.Controls.GroupBox();
            lvAvoidance = new SDUI.Controls.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            ctxAvoidance = new SDUI.Controls.ContextMenuStrip();
            btnAvoid = new System.Windows.Forms.ToolStripMenuItem();
            btnPrefer = new System.Windows.Forms.ToolStripMenuItem();
            btnBerserk = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            btnNoCustomBehavior = new System.Windows.Forms.ToolStripMenuItem();
            groupBoxWalkback = new SDUI.Controls.GroupBox();
            btnRemove = new SDUI.Controls.Button();
            linkRecord = new System.Windows.Forms.LinkLabel();
            checkBoxUseReverse = new SDUI.Controls.CheckBox();
            checkUseSpeedDrug = new SDUI.Controls.CheckBox();
            checkCastBuffs = new SDUI.Controls.CheckBox();
            checkUseMount = new SDUI.Controls.CheckBox();
            btnBrowse = new SDUI.Controls.Button();
            txtWalkscript = new SDUI.Controls.TextBox();
            label4 = new SDUI.Controls.Label();
            checkBerzerkWhenFull = new SDUI.Controls.CheckBox();
            checkBerserkOnMonsterRarity = new SDUI.Controls.CheckBox();
            groupBoxBerserk = new SDUI.Controls.GroupBox();
            label7 = new SDUI.Controls.Label();
            numBerzerkMonsterAmount = new SDUI.Controls.NumUpDown();
            checkBerzerkAvoidance = new SDUI.Controls.CheckBox();
            checkBerzerkMonsterAmount = new SDUI.Controls.CheckBox();
            groupBoxArea = new SDUI.Controls.GroupBox();
            btnApplyArea = new SDUI.Controls.Button();
            label8 = new SDUI.Controls.Label();
            txtRegion = new SDUI.Controls.TextBox();
            buttonSelectTrainingArea = new SDUI.Controls.Button();
            label6 = new SDUI.Controls.Label();
            label5 = new SDUI.Controls.Label();
            radioWalkAround = new SDUI.Controls.Radio();
            radioCenter = new SDUI.Controls.Radio();
            btnGetCurrent = new SDUI.Controls.Button();
            label3 = new SDUI.Controls.Label();
            label2 = new SDUI.Controls.Label();
            label1 = new SDUI.Controls.Label();
            txtRadius = new SDUI.Controls.TextBox();
            txtYCoord = new SDUI.Controls.TextBox();
            txtXCoord = new SDUI.Controls.TextBox();
            groupBoxAdvanced = new SDUI.Controls.GroupBox();
            checkBoxDontFollowMobs = new SDUI.Controls.CheckBox();
            linkAttackWeakerMobsHelp = new System.Windows.Forms.LinkLabel();
            checkAttackWeakerFirst = new SDUI.Controls.CheckBox();
            checkBoxDimensionPillar = new SDUI.Controls.CheckBox();
            timerGrabByAbilityPet = new System.Windows.Forms.Timer(components);
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            checkUseSpeedOnWalkback = new SDUI.Controls.CheckBox();
            groupBox2.SuspendLayout();
            ctxAvoidance.SuspendLayout();
            groupBoxWalkback.SuspendLayout();
            groupBoxBerserk.SuspendLayout();
            groupBoxArea.SuspendLayout();
            groupBoxAdvanced.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox2.Controls.Add(lvAvoidance);
            groupBox2.Location = new System.Drawing.Point(34, 410);
            groupBox2.Margin = new System.Windows.Forms.Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 10, 3, 4);
            groupBox2.Radius = 10;
            groupBox2.ShadowDepth = 4;
            groupBox2.Size = new System.Drawing.Size(332, 321);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Avoidance";
            // 
            // lvAvoidance
            // 
            lvAvoidance.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            lvAvoidance.BackColor = System.Drawing.Color.White;
            lvAvoidance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvAvoidance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1 });
            lvAvoidance.ContextMenuStrip = ctxAvoidance;
            lvAvoidance.Dock = System.Windows.Forms.DockStyle.Fill;
            lvAvoidance.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lvAvoidance.FullRowSelect = true;
            listViewGroup5.Header = "Avoid";
            listViewGroup5.Name = "grpAvoid";
            listViewGroup6.Header = "Prefer";
            listViewGroup6.Name = "grpPrefer";
            listViewGroup7.Header = "Berserk";
            listViewGroup7.Name = "grpBerserk";
            listViewGroup8.Header = "No custom behavior";
            listViewGroup8.Name = "grpNone";
            lvAvoidance.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroup5, listViewGroup6, listViewGroup7, listViewGroup8 });
            lvAvoidance.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem11.Group = listViewGroup8;
            listViewItem12.Group = listViewGroup8;
            listViewItem13.Group = listViewGroup8;
            listViewItem14.Group = listViewGroup8;
            listViewItem15.Group = listViewGroup8;
            listViewItem16.Group = listViewGroup8;
            listViewItem17.Group = listViewGroup8;
            listViewItem18.Group = listViewGroup8;
            listViewItem19.Group = listViewGroup8;
            listViewItem20.Group = listViewGroup8;
            listViewItem20.ToolTipText = "Event Mobs";
            lvAvoidance.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18, listViewItem19, listViewItem20 });
            lvAvoidance.Location = new System.Drawing.Point(3, 34);
            lvAvoidance.Margin = new System.Windows.Forms.Padding(4);
            lvAvoidance.Name = "lvAvoidance";
            lvAvoidance.Size = new System.Drawing.Size(326, 283);
            lvAvoidance.TabIndex = 5;
            lvAvoidance.TileSize = new System.Drawing.Size(168, 16);
            lvAvoidance.UseCompatibleStateImageBehavior = false;
            lvAvoidance.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 190;
            // 
            // ctxAvoidance
            // 
            ctxAvoidance.ImageScalingSize = new System.Drawing.Size(20, 20);
            ctxAvoidance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAvoid, btnPrefer, btnBerserk, toolStripSeparator1, btnNoCustomBehavior });
            ctxAvoidance.Name = "ctxAvoidance";
            ctxAvoidance.Size = new System.Drawing.Size(247, 138);
            // 
            // btnAvoid
            // 
            btnAvoid.Name = "btnAvoid";
            btnAvoid.Size = new System.Drawing.Size(246, 32);
            btnAvoid.Text = "Avoid";
            btnAvoid.Click += btnAvoid_Click;
            // 
            // btnPrefer
            // 
            btnPrefer.Name = "btnPrefer";
            btnPrefer.Size = new System.Drawing.Size(246, 32);
            btnPrefer.Text = "Prefer";
            btnPrefer.Click += btnPrefer_Click;
            // 
            // btnBerserk
            // 
            btnBerserk.Name = "btnBerserk";
            btnBerserk.Size = new System.Drawing.Size(246, 32);
            btnBerserk.Text = "Berserk";
            btnBerserk.Click += btnBerserk_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // btnNoCustomBehavior
            // 
            btnNoCustomBehavior.Name = "btnNoCustomBehavior";
            btnNoCustomBehavior.Size = new System.Drawing.Size(246, 32);
            btnNoCustomBehavior.Text = "No custom behavior";
            btnNoCustomBehavior.Click += btnNoCustomBehavior_Click;
            // 
            // groupBoxWalkback
            // 
            groupBoxWalkback.BackColor = System.Drawing.Color.Transparent;
            groupBoxWalkback.Controls.Add(checkUseSpeedOnWalkback);
            groupBoxWalkback.Controls.Add(btnRemove);
            groupBoxWalkback.Controls.Add(linkRecord);
            groupBoxWalkback.Controls.Add(checkBoxUseReverse);
            groupBoxWalkback.Controls.Add(checkUseSpeedDrug);
            groupBoxWalkback.Controls.Add(checkCastBuffs);
            groupBoxWalkback.Controls.Add(checkUseMount);
            groupBoxWalkback.Controls.Add(btnBrowse);
            groupBoxWalkback.Controls.Add(txtWalkscript);
            groupBoxWalkback.Controls.Add(label4);
            groupBoxWalkback.Location = new System.Drawing.Point(393, 24);
            groupBoxWalkback.Margin = new System.Windows.Forms.Padding(4);
            groupBoxWalkback.Name = "groupBoxWalkback";
            groupBoxWalkback.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            groupBoxWalkback.Radius = 10;
            groupBoxWalkback.ShadowDepth = 4;
            groupBoxWalkback.Size = new System.Drawing.Size(717, 212);
            groupBoxWalkback.TabIndex = 2;
            groupBoxWalkback.TabStop = false;
            groupBoxWalkback.Text = "Back to training";
            // 
            // btnRemove
            // 
            btnRemove.BorderWidth = 0F;
            btnRemove.Color = System.Drawing.Color.Transparent;
            btnRemove.CustomBorderColor = System.Drawing.Color.Empty;
            btnRemove.ForeColor = System.Drawing.Color.White;
            btnRemove.GradientAngle = 45F;
            btnRemove.GradientColor = System.Drawing.Color.Empty;
            btnRemove.Location = new System.Drawing.Point(609, 40);
            btnRemove.Margin = new System.Windows.Forms.Padding(4);
            btnRemove.Name = "btnRemove";
            btnRemove.Radius = 6;
            btnRemove.ShadowDepth = 4F;
            btnRemove.Size = new System.Drawing.Size(86, 34);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseGradient = false;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Visible = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // linkRecord
            // 
            linkRecord.AutoSize = true;
            linkRecord.Location = new System.Drawing.Point(522, 50);
            linkRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkRecord.Name = "linkRecord";
            linkRecord.Size = new System.Drawing.Size(77, 25);
            linkRecord.TabIndex = 7;
            linkRecord.TabStop = true;
            linkRecord.Text = "[Record]";
            linkRecord.LinkClicked += linkRecord_LinkClicked;
            // 
            // checkBoxUseReverse
            // 
            checkBoxUseReverse.AutoSize = true;
            checkBoxUseReverse.BackColor = System.Drawing.Color.Transparent;
            checkBoxUseReverse.Depth = 0;
            checkBoxUseReverse.Location = new System.Drawing.Point(560, 120);
            checkBoxUseReverse.Margin = new System.Windows.Forms.Padding(0);
            checkBoxUseReverse.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxUseReverse.Name = "checkBoxUseReverse";
            checkBoxUseReverse.Ripple = true;
            checkBoxUseReverse.Size = new System.Drawing.Size(132, 30);
            checkBoxUseReverse.TabIndex = 7;
            checkBoxUseReverse.Text = "Use Reverse";
            checkBoxUseReverse.UseVisualStyleBackColor = false;
            checkBoxUseReverse.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseSpeedDrug
            // 
            checkUseSpeedDrug.AutoSize = true;
            checkUseSpeedDrug.BackColor = System.Drawing.Color.Transparent;
            checkUseSpeedDrug.Checked = true;
            checkUseSpeedDrug.CheckState = System.Windows.Forms.CheckState.Checked;
            checkUseSpeedDrug.Depth = 0;
            checkUseSpeedDrug.Location = new System.Drawing.Point(387, 120);
            checkUseSpeedDrug.Margin = new System.Windows.Forms.Padding(0);
            checkUseSpeedDrug.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseSpeedDrug.Name = "checkUseSpeedDrug";
            checkUseSpeedDrug.Ripple = true;
            checkUseSpeedDrug.Size = new System.Drawing.Size(163, 30);
            checkUseSpeedDrug.TabIndex = 7;
            checkUseSpeedDrug.Text = "Use speed drug";
            checkUseSpeedDrug.UseVisualStyleBackColor = false;
            checkUseSpeedDrug.CheckedChanged += settings_CheckedChanged;
            // 
            // checkCastBuffs
            // 
            checkCastBuffs.AutoSize = true;
            checkCastBuffs.BackColor = System.Drawing.Color.Transparent;
            checkCastBuffs.Checked = true;
            checkCastBuffs.CheckState = System.Windows.Forms.CheckState.Checked;
            checkCastBuffs.Depth = 0;
            checkCastBuffs.Location = new System.Drawing.Point(254, 120);
            checkCastBuffs.Margin = new System.Windows.Forms.Padding(0);
            checkCastBuffs.MouseLocation = new System.Drawing.Point(-1, -1);
            checkCastBuffs.Name = "checkCastBuffs";
            checkCastBuffs.Ripple = true;
            checkCastBuffs.Size = new System.Drawing.Size(118, 30);
            checkCastBuffs.TabIndex = 6;
            checkCastBuffs.Text = "Cast buffs";
            checkCastBuffs.UseVisualStyleBackColor = false;
            checkCastBuffs.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseMount
            // 
            checkUseMount.AutoSize = true;
            checkUseMount.BackColor = System.Drawing.Color.Transparent;
            checkUseMount.Checked = true;
            checkUseMount.CheckState = System.Windows.Forms.CheckState.Checked;
            checkUseMount.Depth = 0;
            checkUseMount.Location = new System.Drawing.Point(27, 120);
            checkUseMount.Margin = new System.Windows.Forms.Padding(0);
            checkUseMount.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseMount.Name = "checkUseMount";
            checkUseMount.Ripple = true;
            checkUseMount.Size = new System.Drawing.Size(213, 30);
            checkUseMount.TabIndex = 3;
            checkUseMount.Text = "Use mount if available";
            checkUseMount.UseVisualStyleBackColor = false;
            checkUseMount.CheckedChanged += settings_CheckedChanged;
            // 
            // btnBrowse
            // 
            btnBrowse.BorderWidth = 0F;
            btnBrowse.Color = System.Drawing.Color.Transparent;
            btnBrowse.CustomBorderColor = System.Drawing.Color.Empty;
            btnBrowse.ForeColor = System.Drawing.Color.White;
            btnBrowse.GradientAngle = 45F;
            btnBrowse.GradientColor = System.Drawing.Color.Empty;
            btnBrowse.Location = new System.Drawing.Point(609, 76);
            btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Radius = 6;
            btnBrowse.ShadowDepth = 4F;
            btnBrowse.Size = new System.Drawing.Size(86, 34);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseGradient = false;
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtWalkscript
            // 
            txtWalkscript.BackColor = System.Drawing.Color.White;
            txtWalkscript.Location = new System.Drawing.Point(32, 78);
            txtWalkscript.Margin = new System.Windows.Forms.Padding(4);
            txtWalkscript.MaxLength = 32767;
            txtWalkscript.MultiLine = false;
            txtWalkscript.Name = "txtWalkscript";
            txtWalkscript.PassFocusShow = false;
            txtWalkscript.Radius = 2;
            txtWalkscript.Size = new System.Drawing.Size(568, 29);
            txtWalkscript.TabIndex = 4;
            txtWalkscript.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            txtWalkscript.UseSystemPasswordChar = false;
            txtWalkscript.Click += txtWalkscript_Click;
            // 
            // label4
            // 
            label4.ApplyGradient = false;
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label4.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label4.GradientAnimation = false;
            label4.Location = new System.Drawing.Point(27, 50);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 25);
            label4.TabIndex = 3;
            label4.Text = "Walkscript:";
            // 
            // checkBerzerkWhenFull
            // 
            checkBerzerkWhenFull.AutoSize = true;
            checkBerzerkWhenFull.BackColor = System.Drawing.Color.Transparent;
            checkBerzerkWhenFull.Depth = 0;
            checkBerzerkWhenFull.Location = new System.Drawing.Point(32, 51);
            checkBerzerkWhenFull.Margin = new System.Windows.Forms.Padding(0);
            checkBerzerkWhenFull.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBerzerkWhenFull.Name = "checkBerzerkWhenFull";
            checkBerzerkWhenFull.Ripple = true;
            checkBerzerkWhenFull.Size = new System.Drawing.Size(269, 30);
            checkBerzerkWhenFull.TabIndex = 4;
            checkBerzerkWhenFull.Text = "Enter berzerk mode when full";
            checkBerzerkWhenFull.UseVisualStyleBackColor = false;
            checkBerzerkWhenFull.CheckedChanged += settings_CheckedChanged;
            // 
            // checkBerserkOnMonsterRarity
            // 
            checkBerserkOnMonsterRarity.AutoSize = true;
            checkBerserkOnMonsterRarity.BackColor = System.Drawing.Color.Transparent;
            checkBerserkOnMonsterRarity.Depth = 0;
            checkBerserkOnMonsterRarity.Location = new System.Drawing.Point(32, 168);
            checkBerserkOnMonsterRarity.Margin = new System.Windows.Forms.Padding(0);
            checkBerserkOnMonsterRarity.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBerserkOnMonsterRarity.Name = "checkBerserkOnMonsterRarity";
            checkBerserkOnMonsterRarity.Ripple = true;
            checkBerserkOnMonsterRarity.Size = new System.Drawing.Size(466, 30);
            checkBerserkOnMonsterRarity.TabIndex = 4;
            checkBerserkOnMonsterRarity.Text = "Enter berserk mode when attack specific monster type";
            checkBerserkOnMonsterRarity.UseVisualStyleBackColor = false;
            checkBerserkOnMonsterRarity.CheckedChanged += settings_CheckedChanged;
            // 
            // groupBoxBerserk
            // 
            groupBoxBerserk.BackColor = System.Drawing.Color.Transparent;
            groupBoxBerserk.Controls.Add(label7);
            groupBoxBerserk.Controls.Add(numBerzerkMonsterAmount);
            groupBoxBerserk.Controls.Add(checkBerzerkAvoidance);
            groupBoxBerserk.Controls.Add(checkBerzerkMonsterAmount);
            groupBoxBerserk.Controls.Add(checkBerzerkWhenFull);
            groupBoxBerserk.Controls.Add(checkBerserkOnMonsterRarity);
            groupBoxBerserk.Location = new System.Drawing.Point(393, 317);
            groupBoxBerserk.Margin = new System.Windows.Forms.Padding(4);
            groupBoxBerserk.Name = "groupBoxBerserk";
            groupBoxBerserk.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            groupBoxBerserk.Radius = 10;
            groupBoxBerserk.ShadowDepth = 4;
            groupBoxBerserk.Size = new System.Drawing.Size(717, 225);
            groupBoxBerserk.TabIndex = 5;
            groupBoxBerserk.TabStop = false;
            groupBoxBerserk.Text = "Berserk";
            // 
            // label7
            // 
            label7.ApplyGradient = false;
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label7.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label7.GradientAnimation = false;
            label7.Location = new System.Drawing.Point(450, 100);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(86, 25);
            label7.TabIndex = 7;
            label7.Text = "monsters";
            // 
            // numBerzerkMonsterAmount
            // 
            numBerzerkMonsterAmount.BackColor = System.Drawing.Color.Transparent;
            numBerzerkMonsterAmount.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numBerzerkMonsterAmount.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numBerzerkMonsterAmount.Location = new System.Drawing.Point(321, 93);
            numBerzerkMonsterAmount.Margin = new System.Windows.Forms.Padding(4);
            numBerzerkMonsterAmount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numBerzerkMonsterAmount.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numBerzerkMonsterAmount.MinimumSize = new System.Drawing.Size(120, 38);
            numBerzerkMonsterAmount.Name = "numBerzerkMonsterAmount";
            numBerzerkMonsterAmount.Size = new System.Drawing.Size(120, 38);
            numBerzerkMonsterAmount.TabIndex = 6;
            numBerzerkMonsterAmount.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numBerzerkMonsterAmount.ValueChanged += numSettings_ValueChanged;
            // 
            // checkBerzerkAvoidance
            // 
            checkBerzerkAvoidance.AutoSize = true;
            checkBerzerkAvoidance.BackColor = System.Drawing.Color.Transparent;
            checkBerzerkAvoidance.Depth = 0;
            checkBerzerkAvoidance.Location = new System.Drawing.Point(32, 129);
            checkBerzerkAvoidance.Margin = new System.Windows.Forms.Padding(0);
            checkBerzerkAvoidance.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBerzerkAvoidance.Name = "checkBerzerkAvoidance";
            checkBerzerkAvoidance.Ripple = true;
            checkBerzerkAvoidance.Size = new System.Drawing.Size(510, 30);
            checkBerzerkAvoidance.TabIndex = 5;
            checkBerzerkAvoidance.Text = "If being attacked by a monster type that should be avoided";
            checkBerzerkAvoidance.UseVisualStyleBackColor = false;
            checkBerzerkAvoidance.CheckedChanged += settings_CheckedChanged;
            // 
            // checkBerzerkMonsterAmount
            // 
            checkBerzerkMonsterAmount.AutoSize = true;
            checkBerzerkMonsterAmount.BackColor = System.Drawing.Color.Transparent;
            checkBerzerkMonsterAmount.Depth = 0;
            checkBerzerkMonsterAmount.Location = new System.Drawing.Point(32, 90);
            checkBerzerkMonsterAmount.Margin = new System.Windows.Forms.Padding(0);
            checkBerzerkMonsterAmount.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBerzerkMonsterAmount.Name = "checkBerzerkMonsterAmount";
            checkBerzerkMonsterAmount.Ripple = true;
            checkBerzerkMonsterAmount.Size = new System.Drawing.Size(266, 30);
            checkBerzerkMonsterAmount.TabIndex = 4;
            checkBerzerkMonsterAmount.Text = "Being attacked by more than";
            checkBerzerkMonsterAmount.UseVisualStyleBackColor = false;
            checkBerzerkMonsterAmount.CheckedChanged += settings_CheckedChanged;
            // 
            // groupBoxArea
            // 
            groupBoxArea.BackColor = System.Drawing.Color.Transparent;
            groupBoxArea.Controls.Add(btnApplyArea);
            groupBoxArea.Controls.Add(label8);
            groupBoxArea.Controls.Add(txtRegion);
            groupBoxArea.Controls.Add(buttonSelectTrainingArea);
            groupBoxArea.Controls.Add(label6);
            groupBoxArea.Controls.Add(label5);
            groupBoxArea.Controls.Add(radioWalkAround);
            groupBoxArea.Controls.Add(radioCenter);
            groupBoxArea.Controls.Add(btnGetCurrent);
            groupBoxArea.Controls.Add(label3);
            groupBoxArea.Controls.Add(label2);
            groupBoxArea.Controls.Add(label1);
            groupBoxArea.Controls.Add(txtRadius);
            groupBoxArea.Controls.Add(txtYCoord);
            groupBoxArea.Controls.Add(txtXCoord);
            groupBoxArea.Location = new System.Drawing.Point(34, 24);
            groupBoxArea.Margin = new System.Windows.Forms.Padding(4);
            groupBoxArea.Name = "groupBoxArea";
            groupBoxArea.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            groupBoxArea.Radius = 10;
            groupBoxArea.ShadowDepth = 4;
            groupBoxArea.Size = new System.Drawing.Size(332, 375);
            groupBoxArea.TabIndex = 0;
            groupBoxArea.TabStop = false;
            groupBoxArea.Text = "Area";
            // 
            // btnApplyArea
            // 
            btnApplyArea.BorderWidth = 0F;
            btnApplyArea.Color = System.Drawing.Color.Transparent;
            btnApplyArea.CustomBorderColor = System.Drawing.Color.Empty;
            btnApplyArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            btnApplyArea.ForeColor = System.Drawing.Color.White;
            btnApplyArea.GradientAngle = 45F;
            btnApplyArea.GradientColor = System.Drawing.Color.Empty;
            btnApplyArea.Location = new System.Drawing.Point(68, 208);
            btnApplyArea.Margin = new System.Windows.Forms.Padding(4);
            btnApplyArea.Name = "btnApplyArea";
            btnApplyArea.Radius = 6;
            btnApplyArea.ShadowDepth = 4F;
            btnApplyArea.Size = new System.Drawing.Size(36, 36);
            btnApplyArea.TabIndex = 10;
            btnApplyArea.Text = "v";
            btnApplyArea.UseGradient = false;
            btnApplyArea.UseVisualStyleBackColor = true;
            btnApplyArea.Click += btnApplyArea_Click;
            // 
            // label8
            // 
            label8.ApplyGradient = false;
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label8.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label8.GradientAnimation = false;
            label8.Location = new System.Drawing.Point(40, 130);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(71, 25);
            label8.TabIndex = 9;
            label8.Text = "Region:";
            // 
            // txtRegion
            // 
            txtRegion.Location = new System.Drawing.Point(114, 126);
            txtRegion.Margin = new System.Windows.Forms.Padding(4);
            txtRegion.MaxLength = 32767;
            txtRegion.MultiLine = false;
            txtRegion.Name = "txtRegion";
            txtRegion.PassFocusShow = false;
            txtRegion.Radius = 2;
            txtRegion.Size = new System.Drawing.Size(146, 29);
            txtRegion.TabIndex = 8;
            txtRegion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            txtRegion.UseSystemPasswordChar = false;
            txtRegion.TextChanged += txtRegion_TextChanged;
            // 
            // buttonSelectTrainingArea
            // 
            buttonSelectTrainingArea.BorderWidth = 0F;
            buttonSelectTrainingArea.Color = System.Drawing.Color.Transparent;
            buttonSelectTrainingArea.CustomBorderColor = System.Drawing.Color.Empty;
            buttonSelectTrainingArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            buttonSelectTrainingArea.ForeColor = System.Drawing.Color.White;
            buttonSelectTrainingArea.GradientAngle = 45F;
            buttonSelectTrainingArea.GradientColor = System.Drawing.Color.Empty;
            buttonSelectTrainingArea.Location = new System.Drawing.Point(268, 208);
            buttonSelectTrainingArea.Margin = new System.Windows.Forms.Padding(4);
            buttonSelectTrainingArea.Name = "buttonSelectTrainingArea";
            buttonSelectTrainingArea.Radius = 6;
            buttonSelectTrainingArea.ShadowDepth = 4F;
            buttonSelectTrainingArea.Size = new System.Drawing.Size(36, 36);
            buttonSelectTrainingArea.TabIndex = 7;
            buttonSelectTrainingArea.Text = "...";
            buttonSelectTrainingArea.UseGradient = false;
            buttonSelectTrainingArea.UseVisualStyleBackColor = true;
            buttonSelectTrainingArea.Click += buttonSelectTrainingArea_Click;
            // 
            // label6
            // 
            label6.ApplyGradient = false;
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label6.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label6.GradientAnimation = false;
            label6.Location = new System.Drawing.Point(21, 266);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(253, 25);
            label6.TabIndex = 7;
            label6.Text = "If there is no monster nearby...";
            // 
            // label5
            // 
            label5.ApplyGradient = false;
            label5.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label5.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label5.GradientAnimation = false;
            label5.Location = new System.Drawing.Point(9, 249);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(300, 3);
            label5.TabIndex = 6;
            // 
            // radioWalkAround
            // 
            radioWalkAround.AutoSize = true;
            radioWalkAround.Checked = true;
            radioWalkAround.Location = new System.Drawing.Point(52, 336);
            radioWalkAround.Margin = new System.Windows.Forms.Padding(0);
            radioWalkAround.Name = "radioWalkAround";
            radioWalkAround.Ripple = true;
            radioWalkAround.Size = new System.Drawing.Size(137, 30);
            radioWalkAround.TabIndex = 5;
            radioWalkAround.TabStop = true;
            radioWalkAround.Text = "Walk around";
            radioWalkAround.CheckedChanged += settings_CheckedChanged;
            // 
            // radioCenter
            // 
            radioCenter.AutoSize = true;
            radioCenter.Location = new System.Drawing.Point(52, 297);
            radioCenter.Margin = new System.Windows.Forms.Padding(0);
            radioCenter.Name = "radioCenter";
            radioCenter.Ripple = true;
            radioCenter.Size = new System.Drawing.Size(178, 30);
            radioCenter.TabIndex = 4;
            radioCenter.Text = "Go back to center";
            radioCenter.CheckedChanged += settings_CheckedChanged;
            // 
            // btnGetCurrent
            // 
            btnGetCurrent.BorderWidth = 0F;
            btnGetCurrent.Color = System.Drawing.Color.Transparent;
            btnGetCurrent.CustomBorderColor = System.Drawing.Color.Empty;
            btnGetCurrent.ForeColor = System.Drawing.Color.White;
            btnGetCurrent.GradientAngle = 45F;
            btnGetCurrent.GradientColor = System.Drawing.Color.Empty;
            btnGetCurrent.Location = new System.Drawing.Point(114, 208);
            btnGetCurrent.Margin = new System.Windows.Forms.Padding(4);
            btnGetCurrent.Name = "btnGetCurrent";
            btnGetCurrent.Radius = 6;
            btnGetCurrent.ShadowDepth = 4F;
            btnGetCurrent.Size = new System.Drawing.Size(146, 34);
            btnGetCurrent.TabIndex = 3;
            btnGetCurrent.Text = "Current";
            btnGetCurrent.UseGradient = false;
            btnGetCurrent.UseVisualStyleBackColor = true;
            btnGetCurrent.Click += btnGetCurrent_Click;
            // 
            // label3
            // 
            label3.ApplyGradient = false;
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label3.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label3.GradientAnimation = false;
            label3.Location = new System.Drawing.Point(40, 174);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 25);
            label3.TabIndex = 1;
            label3.Text = "Radius:";
            // 
            // label2
            // 
            label2.ApplyGradient = false;
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label2.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label2.GradientAnimation = false;
            label2.Location = new System.Drawing.Point(80, 87);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(26, 25);
            label2.TabIndex = 1;
            label2.Text = "Y:";
            toolTip1.SetToolTip(label2, "The coordinates of the dungeons should be divided by 10");
            // 
            // label1
            // 
            label1.ApplyGradient = false;
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label1.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label1.GradientAnimation = false;
            label1.Location = new System.Drawing.Point(80, 48);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(27, 25);
            label1.TabIndex = 1;
            label1.Text = "X:";
            toolTip1.SetToolTip(label1, "The coordinates of the dungeons should be divided by 10");
            // 
            // txtRadius
            // 
            txtRadius.Location = new System.Drawing.Point(114, 170);
            txtRadius.Margin = new System.Windows.Forms.Padding(4);
            txtRadius.MaxLength = 32767;
            txtRadius.MultiLine = false;
            txtRadius.Name = "txtRadius";
            txtRadius.PassFocusShow = false;
            txtRadius.Radius = 2;
            txtRadius.Size = new System.Drawing.Size(146, 29);
            txtRadius.TabIndex = 0;
            txtRadius.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            txtRadius.UseSystemPasswordChar = false;
            txtRadius.TextChanged += txtRadius_TextChanged;
            // 
            // txtYCoord
            // 
            txtYCoord.Location = new System.Drawing.Point(114, 82);
            txtYCoord.Margin = new System.Windows.Forms.Padding(4);
            txtYCoord.MaxLength = 32767;
            txtYCoord.MultiLine = false;
            txtYCoord.Name = "txtYCoord";
            txtYCoord.PassFocusShow = false;
            txtYCoord.Radius = 2;
            txtYCoord.Size = new System.Drawing.Size(146, 29);
            txtYCoord.TabIndex = 0;
            txtYCoord.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            txtYCoord.UseSystemPasswordChar = false;
            txtYCoord.TextChanged += txtYCoord_TextChanged;
            // 
            // txtXCoord
            // 
            txtXCoord.Location = new System.Drawing.Point(114, 44);
            txtXCoord.Margin = new System.Windows.Forms.Padding(4);
            txtXCoord.MaxLength = 32767;
            txtXCoord.MultiLine = false;
            txtXCoord.Name = "txtXCoord";
            txtXCoord.PassFocusShow = false;
            txtXCoord.Radius = 2;
            txtXCoord.Size = new System.Drawing.Size(146, 29);
            txtXCoord.TabIndex = 0;
            txtXCoord.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            txtXCoord.UseSystemPasswordChar = false;
            txtXCoord.TextChanged += txtXCoord_TextChanged;
            // 
            // groupBoxAdvanced
            // 
            groupBoxAdvanced.BackColor = System.Drawing.Color.Transparent;
            groupBoxAdvanced.Controls.Add(checkBoxDontFollowMobs);
            groupBoxAdvanced.Controls.Add(linkAttackWeakerMobsHelp);
            groupBoxAdvanced.Controls.Add(checkAttackWeakerFirst);
            groupBoxAdvanced.Controls.Add(checkBoxDimensionPillar);
            groupBoxAdvanced.Location = new System.Drawing.Point(393, 555);
            groupBoxAdvanced.Margin = new System.Windows.Forms.Padding(4);
            groupBoxAdvanced.Name = "groupBoxAdvanced";
            groupBoxAdvanced.Padding = new System.Windows.Forms.Padding(4, 12, 4, 4);
            groupBoxAdvanced.Radius = 10;
            groupBoxAdvanced.ShadowDepth = 4;
            groupBoxAdvanced.Size = new System.Drawing.Size(717, 159);
            groupBoxAdvanced.TabIndex = 6;
            groupBoxAdvanced.TabStop = false;
            groupBoxAdvanced.Text = "Advanced";
            // 
            // checkBoxDontFollowMobs
            // 
            checkBoxDontFollowMobs.AutoSize = true;
            checkBoxDontFollowMobs.BackColor = System.Drawing.Color.Transparent;
            checkBoxDontFollowMobs.Depth = 0;
            checkBoxDontFollowMobs.Location = new System.Drawing.Point(32, 112);
            checkBoxDontFollowMobs.Margin = new System.Windows.Forms.Padding(0);
            checkBoxDontFollowMobs.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxDontFollowMobs.Name = "checkBoxDontFollowMobs";
            checkBoxDontFollowMobs.Ripple = true;
            checkBoxDontFollowMobs.Size = new System.Drawing.Size(384, 30);
            checkBoxDontFollowMobs.TabIndex = 8;
            checkBoxDontFollowMobs.Text = "Don't follow mobs outside the training area";
            checkBoxDontFollowMobs.UseVisualStyleBackColor = false;
            checkBoxDontFollowMobs.CheckedChanged += settings_CheckedChanged;
            // 
            // linkAttackWeakerMobsHelp
            // 
            linkAttackWeakerMobsHelp.AutoSize = true;
            linkAttackWeakerMobsHelp.Location = new System.Drawing.Point(429, 87);
            linkAttackWeakerMobsHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkAttackWeakerMobsHelp.Name = "linkAttackWeakerMobsHelp";
            linkAttackWeakerMobsHelp.Size = new System.Drawing.Size(20, 25);
            linkAttackWeakerMobsHelp.TabIndex = 7;
            linkAttackWeakerMobsHelp.TabStop = true;
            linkAttackWeakerMobsHelp.Text = "?";
            linkAttackWeakerMobsHelp.LinkClicked += linkAttackWeakerMobsHelp_LinkClicked;
            // 
            // checkAttackWeakerFirst
            // 
            checkAttackWeakerFirst.AutoSize = true;
            checkAttackWeakerFirst.BackColor = System.Drawing.Color.Transparent;
            checkAttackWeakerFirst.Depth = 0;
            checkAttackWeakerFirst.Location = new System.Drawing.Point(32, 76);
            checkAttackWeakerFirst.Margin = new System.Windows.Forms.Padding(0);
            checkAttackWeakerFirst.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAttackWeakerFirst.Name = "checkAttackWeakerFirst";
            checkAttackWeakerFirst.Ripple = true;
            checkAttackWeakerFirst.Size = new System.Drawing.Size(385, 30);
            checkAttackWeakerFirst.TabIndex = 1;
            checkAttackWeakerFirst.Text = "If avoided: counter attack weaker mobs first";
            checkAttackWeakerFirst.UseVisualStyleBackColor = false;
            checkAttackWeakerFirst.CheckedChanged += settings_CheckedChanged;
            // 
            // checkBoxDimensionPillar
            // 
            checkBoxDimensionPillar.AutoSize = true;
            checkBoxDimensionPillar.BackColor = System.Drawing.Color.Transparent;
            checkBoxDimensionPillar.Depth = 0;
            checkBoxDimensionPillar.Location = new System.Drawing.Point(32, 40);
            checkBoxDimensionPillar.Margin = new System.Windows.Forms.Padding(0);
            checkBoxDimensionPillar.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxDimensionPillar.Name = "checkBoxDimensionPillar";
            checkBoxDimensionPillar.Ripple = true;
            checkBoxDimensionPillar.Size = new System.Drawing.Size(222, 30);
            checkBoxDimensionPillar.TabIndex = 0;
            checkBoxDimensionPillar.Text = "Ignore Dimension Pillar";
            checkBoxDimensionPillar.UseVisualStyleBackColor = false;
            checkBoxDimensionPillar.CheckedChanged += settings_CheckedChanged;
            // 
            // timerGrabByAbilityPet
            // 
            timerGrabByAbilityPet.Enabled = true;
            timerGrabByAbilityPet.Interval = 200;
            timerGrabByAbilityPet.Tick += timerGrabByAbilityPet_Tick;
            // 
            // checkBox1
            // 
            checkUseSpeedOnWalkback.AutoSize = true;
            checkUseSpeedOnWalkback.BackColor = System.Drawing.Color.Transparent;
            checkUseSpeedOnWalkback.Checked = true;
            checkUseSpeedOnWalkback.CheckState = System.Windows.Forms.CheckState.Checked;
            checkUseSpeedOnWalkback.Depth = 0;
            checkUseSpeedOnWalkback.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            checkUseSpeedOnWalkback.Location = new System.Drawing.Point(397, 152);
            checkUseSpeedOnWalkback.Margin = new System.Windows.Forms.Padding(0);
            checkUseSpeedOnWalkback.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseSpeedOnWalkback.Name = "checkUseSpeedOnWalkback";
            checkUseSpeedOnWalkback.Ripple = true;
            checkUseSpeedOnWalkback.Size = new System.Drawing.Size(262, 30);
            checkUseSpeedOnWalkback.TabIndex = 9;
            checkUseSpeedOnWalkback.Text = "Use speed drug when go training";
            checkUseSpeedOnWalkback.UseVisualStyleBackColor = false;
            checkUseSpeedOnWalkback.CheckedChanged += checkUseSpeedOnWalkback_CheckedChanged;

            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(groupBoxAdvanced);
            Controls.Add(groupBoxWalkback);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxArea);
            Controls.Add(groupBoxBerserk);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Main";
            Size = new System.Drawing.Size(1158, 736);
            Load += Main_Load;
            groupBox2.ResumeLayout(false);
            ctxAvoidance.ResumeLayout(false);
            groupBoxWalkback.ResumeLayout(false);
            groupBoxWalkback.PerformLayout();
            groupBoxBerserk.ResumeLayout(false);
            groupBoxBerserk.PerformLayout();
            groupBoxArea.ResumeLayout(false);
            groupBoxArea.PerformLayout();
            groupBoxAdvanced.ResumeLayout(false);
            groupBoxAdvanced.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SDUI.Controls.GroupBox groupBox2;
        private SDUI.Controls.GroupBox groupBoxWalkback;
        private SDUI.Controls.Button btnBrowse;
        private SDUI.Controls.TextBox txtWalkscript;
        private SDUI.Controls.Label label4;
        private SDUI.Controls.CheckBox checkUseMount;
        private SDUI.Controls.CheckBox checkUseSpeedDrug;
        private SDUI.Controls.CheckBox checkCastBuffs;
        private SDUI.Controls.CheckBox checkBerzerkWhenFull;
        private SDUI.Controls.CheckBox checkBerserkOnMonsterRarity;
        private SDUI.Controls.ListView lvAvoidance;
        private SDUI.Controls.ContextMenuStrip ctxAvoidance;
        private System.Windows.Forms.ToolStripMenuItem btnAvoid;
        private System.Windows.Forms.ToolStripMenuItem btnPrefer;
        private System.Windows.Forms.ToolStripMenuItem btnBerserk;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnNoCustomBehavior;
        private SDUI.Controls.GroupBox groupBoxBerserk;
        private SDUI.Controls.NumUpDown numBerzerkMonsterAmount;
        private SDUI.Controls.CheckBox checkBerzerkAvoidance;
        private SDUI.Controls.CheckBox checkBerzerkMonsterAmount;
        private SDUI.Controls.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private SDUI.Controls.GroupBox groupBoxArea;
        private SDUI.Controls.Label label6;
        private SDUI.Controls.Label label5;
        private SDUI.Controls.Radio radioWalkAround;
        private SDUI.Controls.Radio radioCenter;
        private SDUI.Controls.Button btnGetCurrent;
        private SDUI.Controls.Label label3;
        private SDUI.Controls.Label label2;
        private SDUI.Controls.Label label1;
        private SDUI.Controls.TextBox txtRadius;
        private SDUI.Controls.TextBox txtYCoord;
        private SDUI.Controls.TextBox txtXCoord;
        private SDUI.Controls.CheckBox checkBoxUseReverse;
        private SDUI.Controls.Button buttonSelectTrainingArea;
        private SDUI.Controls.Radio radioStand;
        private SDUI.Controls.GroupBox groupBoxAdvanced;
        private SDUI.Controls.CheckBox checkBoxDimensionPillar;
        private SDUI.Controls.CheckBox checkAttackWeakerFirst;
        private System.Windows.Forms.LinkLabel linkAttackWeakerMobsHelp;
        private System.Windows.Forms.LinkLabel linkRecord;
        private System.Windows.Forms.Timer timerGrabByAbilityPet;
        private SDUI.Controls.Label label8;
        private SDUI.Controls.TextBox txtRegion;
        private SDUI.Controls.Button btnApplyArea;
        private System.Windows.Forms.ToolTip toolTip1;
        private SDUI.Controls.CheckBox checkBoxDontFollowMobs;
        private SDUI.Controls.Button btnRemove;
        private SDUI.Controls.CheckBox checkUseSpeedOnWalkback;
        private int checkBox1_CheckedChanged;

        public bool Ripple { get; private set; }
    }
}
