using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && Int32.Parse(textBox1.Text) >= 0)
            {
                FractalClass.ListOfTriangles.Clear();
                FractalClass.CalculateTriangle(Int32.Parse(textBox1.Text),
                                               new PointF(pictureBox1.Width / 4 + 200, pictureBox1.Height / 4 + 0),
                                               new PointF(pictureBox1.Width / 4 + 0, pictureBox1.Height / 4 + 300),
                                               new PointF(pictureBox1.Width / 4 + 400, pictureBox1.Height / 4 + 300));
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (FractalClass.ListOfTriangles.Count() > 0)
            {
                foreach (var t in FractalClass.ListOfTriangles)
                {
                    e.Graphics.FillPolygon(Brushes.GreenYellow, t);
                }
            }
        }
    }
}
