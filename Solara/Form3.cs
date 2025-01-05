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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Process proc;

        private void Form3_Load(object sender, EventArgs e)
        {
            proc = Process.GetCurrentProcess();
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.OutputDataReceived += Proc_OutputDataReceived;
            proc.ErrorDataReceived += Proc_ErrorDataReceived;
        }

        private void Proc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            alphaBlendTextBox1.Text += e.Data;
        }

        private void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            alphaBlendTextBox1.Text += e.Data;
        }
    }
}
