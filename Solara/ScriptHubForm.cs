using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solara
{
    public partial class ScriptHubForm : Form
    {
        public ScriptHubForm()
        {
            InitializeComponent();
        }

        private void ScriptHubForm_Load(object sender, EventArgs e)
        {
            webView21.EnsureCoreWebView2Async();
        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                webView21.CoreWebView2.Settings.IsBuiltInErrorPageEnabled = false;
                webView21.CoreWebView2.Settings.IsPasswordAutosaveEnabled = false;
                webView21.CoreWebView2.Settings.AreDevToolsEnabled = false;
                webView21.CoreWebView2.Settings.IsZoomControlEnabled = false;
                webView21.CoreWebView2.Settings.IsStatusBarEnabled = false;
                webView21.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
                webView21.CoreWebView2.Navigate("http://positive-began.gl.at.ply.gg:12148/SolaraScripthub/");
            }
            else
            {
                MessageBox.Show("ScriptHub initialization failed:\n\n" + e.InitializationException.ToString(), "WebView2 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void webView21_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {

        }
    }
}
