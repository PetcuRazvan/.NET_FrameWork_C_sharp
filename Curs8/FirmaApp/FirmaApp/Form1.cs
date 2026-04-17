using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaApp
{
    public partial class Form1 : Form
    {
        Firma obf;
        public Form1()
        {
            InitializeComponent();
            obf = new Firma("ASE_SRL");
            obf.Ev_Modificare_Firma += Obf_Ev_Modificare_Firma;
        }

        void show_hide(bool fvb) {
            ((ToolStripMenuItem)men.Items[0]).DropDownItems[1].Enabled = fvb;
            ((ToolStripMenuItem)men.Items[1]).DropDownItems[1].Enabled = fvb;
            ((ToolStripMenuItem)men.Items[1]).DropDownItems[2].Enabled = fvb;

            stocheazaDateSalariatiToolStripMenuItem.Enabled = fvb;
        }
        private void Obf_Ev_Modificare_Firma(object sender, Firma_EvArgs e)
        {
            Firma aux = sender as Firma;
            gv.Rows.Clear();
            sbfs.Text = aux.Fond_sal.ToString();
            foreach (Salariat s in aux.Salariati)
                gv.Rows.Add(s.Marca.ToString(), s.Nume, s.Nr_ore.ToString(), s.Salo.ToString());
            if (aux.Nunar_salariati > 0) {
                gv.Rows[e.Index_Salariat].Selected = true;
                show_hide(true);
            }
            else show_hide(false);
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes== MessageBox.Show("Esti sigur ?", "DaNu", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e) {
            Form_actualizare fa = new Form_actualizare();
            string sopt = ((ToolStripMenuItem)sender).Tag.ToString();
            if (sopt == "A") {
                    fa.Text = "Adaugare Salariat";
                    fa.button1.Text = "Adauga";
                }
            else {
                fa.Text = "Modificare Salariat";
                fa.button1.Text = "Modifica";
                DataGridViewRow rd = gv.SelectedRows[0];
                fa.tb_m.Text = rd.Cells[0].Value.ToString();
                fa.tb_np.Text = rd.Cells[1].Value.ToString();
                fa.tb_no.Text = rd.Cells[2].Value.ToString();
                fa.tb_so.Text = rd.Cells[3].Value.ToString();
            }
            if (DialogResult.OK == fa.ShowDialog()) {
                Salariat temp = new Salariat {
                    Marca = int.Parse(fa.tb_m.Text),
                    Nume = fa.tb_np.Text,
                    Nr_ore = int.Parse(fa.tb_no.Text),
                    Salo = int.Parse(fa.tb_so.Text)
                };
                if(sopt=="A") obf.Adauga_Sal(temp);
                else obf[gv.SelectedRows[0].Index] = temp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text += obf.Nume_firma;
            show_hide(false);
        }

        private void deschideToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "T:\\";
            ofd.Filter = "Fisiere de date|*.dat|Toate fisierele|*.*";
            if(DialogResult.OK ==ofd.ShowDialog())
                    obf.Deserializeaza(ofd.FileName);
        }

        private void stocheazaToolStripMenuItem_Click(object sender, EventArgs e) {
            obf.Serializeaza("fsal.dat");
        }
    }
}
