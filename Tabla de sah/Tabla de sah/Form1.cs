using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tabla_de_sah
{
    public partial class Form1 : Form
    {   
        System.Drawing.Graphics Desen;
        System.Drawing.SolidBrush Pensula_alba;
        System.Drawing.SolidBrush Pensula_neagra;
        int rand,n,coloana;

        public Form1()
        {
            InitializeComponent();
            Desen = this.CreateGraphics();
            Pensula_alba = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            Pensula_neagra = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            n = 0;
            n = rand + coloana;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (rand = 1; rand <= 8; rand++)
            {
                for (coloana = 1; coloana <= 8; coloana++)
                {
                    n = rand + coloana;
                    if(n%2==0)
                    {
                        Desen.FillRectangle(Pensula_neagra, 20 + +coloana * 20, 20 + rand * 20, 20, 20);
                    }
                    else if (n%2==1)
                    {
                        Desen.FillRectangle(Pensula_alba, 20 + +coloana * 20, 20 + rand * 20, 20, 20);
                    }
                }
            } 
        }
     }
}