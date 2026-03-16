using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private BindingList<Angajat> _angajati = new BindingList<Angajat>();
        public Form1()
        {
            InitializeComponent();
            dvgAngajati.DataSource = _angajati;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (var formAngajat = new FormAngajat()) //using e un fel de try catch finally, automat da dispose la fereastra cand o inchizi
            {
                 //show dialog opreste programul la acest punct, executia nu merge mai departe pana nu inchid fereastra, daca foloseam doar Show, imi apareau ambele in acelasi timp
                //MessageBox.Show("Ceva");
                if (formAngajat.ShowDialog() == DialogResult.OK)
                {
                    var angajatNou = formAngajat.AngajatModificat;
                    _angajati.Add(angajatNou);
                }

                
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            var index = dvgAngajati.SelectedRows[0].Index;
            var angajat = _angajati[index];

            using (var formAngajat = new FormAngajat(angajat)) //using e un fel de try catch finally, automat da dispose la fereastra cand o inchizi
            {
                
                if (formAngajat.ShowDialog() == DialogResult.OK)
                {
                    var angajatNou = formAngajat.AngajatModificat;
                    _angajati[index] = angajatNou;
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            var index = dvgAngajati.SelectedRows[0].Index;
            var angajat = _angajati[index];

            if (MessageBox.Show($"Esti sigur ca vrei sa stergi angajatul {angajat.ToString()}", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _angajati.Remove(angajat);
            }
        }
    }
}
