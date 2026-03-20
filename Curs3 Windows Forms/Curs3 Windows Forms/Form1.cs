using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs3_Windows_Forms
{
    public partial class Form1 : Form
    {
        Element obe1;
        public Form1()
        {
            InitializeComponent();
            obe1 = new Element();
            obe1.Ev_Mod_Valoare += Obe1_Ev_Mod_Valoare;
        }

        private void Obe1_Ev_Mod_Valoare(Element obj)
        {
            pe1.Text = obj.Patrat.ToString();
            string s = $"{obj.Valoare,6}|{obj.Patrat,6}|"; //6 ne pastreaza valoarea incadrata intr-un segment de lungime 6
            lb.Items.Add(s); //adaugam calculul in list box
            //cel mai top font este Consolas, spatiile au aceeasi marime si de astea, e aliniat totul
            var rd = lv.Items.Add(obj.Valoare.ToString());
            rd.SubItems.Add(obj.Patrat.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            e1_Validating(e1, new CancelEventArgs());
        }

        public void Form1_load(object sender, EventArgs e)
        { 
            e1.Text = obe1.Valoare.ToString();
            pe1.Text = obe1.Patrat.ToString();
        }

        private void e1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) //return = enter, este si enter dar unele tastaturi au return inloc de enter
            {
                button1_Click(null, null); //nu ne intereseaza nici senderul, nici event args
                e1.SelectAll(); //ca de fiecare data cand dau enter, sa mi selecteze tot textul si sa putem scrie automat urmatoruk nr in textbox
            }
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb.SelectedIndex == -1) //pt ca daca apasam pe buton si ne dispare selectia pe lista(ca asa e mai nice), ne-ar da eroare codul de mai jos pt ca nu e selectat nmc
            {
                return;
            }

            string sel = lb.SelectedItem as string;
            e1.Text = (sel.Split('|')[0]).Trim();
            pe1.Text = (sel.Split('|')[1]).Trim();
        }

        private void e1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                obe1.Valoare = int.Parse(e1.Text);
                lb.SelectedIndex = -1;
                err.SetError(e1, null); //face ca eroarea sa dispara
            }
            catch (FormatException ex)
            {
                //MessageBox.Show(ex.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //putem face asa, sau
                err.SetError(e1, "invalid");
                e.Cancel = true;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Tag == "D")
            {
                lv.View = View.Details;
                return;
            }

            if (((RadioButton)sender).Tag == "L")
            {
                lv.View = View.List;
                return;
            }

            if (((RadioButton)sender).Tag == "T")
            {
                lv.View = View.Tile;
                return;
            }
        }
    }
}
