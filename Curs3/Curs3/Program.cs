using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Curs3
{
    class Fer_mea : Form 
    {
        Button bt1, bt2;
        public Fer_mea()
        {
            this.Text = "Prima aplicatie WF"; //titlul ferestrei

            bt1 = new Button();
            bt1.Text = "Apasa-ma";
            bt1.Location = new Point(20, 30); //x si y, dar axa y  este cu susul in jos 
            bt1.Width = 150;
            bt1.Click += Bt1_Click; //Click este un event

            bt2 = new Button();
            bt2.Text = "Push";
            bt2.Location = new Point(20, 30 + bt1.Height + 3);  //3 pixeli intre butoane
            bt2.Width = 150;
            bt2.Click += Bt1_Click;

            this.Controls.Add(bt1);
            this.Controls.Add(bt2);
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            string s = ((Button)sender).Text;
            MessageBox.Show($"Ai apasat butonul {s}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new Fer_mea());
        }
    }
}
