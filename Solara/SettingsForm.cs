using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solara
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            autoInjectChkBox.Checked = Properties.Settings.Default.AutoInject;
            userNameTxtBox.Text = Properties.Settings.Default.UserName;
            pasteUserNameChkBox.Checked = Properties.Settings.Default.PasteUserName;
            wordWrapChkBox.Checked = Properties.Settings.Default.WordWrap;
            scriptsUpdIntervalBox.Value = (decimal)Properties.Settings.Default.ScriptsUpdateInterval;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoInject = autoInjectChkBox.Checked;
            Properties.Settings.Default.UserName = userNameTxtBox.Text;
            Properties.Settings.Default.PasteUserName = pasteUserNameChkBox.Checked;
            Properties.Settings.Default.WordWrap = wordWrapChkBox.Checked;
            Properties.Settings.Default.ScriptsUpdateInterval = (int)scriptsUpdIntervalBox.Value;
            Properties.Settings.Default.Save();
            Process.Start(Application.ExecutablePath,"-no-disclaimer");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
