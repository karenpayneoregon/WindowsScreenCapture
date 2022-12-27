using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<int, List<Point>> signatureObject = new Dictionary<int, List<Point>>();
        private readonly Pen signaturePen = new Pen(Color.Black, 4);
        private List<Point> currentCurvePoints;
        private int currentCurve = -1;

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

        private void PictureBoxButton_Click(object sender, EventArgs e)
        {
            var signatureFileName = "Test.bmp";

            if (string.IsNullOrEmpty(signatureFileName))
            {
                return;
            }

            if (currentCurve < 0 || signatureObject[currentCurve].Count == 0)
            {
                return;
            }

            using (Bitmap imgSignature = new Bitmap(pictureBox3.Width, pictureBox3.Height, PixelFormat.Format32bppArgb))
            {
                using (Graphics g = Graphics.FromImage(imgSignature))
                {
                    DrawSignature(g);
                    var signaturePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{signatureFileName}.png");
                    imgSignature.Save(signaturePath, ImageFormat.Png);
                }
            }

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            currentCurvePoints = new List<Point>();
            currentCurve += 1;
            signatureObject.Add(currentCurve, currentCurvePoints);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || currentCurve < 0)
            {
                return;
            }

            signatureObject[currentCurve].Add(e.Location);
            pictureBox3.Invalidate();
        }
        private void DrawSignature(Graphics g)
        {
            g.CompositingMode = CompositingMode.SourceOver;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (var curve in signatureObject)
            {
                if (curve.Value.Count < 2)
                {
                    continue;
                }

                using (GraphicsPath gPath = new GraphicsPath())
                {
                    gPath.AddCurve(curve.Value.ToArray(), 0.5F);
                    g.DrawPath(signaturePen, gPath);
                }
            }
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            if (currentCurve < 0 || signatureObject[currentCurve].Count == 0)
            {
                return;
            }

            DrawSignature(e.Graphics);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            currentCurve = -1;
            signatureObject.Clear();
            pictureBox3.Invalidate();
        }
    }
}
