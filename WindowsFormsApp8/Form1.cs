using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("本当にシャットダウンしますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Process.Start("shutdown", "/s /f /t 0");
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("本当に再起動しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Process.Start("shutdown", "/r /f /t 0");
            }
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("本当にスリープしますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.SetSuspendState(PowerState.Suspend, true, true);
            }
        }

        private void btnHibernate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("本当に休止状態にしますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.SetSuspendState(PowerState.Hibernate, true, true);
            }
        }
    }
}
