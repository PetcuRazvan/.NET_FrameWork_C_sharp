using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs5_FirmaApp
{
    public partial class Form1 : Form
    {
        Firma obf;

        public Form1()
        {
            InitializeComponent();
            obf = new Firma("ASE_SRL"); //bineeee

            obf.Ev_Modificare_Firma += Obf_Ev_Modificare_Firma;
        }

        void show_hide(bool fvb)
        {
            ((ToolStripMenuItem)men.Items[0]).DropDownItems[1].Enabled = fvb;
            ((ToolStripMenuItem)men.Items[1]).DropDownItems[1].Enabled = fvb;
            ((ToolStripMenuItem)men.Items[1]).DropDownItems[2].Enabled = fvb;
        }

        private void Obf_Ev_Modificare_Firma(object sender, Firma_EvArgs e)
        {
            Firma aux = sender as Firma;
            gv.Rows.Clear();
            sbfs.Text = aux.Fond_sal.ToString();

            foreach(Salariat s in aux.Salariati)
            {
                gv.Rows.Add(s.Marca.ToString(), s.Nume, s.NrOre.ToString(), s.Salo.ToString());
            }

            if (aux.Numar_salariati > 0)
            {
                gv.Rows[e.Index_Salariat].Selected = true;
                show_hide(true);
            }
            else
            {
                show_hide(false);
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esti sigur?", "DaNu", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_actualizare fa = new Form_actualizare();
            string sopt = ((ToolStripMenuItem)sender).Tag.ToString();
            if (sopt == "a") {
                fa.Text = "Adaugare Salariat";
                fa.button1.Text = "Adauga";
            } else
            {
                fa.Text = "Modificare Salariat";
                fa.button1.Text = "Modifica";

                DataGridViewRow rd = gv.SelectedRows[0];
                fa.tbMarca.Text = rd.Cells[0].Value.ToString();
                fa.tbNumePrenume.Text = rd.Cells[1].Value.ToString();
                fa.tbNrOre.Text = rd.Cells[2].Value.ToString();
                fa.tbSalariuOra.Text = rd.Cells[3].Value.ToString();
            }


            if (DialogResult.OK == fa.ShowDialog()) //daca apasam pe adauga un formul de actualizare
            {
                Salariat temp = new Salariat
                {
                    Marca = int.Parse(fa.tbMarca.Text),
                    Nume = fa.tbNumePrenume.Text,
                    NrOre = int.Parse(fa.tbNrOre.Text),
                    Salo = int.Parse(fa.tbSalariuOra.Text)
                };

                obf.Adauga_Sal(temp);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text += obf.Nume_firma; //concateneaza la text
            show_hide(false);
        }

        private void stocheazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obf.Serializeaza("fsal.dat");
        }

        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "Fisiere de date| *.dat|Toate fisierele|*.*";
            if (DialogResult.OK == ofd.ShowDialog())
            {
                obf.Deserializeaza(ofd.FileName);
            }
           
        }
    }
}
