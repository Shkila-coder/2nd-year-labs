using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        Graphics g;
        bool MouseDown = false;
        bool MouseUp = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Location = e.Location;
            label1.Text = e.Button.ToString() + " " + e.Location.ToString();
        }

        private void graphWind_MouseClick(object sender, MouseEventArgs e)
        {
            if(MouseUp)
            {
                MouseUp = false;
                return;
            }
            if (e.Button == MouseButtons.Right)
                g.DrawLine(new Pen(Color.Black), 0, 0, e.Location.X, e.Location.Y);
            if (e.Button == MouseButtons.Left)
                g.DrawLine(new Pen(Color.Black), e.Location.X, e.Location.Y, graphWind.Width, graphWind.Height);
        }

        private void graphWind_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
        }

        private void graphWind_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void graphWind_MouseMove(object sender, MouseEventArgs e)
        {
            if(MouseDown)
            {
                g.FillEllipse(new SolidBrush(Color.Black), e.Location.X-5, e.Location.Y-5, 10, 10);
                MouseUp = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                g = graphWind.CreateGraphics();
                g.SmoothingMode = SmoothingMode.AntiAlias;
        }
    }
}
