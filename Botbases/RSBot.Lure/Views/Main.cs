using System;
using System.ComponentModel;
using System.Windows.Forms;
using SDUI.Controls;

namespace RSBot.Lure.Views
{
    [ToolboxItem(false)]
    public partial class Main : DoubleBufferedControl
    {
        // مفتاح تشغيل الـ Lure
        private bool _lureEnabled;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // افتراضيًا: مقفول
            _lureEnabled = false;
            checkBox1.Checked = false;
        }

        // =========================
        // Checkbox Control
        // =========================
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _lureEnabled = checkBox1.Checked;
        }

        // =========================
        // Entry point للـ Lure
        // =========================
        private void RunLure()
        {
            if (!_lureEnabled)
                return;

            // ===== LURE LOGIC =====
            // هنا تحط كود الـ lure الحقيقي
        }

        // =========================
        // Designer Events
        // =========================
        private void OnSettingsChanged(object sender, EventArgs e) { }
        private void btnSetCenter_Click(object sender, EventArgs e) { }
        private void btnBrowse_Click(object sender, EventArgs e) { }
        private void linkRecord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }
        private void btnBrowseWalkscript_Click(object sender, EventArgs e) { }
        private void comboMonsterType_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
