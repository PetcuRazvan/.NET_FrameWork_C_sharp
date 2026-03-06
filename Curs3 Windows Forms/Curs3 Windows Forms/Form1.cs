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
            obe1.Ev_Mod_Valoare += Obe1_Ev_Mod_Valoare;
        }

        private void Obe1_Ev_Mod_Valoare(Element obj)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
