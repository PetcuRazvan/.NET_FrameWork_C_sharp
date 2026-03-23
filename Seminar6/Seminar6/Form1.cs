using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar6
{
    public partial class Form1 : Form
    {
        private CarteRepository _carteRepository;
        public Form1()
        {
            _carteRepository = new CarteRepository();

            InitializeComponent();

            lvCarti.FullRowSelect = true;
            lvCarti.GridLines = true;
            lvCarti.AllowColumnReorder = true;

            var latime = lvCarti.ClientSize.Width;

            lvCarti.Columns.Add("Titlu",(int)(latime * 0.3));
            lvCarti.Columns.Add("Autor", (int)(latime * 0.3));
            lvCarti.Columns.Add("An", (int)(latime * 0.2));
            lvCarti.Columns.Add("Gen", (int)(latime * 0.2));

            btnEditeaza.Enabled = false; //il dezactivam la inceput in caza ca nu am selectat nicio carte, vrem sa apara numai cand selectam o carte

            RefreshLista();
        }

        private void RefreshLista()
        {
            lvCarti.Items.Clear();
            var carti = _carteRepository.GetAll();
            foreach(var carte in carti)
            {
                var item = new ListViewItem(carte.Titlu);
                item.SubItems.Add(carte.Autor);
                item.SubItems.Add(carte.AnAparitie.ToString());
                item.SubItems.Add(carte.Gen.ToString());
                item.Tag = carte; //putem pune absolul ce vrem folosim tag ca sa fie usor sa il luam in cod

                lvCarti.Items.Add(item);
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using(var formCarte = new FormCarte())
            {
                if (formCarte.ShowDialog() == DialogResult.OK)
                {
                    RefreshLista(); //am intrat aici deoarece am terminat de adaugat o carte in lista, baza de date s-a actualizat deci dam refresh la lista si atat
                }
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            var carte = lvCarti.SelectedItems[0].Tag as Carte; //putem ori cu as Carte ori cu (Carte) scris inainte, inseamna acelasi lucru

            using (var formCarte = new FormCarte(carte.Id))
            {
                if (formCarte.ShowDialog() == DialogResult.OK)
                {
                    RefreshLista(); 
                }
            }
        }
        private void lvCarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditeaza.Enabled = true; //am selectat o carte deci acum afisam butonul
        }

    }
}
