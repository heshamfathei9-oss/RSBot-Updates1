namespace RSBot.Protection.Views
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
            label22 = new SDUI.Controls.Label();
            groupBackTown = new SDUI.Controls.GroupBox();
            checkBox2 = new SDUI.Controls.CheckBox();
            label19 = new SDUI.Controls.Label();
            numShardFatigueMinToDC = new SDUI.Controls.NumUpDown();
            numMPPotionsLeft = new SDUI.Controls.NumUpDown();
            numHPPotionsLeft = new SDUI.Controls.NumUpDown();
            checkShardFatigue = new SDUI.Controls.CheckBox();
            checkStopBotOnReturnToTown = new SDUI.Controls.CheckBox();
            label21 = new SDUI.Controls.Label();
            numDeadTimeout = new SDUI.Controls.NumUpDown();
            checkLevelUp = new SDUI.Controls.CheckBox();
            checkFullPetInventory = new SDUI.Controls.CheckBox();
            checkNoMPPotions = new SDUI.Controls.CheckBox();
            checkNoHPPotions = new SDUI.Controls.CheckBox();
            checkDurability = new SDUI.Controls.CheckBox();
            checkDead = new SDUI.Controls.CheckBox();
            checkInventory = new SDUI.Controls.CheckBox();
            checkNoArrows = new SDUI.Controls.CheckBox();
            groupBadStatus = new SDUI.Controls.GroupBox();
            label18 = new SDUI.Controls.Label();
            comboSkillBadStatus = new SDUI.Controls.ComboBox();
            checkUseBadStatusSkill = new SDUI.Controls.CheckBox();
            checkUseUniversalPills = new SDUI.Controls.CheckBox();
            groupHPMP = new SDUI.Controls.GroupBox();
            label17 = new SDUI.Controls.Label();
            comboSkillPlayerMP = new SDUI.Controls.ComboBox();
            comboSkillPlayerHP = new SDUI.Controls.ComboBox();
            label11 = new SDUI.Controls.Label();
            numPlayerSkillMPMin = new SDUI.Controls.NumUpDown();
            label12 = new SDUI.Controls.Label();
            label9 = new SDUI.Controls.Label();
            numPlayerSkillHPMin = new SDUI.Controls.NumUpDown();
            label10 = new SDUI.Controls.Label();
            label7 = new SDUI.Controls.Label();
            numPlayerMPVigorPotionMin = new SDUI.Controls.NumUpDown();
            label8 = new SDUI.Controls.Label();
            label5 = new SDUI.Controls.Label();
            numPlayerHPVigorPotionMin = new SDUI.Controls.NumUpDown();
            label6 = new SDUI.Controls.Label();
            label3 = new SDUI.Controls.Label();
            numPlayerMPPotionMin = new SDUI.Controls.NumUpDown();
            label4 = new SDUI.Controls.Label();
            label2 = new SDUI.Controls.Label();
            numPlayerHPPotionMin = new SDUI.Controls.NumUpDown();
            label1 = new SDUI.Controls.Label();
            checkUseSkillHP = new SDUI.Controls.CheckBox();
            checkUseSkillMP = new SDUI.Controls.CheckBox();
            checkUseHPPotionsPlayer = new SDUI.Controls.CheckBox();
            checkUseVigorMP = new SDUI.Controls.CheckBox();
            checkUseMPPotionsPlayer = new SDUI.Controls.CheckBox();
            checkUseVigorHP = new SDUI.Controls.CheckBox();
            groupPet = new SDUI.Controls.GroupBox();
            checkAutoSummonAttackPet = new SDUI.Controls.CheckBox();
            checkUseAbnormalStatePotion = new SDUI.Controls.CheckBox();
            checkReviveAttackPet = new SDUI.Controls.CheckBox();
            label13 = new SDUI.Controls.Label();
            numPetMinHGP = new SDUI.Controls.NumUpDown();
            label14 = new SDUI.Controls.Label();
            label15 = new SDUI.Controls.Label();
            numPetMinHP = new SDUI.Controls.NumUpDown();
            label16 = new SDUI.Controls.Label();
            checkUsePetHP = new SDUI.Controls.CheckBox();
            checkUseHGP = new SDUI.Controls.CheckBox();
            groupStatPoints = new SDUI.Controls.GroupBox();
            buttonRun = new SDUI.Controls.Button();
            checkIncBotStopped = new SDUI.Controls.CheckBox();
            numIncStr = new SDUI.Controls.NumUpDown();
            numIncInt = new SDUI.Controls.NumUpDown();
            checkIncStr = new SDUI.Controls.CheckBox();
            checkIncInt = new SDUI.Controls.CheckBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            groupBackTown.SuspendLayout();
            groupBadStatus.SuspendLayout();
            groupHPMP.SuspendLayout();
            groupPet.SuspendLayout();
            groupStatPoints.SuspendLayout();
            SuspendLayout();
            // 
            // label22
            // 
            label22.ApplyGradient = false;
            label22.AutoSize = true;
            label22.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label22.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label22.GradientAnimation = false;
            label22.Location = new System.Drawing.Point(750, 706);
            label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(386, 25);
            label22.TabIndex = 16;
            label22.Text = "* Will also be executed, if the bot is not started.";
            // 
            // groupBackTown
            // 
            groupBackTown.BackColor = System.Drawing.Color.Transparent;
            groupBackTown.Controls.Add(checkBox2);
            groupBackTown.Controls.Add(label19);
            groupBackTown.Controls.Add(numShardFatigueMinToDC);
            groupBackTown.Controls.Add(numMPPotionsLeft);
            groupBackTown.Controls.Add(numHPPotionsLeft);
            groupBackTown.Controls.Add(checkShardFatigue);
            groupBackTown.Controls.Add(checkStopBotOnReturnToTown);
            groupBackTown.Controls.Add(label21);
            groupBackTown.Controls.Add(numDeadTimeout);
            groupBackTown.Controls.Add(checkLevelUp);
            groupBackTown.Controls.Add(checkFullPetInventory);
            groupBackTown.Controls.Add(checkNoMPPotions);
            groupBackTown.Controls.Add(checkNoHPPotions);
            groupBackTown.Controls.Add(checkDurability);
            groupBackTown.Controls.Add(checkDead);
            groupBackTown.Controls.Add(checkInventory);
            groupBackTown.Controls.Add(checkNoArrows);
            groupBackTown.Location = new System.Drawing.Point(735, 11);
            groupBackTown.Margin = new System.Windows.Forms.Padding(5);
            groupBackTown.Name = "groupBackTown";
            groupBackTown.Padding = new System.Windows.Forms.Padding(5, 14, 5, 5);
            groupBackTown.Radius = 10;
            groupBackTown.ShadowDepth = 4;
            groupBackTown.Size = new System.Drawing.Size(491, 427);
            groupBackTown.TabIndex = 17;
            groupBackTown.TabStop = false;
            groupBackTown.Text = "Back to town";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = System.Drawing.Color.Transparent;
            checkBox2.Depth = 0;
            checkBox2.Location = new System.Drawing.Point(15, 108);
            checkBox2.Margin = new System.Windows.Forms.Padding(0);
            checkBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBox2.Name = "checkBox2";
            checkBox2.Ripple = true;
            checkBox2.Size = new System.Drawing.Size(470, 30);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Return immediately if dead outside of the training area";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label19
            // 
            label19.ApplyGradient = false;
            label19.AutoSize = true;
            label19.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label19.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label19.GradientAnimation = false;
            label19.Location = new System.Drawing.Point(343, 388);
            label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(42, 25);
            label19.TabIndex = 16;
            label19.Text = "min";
            // 
            // numShardFatigueMinToDC
            // 
            numShardFatigueMinToDC.BackColor = System.Drawing.Color.Transparent;
            numShardFatigueMinToDC.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numShardFatigueMinToDC.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numShardFatigueMinToDC.Location = new System.Drawing.Point(220, 382);
            numShardFatigueMinToDC.Margin = new System.Windows.Forms.Padding(5);
            numShardFatigueMinToDC.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numShardFatigueMinToDC.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numShardFatigueMinToDC.MinimumSize = new System.Drawing.Size(120, 37);
            numShardFatigueMinToDC.Name = "numShardFatigueMinToDC";
            numShardFatigueMinToDC.Size = new System.Drawing.Size(120, 37);
            numShardFatigueMinToDC.TabIndex = 15;
            numShardFatigueMinToDC.Value = new decimal(new int[] { 15, 0, 0, 0 });
            numShardFatigueMinToDC.ValueChanged += numSettings_ValueChanged;
            // 
            // numMPPotionsLeft
            // 
            numMPPotionsLeft.BackColor = System.Drawing.Color.Transparent;
            numMPPotionsLeft.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numMPPotionsLeft.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numMPPotionsLeft.Location = new System.Drawing.Point(220, 274);
            numMPPotionsLeft.Margin = new System.Windows.Forms.Padding(5);
            numMPPotionsLeft.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numMPPotionsLeft.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numMPPotionsLeft.MinimumSize = new System.Drawing.Size(120, 37);
            numMPPotionsLeft.Name = "numMPPotionsLeft";
            numMPPotionsLeft.Size = new System.Drawing.Size(120, 37);
            numMPPotionsLeft.TabIndex = 14;
            numMPPotionsLeft.Value = new decimal(new int[] { 15, 0, 0, 0 });
            numMPPotionsLeft.ValueChanged += numSettings_ValueChanged;
            // 
            // numHPPotionsLeft
            // 
            numHPPotionsLeft.BackColor = System.Drawing.Color.Transparent;
            numHPPotionsLeft.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numHPPotionsLeft.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numHPPotionsLeft.Location = new System.Drawing.Point(220, 233);
            numHPPotionsLeft.Margin = new System.Windows.Forms.Padding(5);
            numHPPotionsLeft.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numHPPotionsLeft.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numHPPotionsLeft.MinimumSize = new System.Drawing.Size(120, 37);
            numHPPotionsLeft.Name = "numHPPotionsLeft";
            numHPPotionsLeft.Size = new System.Drawing.Size(120, 37);
            numHPPotionsLeft.TabIndex = 13;
            numHPPotionsLeft.Value = new decimal(new int[] { 15, 0, 0, 0 });
            numHPPotionsLeft.ValueChanged += numSettings_ValueChanged;
            // 
            // checkShardFatigue
            // 
            checkShardFatigue.AutoSize = true;
            checkShardFatigue.BackColor = System.Drawing.Color.Transparent;
            checkShardFatigue.Depth = 0;
            checkShardFatigue.Location = new System.Drawing.Point(18, 383);
            checkShardFatigue.Margin = new System.Windows.Forms.Padding(0);
            checkShardFatigue.MouseLocation = new System.Drawing.Point(-1, -1);
            checkShardFatigue.Name = "checkShardFatigue";
            checkShardFatigue.Ripple = true;
            checkShardFatigue.Size = new System.Drawing.Size(144, 30);
            checkShardFatigue.TabIndex = 12;
            checkShardFatigue.Text = "Shard fatigue";
            toolTip1.SetToolTip(checkShardFatigue, "Return and disconnect when Shard fatigue reaches that time");
            checkShardFatigue.UseVisualStyleBackColor = false;
            checkShardFatigue.CheckedChanged += settings_CheckedChanged;
            // 
            // checkStopBotOnReturnToTown
            // 
            checkStopBotOnReturnToTown.AutoSize = true;
            checkStopBotOnReturnToTown.BackColor = System.Drawing.Color.Transparent;
            checkStopBotOnReturnToTown.Depth = 0;
            checkStopBotOnReturnToTown.Location = new System.Drawing.Point(15, 78);
            checkStopBotOnReturnToTown.Margin = new System.Windows.Forms.Padding(0);
            checkStopBotOnReturnToTown.MouseLocation = new System.Drawing.Point(-1, -1);
            checkStopBotOnReturnToTown.Name = "checkStopBotOnReturnToTown";
            checkStopBotOnReturnToTown.Ripple = true;
            checkStopBotOnReturnToTown.Size = new System.Drawing.Size(261, 30);
            checkStopBotOnReturnToTown.TabIndex = 11;
            checkStopBotOnReturnToTown.Text = "Stop bot when back in town";
            checkStopBotOnReturnToTown.UseVisualStyleBackColor = false;
            checkStopBotOnReturnToTown.CheckedChanged += settings_CheckedChanged;
            // 
            // label21
            // 
            label21.ApplyGradient = false;
            label21.AutoSize = true;
            label21.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label21.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label21.GradientAnimation = false;
            label21.Location = new System.Drawing.Point(338, 47);
            label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(27, 25);
            label21.TabIndex = 10;
            label21.Text = "/s";
            // 
            // numDeadTimeout
            // 
            numDeadTimeout.BackColor = System.Drawing.Color.Transparent;
            numDeadTimeout.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numDeadTimeout.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numDeadTimeout.Location = new System.Drawing.Point(208, 39);
            numDeadTimeout.Margin = new System.Windows.Forms.Padding(5);
            numDeadTimeout.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numDeadTimeout.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDeadTimeout.MinimumSize = new System.Drawing.Size(120, 37);
            numDeadTimeout.Name = "numDeadTimeout";
            numDeadTimeout.Size = new System.Drawing.Size(120, 37);
            numDeadTimeout.TabIndex = 9;
            numDeadTimeout.Value = new decimal(new int[] { 30, 0, 0, 0 });
            numDeadTimeout.ValueChanged += numSettings_ValueChanged;
            // 
            // checkLevelUp
            // 
            checkLevelUp.AutoSize = true;
            checkLevelUp.BackColor = System.Drawing.Color.Transparent;
            checkLevelUp.Depth = 0;
            checkLevelUp.Location = new System.Drawing.Point(18, 347);
            checkLevelUp.Margin = new System.Windows.Forms.Padding(0);
            checkLevelUp.MouseLocation = new System.Drawing.Point(-1, -1);
            checkLevelUp.Name = "checkLevelUp";
            checkLevelUp.Ripple = true;
            checkLevelUp.Size = new System.Drawing.Size(103, 30);
            checkLevelUp.TabIndex = 8;
            checkLevelUp.Text = "Level up";
            checkLevelUp.UseVisualStyleBackColor = false;
            checkLevelUp.CheckedChanged += settings_CheckedChanged;
            // 
            // checkFullPetInventory
            // 
            checkFullPetInventory.AutoSize = true;
            checkFullPetInventory.BackColor = System.Drawing.Color.Transparent;
            checkFullPetInventory.Depth = 0;
            checkFullPetInventory.Location = new System.Drawing.Point(18, 203);
            checkFullPetInventory.Margin = new System.Windows.Forms.Padding(0);
            checkFullPetInventory.MouseLocation = new System.Drawing.Point(-1, -1);
            checkFullPetInventory.Name = "checkFullPetInventory";
            checkFullPetInventory.Ripple = true;
            checkFullPetInventory.Size = new System.Drawing.Size(175, 30);
            checkFullPetInventory.TabIndex = 7;
            checkFullPetInventory.Text = "Full pet inventory";
            checkFullPetInventory.UseVisualStyleBackColor = false;
            checkFullPetInventory.CheckedChanged += settings_CheckedChanged;
            // 
            // checkNoMPPotions
            // 
            checkNoMPPotions.AutoSize = true;
            checkNoMPPotions.BackColor = System.Drawing.Color.Transparent;
            checkNoMPPotions.Depth = 0;
            checkNoMPPotions.Location = new System.Drawing.Point(18, 275);
            checkNoMPPotions.Margin = new System.Windows.Forms.Padding(0);
            checkNoMPPotions.MouseLocation = new System.Drawing.Point(-1, -1);
            checkNoMPPotions.Name = "checkNoMPPotions";
            checkNoMPPotions.Ripple = true;
            checkNoMPPotions.Size = new System.Drawing.Size(158, 30);
            checkNoMPPotions.TabIndex = 6;
            checkNoMPPotions.Text = "MP Potions left";
            checkNoMPPotions.UseVisualStyleBackColor = false;
            checkNoMPPotions.CheckedChanged += settings_CheckedChanged;
            // 
            // checkNoHPPotions
            // 
            checkNoHPPotions.AutoSize = true;
            checkNoHPPotions.BackColor = System.Drawing.Color.Transparent;
            checkNoHPPotions.Depth = 0;
            checkNoHPPotions.Location = new System.Drawing.Point(18, 239);
            checkNoHPPotions.Margin = new System.Windows.Forms.Padding(0);
            checkNoHPPotions.MouseLocation = new System.Drawing.Point(-1, -1);
            checkNoHPPotions.Name = "checkNoHPPotions";
            checkNoHPPotions.Ripple = true;
            checkNoHPPotions.Size = new System.Drawing.Size(155, 30);
            checkNoHPPotions.TabIndex = 5;
            checkNoHPPotions.Text = "HP Potions left";
            checkNoHPPotions.UseVisualStyleBackColor = false;
            checkNoHPPotions.CheckedChanged += settings_CheckedChanged;
            // 
            // checkDurability
            // 
            checkDurability.AutoSize = true;
            checkDurability.BackColor = System.Drawing.Color.Transparent;
            checkDurability.Depth = 0;
            checkDurability.Location = new System.Drawing.Point(18, 311);
            checkDurability.Margin = new System.Windows.Forms.Padding(0);
            checkDurability.MouseLocation = new System.Drawing.Point(-1, -1);
            checkDurability.Name = "checkDurability";
            checkDurability.Ripple = true;
            checkDurability.Size = new System.Drawing.Size(236, 30);
            checkDurability.TabIndex = 4;
            checkDurability.Text = "Equipment durability low";
            checkDurability.UseVisualStyleBackColor = false;
            checkDurability.CheckedChanged += settings_CheckedChanged;
            // 
            // checkDead
            // 
            checkDead.AutoSize = true;
            checkDead.BackColor = System.Drawing.Color.Transparent;
            checkDead.Depth = 0;
            checkDead.Location = new System.Drawing.Point(15, 42);
            checkDead.Margin = new System.Windows.Forms.Padding(0);
            checkDead.MouseLocation = new System.Drawing.Point(-1, -1);
            checkDead.Name = "checkDead";
            checkDead.Ripple = true;
            checkDead.Size = new System.Drawing.Size(192, 30);
            checkDead.TabIndex = 3;
            checkDead.Text = "Dead with delay of ";
            checkDead.UseVisualStyleBackColor = false;
            checkDead.CheckedChanged += settings_CheckedChanged;
            // 
            // checkInventory
            // 
            checkInventory.AutoSize = true;
            checkInventory.BackColor = System.Drawing.Color.Transparent;
            checkInventory.Depth = 0;
            checkInventory.Location = new System.Drawing.Point(18, 167);
            checkInventory.Margin = new System.Windows.Forms.Padding(0);
            checkInventory.MouseLocation = new System.Drawing.Point(-1, -1);
            checkInventory.Name = "checkInventory";
            checkInventory.Ripple = true;
            checkInventory.Size = new System.Drawing.Size(144, 30);
            checkInventory.TabIndex = 4;
            checkInventory.Text = "Full inventory";
            checkInventory.UseVisualStyleBackColor = false;
            checkInventory.CheckedChanged += settings_CheckedChanged;
            // 
            // checkNoArrows
            // 
            checkNoArrows.AutoSize = true;
            checkNoArrows.BackColor = System.Drawing.Color.Transparent;
            checkNoArrows.Depth = 0;
            checkNoArrows.Location = new System.Drawing.Point(14, 136);
            checkNoArrows.Margin = new System.Windows.Forms.Padding(0);
            checkNoArrows.MouseLocation = new System.Drawing.Point(-1, -1);
            checkNoArrows.Name = "checkNoArrows";
            checkNoArrows.Ripple = true;
            checkNoArrows.Size = new System.Drawing.Size(207, 30);
            checkNoArrows.TabIndex = 4;
            checkNoArrows.Text = "No arrows / bolts left";
            checkNoArrows.UseVisualStyleBackColor = false;
            checkNoArrows.CheckedChanged += settings_CheckedChanged;
            // 
            // groupBadStatus
            // 
            groupBadStatus.BackColor = System.Drawing.Color.Transparent;
            groupBadStatus.Controls.Add(label18);
            groupBadStatus.Controls.Add(comboSkillBadStatus);
            groupBadStatus.Controls.Add(checkUseBadStatusSkill);
            groupBadStatus.Controls.Add(checkUseUniversalPills);
            groupBadStatus.Location = new System.Drawing.Point(23, 338);
            groupBadStatus.Margin = new System.Windows.Forms.Padding(5);
            groupBadStatus.Name = "groupBadStatus";
            groupBadStatus.Padding = new System.Windows.Forms.Padding(5, 14, 5, 5);
            groupBadStatus.Radius = 10;
            groupBadStatus.ShadowDepth = 4;
            groupBadStatus.Size = new System.Drawing.Size(702, 139);
            groupBadStatus.TabIndex = 6;
            groupBadStatus.TabStop = false;
            groupBadStatus.Text = "Bad status";
            // 
            // label18
            // 
            label18.ApplyGradient = false;
            label18.AutoSize = true;
            label18.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label18.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label18.GradientAnimation = false;
            label18.Location = new System.Drawing.Point(474, 62);
            label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(47, 25);
            label18.TabIndex = 27;
            label18.Text = "Skill:";
            // 
            // comboSkillBadStatus
            // 
            comboSkillBadStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            comboSkillBadStatus.DropDownHeight = 100;
            comboSkillBadStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboSkillBadStatus.FormattingEnabled = true;
            comboSkillBadStatus.IntegralHeight = false;
            comboSkillBadStatus.ItemHeight = 17;
            comboSkillBadStatus.Location = new System.Drawing.Point(478, 89);
            comboSkillBadStatus.Margin = new System.Windows.Forms.Padding(5);
            comboSkillBadStatus.Name = "comboSkillBadStatus";
            comboSkillBadStatus.Radius = 5;
            comboSkillBadStatus.ShadowDepth = 4F;
            comboSkillBadStatus.Size = new System.Drawing.Size(179, 23);
            comboSkillBadStatus.TabIndex = 26;
            comboSkillBadStatus.SelectedIndexChanged += comboSkill_SelectedIndexChanged;
            // 
            // checkUseBadStatusSkill
            // 
            checkUseBadStatusSkill.AutoSize = true;
            checkUseBadStatusSkill.BackColor = System.Drawing.Color.Transparent;
            checkUseBadStatusSkill.Depth = 0;
            checkUseBadStatusSkill.Location = new System.Drawing.Point(17, 84);
            checkUseBadStatusSkill.Margin = new System.Windows.Forms.Padding(0);
            checkUseBadStatusSkill.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseBadStatusSkill.Name = "checkUseBadStatusSkill";
            checkUseBadStatusSkill.Ripple = true;
            checkUseBadStatusSkill.Size = new System.Drawing.Size(103, 30);
            checkUseBadStatusSkill.TabIndex = 5;
            checkUseBadStatusSkill.Text = "Use Skill";
            checkUseBadStatusSkill.UseVisualStyleBackColor = false;
            checkUseBadStatusSkill.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseUniversalPills
            // 
            checkUseUniversalPills.AutoSize = true;
            checkUseUniversalPills.BackColor = System.Drawing.Color.Transparent;
            checkUseUniversalPills.Checked = true;
            checkUseUniversalPills.CheckState = System.Windows.Forms.CheckState.Checked;
            checkUseUniversalPills.Depth = 0;
            checkUseUniversalPills.Location = new System.Drawing.Point(17, 43);
            checkUseUniversalPills.Margin = new System.Windows.Forms.Padding(0);
            checkUseUniversalPills.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseUniversalPills.Name = "checkUseUniversalPills";
            checkUseUniversalPills.Ripple = true;
            checkUseUniversalPills.Size = new System.Drawing.Size(191, 30);
            checkUseUniversalPills.TabIndex = 4;
            checkUseUniversalPills.Text = "Use Universal Pills *";
            checkUseUniversalPills.UseVisualStyleBackColor = false;
            checkUseUniversalPills.CheckedChanged += settings_CheckedChanged;
            // 
            // groupHPMP
            // 
            groupHPMP.BackColor = System.Drawing.Color.Transparent;
            groupHPMP.Controls.Add(label17);
            groupHPMP.Controls.Add(comboSkillPlayerMP);
            groupHPMP.Controls.Add(comboSkillPlayerHP);
            groupHPMP.Controls.Add(label11);
            groupHPMP.Controls.Add(numPlayerSkillMPMin);
            groupHPMP.Controls.Add(label12);
            groupHPMP.Controls.Add(label9);
            groupHPMP.Controls.Add(numPlayerSkillHPMin);
            groupHPMP.Controls.Add(label10);
            groupHPMP.Controls.Add(label7);
            groupHPMP.Controls.Add(numPlayerMPVigorPotionMin);
            groupHPMP.Controls.Add(label8);
            groupHPMP.Controls.Add(label5);
            groupHPMP.Controls.Add(numPlayerHPVigorPotionMin);
            groupHPMP.Controls.Add(label6);
            groupHPMP.Controls.Add(label3);
            groupHPMP.Controls.Add(numPlayerMPPotionMin);
            groupHPMP.Controls.Add(label4);
            groupHPMP.Controls.Add(label2);
            groupHPMP.Controls.Add(numPlayerHPPotionMin);
            groupHPMP.Controls.Add(label1);
            groupHPMP.Controls.Add(checkUseSkillHP);
            groupHPMP.Controls.Add(checkUseSkillMP);
            groupHPMP.Controls.Add(checkUseHPPotionsPlayer);
            groupHPMP.Controls.Add(checkUseVigorMP);
            groupHPMP.Controls.Add(checkUseMPPotionsPlayer);
            groupHPMP.Controls.Add(checkUseVigorHP);
            groupHPMP.Location = new System.Drawing.Point(23, 11);
            groupHPMP.Margin = new System.Windows.Forms.Padding(5);
            groupHPMP.Name = "groupHPMP";
            groupHPMP.Padding = new System.Windows.Forms.Padding(5, 14, 5, 5);
            groupHPMP.Radius = 10;
            groupHPMP.ShadowDepth = 4;
            groupHPMP.Size = new System.Drawing.Size(702, 319);
            groupHPMP.TabIndex = 5;
            groupHPMP.TabStop = false;
            groupHPMP.Text = "Health / Mana recovery";
            // 
            // label17
            // 
            label17.ApplyGradient = false;
            label17.AutoSize = true;
            label17.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label17.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label17.GradientAnimation = false;
            label17.Location = new System.Drawing.Point(498, 202);
            label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(47, 25);
            label17.TabIndex = 26;
            label17.Text = "Skill:";
            // 
            // comboSkillPlayerMP
            // 
            comboSkillPlayerMP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            comboSkillPlayerMP.DropDownHeight = 100;
            comboSkillPlayerMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboSkillPlayerMP.FormattingEnabled = true;
            comboSkillPlayerMP.IntegralHeight = false;
            comboSkillPlayerMP.ItemHeight = 17;
            comboSkillPlayerMP.Location = new System.Drawing.Point(498, 269);
            comboSkillPlayerMP.Margin = new System.Windows.Forms.Padding(5);
            comboSkillPlayerMP.Name = "comboSkillPlayerMP";
            comboSkillPlayerMP.Radius = 5;
            comboSkillPlayerMP.ShadowDepth = 4F;
            comboSkillPlayerMP.Size = new System.Drawing.Size(179, 23);
            comboSkillPlayerMP.TabIndex = 25;
            comboSkillPlayerMP.SelectedIndexChanged += comboSkill_SelectedIndexChanged;
            // 
            // comboSkillPlayerHP
            // 
            comboSkillPlayerHP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            comboSkillPlayerHP.DropDownHeight = 100;
            comboSkillPlayerHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboSkillPlayerHP.FormattingEnabled = true;
            comboSkillPlayerHP.IntegralHeight = false;
            comboSkillPlayerHP.ItemHeight = 17;
            comboSkillPlayerHP.Location = new System.Drawing.Point(498, 228);
            comboSkillPlayerHP.Margin = new System.Windows.Forms.Padding(5);
            comboSkillPlayerHP.Name = "comboSkillPlayerHP";
            comboSkillPlayerHP.Radius = 5;
            comboSkillPlayerHP.ShadowDepth = 4F;
            comboSkillPlayerHP.Size = new System.Drawing.Size(179, 23);
            comboSkillPlayerHP.TabIndex = 7;
            comboSkillPlayerHP.SelectedIndexChanged += comboSkill_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.ApplyGradient = false;
            label11.AutoSize = true;
            label11.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label11.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label11.GradientAnimation = false;
            label11.Location = new System.Drawing.Point(451, 275);
            label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(27, 25);
            label11.TabIndex = 24;
            label11.Text = "%";
            // 
            // numPlayerSkillMPMin
            // 
            numPlayerSkillMPMin.BackColor = System.Drawing.Color.Transparent;
            numPlayerSkillMPMin.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numPlayerSkillMPMin.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numPlayerSkillMPMin.Location = new System.Drawing.Point(330, 269);
            numPlayerSkillMPMin.Margin = new System.Windows.Forms.Padding(5);
            numPlayerSkillMPMin.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numPlayerSkillMPMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPlayerSkillMPMin.MinimumSize = new System.Drawing.Size(120, 37);
            numPlayerSkillMPMin.Name = "numPlayerSkillMPMin";
            numPlayerSkillMPMin.Size = new System.Drawing.Size(120, 37);
            numPlayerSkillMPMin.TabIndex = 23;
            numPlayerSkillMPMin.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numPlayerSkillMPMin.ValueChanged += numSettings_ValueChanged;
            // 
            // label12
            // 
            label12.ApplyGradient = false;
            label12.AutoSize = true;
            label12.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label12.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label12.GradientAnimation = false;
            label12.Location = new System.Drawing.Point(301, 274);
            label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(24, 25);
            label12.TabIndex = 22;
            label12.Text = "<";
            // 
            // label9
            // 
            label9.ApplyGradient = false;
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label9.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label9.GradientAnimation = false;
            label9.Location = new System.Drawing.Point(454, 234);
            label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(27, 25);
            label9.TabIndex = 21;
            label9.Text = "%";
            // 
            // numPlayerSkillHPMin
            // 
            numPlayerSkillHPMin.BackColor = System.Drawing.Color.Transparent;
            numPlayerSkillHPMin.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numPlayerSkillHPMin.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numPlayerSkillHPMin.Location = new System.Drawing.Point(330, 228);
            numPlayerSkillHPMin.Margin = new System.Windows.Forms.Padding(5);
            numPlayerSkillHPMin.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numPlayerSkillHPMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPlayerSkillHPMin.MinimumSize = new System.Drawing.Size(120, 37);
            numPlayerSkillHPMin.Name = "numPlayerSkillHPMin";
            numPlayerSkillHPMin.Size = new System.Drawing.Size(120, 37);
            numPlayerSkillHPMin.TabIndex = 20;
            numPlayerSkillHPMin.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numPlayerSkillHPMin.ValueChanged += numSettings_ValueChanged;
            // 
            // label10
            // 
            label10.ApplyGradient = false;
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label10.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label10.GradientAnimation = false;
            label10.Location = new System.Drawing.Point(301, 233);
            label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(24, 25);
            label10.TabIndex = 19;
            label10.Text = "<";
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
            label7.Location = new System.Drawing.Point(454, 185);
            label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(27, 25);
            label7.TabIndex = 18;
            label7.Text = "%";
            // 
            // numPlayerMPVigorPotionMin
            // 
            numPlayerMPVigorPotionMin.BackColor = System.Drawing.Color.Transparent;
            numPlayerMPVigorPotionMin.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numPlayerMPVigorPotionMin.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numPlayerMPVigorPotionMin.Location = new System.Drawing.Point(330, 178);
            numPlayerMPVigorPotionMin.Margin = new System.Windows.Forms.Padding(5);
            numPlayerMPVigorPotionMin.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numPlayerMPVigorPotionMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPlayerMPVigorPotionMin.MinimumSize = new System.Drawing.Size(120, 37);
            numPlayerMPVigorPotionMin.Name = "numPlayerMPVigorPotionMin";
            numPlayerMPVigorPotionMin.Size = new System.Drawing.Size(120, 37);
            numPlayerMPVigorPotionMin.TabIndex = 17;
            numPlayerMPVigorPotionMin.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numPlayerMPVigorPotionMin.ValueChanged += numSettings_ValueChanged;
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
            label8.Location = new System.Drawing.Point(301, 182);
            label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(24, 25);
            label8.TabIndex = 16;
            label8.Text = "<";
            // 
            // label5
            // 
            label5.ApplyGradient = false;
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label5.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label5.GradientAnimation = false;
            label5.Location = new System.Drawing.Point(454, 144);
            label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(27, 25);
            label5.TabIndex = 15;
            label5.Text = "%";
            // 
            // numPlayerHPVigorPotionMin
            // 
            numPlayerHPVigorPotionMin.BackColor = System.Drawing.Color.Transparent;
            numPlayerHPVigorPotionMin.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numPlayerHPVigorPotionMin.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numPlayerHPVigorPotionMin.Location = new System.Drawing.Point(330, 137);
            numPlayerHPVigorPotionMin.Margin = new System.Windows.Forms.Padding(5);
            numPlayerHPVigorPotionMin.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numPlayerHPVigorPotionMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPlayerHPVigorPotionMin.MinimumSize = new System.Drawing.Size(120, 37);
            numPlayerHPVigorPotionMin.Name = "numPlayerHPVigorPotionMin";
            numPlayerHPVigorPotionMin.Size = new System.Drawing.Size(120, 37);
            numPlayerHPVigorPotionMin.TabIndex = 14;
            numPlayerHPVigorPotionMin.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numPlayerHPVigorPotionMin.ValueChanged += numSettings_ValueChanged;
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
            label6.Location = new System.Drawing.Point(301, 143);
            label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(24, 25);
            label6.TabIndex = 13;
            label6.Text = "<";
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
            label3.Location = new System.Drawing.Point(458, 96);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(27, 25);
            label3.TabIndex = 12;
            label3.Text = "%";
            // 
            // numPlayerMPPotionMin
            // 
            numPlayerMPPotionMin.BackColor = System.Drawing.Color.Transparent;
            numPlayerMPPotionMin.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numPlayerMPPotionMin.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numPlayerMPPotionMin.Location = new System.Drawing.Point(330, 90);
            numPlayerMPPotionMin.Margin = new System.Windows.Forms.Padding(5);
            numPlayerMPPotionMin.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numPlayerMPPotionMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPlayerMPPotionMin.MinimumSize = new System.Drawing.Size(120, 37);
            numPlayerMPPotionMin.Name = "numPlayerMPPotionMin";
            numPlayerMPPotionMin.Size = new System.Drawing.Size(120, 37);
            numPlayerMPPotionMin.TabIndex = 11;
            numPlayerMPPotionMin.Value = new decimal(new int[] { 75, 0, 0, 0 });
            numPlayerMPPotionMin.ValueChanged += numSettings_ValueChanged;
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
            label4.Location = new System.Drawing.Point(301, 96);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(24, 25);
            label4.TabIndex = 10;
            label4.Text = "<";
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
            label2.Location = new System.Drawing.Point(458, 55);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(27, 25);
            label2.TabIndex = 9;
            label2.Text = "%";
            // 
            // numPlayerHPPotionMin
            // 
            numPlayerHPPotionMin.BackColor = System.Drawing.Color.Transparent;
            numPlayerHPPotionMin.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numPlayerHPPotionMin.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numPlayerHPPotionMin.Location = new System.Drawing.Point(330, 49);
            numPlayerHPPotionMin.Margin = new System.Windows.Forms.Padding(5);
            numPlayerHPPotionMin.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numPlayerHPPotionMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPlayerHPPotionMin.MinimumSize = new System.Drawing.Size(120, 37);
            numPlayerHPPotionMin.Name = "numPlayerHPPotionMin";
            numPlayerHPPotionMin.Size = new System.Drawing.Size(120, 37);
            numPlayerHPPotionMin.TabIndex = 8;
            numPlayerHPPotionMin.Value = new decimal(new int[] { 75, 0, 0, 0 });
            numPlayerHPPotionMin.ValueChanged += numSettings_ValueChanged;
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
            label1.Location = new System.Drawing.Point(301, 55);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 25);
            label1.TabIndex = 7;
            label1.Text = "<";
            // 
            // checkUseSkillHP
            // 
            checkUseSkillHP.AutoSize = true;
            checkUseSkillHP.BackColor = System.Drawing.Color.Transparent;
            checkUseSkillHP.Depth = 0;
            checkUseSkillHP.Location = new System.Drawing.Point(17, 223);
            checkUseSkillHP.Margin = new System.Windows.Forms.Padding(0);
            checkUseSkillHP.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseSkillHP.Name = "checkUseSkillHP";
            checkUseSkillHP.Ripple = true;
            checkUseSkillHP.Size = new System.Drawing.Size(144, 30);
            checkUseSkillHP.TabIndex = 4;
            checkUseSkillHP.Text = "Use skill if HP";
            checkUseSkillHP.UseVisualStyleBackColor = false;
            checkUseSkillHP.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseSkillMP
            // 
            checkUseSkillMP.AutoSize = true;
            checkUseSkillMP.BackColor = System.Drawing.Color.Transparent;
            checkUseSkillMP.Depth = 0;
            checkUseSkillMP.Location = new System.Drawing.Point(13, 263);
            checkUseSkillMP.Margin = new System.Windows.Forms.Padding(0);
            checkUseSkillMP.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseSkillMP.Name = "checkUseSkillMP";
            checkUseSkillMP.Ripple = true;
            checkUseSkillMP.Size = new System.Drawing.Size(147, 30);
            checkUseSkillMP.TabIndex = 5;
            checkUseSkillMP.Text = "Use skill if MP";
            checkUseSkillMP.UseVisualStyleBackColor = false;
            checkUseSkillMP.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseHPPotionsPlayer
            // 
            checkUseHPPotionsPlayer.AutoSize = true;
            checkUseHPPotionsPlayer.BackColor = System.Drawing.Color.Transparent;
            checkUseHPPotionsPlayer.Checked = true;
            checkUseHPPotionsPlayer.CheckState = System.Windows.Forms.CheckState.Checked;
            checkUseHPPotionsPlayer.Depth = 0;
            checkUseHPPotionsPlayer.Location = new System.Drawing.Point(17, 43);
            checkUseHPPotionsPlayer.Margin = new System.Windows.Forms.Padding(0);
            checkUseHPPotionsPlayer.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseHPPotionsPlayer.Name = "checkUseHPPotionsPlayer";
            checkUseHPPotionsPlayer.Ripple = true;
            checkUseHPPotionsPlayer.Size = new System.Drawing.Size(217, 30);
            checkUseHPPotionsPlayer.TabIndex = 0;
            checkUseHPPotionsPlayer.Text = "Use HP potions if HP *";
            checkUseHPPotionsPlayer.UseVisualStyleBackColor = false;
            checkUseHPPotionsPlayer.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseVigorMP
            // 
            checkUseVigorMP.AutoSize = true;
            checkUseVigorMP.BackColor = System.Drawing.Color.Transparent;
            checkUseVigorMP.Depth = 0;
            checkUseVigorMP.Location = new System.Drawing.Point(17, 169);
            checkUseVigorMP.Margin = new System.Windows.Forms.Padding(0);
            checkUseVigorMP.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseVigorMP.Name = "checkUseVigorMP";
            checkUseVigorMP.Ripple = true;
            checkUseVigorMP.Size = new System.Drawing.Size(225, 30);
            checkUseVigorMP.TabIndex = 3;
            checkUseVigorMP.Text = "Use Vigor Potions if MP";
            checkUseVigorMP.UseVisualStyleBackColor = false;
            checkUseVigorMP.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseMPPotionsPlayer
            // 
            checkUseMPPotionsPlayer.AutoSize = true;
            checkUseMPPotionsPlayer.BackColor = System.Drawing.Color.Transparent;
            checkUseMPPotionsPlayer.Checked = true;
            checkUseMPPotionsPlayer.CheckState = System.Windows.Forms.CheckState.Checked;
            checkUseMPPotionsPlayer.Depth = 0;
            checkUseMPPotionsPlayer.Location = new System.Drawing.Point(17, 84);
            checkUseMPPotionsPlayer.Margin = new System.Windows.Forms.Padding(0);
            checkUseMPPotionsPlayer.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseMPPotionsPlayer.Name = "checkUseMPPotionsPlayer";
            checkUseMPPotionsPlayer.Ripple = true;
            checkUseMPPotionsPlayer.Size = new System.Drawing.Size(223, 30);
            checkUseMPPotionsPlayer.TabIndex = 1;
            checkUseMPPotionsPlayer.Text = "Use MP potions if MP *";
            checkUseMPPotionsPlayer.UseVisualStyleBackColor = false;
            checkUseMPPotionsPlayer.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseVigorHP
            // 
            checkUseVigorHP.AutoSize = true;
            checkUseVigorHP.BackColor = System.Drawing.Color.Transparent;
            checkUseVigorHP.Depth = 0;
            checkUseVigorHP.Location = new System.Drawing.Point(17, 131);
            checkUseVigorHP.Margin = new System.Windows.Forms.Padding(0);
            checkUseVigorHP.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseVigorHP.Name = "checkUseVigorHP";
            checkUseVigorHP.Ripple = true;
            checkUseVigorHP.Size = new System.Drawing.Size(222, 30);
            checkUseVigorHP.TabIndex = 2;
            checkUseVigorHP.Text = "Use Vigor Potions if HP";
            checkUseVigorHP.UseVisualStyleBackColor = false;
            checkUseVigorHP.CheckedChanged += settings_CheckedChanged;
            // 
            // groupPet
            // 
            groupPet.BackColor = System.Drawing.Color.Transparent;
            groupPet.Controls.Add(checkAutoSummonAttackPet);
            groupPet.Controls.Add(checkUseAbnormalStatePotion);
            groupPet.Controls.Add(checkReviveAttackPet);
            groupPet.Controls.Add(label13);
            groupPet.Controls.Add(numPetMinHGP);
            groupPet.Controls.Add(label14);
            groupPet.Controls.Add(label15);
            groupPet.Controls.Add(numPetMinHP);
            groupPet.Controls.Add(label16);
            groupPet.Controls.Add(checkUsePetHP);
            groupPet.Controls.Add(checkUseHGP);
            groupPet.Location = new System.Drawing.Point(23, 487);
            groupPet.Margin = new System.Windows.Forms.Padding(5);
            groupPet.Name = "groupPet";
            groupPet.Padding = new System.Windows.Forms.Padding(5, 14, 5, 5);
            groupPet.Radius = 10;
            groupPet.ShadowDepth = 4;
            groupPet.Size = new System.Drawing.Size(702, 240);
            groupPet.TabIndex = 1;
            groupPet.TabStop = false;
            groupPet.Text = "Recovery - Pet";
            // 
            // checkAutoSummonAttackPet
            // 
            checkAutoSummonAttackPet.AutoSize = true;
            checkAutoSummonAttackPet.BackColor = System.Drawing.Color.Transparent;
            checkAutoSummonAttackPet.Depth = 0;
            checkAutoSummonAttackPet.Location = new System.Drawing.Point(17, 193);
            checkAutoSummonAttackPet.Margin = new System.Windows.Forms.Padding(0);
            checkAutoSummonAttackPet.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAutoSummonAttackPet.Name = "checkAutoSummonAttackPet";
            checkAutoSummonAttackPet.Ripple = true;
            checkAutoSummonAttackPet.Size = new System.Drawing.Size(303, 30);
            checkAutoSummonAttackPet.TabIndex = 27;
            checkAutoSummonAttackPet.Text = "Auto summon growth & fellow pet";
            checkAutoSummonAttackPet.UseVisualStyleBackColor = false;
            checkAutoSummonAttackPet.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseAbnormalStatePotion
            // 
            checkUseAbnormalStatePotion.AutoSize = true;
            checkUseAbnormalStatePotion.BackColor = System.Drawing.Color.Transparent;
            checkUseAbnormalStatePotion.Checked = true;
            checkUseAbnormalStatePotion.CheckState = System.Windows.Forms.CheckState.Checked;
            checkUseAbnormalStatePotion.Depth = 0;
            checkUseAbnormalStatePotion.Location = new System.Drawing.Point(17, 122);
            checkUseAbnormalStatePotion.Margin = new System.Windows.Forms.Padding(0);
            checkUseAbnormalStatePotion.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseAbnormalStatePotion.Name = "checkUseAbnormalStatePotion";
            checkUseAbnormalStatePotion.Ripple = true;
            checkUseAbnormalStatePotion.Size = new System.Drawing.Size(342, 30);
            checkUseAbnormalStatePotion.TabIndex = 26;
            checkUseAbnormalStatePotion.Text = "Use abnormal state recovery potions *";
            checkUseAbnormalStatePotion.UseVisualStyleBackColor = false;
            checkUseAbnormalStatePotion.CheckedChanged += settings_CheckedChanged;
            // 
            // checkReviveAttackPet
            // 
            checkReviveAttackPet.AutoSize = true;
            checkReviveAttackPet.BackColor = System.Drawing.Color.Transparent;
            checkReviveAttackPet.Depth = 0;
            checkReviveAttackPet.Location = new System.Drawing.Point(17, 157);
            checkReviveAttackPet.Margin = new System.Windows.Forms.Padding(0);
            checkReviveAttackPet.MouseLocation = new System.Drawing.Point(-1, -1);
            checkReviveAttackPet.Name = "checkReviveAttackPet";
            checkReviveAttackPet.Ripple = true;
            checkReviveAttackPet.Size = new System.Drawing.Size(245, 30);
            checkReviveAttackPet.TabIndex = 25;
            checkReviveAttackPet.Text = "Revive growth / fellow pet";
            checkReviveAttackPet.UseVisualStyleBackColor = false;
            checkReviveAttackPet.CheckedChanged += settings_CheckedChanged;
            // 
            // label13
            // 
            label13.ApplyGradient = false;
            label13.AutoSize = true;
            label13.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label13.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label13.GradientAnimation = false;
            label13.Location = new System.Drawing.Point(529, 96);
            label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(27, 25);
            label13.TabIndex = 20;
            label13.Text = "%";
            // 
            // numPetMinHGP
            // 
            numPetMinHGP.BackColor = System.Drawing.Color.Transparent;
            numPetMinHGP.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numPetMinHGP.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numPetMinHGP.Location = new System.Drawing.Point(401, 89);
            numPetMinHGP.Margin = new System.Windows.Forms.Padding(5);
            numPetMinHGP.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numPetMinHGP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPetMinHGP.MinimumSize = new System.Drawing.Size(120, 37);
            numPetMinHGP.Name = "numPetMinHGP";
            numPetMinHGP.Size = new System.Drawing.Size(120, 37);
            numPetMinHGP.TabIndex = 19;
            numPetMinHGP.Value = new decimal(new int[] { 90, 0, 0, 0 });
            numPetMinHGP.ValueChanged += numSettings_ValueChanged;
            // 
            // label14
            // 
            label14.ApplyGradient = false;
            label14.AutoSize = true;
            label14.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label14.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label14.GradientAnimation = false;
            label14.Location = new System.Drawing.Point(370, 96);
            label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(24, 25);
            label14.TabIndex = 18;
            label14.Text = "<";
            // 
            // label15
            // 
            label15.ApplyGradient = false;
            label15.AutoSize = true;
            label15.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label15.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label15.GradientAnimation = false;
            label15.Location = new System.Drawing.Point(529, 54);
            label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(27, 25);
            label15.TabIndex = 17;
            label15.Text = "%";
            // 
            // numPetMinHP
            // 
            numPetMinHP.BackColor = System.Drawing.Color.Transparent;
            numPetMinHP.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numPetMinHP.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numPetMinHP.Location = new System.Drawing.Point(401, 47);
            numPetMinHP.Margin = new System.Windows.Forms.Padding(5);
            numPetMinHP.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numPetMinHP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPetMinHP.MinimumSize = new System.Drawing.Size(120, 37);
            numPetMinHP.Name = "numPetMinHP";
            numPetMinHP.Size = new System.Drawing.Size(120, 37);
            numPetMinHP.TabIndex = 16;
            numPetMinHP.Value = new decimal(new int[] { 80, 0, 0, 0 });
            numPetMinHP.ValueChanged += numSettings_ValueChanged;
            // 
            // label16
            // 
            label16.ApplyGradient = false;
            label16.AutoSize = true;
            label16.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label16.Gradient = new System.Drawing.Color[]
    {
    System.Drawing.Color.Gray,
    System.Drawing.Color.Black
    };
            label16.GradientAnimation = false;
            label16.Location = new System.Drawing.Point(370, 55);
            label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(24, 25);
            label16.TabIndex = 15;
            label16.Text = "<";
            // 
            // checkUsePetHP
            // 
            checkUsePetHP.AutoSize = true;
            checkUsePetHP.BackColor = System.Drawing.Color.Transparent;
            checkUsePetHP.Checked = true;
            checkUsePetHP.CheckState = System.Windows.Forms.CheckState.Checked;
            checkUsePetHP.Depth = 0;
            checkUsePetHP.Location = new System.Drawing.Point(17, 46);
            checkUsePetHP.Margin = new System.Windows.Forms.Padding(0);
            checkUsePetHP.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUsePetHP.Name = "checkUsePetHP";
            checkUsePetHP.Ripple = true;
            checkUsePetHP.Size = new System.Drawing.Size(217, 30);
            checkUsePetHP.TabIndex = 13;
            checkUsePetHP.Text = "Use HP potions if HP *";
            checkUsePetHP.UseVisualStyleBackColor = false;
            checkUsePetHP.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseHGP
            // 
            checkUseHGP.AutoSize = true;
            checkUseHGP.BackColor = System.Drawing.Color.Transparent;
            checkUseHGP.Checked = true;
            checkUseHGP.CheckState = System.Windows.Forms.CheckState.Checked;
            checkUseHGP.Depth = 0;
            checkUseHGP.Location = new System.Drawing.Point(17, 85);
            checkUseHGP.Margin = new System.Windows.Forms.Padding(0);
            checkUseHGP.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseHGP.Name = "checkUseHGP";
            checkUseHGP.Ripple = true;
            checkUseHGP.Size = new System.Drawing.Size(326, 30);
            checkUseHGP.TabIndex = 14;
            checkUseHGP.Text = "Use HGP / Saiety potions if hunger *";
            checkUseHGP.UseVisualStyleBackColor = false;
            checkUseHGP.CheckedChanged += settings_CheckedChanged;
            // 
            // groupStatPoints
            // 
            groupStatPoints.BackColor = System.Drawing.Color.Transparent;
            groupStatPoints.Controls.Add(buttonRun);
            groupStatPoints.Controls.Add(checkIncBotStopped);
            groupStatPoints.Controls.Add(numIncStr);
            groupStatPoints.Controls.Add(numIncInt);
            groupStatPoints.Controls.Add(checkIncStr);
            groupStatPoints.Controls.Add(checkIncInt);
            groupStatPoints.Location = new System.Drawing.Point(750, 448);
            groupStatPoints.Margin = new System.Windows.Forms.Padding(5);
            groupStatPoints.Name = "groupStatPoints";
            groupStatPoints.Padding = new System.Windows.Forms.Padding(5, 14, 5, 5);
            groupStatPoints.Radius = 10;
            groupStatPoints.ShadowDepth = 4;
            groupStatPoints.Size = new System.Drawing.Size(382, 253);
            groupStatPoints.TabIndex = 18;
            groupStatPoints.TabStop = false;
            groupStatPoints.Text = "Stat points";
            // 
            // buttonRun
            // 
            buttonRun.BorderWidth = 0F;
            buttonRun.Color = System.Drawing.Color.Transparent;
            buttonRun.CustomBorderColor = System.Drawing.Color.Empty;
            buttonRun.ForeColor = System.Drawing.Color.White;
            buttonRun.GradientAngle = 45F;
            buttonRun.GradientColor = System.Drawing.Color.Empty;
            buttonRun.Location = new System.Drawing.Point(95, 205);
            buttonRun.Margin = new System.Windows.Forms.Padding(5);
            buttonRun.Name = "buttonRun";
            buttonRun.Radius = 6;
            buttonRun.ShadowDepth = 4F;
            buttonRun.Size = new System.Drawing.Size(145, 35);
            buttonRun.TabIndex = 27;
            buttonRun.Text = "Run";
            buttonRun.UseGradient = false;
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // checkIncBotStopped
            // 
            checkIncBotStopped.AutoSize = true;
            checkIncBotStopped.BackColor = System.Drawing.Color.Transparent;
            checkIncBotStopped.Checked = true;
            checkIncBotStopped.CheckState = System.Windows.Forms.CheckState.Checked;
            checkIncBotStopped.Depth = 0;
            checkIncBotStopped.Location = new System.Drawing.Point(26, 156);
            checkIncBotStopped.Margin = new System.Windows.Forms.Padding(0);
            checkIncBotStopped.MouseLocation = new System.Drawing.Point(-1, -1);
            checkIncBotStopped.Name = "checkIncBotStopped";
            checkIncBotStopped.Ripple = true;
            checkIncBotStopped.Size = new System.Drawing.Size(281, 30);
            checkIncBotStopped.TabIndex = 24;
            checkIncBotStopped.Text = "Increase even if bot is stopped";
            checkIncBotStopped.UseVisualStyleBackColor = false;
            checkIncBotStopped.CheckedChanged += settings_CheckedChanged;
            // 
            // numIncStr
            // 
            numIncStr.BackColor = System.Drawing.Color.Transparent;
            numIncStr.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numIncStr.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numIncStr.Location = new System.Drawing.Point(199, 114);
            numIncStr.Margin = new System.Windows.Forms.Padding(5);
            numIncStr.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numIncStr.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numIncStr.MinimumSize = new System.Drawing.Size(120, 37);
            numIncStr.Name = "numIncStr";
            numIncStr.Size = new System.Drawing.Size(120, 37);
            numIncStr.TabIndex = 22;
            numIncStr.Value = new decimal(new int[] { 0, 0, 0, 0 });
            numIncStr.ValueChanged += numIncStr_ValueChanged;
            // 
            // numIncInt
            // 
            numIncInt.BackColor = System.Drawing.Color.Transparent;
            numIncInt.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numIncInt.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numIncInt.Location = new System.Drawing.Point(199, 67);
            numIncInt.Margin = new System.Windows.Forms.Padding(5);
            numIncInt.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numIncInt.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numIncInt.MinimumSize = new System.Drawing.Size(120, 37);
            numIncInt.Name = "numIncInt";
            numIncInt.Size = new System.Drawing.Size(120, 37);
            numIncInt.TabIndex = 21;
            numIncInt.Value = new decimal(new int[] { 0, 0, 0, 0 });
            numIncInt.ValueChanged += numIncInt_ValueChanged;
            // 
            // checkIncStr
            // 
            checkIncStr.AutoSize = true;
            checkIncStr.BackColor = System.Drawing.Color.Transparent;
            checkIncStr.Depth = 0;
            checkIncStr.Location = new System.Drawing.Point(26, 110);
            checkIncStr.Margin = new System.Windows.Forms.Padding(0);
            checkIncStr.MouseLocation = new System.Drawing.Point(-1, -1);
            checkIncStr.Name = "checkIncStr";
            checkIncStr.Ripple = true;
            checkIncStr.Size = new System.Drawing.Size(137, 30);
            checkIncStr.TabIndex = 20;
            checkIncStr.Text = "Increase STR";
            checkIncStr.UseVisualStyleBackColor = false;
            checkIncStr.CheckedChanged += settings_CheckedChanged;
            // 
            // checkIncInt
            // 
            checkIncInt.AutoSize = true;
            checkIncInt.BackColor = System.Drawing.Color.Transparent;
            checkIncInt.Depth = 0;
            checkIncInt.Location = new System.Drawing.Point(26, 65);
            checkIncInt.Margin = new System.Windows.Forms.Padding(0);
            checkIncInt.MouseLocation = new System.Drawing.Point(-1, -1);
            checkIncInt.Name = "checkIncInt";
            checkIncInt.Ripple = true;
            checkIncInt.Size = new System.Drawing.Size(134, 30);
            checkIncInt.TabIndex = 19;
            checkIncInt.Text = "Increase INT";
            checkIncInt.UseVisualStyleBackColor = false;
            checkIncInt.CheckedChanged += settings_CheckedChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(groupStatPoints);
            Controls.Add(groupBackTown);
            Controls.Add(label22);
            Controls.Add(groupBadStatus);
            Controls.Add(groupHPMP);
            Controls.Add(groupPet);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "Main";
            Size = new System.Drawing.Size(1244, 745);
            Load += Main_Load;
            groupBackTown.ResumeLayout(false);
            groupBackTown.PerformLayout();
            groupBadStatus.ResumeLayout(false);
            groupBadStatus.PerformLayout();
            groupHPMP.ResumeLayout(false);
            groupHPMP.PerformLayout();
            groupPet.ResumeLayout(false);
            groupPet.PerformLayout();
            groupStatPoints.ResumeLayout(false);
            groupStatPoints.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SDUI.Controls.GroupBox groupPet;
        private SDUI.Controls.CheckBox checkUseUniversalPills;
        private SDUI.Controls.GroupBox groupHPMP;
        private SDUI.Controls.CheckBox checkUseHPPotionsPlayer;
        private SDUI.Controls.CheckBox checkUseVigorMP;
        private SDUI.Controls.CheckBox checkUseMPPotionsPlayer;
        private SDUI.Controls.CheckBox checkUseVigorHP;
        private SDUI.Controls.GroupBox groupBadStatus;
        private SDUI.Controls.CheckBox checkUseSkillHP;
        private SDUI.Controls.CheckBox checkUseSkillMP;
        private SDUI.Controls.Label label11;
        private SDUI.Controls.NumUpDown numPlayerSkillMPMin;
        private SDUI.Controls.Label label12;
        private SDUI.Controls.Label label9;
        private SDUI.Controls.NumUpDown numPlayerSkillHPMin;
        private SDUI.Controls.Label label10;
        private SDUI.Controls.Label label7;
        private SDUI.Controls.NumUpDown numPlayerMPVigorPotionMin;
        private SDUI.Controls.Label label8;
        private SDUI.Controls.Label label5;
        private SDUI.Controls.NumUpDown numPlayerHPVigorPotionMin;
        private SDUI.Controls.Label label6;
        private SDUI.Controls.Label label3;
        private SDUI.Controls.NumUpDown numPlayerMPPotionMin;
        private SDUI.Controls.Label label4;
        private SDUI.Controls.Label label2;
        private SDUI.Controls.NumUpDown numPlayerHPPotionMin;
        private SDUI.Controls.Label label1;
        private SDUI.Controls.CheckBox checkUseBadStatusSkill;
        private SDUI.Controls.ComboBox comboSkillPlayerMP;
        private SDUI.Controls.ComboBox comboSkillPlayerHP;
        private SDUI.Controls.ComboBox comboSkillBadStatus;
        private SDUI.Controls.Label label13;
        private SDUI.Controls.NumUpDown numPetMinHGP;
        private SDUI.Controls.Label label14;
        private SDUI.Controls.Label label15;
        private SDUI.Controls.NumUpDown numPetMinHP;
        private SDUI.Controls.Label label16;
        private SDUI.Controls.CheckBox checkUsePetHP;
        private SDUI.Controls.CheckBox checkUseHGP;
        private SDUI.Controls.Label label18;
        private SDUI.Controls.CheckBox checkUseAbnormalStatePotion;
        private SDUI.Controls.CheckBox checkReviveAttackPet;
        private SDUI.Controls.Label label19;
        private SDUI.Controls.NumUpDown numMountMinHP;
        private SDUI.Controls.Label label20;
        private SDUI.Controls.CheckBox checkUseMountHP;
        private SDUI.Controls.Label label22;
        private SDUI.Controls.CheckBox checkAutoSummonAttackPet;
        private SDUI.Controls.GroupBox groupBackTown;
        private SDUI.Controls.Label label21;
        private SDUI.Controls.NumUpDown numDeadTimeout;
        private SDUI.Controls.CheckBox checkLevelUp;
        private SDUI.Controls.CheckBox checkFullPetInventory;
        private SDUI.Controls.CheckBox checkNoMPPotions;
        private SDUI.Controls.CheckBox checkNoHPPotions;
        private SDUI.Controls.CheckBox checkDurability;
        private SDUI.Controls.CheckBox checkDead;
        private SDUI.Controls.CheckBox checkInventory;
        private SDUI.Controls.CheckBox checkNoArrows;
        private SDUI.Controls.GroupBox groupStatPoints;
        private SDUI.Controls.NumUpDown numIncStr;
        private SDUI.Controls.NumUpDown numIncInt;
        private SDUI.Controls.CheckBox checkIncStr;
        private SDUI.Controls.CheckBox checkIncInt;
        private SDUI.Controls.CheckBox checkIncBotStopped;
        private SDUI.Controls.Button buttonRun;
        private SDUI.Controls.CheckBox checkStopBotOnReturnToTown;
        private SDUI.Controls.Label label17;
        private SDUI.Controls.NumUpDown numShardFatigueMinToDC;
        private SDUI.Controls.NumUpDown numMPPotionsLeft;
        private SDUI.Controls.NumUpDown numHPPotionsLeft;
        private SDUI.Controls.CheckBox checkShardFatigue;
        private System.Windows.Forms.ToolTip toolTip1;
        private SDUI.Controls.CheckBox checkBox2;
    }
}
