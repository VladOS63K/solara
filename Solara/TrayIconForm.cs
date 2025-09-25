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
    public partial class TrayIconForm : Form
    {
        public TrayIconForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            Point p = MousePosition;
            p.X += 20;
            p.X -= this.Width;
            p.Y += (20-this.Size.Height);
            this.Location = p;
        }

        Form mainForm;

        private void Form4_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnMouseLeave(EventArgs e)
        {

            if (this.ClientRectangle.Contains(this.PointToClient(MousePosition)))
                return;
            else
            {
                base.OnMouseLeave(e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.hide = !Program.hide;
            if (Program.hide)
            {
                mainForm.Hide();
            }
            else
            {
                mainForm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
