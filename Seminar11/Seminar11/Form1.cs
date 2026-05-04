using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvStudenti.DataSource = FakeDatabase.Studenti;
            dgvStudenti.AutoGenerateColumns = true;
        }

        private void pdRaport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;

            Font titleFont = new Font("Verdana", 16, FontStyle.Bold | FontStyle.Italic); //facem sau pe biti ca sa avem si bold si italic ;
            Font studentFont = new Font("Verdana", 12, FontStyle.Bold);
            Font noteFont = new Font("Verdana", 12);

            g.DrawString("LISTA STUDENTI", titleFont, Brushes.Black, x, y);
            y += 30;

            foreach(var student in FakeDatabase.Studenti)
            {
                g.DrawString(student.Nume, studentFont, Brushes.Black, x, y);
                y += 16;

                g.DrawString($"Matematica: {student.Matematica}", noteFont, Brushes.Black, x + 30, y);
                y += 16;
                g.DrawString($"Informatica: {student.Informatica}", noteFont, Brushes.Black, x + 30, y);
                y += 16;
                g.DrawString($"Fizica: {student.Fizica}", noteFont, Brushes.Black, x + 30, y);
                y += 16;
                g.DrawString($"Biologie: {student.Biologie}", noteFont, Brushes.Black, x + 30, y);
                y += 16;
                g.DrawString($"Chimie: {student.Chimie}", noteFont, Brushes.Black, x + 30, y);
                y += 24;
            }

            int[] latimi = new int[] { 325, 450 };
            g.FillRectangle(Brushes.LightGray, x, y, 650, 28);
            g.DrawString("Materie", studentFont, Brushes.Black, x + 5, y + 5);
            g.DrawString("Medie", studentFont, Brushes.Black, x + 318, y + 5);
            y += 28;

            var medieMatematica = FakeDatabase.Studenti.Average(stud => stud.Matematica);
            g.DrawString("Matematica", studentFont, Brushes.Black, x + 5, y + 5);
            g.DrawString(medieMatematica.ToString(), noteFont, Brushes.Black, x + 318, y + 5);
            y += 25;
            g.DrawLine(Pens.Black, x, y, x + 650, y);


            var medieInformatica = FakeDatabase.Studenti.Average(stud => stud.Informatica);
            g.DrawString("Informatica", studentFont, Brushes.Black, x + 5, y + 5);
            g.DrawString(medieInformatica.ToString(), noteFont, Brushes.Black, x + 318, y + 5);
            y += 25;
            g.DrawLine(Pens.Black, x, y, x + 650, y);


            var medieFizica = FakeDatabase.Studenti.Average(stud => stud.Fizica);
            g.DrawString("Fizica", studentFont, Brushes.Black, x + 5, y + 5);
            g.DrawString(medieFizica.ToString(), noteFont, Brushes.Black, x + 318, y + 5);
            y += 25;
            g.DrawLine(Pens.Black, x, y, x + 650, y);

            var medieBiologie = FakeDatabase.Studenti.Average(stud => stud.Biologie);
            g.DrawString("Biologie", studentFont, Brushes.Black, x + 5, y + 5);
            g.DrawString(medieBiologie.ToString(), noteFont, Brushes.Black, x + 318, y + 5);
            y += 25;
            g.DrawLine(Pens.Black, x, y, x + 650, y);

            var medieChimie = FakeDatabase.Studenti.Average(stud => stud.Chimie);
            g.DrawString("Chimie", studentFont, Brushes.Black, x + 5, y + 5);
            g.DrawString(medieChimie.ToString(), noteFont, Brushes.Black, x + 318, y + 5);
            y += 25;
            g.DrawLine(Pens.Black, x, y, x + 650, y);

        }

        private void btnGenereazaRaport_Click(object sender, EventArgs e)
        {
            using (var printPreiewDialog = new PrintPreviewDialog()) {
                printPreiewDialog.Document = pdRaport;

                printPreiewDialog.Width = 600;
                printPreiewDialog.Height = 800;
                printPreiewDialog.ShowDialog(); 
            }
        }
    }
}
