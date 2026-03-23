using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar6
{
    public partial class FormCarte : Form
    {
        private CarteRepository _carteRepository;

        private Guid? _idOfEditable;
        public FormCarte(Guid? id = null) //parametru optional
        {
            InitializeComponent();

            _carteRepository = new CarteRepository();

           

            nmrAnAparitie.Minimum = 1000;
            nmrAnAparitie.Maximum = DateTime.Now.Year; //nu putem selecta un an mai mare decat anul curent
            nmrAnAparitie.Value = DateTime.Now.Year; //din prima apare anul curent in casuta

            var genuri = Enum.GetValues(typeof(GenCarte)); //ca sa adaugam enumul in combobox
            foreach(var gen in genuri)
            {
                cmbGen.Items.Add(gen);
            }

            if (id != null)
            {
                var carte = _carteRepository.GetById(id.Value); //trebuie value pt ca id ul primit este nulabil dar aceasta functie accepta guid nenulabil
                txtTitlu.Text = carte.Titlu;
                txtAutor.Text = carte.Autor;
                nmrAnAparitie.Value = carte.AnAparitie;
                cmbGen.SelectedItem = carte.Gen;

                _idOfEditable = id;
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (!EsteValid())
            {
                return;
            }

            var carte = new Carte();

            if (_idOfEditable != null)
            {
                carte.Id = _idOfEditable.Value;
            }
            else
            {
                carte.Id = Guid.NewGuid();
            }
   
            carte.Titlu = txtTitlu.Text;
            carte.Autor = txtAutor.Text;
            carte.AnAparitie = (int)nmrAnAparitie.Value; //by default returneaza decimal deci tre sa dam cast
            carte.Gen = (GenCarte)cmbGen.SelectedItem;

            if (_idOfEditable != null)
            {
                _carteRepository.Update(carte);
            }
            else
            {
                _carteRepository.Add(carte);
            }

            DialogResult = DialogResult.OK;
        }

        private bool EsteValid()
        {
            bool esteValid = true;
            epCarti.Clear();

            if(string.IsNullOrEmpty(txtTitlu.Text))
            {
                epCarti.SetError(txtTitlu, "Titlul este obligatoriu");
                esteValid = false;
            }

            if(string.IsNullOrEmpty(txtAutor.Text))
            {
                epCarti.SetError(txtAutor, "Autorul este obligatoriu");
                esteValid = false;
            }

            if (cmbGen.SelectedIndex < 0) //adica daca nu am selectat nmc, indexul se refera la ce am selectat
            {
                epCarti.SetError(cmbGen, "Genul este obligatoriu");
                esteValid = false;
            }

            return esteValid;
        }
    }
}
