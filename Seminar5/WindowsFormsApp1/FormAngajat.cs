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
    public partial class FormAngajat : Form
    {
        public Angajat AngajatModificat { get; set; }
        public FormAngajat(Angajat angajat = null)
        {
            InitializeComponent();

            AngajatModificat = new Angajat();

            if (angajat != null)
            {
                AngajatModificat = angajat;
                txtNume.Text = angajat.Nume;
                txtPrenume.Text = angajat.Prenume;
                txtSalariu.Text = angajat.Salariu.ToString();
                chkEstePermanent.Checked = angajat.EstePermanent;
                dtpDataAngajarii.Value = angajat.DataAngajarii;
                cmbDepartament.SelectedItem = angajat.Departament;
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            bool esteValid = valideazaForm();

            if (!esteValid)
            {
                return;
            }

            AngajatModificat = new Angajat();
            AngajatModificat.Nume = txtNume.Text;
            AngajatModificat.Prenume = txtPrenume.Text;
            AngajatModificat.Departament = cmbDepartament.SelectedItem.ToString();
            decimal.TryParse(txtSalariu.Text, out decimal result);
            AngajatModificat.Salariu = result;
            AngajatModificat.DataAngajarii = dtpDataAngajarii.Value;
            AngajatModificat.EstePermanent = chkEstePermanent.Checked;

            DialogResult = DialogResult.OK;
        }

        private bool valideazaForm()
        {
            bool esteValid = true;

            epFormAngajat.Clear();
            if (string.IsNullOrEmpty(txtNume.Text))
            {
                epFormAngajat.SetError(txtNume, "Numele este obligatoriu");
                esteValid = false;
            }

            if (string.IsNullOrEmpty(txtPrenume.Text))
            {
                epFormAngajat.SetError(txtPrenume, "Prenumele este obligatoriu");
                esteValid = false;
            }

            if (string.IsNullOrEmpty(txtSalariu.Text))
            {
                epFormAngajat.SetError(txtSalariu, "Salariul este obligatoriu");
                esteValid = false;
            }

            if (!decimal.TryParse(txtSalariu.Text, out decimal result)) //out e ca & din C++
            {
                epFormAngajat.SetError(txtSalariu, "Salariul este invalid");
                esteValid = false;
            }
            else
            {
                if (result < 0)
                {
                    epFormAngajat.SetError(txtSalariu, "Salariul trebuie sa fie pozitiv");
                    esteValid = false;
                }
            }

            return esteValid;
        }
    }
}
