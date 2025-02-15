using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solara
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int timeLeft = 0;
        bool formContinue = false;

        private async void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Resources.ReadMe;
            await Task.Delay(100);
            SystemSounds.Exclamation.Play();
            await Task.Delay(1100);
            SystemSounds.Exclamation.Play();
            await Task.Delay(1100);
            SystemSounds.Exclamation.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft += 1;
            button2.Text = "Continue (" + (20-timeLeft) + ")";
            if (timeLeft == 20)
            {
                timer1.Enabled = false;
                formContinue = true;
                button2.Text = "Continue";
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!formContinue)
            {
                Application.Exit();
            }
        }
    }
}
