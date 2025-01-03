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

namespace Solara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            statusLbl.Text = "Status: WAIT FOR INJECT";
            if (ForlornApi.Api.IsRobloxOpen() && !ForlornApi.Api.IsInjected())
            {
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
            textBox1.Text = "";
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
            //notifyIcon1.Icon = SystemIcons.Information;
            await Task.Delay(500);
            new Form2().ShowDialog();
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
                File.WriteAllText("scripts\\" + res.Text + ".lua", textBox1.Text);
            }
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { FileName = "", Filter = "LUA scripts|*.lua", InitialDirectory = Application.StartupPath + "\\scripts\\"};
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        bool hide = false;

        private void sHOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hide = !hide;
            if (hide)
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
    }
}
