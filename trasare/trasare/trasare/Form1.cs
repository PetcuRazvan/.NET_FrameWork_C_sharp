using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace trasare
{
    public partial class Form1 : Form
    {
        bool vb = false;
        public Form1()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vb = true;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics dc = e.Graphics;
            Rectangle rc = this.ClientRectangle;
            Point pbtn = new Point(rc.Right - btn.Size.Width, rc.Y);
            btn.Location = pbtn;

            if (vb)
            {               
                string sir = "Trasare grafica!!";
                Pen pr = new Pen(Brushes.Red, 2);
                dc.DrawLine(pr, new Point(rc.X, rc.Y), new Point(rc.Right, rc.Bottom));
                Size dimt = TextRenderer.MeasureText(sir, this.Font);
                float st = rc.X + rc.Width/2 - dimt.Width / 2;
                float sus = rc.Y + rc.Height/2 - dimt.Height / 2;
                dc.DrawString(sir, this.Font, Brushes.Blue, st, sus);
            }          
        }
    }
}
