using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Termometru
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics Desen;
        System.Drawing.Pen Creion_albastru;
        System.Drawing.SolidBrush Pensula_rosie;
        System.Drawing.Pen Creion_gri;
        int i,nr;

        public Form1()
        {
            InitializeComponent();
            Desen = this.CreateGraphics();
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
            Pensula_rosie = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            Creion_gri = new System.Drawing.Pen(System.Drawing.Color.Gray);
            nr = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.ll.Left = Convert.ToInt32(trackBar1.Left + trackBar1.Value*1.5);//Am pozitionat labelul care arata valoarea trackbarului deasupra cursorului
            this.ll.Top = trackBar1.Top - ll.Height - 10;//Am facut ca labelul sa imi pastreze pozitia chiar daca se mareste formul
            this.ll.Text = Convert.ToString(trackBar1.Value);//Arata in label valoarea trackbarului
            Desen.Clear(this.BackColor);
            Desen.DrawRectangle(Creion_albastru, 170, 30, 10, 250);
            Desen.FillRectangle(Pensula_rosie, 171, 280 - trackBar1.Value, 9, trackBar1.Value);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Desen.Clear(this.BackColor);
            Desen.DrawRectangle(Creion_albastru, 170, 30, 10, 250);
            Desen.FillRectangle(Pensula_rosie, 171, 280 - trackBar1.Value, 9, trackBar1.Value);
            if (trackBar1.Value > 220)
                Desen.FillEllipse(Pensula_rosie, 190, 30, 10, 10);
            for (i = 1; i <= 250; i++)
            {
                Desen.DrawLine(Creion_gri, 185, 30 + i, 190, 30 + i);
                i = i + 5;
                nr = nr + 1;
                if (nr % 5 == 0)
                {
                    Desen.DrawLine(Creion_gri, 185, 31 + i, 195, 31 + i);
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.ll.Top = trackBar1.Top - ll.Height - 10;//Mentinem labelul pe pozitie chiar daca formul isi mareste dimensiunile 
        }
    }
}
