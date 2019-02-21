using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stalacnite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int x1, y1, w, h;
            int nr_s = 20;
            System.Drawing.Graphics Desen;
            Desen = this.CreateGraphics();
            System.Drawing.Pen Creion_g;
            Creion_g = new System.Drawing.Pen(System.Drawing.Color.LightGray, 2);
            System.Random n = new System.Random();
            Desen.Clear(this.BackColor);
            x1 = 0;
            do
            {
                y1 = 0;
                w = 3 + n.Next(12);
                h = n.Next(this.Height);
                Desen.DrawLine(Creion_g, x1, y1, x1 + w / 2, h);
                Desen.DrawLine(Creion_g, x1 + w, y1, x1 + w / 2, h);
                x1 = x1 + this.Width / nr_s;
            }
            while (x1 <= this.Width);
        }
    }
}
