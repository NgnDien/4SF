using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 箱娘你
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            double x0 = this.Width / 2.0;
            double y0 = this.Height / 2.0;
            Pen pen = new Pen(Color.Red, 1F);
            Graphics g = this.CreateGraphics();

            int x1, x2, y1, y2;

            for(double a = 0.05; a<10; a+=0.05)
            {
                x1 = (int)Math.Round(x0, 0);
                y1 = (int)Math.Round(y0 - a * 5);
                for(double t = 0.001; t<2*Math.PI; t+=0.001)
                {
                    x2 = (int)Math.Round(x0 + a * 16 * Math.Pow(Math.Sin(t), 3));
                    y2 = (int)Math.Round(y0 - a * (13 * Math.Cos(t) - 5 * Math.Cos(2 * t) - 2 * Math.Cos(3 * t) - Math.Cos(4 * t)), 0);
                    g.DrawLine(pen, x1, y1, x2, y2);
                    x1 = x2;
                    y1 = y2;
                }
            }
        }
    }
}
