using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CaptureThisButton_Click(object sender, EventArgs e)
        {
            var ops = new ScreenCapture();
            pictureBox1.Image = ops.CaptureWindow(CaptureThisButton.Handle);
        }

        private void CaptureDesktopButton_Click(object sender, EventArgs e)
        {
            var ops = new ScreenCapture();
            pictureBox2.Image = ops.CaptureScreen();
        }
    }
}
