using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics g;
            //g;
        }

        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Rectangle r = e.ClipRectangle;

            g.DrawLine(Pens.Red, new Point(r.X, r.Y), new Point(r.X + r.Width, r.Y + r.Height));

            g.DrawString("Trasare Mod Grafic", this.Font, Brushes.Blue, new Point(r.X + r.Width / 2, r.Y + r.Height / 2));
        }
    }
}
