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
    public partial class WatermarkForm : Form
    {
        public WatermarkForm()
        {
            InitializeComponent();
        }

        int pos = 1;

        private void hideWatermarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowWatermark = false;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rectangle sc = Screen.PrimaryScreen.WorkingArea;
            pos++;
            if (pos > 4) pos = 1;
            switch (pos)
            {
                case 1:
                    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                    break;
                case 2:
                    this.Left = sc.Width - this.Width;
                    break;
                case 3:
                    this.Left = sc.X;
                    this.Top = sc.Height - this.Height;
                    break;
                case 4:
                    this.Left = sc.Width - this.Width;
                    this.Top = sc.Height - this.Height;
                    break;
            }
        }
    }
}
