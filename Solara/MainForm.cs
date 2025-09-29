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
using System.Diagnostics;

namespace Solara
{
    public partial class MainForm : Form
    {
        public MainForm(string[] args)
        {
            InitializeComponent();
            this.args = args;
        }

        string[] args;
        string userName = Properties.Settings.Default.UserName;

        public async void ExecuteScript(string script)
        {
            if (Properties.Settings.Default.RunAfterScriptBtnClick)
            {
                if (VanityAPI.Api.IsInjected() && VanityAPI.Api.IsRobloxOpen())
                {
                    statusLbl.Text = "Status: RUNNING SCRIPT";
                    await Task.Delay(500);
                    VanityAPI.Api.Execute(script);
                    statusLbl.Text = "Status: INJECTED";
                }
                else
                {
                    MessageBox.Show("ROBLOX is NOT INJECTED or ROBLOX is NOT OPENED");
                }
            }
            else
            {
                textBox1.Text = script;
            }
        }

        public void OpenFile(string file)
        {
            textBox1.Text = File.ReadAllText(file);
        }

        public void SetScript(string script)
        {
            textBox1.Text = script;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VanityAPI.Api.IsRobloxOpen() && !VanityAPI.Api.IsInjected())
            {
                VanityAPI.Api.Inject();
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
            if (VanityAPI.Api.IsInjected() && VanityAPI.Api.IsRobloxOpen())
            {
                statusLbl.Text = "Status: RUNNING SCRIPT";
                await Task.Delay(500);
                VanityAPI.Api.Execute(textBox1.Text);
                statusLbl.Text = "Status: INJECTED";
            }
            else
            {
                MessageBox.Show("ROBLOX is NOT INJECTED or ROBLOX is NOT OPENED");
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ShowWatermark) new WatermarkForm().Show();
            webView21.EnsureCoreWebView2Async();
            VanityAPI.Api.SetAutoInject(Properties.Settings.Default.AutoInject);
            textBox1.WordWrap = Properties.Settings.Default.WordWrap;
            if (Properties.Settings.Default.AutoInject)
            {
                injectBtn.Enabled = false;
                toolTip1.SetToolTip(injectBtn, "Inject button is disabled, Because AutoInject is ON.");
            }
            await Task.Delay(500);
            if (args.Length != 0)
            {
                if (args[0] != "-no-disclaimer")
                {
                    new WarningForm().ShowDialog();
                }
            }
            else
            {
                new WarningForm().ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (VanityAPI.Api.IsInjected() && VanityAPI.Api.IsRobloxOpen())
            {
                DialogResult res = MessageBox.Show("Exit? It closes ROBLOX.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    VanityAPI.Api.KillRoblox();
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
                if (File.Exists(Application.StartupPath + "\\scripts\\" + res.Text + ".lua"))
                {
                    DialogResult msg = MessageBox.Show("Overwrite LUA File?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        File.WriteAllText(Application.StartupPath + "\\scripts\\" + res.Text + ".lua", textBox1.Text);
                    }
                    else
                    {
                        File.WriteAllText(Application.StartupPath + "\\scripts\\" + res.Text + "_copy.lua", textBox1.Text);
                    }
                }
                else
                {
                    File.WriteAllText(Application.StartupPath + "\\scripts\\" + res.Text + ".lua", textBox1.Text);
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
            if (VanityAPI.Api.IsInjected() && VanityAPI.Api.IsRobloxOpen())
            {
                DialogResult res = MessageBox.Show("Exit? It closes ROBLOX.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    VanityAPI.Api.KillRoblox();
                    Application.Exit();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall && VanityAPI.Api.IsInjected())
            {
                DialogResult res = MessageBox.Show("Exit? It closes ROBLOX.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    VanityAPI.Api.KillRoblox();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        Form contextForm;

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextForm = new TrayIconForm(this);
                contextForm.Show();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.U)
            {
                if (Properties.Settings.Default.PasteUserName)
                {
                    textBox1.InsertText(Properties.Settings.Default.UserName);
                }
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
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
                new ScriptsForm(this).Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (VanityAPI.Api.IsInjected())
            {
                statusLbl.Text = "STATUS: INJECTED";
            }
            else
            {
                statusLbl.Text = "STATUS: NOT INJECTED";
            }
        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                webView21.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;
                webView21.CoreWebView2.Settings.IsBuiltInErrorPageEnabled = false;
                webView21.CoreWebView2.Settings.IsPasswordAutosaveEnabled = false;
                //webView21.CoreWebView2.Settings.AreDevToolsEnabled = false;
                webView21.CoreWebView2.Settings.IsZoomControlEnabled = false;
                webView21.CoreWebView2.Settings.IsStatusBarEnabled = false;
                //webView21.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
                webView21.NavigateToString(Encoding.UTF8.GetString(Properties.Resources.ScriptHubButton));
            }
            else
            {
                MessageBox.Show("ScriptHub button initialization failed:\n\n" + e.InitializationException.ToString(), "WebView2 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void webView21_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            Debug.WriteLine("Received " + e.WebMessageAsJson);
            new ScriptHubForm(this).Show();
        }
    }
}
