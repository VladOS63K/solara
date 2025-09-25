using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solara
{
    public partial class ButtonForm : Form
    {
        public ButtonForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        MainForm mainForm;

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.ButtonsJson.Length == 0) return;
                ScriptButton[] btns = { };
                foreach (ScriptButton btn in JsonSerializer.Deserialize<ScriptButton[]>(Properties.Settings.Default.ButtonsJson))
                {
                    btns[btn.BtnOrder] = btn;
                }
                for (int i = 0; i < btns.Length; i++)
                {
                    Button btn = new Button();
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Name = "ScriptButton";
                    btn.Size = btns[i].BtnSize;
                    btn.Text = btns[i].BtnName;
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += (s,v) =>
                    {
                        mainForm.ExecuteScript(btns[i].BtnScript);
                    };
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
            catch { }
        }
    }
}
