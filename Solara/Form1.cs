using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Solara
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            InitializeComponent();
            this.args = args;
        }

        string[] args;
        string userName = Properties.Settings.Default.UserName;

        public void OpenFile(string file)
        {
            textBox1.Text = File.ReadAllText(file);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ForlornApi.Api.IsRobloxOpen() && !ForlornApi.Api.IsInjected())
            {
                statusLbl.Text = "Status: WAIT FOR INJECT";
                ForlornApi.Api.Inject();
                statusLbl.Text = "Status: INJECTED";
            }
            else
            {
                MessageBox.Show("ROBLOX is now INJECTED or ROBLOX is NOT OPENED");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Really clear?","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                textBox1.Text = "";
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            if (ForlornApi.Api.IsInjected() && ForlornApi.Api.IsRobloxOpen())
            {
                statusLbl.Text = "Status: RUNNING SCRIPT";
                await Task.Delay(500);
                ForlornApi.Api.ExecuteScript(textBox1.Text);
                statusLbl.Text = "Status: INJECTED";
            }
            else
            {
                MessageBox.Show("ROBLOX is NOT INJECTED or ROBLOX is NOT OPENED");
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            ForlornApi.Api.SetAutoInject(Properties.Settings.Default.AutoInject);
            textBox1.WordWrap = Properties.Settings.Default.WordWrap;
            if (Properties.Settings.Default.AutoInject)
            {
                statusLbl.Text = "STATUS: UNKNOWN";
                injectBtn.Enabled = false;
                toolTip1.SetToolTip(injectBtn, "Inject button is disabled, Because AutoInject is ON.");
                toolTip1.SetToolTip(statusLbl, "Status is unknown, Because AutoInject is ON.");
            }
            await Task.Delay(500);
            if (args.Length != 0)
            {
                if (args[0] != "-no-disclaimer")
                {
                    new Form2().ShowDialog();
                }
            }
            else
            {
                new Form2().ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ForlornApi.Api.IsInjected() && ForlornApi.Api.IsRobloxOpen())
            {
                DialogResult res = MessageBox.Show("Exit? It closes ROBLOX.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    ForlornApi.Api.KillRoblox();
                    Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(MousePosition);
        }

        private void sAVESCRIPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBoxResult res = InputBox.Show("Enter SCRIPT name");
            if (res.DialogResult == InputBoxDialogResult.OK)
            {
                if (File.Exists("scripts\\" + res.Text + ".lua"))
                {
                    DialogResult msg = MessageBox.Show("Overwrite LUA File?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        File.WriteAllText("scripts\\" + res.Text + ".lua", textBox1.Text);
                    }
                    else
                    {
                        File.WriteAllText("scripts\\" + res.Text + "_copy.lua", textBox1.Text);
                    }
                }
                else
                {
                    File.WriteAllText("scripts\\" + res.Text + ".lua", textBox1.Text);
                }
            }
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { FileName = "", Filter = "LUA scripts|*.lua", InitialDirectory = Application.StartupPath + "\\scripts\\"};
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenFile(ofd.FileName);
            }
        }

        private void sHOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.hide = !Program.hide;
            if (Program.hide)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ForlornApi.Api.IsInjected() && ForlornApi.Api.IsRobloxOpen())
            {
                DialogResult res = MessageBox.Show("Exit? It closes ROBLOX.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    ForlornApi.Api.KillRoblox();
                    Application.Exit();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall && ForlornApi.Api.IsInjected())
            {
                DialogResult res = MessageBox.Show("Exit? It closes ROBLOX.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    ForlornApi.Api.KillRoblox();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void dEBUGCONSOLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        Form contextForm;

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextForm = new Form4(this);
                contextForm.Show();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.U)
            {
                if (Properties.Settings.Default.PasteUserName)
                {
                    textBox1.Paste(userName);
                }
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }

        private void oPENSCRIPTSWINDOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool opened = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Form6")
                {
                    opened = true;
                    f.Activate();
                }
            }
            if (!opened)
            {
                new Form6(this).Show();
            }
        }
    }
}
