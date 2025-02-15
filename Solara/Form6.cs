using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solara
{
    public partial class Form6 : Form
    {
        public Form6(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        Form1 mainForm;

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Interval = Properties.Settings.Default.ScriptsUpdateInterval;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int selectedIndex;
            selectedIndex = listBox1.SelectedIndex;
            listBox1.Items.Clear();
            string[] scripts = Directory.GetFiles("scripts\\", "*.lua");
            foreach (string script in scripts)
            {
                string name = Path.GetFileName(script);
                listBox1.Items.Add(name);
            }
            listBox1.SelectedIndex = selectedIndex;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                mainForm.OpenFile("scripts\\" + listBox1.SelectedItem);
            }
        }
    }
}
