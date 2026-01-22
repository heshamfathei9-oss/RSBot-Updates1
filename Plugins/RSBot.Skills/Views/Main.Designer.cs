namespace RSBot.Skills.Views
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new SDUI.Controls.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBoxAttackingSkills = new SDUI.Controls.GroupBox();
            checkUseDefaultAttack = new SDUI.Controls.CheckBox();
            checkUseSkillsInOrder = new SDUI.Controls.CheckBox();
            checkBoxNoAttack = new SDUI.Controls.CheckBox();
            listAttackingSkills = new SDUI.Controls.ListView();
            columnName = new System.Windows.Forms.ColumnHeader();
            columnLevel = new System.Windows.Forms.ColumnHeader();
            label2 = new SDUI.Controls.Label();
            comboMonsterType = new SDUI.Controls.ComboBox();
            btnMoveAttackSkillDown = new SDUI.Controls.Button();
            btnMoveAttackSkillUp = new SDUI.Controls.Button();
            btnRemoveAttackSkill = new SDUI.Controls.Button();
            groupBox2 = new SDUI.Controls.GroupBox();
            button1 = new SDUI.Controls.Button();
            button2 = new SDUI.Controls.Button();
            button3 = new SDUI.Controls.Button();
            listBuffs = new SDUI.Controls.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            comboImbue = new SDUI.Controls.ComboBox();
            label1 = new SDUI.Controls.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            groupAdvancedSetup = new SDUI.Controls.GroupBox();
            comboTeleportSkill = new SDUI.Controls.ComboBox();
            checkUseTeleportSkill = new SDUI.Controls.CheckBox();
            checkWarlockMode = new SDUI.Controls.CheckBox();
            grpMasteryUpdate = new SDUI.Controls.GroupBox();
            checkLearnMasteryBotStopped = new SDUI.Controls.CheckBox();
            label4 = new SDUI.Controls.Label();
            numMasteryGap = new SDUI.Controls.NumUpDown();
            comboLearnMastery = new SDUI.Controls.ComboBox();
            checkLearnMastery = new SDUI.Controls.CheckBox();
            groupBoxAutomatedResurrection = new SDUI.Controls.GroupBox();
            comboResurrectionSkill = new SDUI.Controls.ComboBox();
            checkAcceptResurrection = new SDUI.Controls.CheckBox();
            label3 = new SDUI.Controls.Label();
            checkResurrectParty = new SDUI.Controls.CheckBox();
            groupBoxAdvancedBuff = new SDUI.Controls.GroupBox();
            checkCastBuffsBetweenAttacks = new SDUI.Controls.CheckBox();
            checkCastBuffsDuringWalkBack = new SDUI.Controls.CheckBox();
            checkCastBuffsInTowns = new SDUI.Controls.CheckBox();
            tabControl2 = new SDUI.Controls.TabControl();
            tabPage3 = new System.Windows.Forms.TabPage();
            listSkills = new SDUI.Controls.ListView();
            colName = new System.Windows.Forms.ColumnHeader();
            colLevel = new System.Windows.Forms.ColumnHeader();
            skillContextMenu = new SDUI.Controls.ContextMenuStrip();
            skillContextMenuAddAttackSkill = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            skillContextMenuAddBuffSkill = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            useToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            useToPartyMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panelPlayerSkills = new SDUI.Controls.Panel();
            panel2 = new SDUI.Controls.Panel();
            checkHideLowerLevelSkills = new SDUI.Controls.CheckBox();
            checkShowAttacks = new SDUI.Controls.CheckBox();
            checkShowBuffs = new SDUI.Controls.CheckBox();
            tabPage4 = new System.Windows.Forms.TabPage();
            listActiveBuffs = new SDUI.Controls.ListView();
            colActiveName = new System.Windows.Forms.ColumnHeader();
            colActiveLevel = new System.Windows.Forms.ColumnHeader();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBoxAttackingSkills.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            groupAdvancedSetup.SuspendLayout();
            grpMasteryUpdate.SuspendLayout();
            groupBoxAutomatedResurrection.SuspendLayout();
            groupBoxAdvancedBuff.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            skillContextMenu.SuspendLayout();
            panelPlayerSkills.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            tabControl1.ItemSize = new System.Drawing.Size(80, 24);
            tabControl1.Location = new System.Drawing.Point(617, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.Radius = new System.Windows.Forms.Padding(4);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(630, 749);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.White;
            tabPage1.Controls.Add(groupBoxAttackingSkills);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new System.Drawing.Point(4, 28);
            tabPage1.Margin = new System.Windows.Forms.Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4);
            tabPage1.Size = new System.Drawing.Size(622, 717);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General setup";
            // 
            // groupBoxAttackingSkills
            // 
            groupBoxAttackingSkills.BackColor = System.Drawing.Color.Transparent;
            groupBoxAttackingSkills.Controls.Add(checkUseDefaultAttack);
            groupBoxAttackingSkills.Controls.Add(checkUseSkillsInOrder);
            groupBoxAttackingSkills.Controls.Add(checkBoxNoAttack);
            groupBoxAttackingSkills.Controls.Add(listAttackingSkills);
            groupBoxAttackingSkills.Controls.Add(label2);
            groupBoxAttackingSkills.Controls.Add(comboMonsterType);
            groupBoxAttackingSkills.Controls.Add(btnMoveAttackSkillDown);
            groupBoxAttackingSkills.Controls.Add(btnMoveAttackSkillUp);
            groupBoxAttackingSkills.Controls.Add(btnRemoveAttackSkill);
            groupBoxAttackingSkills.Location = new System.Drawing.Point(12, 8);
            groupBoxAttackingSkills.Margin = new System.Windows.Forms.Padding(4);
            groupBoxAttackingSkills.Name = "groupBoxAttackingSkills";
            groupBoxAttackingSkills.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            groupBoxAttackingSkills.Radius = 10;
            groupBoxAttackingSkills.ShadowDepth = 4;
            groupBoxAttackingSkills.Size = new System.Drawing.Size(536, 344);
            groupBoxAttackingSkills.TabIndex = 1;
            groupBoxAttackingSkills.TabStop = false;
            groupBoxAttackingSkills.Text = "Attacking skills";
            // 
            // checkUseDefaultAttack
            // 
            checkUseDefaultAttack.AutoSize = true;
            checkUseDefaultAttack.BackColor = System.Drawing.Color.Transparent;
            checkUseDefaultAttack.Checked = true;
            checkUseDefaultAttack.CheckState = System.Windows.Forms.CheckState.Checked;
            checkUseDefaultAttack.Depth = 0;
            checkUseDefaultAttack.Location = new System.Drawing.Point(179, 310);
            checkUseDefaultAttack.Margin = new System.Windows.Forms.Padding(0);
            checkUseDefaultAttack.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseDefaultAttack.Name = "checkUseDefaultAttack";
            checkUseDefaultAttack.Ripple = true;
            checkUseDefaultAttack.Size = new System.Drawing.Size(345, 30);
            checkUseDefaultAttack.TabIndex = 11;
            checkUseDefaultAttack.Text = "Use normal attack if no skill is available";
            checkUseDefaultAttack.UseVisualStyleBackColor = false;
            // 
            // checkUseSkillsInOrder
            // 
            checkUseSkillsInOrder.BackColor = System.Drawing.Color.Transparent;
            checkUseSkillsInOrder.Depth = 0;
            checkUseSkillsInOrder.Location = new System.Drawing.Point(346, 291);
            checkUseSkillsInOrder.Margin = new System.Windows.Forms.Padding(0);
            checkUseSkillsInOrder.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseSkillsInOrder.Name = "checkUseSkillsInOrder";
            checkUseSkillsInOrder.Ripple = true;
            checkUseSkillsInOrder.Size = new System.Drawing.Size(129, 22);
            checkUseSkillsInOrder.TabIndex = 10;
            checkUseSkillsInOrder.Text = "Use in order";
            checkUseSkillsInOrder.UseVisualStyleBackColor = false;
            checkUseSkillsInOrder.CheckedChanged += settings_CheckedChanged;
            // 
            // checkBoxNoAttack
            // 
            checkBoxNoAttack.BackColor = System.Drawing.Color.Transparent;
            checkBoxNoAttack.Depth = 0;
            checkBoxNoAttack.Location = new System.Drawing.Point(346, 259);
            checkBoxNoAttack.Margin = new System.Windows.Forms.Padding(0);
            checkBoxNoAttack.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxNoAttack.Name = "checkBoxNoAttack";
            checkBoxNoAttack.Ripple = true;
            checkBoxNoAttack.Size = new System.Drawing.Size(114, 22);
            checkBoxNoAttack.TabIndex = 9;
            checkBoxNoAttack.Text = "No Attack";
            checkBoxNoAttack.UseVisualStyleBackColor = false;
            checkBoxNoAttack.CheckedChanged += settings_CheckedChanged;
            // 
            // listAttackingSkills
            // 
            listAttackingSkills.BackColor = System.Drawing.Color.White;
            listAttackingSkills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnName, columnLevel });
            listAttackingSkills.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            listAttackingSkills.FullRowSelect = true;
            listAttackingSkills.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listAttackingSkills.Location = new System.Drawing.Point(9, 38);
            listAttackingSkills.Margin = new System.Windows.Forms.Padding(4);
            listAttackingSkills.Name = "listAttackingSkills";
            listAttackingSkills.Size = new System.Drawing.Size(470, 217);
            listAttackingSkills.TabIndex = 8;
            listAttackingSkills.UseCompatibleStateImageBehavior = false;
            listAttackingSkills.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.Width = 248;
            // 
            // columnLevel
            // 
            columnLevel.Text = "Level";
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
            label2.Location = new System.Drawing.Point(14, 274);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 25);
            label2.TabIndex = 7;
            label2.Text = "Type:";
            // 
            // comboMonsterType
            // 
            comboMonsterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            comboMonsterType.DropDownHeight = 100;
            comboMonsterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboMonsterType.FormattingEnabled = true;
            comboMonsterType.IntegralHeight = false;
            comboMonsterType.ItemHeight = 17;
            comboMonsterType.Items.AddRange(new object[] { "General (Default)", "Champion", "Giant", "General (Party)", "Champion (Party)", "Giant (Party)", "Elite", "Strong", "Unique", "Event" });
            comboMonsterType.Location = new System.Drawing.Point(81, 270);
            comboMonsterType.Margin = new System.Windows.Forms.Padding(4);
            comboMonsterType.Name = "comboMonsterType";
            comboMonsterType.Radius = 5;
            comboMonsterType.ShadowDepth = 4F;
            comboMonsterType.Size = new System.Drawing.Size(254, 23);
            comboMonsterType.TabIndex = 2;
            comboMonsterType.SelectedIndexChanged += comboMonsterType_SelectedIndexChanged;
            // 
            // btnMoveAttackSkillDown
            // 
            btnMoveAttackSkillDown.BorderWidth = 0F;
            btnMoveAttackSkillDown.Color = System.Drawing.Color.Transparent;
            btnMoveAttackSkillDown.CustomBorderColor = System.Drawing.Color.Empty;
            btnMoveAttackSkillDown.Font = new System.Drawing.Font("Webdings", 9.75F);
            btnMoveAttackSkillDown.ForeColor = System.Drawing.Color.White;
            btnMoveAttackSkillDown.GradientAngle = 45F;
            btnMoveAttackSkillDown.GradientColor = System.Drawing.Color.Empty;
            btnMoveAttackSkillDown.Location = new System.Drawing.Point(490, 128);
            btnMoveAttackSkillDown.Margin = new System.Windows.Forms.Padding(4);
            btnMoveAttackSkillDown.Name = "btnMoveAttackSkillDown";
            btnMoveAttackSkillDown.Radius = 6;
            btnMoveAttackSkillDown.ShadowDepth = 4F;
            btnMoveAttackSkillDown.Size = new System.Drawing.Size(36, 36);
            btnMoveAttackSkillDown.TabIndex = 1;
            btnMoveAttackSkillDown.Text = "6";
            btnMoveAttackSkillDown.UseGradient = false;
            btnMoveAttackSkillDown.UseVisualStyleBackColor = true;
            btnMoveAttackSkillDown.Click += btnMoveAttackSkillDown_Click;
            // 
            // btnMoveAttackSkillUp
            // 
            btnMoveAttackSkillUp.BorderWidth = 0F;
            btnMoveAttackSkillUp.Color = System.Drawing.Color.Transparent;
            btnMoveAttackSkillUp.CustomBorderColor = System.Drawing.Color.Empty;
            btnMoveAttackSkillUp.Font = new System.Drawing.Font("Webdings", 9.75F);
            btnMoveAttackSkillUp.ForeColor = System.Drawing.Color.White;
            btnMoveAttackSkillUp.GradientAngle = 45F;
            btnMoveAttackSkillUp.GradientColor = System.Drawing.Color.Empty;
            btnMoveAttackSkillUp.Location = new System.Drawing.Point(490, 82);
            btnMoveAttackSkillUp.Margin = new System.Windows.Forms.Padding(4);
            btnMoveAttackSkillUp.Name = "btnMoveAttackSkillUp";
            btnMoveAttackSkillUp.Radius = 6;
            btnMoveAttackSkillUp.ShadowDepth = 4F;
            btnMoveAttackSkillUp.Size = new System.Drawing.Size(36, 36);
            btnMoveAttackSkillUp.TabIndex = 1;
            btnMoveAttackSkillUp.Text = "5";
            btnMoveAttackSkillUp.UseGradient = false;
            btnMoveAttackSkillUp.UseVisualStyleBackColor = true;
            btnMoveAttackSkillUp.Click += btnMoveAttackSkillUp_Click;
            // 
            // btnRemoveAttackSkill
            // 
            btnRemoveAttackSkill.BorderWidth = 0F;
            btnRemoveAttackSkill.Color = System.Drawing.Color.Transparent;
            btnRemoveAttackSkill.CustomBorderColor = System.Drawing.Color.Empty;
            btnRemoveAttackSkill.Font = new System.Drawing.Font("Webdings", 9.75F);
            btnRemoveAttackSkill.ForeColor = System.Drawing.Color.White;
            btnRemoveAttackSkill.GradientAngle = 45F;
            btnRemoveAttackSkill.GradientColor = System.Drawing.Color.Empty;
            btnRemoveAttackSkill.Location = new System.Drawing.Point(490, 38);
            btnRemoveAttackSkill.Margin = new System.Windows.Forms.Padding(4);
            btnRemoveAttackSkill.Name = "btnRemoveAttackSkill";
            btnRemoveAttackSkill.Radius = 6;
            btnRemoveAttackSkill.ShadowDepth = 4F;
            btnRemoveAttackSkill.Size = new System.Drawing.Size(36, 33);
            btnRemoveAttackSkill.TabIndex = 1;
            btnRemoveAttackSkill.Text = "r";
            btnRemoveAttackSkill.UseGradient = false;
            btnRemoveAttackSkill.UseVisualStyleBackColor = true;
            btnRemoveAttackSkill.Click += btnRemoveAttackSkill_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(listBuffs);
            groupBox2.Controls.Add(comboImbue);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new System.Drawing.Point(16, 360);
            groupBox2.Margin = new System.Windows.Forms.Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            groupBox2.Radius = 10;
            groupBox2.ShadowDepth = 4;
            groupBox2.Size = new System.Drawing.Size(536, 297);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buffing skills";
            // 
            // button1
            // 
            button1.BorderWidth = 0F;
            button1.Color = System.Drawing.Color.Transparent;
            button1.CustomBorderColor = System.Drawing.Color.Empty;
            button1.Font = new System.Drawing.Font("Webdings", 9.75F);
            button1.ForeColor = System.Drawing.Color.White;
            button1.GradientAngle = 45F;
            button1.GradientColor = System.Drawing.Color.Empty;
            button1.Location = new System.Drawing.Point(490, 135);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Radius = 6;
            button1.ShadowDepth = 4F;
            button1.Size = new System.Drawing.Size(36, 36);
            button1.TabIndex = 9;
            button1.Text = "6";
            button1.UseGradient = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BorderWidth = 0F;
            button2.Color = System.Drawing.Color.Transparent;
            button2.CustomBorderColor = System.Drawing.Color.Empty;
            button2.Font = new System.Drawing.Font("Webdings", 9.75F);
            button2.ForeColor = System.Drawing.Color.White;
            button2.GradientAngle = 45F;
            button2.GradientColor = System.Drawing.Color.Empty;
            button2.Location = new System.Drawing.Point(490, 89);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Radius = 6;
            button2.ShadowDepth = 4F;
            button2.Size = new System.Drawing.Size(36, 36);
            button2.TabIndex = 10;
            button2.Text = "5";
            button2.UseGradient = false;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BorderWidth = 0F;
            button3.Color = System.Drawing.Color.Transparent;
            button3.CustomBorderColor = System.Drawing.Color.Empty;
            button3.Font = new System.Drawing.Font("Webdings", 9.75F);
            button3.ForeColor = System.Drawing.Color.White;
            button3.GradientAngle = 45F;
            button3.GradientColor = System.Drawing.Color.Empty;
            button3.Location = new System.Drawing.Point(490, 45);
            button3.Margin = new System.Windows.Forms.Padding(4);
            button3.Name = "button3";
            button3.Radius = 6;
            button3.ShadowDepth = 4F;
            button3.Size = new System.Drawing.Size(36, 33);
            button3.TabIndex = 11;
            button3.Text = "r";
            button3.UseGradient = false;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBuffs
            // 
            listBuffs.BackColor = System.Drawing.Color.White;
            listBuffs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2 });
            listBuffs.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            listBuffs.FullRowSelect = true;
            listBuffs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listBuffs.Location = new System.Drawing.Point(9, 40);
            listBuffs.Margin = new System.Windows.Forms.Padding(4);
            listBuffs.Name = "listBuffs";
            listBuffs.Size = new System.Drawing.Size(470, 205);
            listBuffs.TabIndex = 8;
            listBuffs.UseCompatibleStateImageBehavior = false;
            listBuffs.View = System.Windows.Forms.View.Details;
            listBuffs.SelectedIndexChanged += listBuffs_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 248;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Level";
            // 
            // comboImbue
            // 
            comboImbue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            comboImbue.DropDownHeight = 100;
            comboImbue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboImbue.FormattingEnabled = true;
            comboImbue.IntegralHeight = false;
            comboImbue.ItemHeight = 17;
            comboImbue.Location = new System.Drawing.Point(81, 256);
            comboImbue.Margin = new System.Windows.Forms.Padding(4);
            comboImbue.Name = "comboImbue";
            comboImbue.Radius = 5;
            comboImbue.ShadowDepth = 4F;
            comboImbue.Size = new System.Drawing.Size(398, 23);
            comboImbue.TabIndex = 7;
            comboImbue.SelectedIndexChanged += comboImbue_SelectedIndexChanged;
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
            label1.Location = new System.Drawing.Point(14, 261);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 25);
            label1.TabIndex = 6;
            label1.Text = "Imbue:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.White;
            tabPage2.Controls.Add(groupAdvancedSetup);
            tabPage2.Controls.Add(grpMasteryUpdate);
            tabPage2.Controls.Add(groupBoxAutomatedResurrection);
            tabPage2.Controls.Add(groupBoxAdvancedBuff);
            tabPage2.Location = new System.Drawing.Point(4, 28);
            tabPage2.Margin = new System.Windows.Forms.Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(4);
            tabPage2.Size = new System.Drawing.Size(622, 717);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Advanced setup";
            // 
            // groupAdvancedSetup
            // 
            groupAdvancedSetup.BackColor = System.Drawing.Color.Transparent;
            groupAdvancedSetup.Controls.Add(comboTeleportSkill);
            groupAdvancedSetup.Controls.Add(checkUseTeleportSkill);
            groupAdvancedSetup.Controls.Add(checkWarlockMode);
            groupAdvancedSetup.Location = new System.Drawing.Point(12, 470);
            groupAdvancedSetup.Margin = new System.Windows.Forms.Padding(4);
            groupAdvancedSetup.Name = "groupAdvancedSetup";
            groupAdvancedSetup.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            groupAdvancedSetup.Radius = 10;
            groupAdvancedSetup.ShadowDepth = 4;
            groupAdvancedSetup.Size = new System.Drawing.Size(550, 184);
            groupAdvancedSetup.TabIndex = 14;
            groupAdvancedSetup.TabStop = false;
            groupAdvancedSetup.Text = "Advanced setup";
            // 
            // comboTeleportSkill
            // 
            comboTeleportSkill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            comboTeleportSkill.DropDownHeight = 100;
            comboTeleportSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboTeleportSkill.FormattingEnabled = true;
            comboTeleportSkill.IntegralHeight = false;
            comboTeleportSkill.ItemHeight = 16;
            comboTeleportSkill.Location = new System.Drawing.Point(212, 102);
            comboTeleportSkill.Margin = new System.Windows.Forms.Padding(4);
            comboTeleportSkill.Name = "comboTeleportSkill";
            comboTeleportSkill.Radius = 5;
            comboTeleportSkill.ShadowDepth = 4F;
            comboTeleportSkill.Size = new System.Drawing.Size(310, 22);
            comboTeleportSkill.TabIndex = 9;
            comboTeleportSkill.SelectedIndexChanged += comboTeleportSkill_SelectedIndexChanged;
            // 
            // checkUseTeleportSkill
            // 
            checkUseTeleportSkill.AutoSize = true;
            checkUseTeleportSkill.BackColor = System.Drawing.Color.Transparent;
            checkUseTeleportSkill.Depth = 0;
            checkUseTeleportSkill.Location = new System.Drawing.Point(22, 93);
            checkUseTeleportSkill.Margin = new System.Windows.Forms.Padding(0);
            checkUseTeleportSkill.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseTeleportSkill.Name = "checkUseTeleportSkill";
            checkUseTeleportSkill.Ripple = true;
            checkUseTeleportSkill.Size = new System.Drawing.Size(172, 30);
            checkUseTeleportSkill.TabIndex = 2;
            checkUseTeleportSkill.Text = "Use teleport skill:";
            checkUseTeleportSkill.UseVisualStyleBackColor = false;
            checkUseTeleportSkill.CheckedChanged += settings_CheckedChanged;
            // 
            // checkWarlockMode
            // 
            checkWarlockMode.AutoSize = true;
            checkWarlockMode.BackColor = System.Drawing.Color.Transparent;
            checkWarlockMode.Depth = 0;
            checkWarlockMode.Location = new System.Drawing.Point(22, 46);
            checkWarlockMode.Margin = new System.Windows.Forms.Padding(0);
            checkWarlockMode.MouseLocation = new System.Drawing.Point(-1, -1);
            checkWarlockMode.Name = "checkWarlockMode";
            checkWarlockMode.Ripple = true;
            checkWarlockMode.Size = new System.Drawing.Size(251, 30);
            checkWarlockMode.TabIndex = 0;
            checkWarlockMode.Text = "Change target after 2 DoTs";
            checkWarlockMode.UseVisualStyleBackColor = false;
            checkWarlockMode.CheckedChanged += settings_CheckedChanged;
            // 
            // grpMasteryUpdate
            // 
            grpMasteryUpdate.BackColor = System.Drawing.Color.Transparent;
            grpMasteryUpdate.Controls.Add(checkLearnMasteryBotStopped);
            grpMasteryUpdate.Controls.Add(label4);
            grpMasteryUpdate.Controls.Add(numMasteryGap);
            grpMasteryUpdate.Controls.Add(comboLearnMastery);
            grpMasteryUpdate.Controls.Add(checkLearnMastery);
            grpMasteryUpdate.Location = new System.Drawing.Point(12, 327);
            grpMasteryUpdate.Margin = new System.Windows.Forms.Padding(4);
            grpMasteryUpdate.Name = "grpMasteryUpdate";
            grpMasteryUpdate.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            grpMasteryUpdate.Radius = 10;
            grpMasteryUpdate.ShadowDepth = 4;
            grpMasteryUpdate.Size = new System.Drawing.Size(550, 134);
            grpMasteryUpdate.TabIndex = 13;
            grpMasteryUpdate.TabStop = false;
            grpMasteryUpdate.Text = "Mastery update";
            // 
            // checkLearnMasteryBotStopped
            // 
            checkLearnMasteryBotStopped.AutoSize = true;
            checkLearnMasteryBotStopped.BackColor = System.Drawing.Color.Transparent;
            checkLearnMasteryBotStopped.Depth = 0;
            checkLearnMasteryBotStopped.Location = new System.Drawing.Point(22, 84);
            checkLearnMasteryBotStopped.Margin = new System.Windows.Forms.Padding(0);
            checkLearnMasteryBotStopped.MouseLocation = new System.Drawing.Point(-1, -1);
            checkLearnMasteryBotStopped.Name = "checkLearnMasteryBotStopped";
            checkLearnMasteryBotStopped.Ripple = true;
            checkLearnMasteryBotStopped.Size = new System.Drawing.Size(281, 30);
            checkLearnMasteryBotStopped.TabIndex = 25;
            checkLearnMasteryBotStopped.Text = "Increase even if bot is stopped";
            checkLearnMasteryBotStopped.UseVisualStyleBackColor = false;
            checkLearnMasteryBotStopped.CheckedChanged += settings_CheckedChanged;
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
            label4.Location = new System.Drawing.Point(364, 54);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 25);
            label4.TabIndex = 3;
            label4.Text = "Gap";
            // 
            // numMasteryGap
            // 
            numMasteryGap.BackColor = System.Drawing.Color.Transparent;
            numMasteryGap.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            numMasteryGap.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numMasteryGap.Location = new System.Drawing.Point(416, 48);
            numMasteryGap.Margin = new System.Windows.Forms.Padding(4);
            numMasteryGap.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numMasteryGap.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numMasteryGap.MinimumSize = new System.Drawing.Size(120, 38);
            numMasteryGap.Name = "numMasteryGap";
            numMasteryGap.Size = new System.Drawing.Size(120, 38);
            numMasteryGap.TabIndex = 2;
            numMasteryGap.Value = new decimal(new int[] { 0, 0, 0, 0 });
            numMasteryGap.ValueChanged += numSettings_ValueChanged;
            // 
            // comboLearnMastery
            // 
            comboLearnMastery.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            comboLearnMastery.DropDownHeight = 100;
            comboLearnMastery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboLearnMastery.FormattingEnabled = true;
            comboLearnMastery.IntegralHeight = false;
            comboLearnMastery.ItemHeight = 17;
            comboLearnMastery.Location = new System.Drawing.Point(136, 50);
            comboLearnMastery.Margin = new System.Windows.Forms.Padding(4);
            comboLearnMastery.Name = "comboLearnMastery";
            comboLearnMastery.Radius = 5;
            comboLearnMastery.ShadowDepth = 4F;
            comboLearnMastery.Size = new System.Drawing.Size(210, 23);
            comboLearnMastery.TabIndex = 1;
            comboLearnMastery.SelectedIndexChanged += comboLearnMastery_SelectedIndexChanged;
            // 
            // checkLearnMastery
            // 
            checkLearnMastery.AutoSize = true;
            checkLearnMastery.BackColor = System.Drawing.Color.Transparent;
            checkLearnMastery.Depth = 0;
            checkLearnMastery.Location = new System.Drawing.Point(22, 44);
            checkLearnMastery.Margin = new System.Windows.Forms.Padding(0);
            checkLearnMastery.MouseLocation = new System.Drawing.Point(-1, -1);
            checkLearnMastery.Name = "checkLearnMastery";
            checkLearnMastery.Ripple = true;
            checkLearnMastery.Size = new System.Drawing.Size(101, 30);
            checkLearnMastery.TabIndex = 0;
            checkLearnMastery.Text = "Mastery";
            checkLearnMastery.UseVisualStyleBackColor = false;
            checkLearnMastery.CheckedChanged += settings_CheckedChanged;
            // 
            // groupBoxAutomatedResurrection
            // 
            groupBoxAutomatedResurrection.BackColor = System.Drawing.Color.Transparent;
            groupBoxAutomatedResurrection.Controls.Add(comboResurrectionSkill);
            groupBoxAutomatedResurrection.Controls.Add(checkAcceptResurrection);
            groupBoxAutomatedResurrection.Controls.Add(label3);
            groupBoxAutomatedResurrection.Controls.Add(checkResurrectParty);
            groupBoxAutomatedResurrection.Location = new System.Drawing.Point(12, 9);
            groupBoxAutomatedResurrection.Margin = new System.Windows.Forms.Padding(4);
            groupBoxAutomatedResurrection.Name = "groupBoxAutomatedResurrection";
            groupBoxAutomatedResurrection.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            groupBoxAutomatedResurrection.Radius = 10;
            groupBoxAutomatedResurrection.ShadowDepth = 4;
            groupBoxAutomatedResurrection.Size = new System.Drawing.Size(550, 178);
            groupBoxAutomatedResurrection.TabIndex = 11;
            groupBoxAutomatedResurrection.TabStop = false;
            groupBoxAutomatedResurrection.Text = "Automated resurrection";
            // 
            // comboResurrectionSkill
            // 
            comboResurrectionSkill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            comboResurrectionSkill.DropDownHeight = 100;
            comboResurrectionSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboResurrectionSkill.FormattingEnabled = true;
            comboResurrectionSkill.IntegralHeight = false;
            comboResurrectionSkill.ItemHeight = 17;
            comboResurrectionSkill.Location = new System.Drawing.Point(129, 48);
            comboResurrectionSkill.Margin = new System.Windows.Forms.Padding(4);
            comboResurrectionSkill.Name = "comboResurrectionSkill";
            comboResurrectionSkill.Radius = 5;
            comboResurrectionSkill.ShadowDepth = 4F;
            comboResurrectionSkill.Size = new System.Drawing.Size(380, 23);
            comboResurrectionSkill.TabIndex = 8;
            comboResurrectionSkill.SelectedIndexChanged += comboResurrectionSkill_SelectedIndexChanged;
            // 
            // checkAcceptResurrection
            // 
            checkAcceptResurrection.AutoSize = true;
            checkAcceptResurrection.BackColor = System.Drawing.Color.Transparent;
            checkAcceptResurrection.Checked = true;
            checkAcceptResurrection.CheckState = System.Windows.Forms.CheckState.Checked;
            checkAcceptResurrection.Depth = 0;
            checkAcceptResurrection.Location = new System.Drawing.Point(129, 126);
            checkAcceptResurrection.Margin = new System.Windows.Forms.Padding(0);
            checkAcceptResurrection.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAcceptResurrection.Name = "checkAcceptResurrection";
            checkAcceptResurrection.Ripple = true;
            checkAcceptResurrection.Size = new System.Drawing.Size(231, 30);
            checkAcceptResurrection.TabIndex = 9;
            checkAcceptResurrection.Text = "Auto accept resurrection";
            checkAcceptResurrection.UseVisualStyleBackColor = false;
            checkAcceptResurrection.CheckedChanged += settings_CheckedChanged;
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
            label3.Location = new System.Drawing.Point(39, 52);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 25);
            label3.TabIndex = 0;
            label3.Text = "Res. skill:";
            // 
            // checkResurrectParty
            // 
            checkResurrectParty.AutoSize = true;
            checkResurrectParty.BackColor = System.Drawing.Color.Transparent;
            checkResurrectParty.Depth = 0;
            checkResurrectParty.Location = new System.Drawing.Point(129, 88);
            checkResurrectParty.Margin = new System.Windows.Forms.Padding(0);
            checkResurrectParty.MouseLocation = new System.Drawing.Point(-1, -1);
            checkResurrectParty.Name = "checkResurrectParty";
            checkResurrectParty.Ripple = true;
            checkResurrectParty.Size = new System.Drawing.Size(276, 30);
            checkResurrectParty.TabIndex = 6;
            checkResurrectParty.Text = "Auto resurrect party members";
            checkResurrectParty.UseVisualStyleBackColor = false;
            checkResurrectParty.CheckedChanged += settings_CheckedChanged;
            // 
            // groupBoxAdvancedBuff
            // 
            groupBoxAdvancedBuff.BackColor = System.Drawing.Color.Transparent;
            groupBoxAdvancedBuff.Controls.Add(checkCastBuffsBetweenAttacks);
            groupBoxAdvancedBuff.Controls.Add(checkCastBuffsDuringWalkBack);
            groupBoxAdvancedBuff.Controls.Add(checkCastBuffsInTowns);
            groupBoxAdvancedBuff.Location = new System.Drawing.Point(12, 177);
            groupBoxAdvancedBuff.Margin = new System.Windows.Forms.Padding(4);
            groupBoxAdvancedBuff.Name = "groupBoxAdvancedBuff";
            groupBoxAdvancedBuff.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            groupBoxAdvancedBuff.Radius = 10;
            groupBoxAdvancedBuff.ShadowDepth = 4;
            groupBoxAdvancedBuff.Size = new System.Drawing.Size(550, 136);
            groupBoxAdvancedBuff.TabIndex = 12;
            groupBoxAdvancedBuff.TabStop = false;
            groupBoxAdvancedBuff.Text = "Advanced buff configuration";
            // 
            // checkCastBuffsBetweenAttacks
            // 
            checkCastBuffsBetweenAttacks.AutoSize = true;
            checkCastBuffsBetweenAttacks.BackColor = System.Drawing.Color.Transparent;
            checkCastBuffsBetweenAttacks.Depth = 0;
            checkCastBuffsBetweenAttacks.Location = new System.Drawing.Point(22, 104);
            checkCastBuffsBetweenAttacks.Margin = new System.Windows.Forms.Padding(0);
            checkCastBuffsBetweenAttacks.MouseLocation = new System.Drawing.Point(-1, -1);
            checkCastBuffsBetweenAttacks.Name = "checkCastBuffsBetweenAttacks";
            checkCastBuffsBetweenAttacks.Ripple = true;
            checkCastBuffsBetweenAttacks.Size = new System.Drawing.Size(284, 30);
            checkCastBuffsBetweenAttacks.TabIndex = 11;
            checkCastBuffsBetweenAttacks.Text = "Cast buffs between attack skills";
            checkCastBuffsBetweenAttacks.UseVisualStyleBackColor = false;
            checkCastBuffsBetweenAttacks.CheckedChanged += settings_CheckedChanged;
            // 
            // checkCastBuffsDuringWalkBack
            // 
            checkCastBuffsDuringWalkBack.AutoSize = true;
            checkCastBuffsDuringWalkBack.BackColor = System.Drawing.Color.Transparent;
            checkCastBuffsDuringWalkBack.Checked = true;
            checkCastBuffsDuringWalkBack.CheckState = System.Windows.Forms.CheckState.Checked;
            checkCastBuffsDuringWalkBack.Depth = 0;
            checkCastBuffsDuringWalkBack.Location = new System.Drawing.Point(22, 72);
            checkCastBuffsDuringWalkBack.Margin = new System.Windows.Forms.Padding(0);
            checkCastBuffsDuringWalkBack.MouseLocation = new System.Drawing.Point(-1, -1);
            checkCastBuffsDuringWalkBack.Name = "checkCastBuffsDuringWalkBack";
            checkCastBuffsDuringWalkBack.Ripple = true;
            checkCastBuffsDuringWalkBack.Size = new System.Drawing.Size(247, 30);
            checkCastBuffsDuringWalkBack.TabIndex = 10;
            checkCastBuffsDuringWalkBack.Text = "Cast buffs while walk-back";
            checkCastBuffsDuringWalkBack.UseVisualStyleBackColor = false;
            checkCastBuffsDuringWalkBack.CheckedChanged += settings_CheckedChanged;
            // 
            // checkCastBuffsInTowns
            // 
            checkCastBuffsInTowns.AutoSize = true;
            checkCastBuffsInTowns.BackColor = System.Drawing.Color.Transparent;
            checkCastBuffsInTowns.Depth = 0;
            checkCastBuffsInTowns.Location = new System.Drawing.Point(22, 39);
            checkCastBuffsInTowns.Margin = new System.Windows.Forms.Padding(0);
            checkCastBuffsInTowns.MouseLocation = new System.Drawing.Point(-1, -1);
            checkCastBuffsInTowns.Name = "checkCastBuffsInTowns";
            checkCastBuffsInTowns.Ripple = true;
            checkCastBuffsInTowns.Size = new System.Drawing.Size(190, 30);
            checkCastBuffsInTowns.TabIndex = 10;
            checkCastBuffsInTowns.Text = "Cast buffs in towns";
            checkCastBuffsInTowns.UseVisualStyleBackColor = false;
            checkCastBuffsInTowns.CheckedChanged += settings_CheckedChanged;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl2.ItemSize = new System.Drawing.Size(80, 24);
            tabControl2.Location = new System.Drawing.Point(0, 0);
            tabControl2.Margin = new System.Windows.Forms.Padding(4);
            tabControl2.Name = "tabControl2";
            tabControl2.Radius = new System.Windows.Forms.Padding(4);
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(617, 749);
            tabControl2.TabIndex = 6;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.Color.White;
            tabPage3.Controls.Add(listSkills);
            tabPage3.Controls.Add(panelPlayerSkills);
            tabPage3.Location = new System.Drawing.Point(4, 28);
            tabPage3.Margin = new System.Windows.Forms.Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(4);
            tabPage3.Size = new System.Drawing.Size(609, 717);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Player skills";
            tabPage3.Click += tabPage3_Click;
            // 
            // listSkills
            // 
            listSkills.BackColor = System.Drawing.Color.White;
            listSkills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listSkills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colName, colLevel });
            listSkills.ContextMenuStrip = skillContextMenu;
            listSkills.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            listSkills.FullRowSelect = true;
            listSkills.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listSkills.Location = new System.Drawing.Point(4, -28);
            listSkills.Margin = new System.Windows.Forms.Padding(4);
            listSkills.Name = "listSkills";
            listSkills.Size = new System.Drawing.Size(367, 574);
            listSkills.TabIndex = 5;
            listSkills.UseCompatibleStateImageBehavior = false;
            listSkills.View = System.Windows.Forms.View.Details;
            listSkills.MouseDoubleClick += listSkills_MouseDoubleClick;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 226;
            // 
            // colLevel
            // 
            colLevel.Text = "";
            colLevel.Width = 69;
            // 
            // skillContextMenu
            // 
            skillContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            skillContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { skillContextMenuAddAttackSkill, toolStripSeparator1, skillContextMenuAddBuffSkill, toolStripSeparator2, useToolStripMenuItem, useToPartyMemberToolStripMenuItem });
            skillContextMenu.Name = "skillContextMenu";
            skillContextMenu.Size = new System.Drawing.Size(254, 144);
            skillContextMenu.Opening += skillContextMenu_Opening;
            // 
            // skillContextMenuAddAttackSkill
            // 
            skillContextMenuAddAttackSkill.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            skillContextMenuAddAttackSkill.Name = "skillContextMenuAddAttackSkill";
            skillContextMenuAddAttackSkill.Size = new System.Drawing.Size(253, 32);
            skillContextMenuAddAttackSkill.Text = "Add To Attacks";
            skillContextMenuAddAttackSkill.Click += menuAddAttack_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(250, 6);
            // 
            // skillContextMenuAddBuffSkill
            // 
            skillContextMenuAddBuffSkill.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            skillContextMenuAddBuffSkill.Name = "skillContextMenuAddBuffSkill";
            skillContextMenuAddBuffSkill.Size = new System.Drawing.Size(253, 32);
            skillContextMenuAddBuffSkill.Text = "Add To Buffs";
            skillContextMenuAddBuffSkill.Click += menuAddBuff_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(250, 6);
            // 
            // useToolStripMenuItem
            // 
            useToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            useToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            useToolStripMenuItem.Name = "useToolStripMenuItem";
            useToolStripMenuItem.Size = new System.Drawing.Size(253, 32);
            useToolStripMenuItem.Text = "Use";
            useToolStripMenuItem.Click += useToolStripMenuItem_Click;
            // 
            // useToPartyMemberToolStripMenuItem
            // 
            useToPartyMemberToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            useToPartyMemberToolStripMenuItem.Name = "useToPartyMemberToolStripMenuItem";
            useToPartyMemberToolStripMenuItem.Size = new System.Drawing.Size(253, 32);
            useToPartyMemberToolStripMenuItem.Text = "Use to party member";
            // 
            // panelPlayerSkills
            // 
            panelPlayerSkills.BackColor = System.Drawing.Color.Transparent;
            panelPlayerSkills.Border = new System.Windows.Forms.Padding(0, 1, 0, 0);
            panelPlayerSkills.BorderColor = System.Drawing.Color.Transparent;
            panelPlayerSkills.Controls.Add(panel2);
            panelPlayerSkills.Controls.Add(checkHideLowerLevelSkills);
            panelPlayerSkills.Controls.Add(checkShowAttacks);
            panelPlayerSkills.Controls.Add(checkShowBuffs);
            panelPlayerSkills.Location = new System.Drawing.Point(0, 572);
            panelPlayerSkills.Margin = new System.Windows.Forms.Padding(4);
            panelPlayerSkills.Name = "panelPlayerSkills";
            panelPlayerSkills.Radius = 0;
            panelPlayerSkills.ShadowDepth = 4F;
            panelPlayerSkills.Size = new System.Drawing.Size(374, 56);
            panelPlayerSkills.TabIndex = 9;
            panelPlayerSkills.Paint += panelPlayerSkills_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Transparent;
            panel2.Border = new System.Windows.Forms.Padding(0, 0, 0, 0);
            panel2.BorderColor = System.Drawing.Color.Transparent;
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(4);
            panel2.Name = "panel2";
            panel2.Radius = 1;
            panel2.ShadowDepth = 4F;
            panel2.Size = new System.Drawing.Size(374, 2);
            panel2.TabIndex = 9;
            // 
            // checkHideLowerLevelSkills
            // 
            checkHideLowerLevelSkills.AutoSize = true;
            checkHideLowerLevelSkills.BackColor = System.Drawing.Color.Transparent;
            checkHideLowerLevelSkills.Depth = 0;
            checkHideLowerLevelSkills.Location = new System.Drawing.Point(202, 9);
            checkHideLowerLevelSkills.Margin = new System.Windows.Forms.Padding(0);
            checkHideLowerLevelSkills.MouseLocation = new System.Drawing.Point(-1, -1);
            checkHideLowerLevelSkills.Name = "checkHideLowerLevelSkills";
            checkHideLowerLevelSkills.Ripple = true;
            checkHideLowerLevelSkills.Size = new System.Drawing.Size(205, 30);
            checkHideLowerLevelSkills.TabIndex = 6;
            checkHideLowerLevelSkills.Text = "Hide lower level skills";
            checkHideLowerLevelSkills.UseVisualStyleBackColor = false;
            checkHideLowerLevelSkills.CheckedChanged += Filter_CheckedChanged;
            // 
            // checkShowAttacks
            // 
            checkShowAttacks.AutoSize = true;
            checkShowAttacks.BackColor = System.Drawing.Color.Transparent;
            checkShowAttacks.Checked = true;
            checkShowAttacks.CheckState = System.Windows.Forms.CheckState.Checked;
            checkShowAttacks.Depth = 0;
            checkShowAttacks.Location = new System.Drawing.Point(0, 9);
            checkShowAttacks.Margin = new System.Windows.Forms.Padding(0);
            checkShowAttacks.MouseLocation = new System.Drawing.Point(-1, -1);
            checkShowAttacks.Name = "checkShowAttacks";
            checkShowAttacks.Ripple = true;
            checkShowAttacks.Size = new System.Drawing.Size(96, 30);
            checkShowAttacks.TabIndex = 7;
            checkShowAttacks.Text = "Attacks";
            checkShowAttacks.UseVisualStyleBackColor = false;
            checkShowAttacks.CheckedChanged += Filter_CheckedChanged;
            // 
            // checkShowBuffs
            // 
            checkShowBuffs.AutoSize = true;
            checkShowBuffs.BackColor = System.Drawing.Color.Transparent;
            checkShowBuffs.Checked = true;
            checkShowBuffs.CheckState = System.Windows.Forms.CheckState.Checked;
            checkShowBuffs.Depth = 0;
            checkShowBuffs.Location = new System.Drawing.Point(124, 9);
            checkShowBuffs.Margin = new System.Windows.Forms.Padding(0);
            checkShowBuffs.MouseLocation = new System.Drawing.Point(-1, -1);
            checkShowBuffs.Name = "checkShowBuffs";
            checkShowBuffs.Ripple = true;
            checkShowBuffs.Size = new System.Drawing.Size(78, 30);
            checkShowBuffs.TabIndex = 8;
            checkShowBuffs.Text = "Buffs";
            checkShowBuffs.UseVisualStyleBackColor = false;
            checkShowBuffs.CheckedChanged += Filter_CheckedChanged;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = System.Drawing.Color.White;
            tabPage4.Controls.Add(listActiveBuffs);
            tabPage4.Location = new System.Drawing.Point(4, 28);
            tabPage4.Margin = new System.Windows.Forms.Padding(4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(4);
            tabPage4.Size = new System.Drawing.Size(609, 717);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Active buffs";
            // 
            // listActiveBuffs
            // 
            listActiveBuffs.BackColor = System.Drawing.Color.White;
            listActiveBuffs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listActiveBuffs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colActiveName, colActiveLevel });
            listActiveBuffs.Dock = System.Windows.Forms.DockStyle.Fill;
            listActiveBuffs.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            listActiveBuffs.FullRowSelect = true;
            listActiveBuffs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listActiveBuffs.Location = new System.Drawing.Point(4, 4);
            listActiveBuffs.Margin = new System.Windows.Forms.Padding(4);
            listActiveBuffs.Name = "listActiveBuffs";
            listActiveBuffs.Size = new System.Drawing.Size(601, 709);
            listActiveBuffs.TabIndex = 6;
            listActiveBuffs.UseCompatibleStateImageBehavior = false;
            listActiveBuffs.View = System.Windows.Forms.View.Details;
            listActiveBuffs.MouseDoubleClick += listActiveBuffs_MouseDoubleClick;
            // 
            // colActiveName
            // 
            colActiveName.Text = "Name";
            colActiveName.Width = 226;
            // 
            // colActiveLevel
            // 
            colActiveLevel.Text = "";
            colActiveLevel.Width = 69;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(tabControl2);
            Controls.Add(tabControl1);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Main";
            Size = new System.Drawing.Size(1247, 749);
            Load += Main_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBoxAttackingSkills.ResumeLayout(false);
            groupBoxAttackingSkills.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupAdvancedSetup.ResumeLayout(false);
            groupAdvancedSetup.PerformLayout();
            grpMasteryUpdate.ResumeLayout(false);
            grpMasteryUpdate.PerformLayout();
            groupBoxAutomatedResurrection.ResumeLayout(false);
            groupBoxAutomatedResurrection.PerformLayout();
            groupBoxAdvancedBuff.ResumeLayout(false);
            groupBoxAdvancedBuff.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            skillContextMenu.ResumeLayout(false);
            panelPlayerSkills.ResumeLayout(false);
            panelPlayerSkills.PerformLayout();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SDUI.Controls.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private SDUI.Controls.ComboBox comboResurrectionSkill;
        private SDUI.Controls.Label label3;
        private SDUI.Controls.CheckBox checkResurrectParty;
        private SDUI.Controls.CheckBox checkAcceptResurrection;
        private SDUI.Controls.CheckBox checkCastBuffsInTowns;
        private SDUI.Controls.GroupBox groupBoxAutomatedResurrection;
        private SDUI.Controls.GroupBox groupBoxAdvancedBuff;
        private SDUI.Controls.CheckBox checkCastBuffsDuringWalkBack;
        private SDUI.Controls.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private SDUI.Controls.CheckBox checkShowAttacks;
        private SDUI.Controls.CheckBox checkShowBuffs;
        private SDUI.Controls.CheckBox checkHideLowerLevelSkills;
        private SDUI.Controls.ListView listSkills;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLevel;
        private System.Windows.Forms.TabPage tabPage4;
        private SDUI.Controls.ListView listActiveBuffs;
        private System.Windows.Forms.ColumnHeader colActiveName;
        private System.Windows.Forms.ColumnHeader colActiveLevel;
        private SDUI.Controls.Panel panelPlayerSkills;
        private SDUI.Controls.Panel panel2;
        private SDUI.Controls.ContextMenuStrip skillContextMenu;
        private System.Windows.Forms.ToolStripMenuItem skillContextMenuAddBuffSkill;
        private System.Windows.Forms.ToolStripMenuItem skillContextMenuAddAttackSkill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private SDUI.Controls.GroupBox grpMasteryUpdate;
        private SDUI.Controls.Label label4;
        private SDUI.Controls.NumUpDown numMasteryGap;
        private SDUI.Controls.ComboBox comboLearnMastery;
        private SDUI.Controls.CheckBox checkLearnMastery;
        private SDUI.Controls.CheckBox checkLearnMasteryBotStopped;
        private SDUI.Controls.GroupBox groupAdvancedSetup;
        private SDUI.Controls.CheckBox checkWarlockMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem useToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useToPartyMemberToolStripMenuItem;
        private SDUI.Controls.ComboBox comboTeleportSkill;
        private SDUI.Controls.CheckBox checkUseTeleportSkill;
        private SDUI.Controls.CheckBox checkCastBuffsBetweenAttacks;
        private SDUI.Controls.GroupBox groupBox2;
        private SDUI.Controls.Button button1;
        private SDUI.Controls.Button button2;
        private SDUI.Controls.Button button3;
        private SDUI.Controls.ListView listBuffs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private SDUI.Controls.ComboBox comboImbue;
        private SDUI.Controls.Label label1;
        private SDUI.Controls.GroupBox groupBoxAttackingSkills;
        private SDUI.Controls.CheckBox checkUseDefaultAttack;
        private SDUI.Controls.CheckBox checkUseSkillsInOrder;
        private SDUI.Controls.CheckBox checkBoxNoAttack;
        private SDUI.Controls.ListView listAttackingSkills;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnLevel;
        private SDUI.Controls.Label label2;
        private SDUI.Controls.ComboBox comboMonsterType;
        private SDUI.Controls.Button btnMoveAttackSkillDown;
        private SDUI.Controls.Button btnMoveAttackSkillUp;
        private SDUI.Controls.Button btnRemoveAttackSkill;
    }
}
