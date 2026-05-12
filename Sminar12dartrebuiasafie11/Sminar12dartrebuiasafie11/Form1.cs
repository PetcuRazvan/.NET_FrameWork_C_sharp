using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sminar12dartrebuiasafie11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listaTaskuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var form in this.MdiChildren)
            {
                if (form is FormLista)
                {
                    form.Activate(); //pune focusul pe form
                    return;
                }
            }

            var formLista = new FormLista();
            formLista.MdiParent = this;
            formLista.Show();
        }

        private void taskNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var form in this.MdiChildren)
            {
                if (form is FormTaskNou)
                {
                    form.Activate(); //pune focusul pe form
                    return;
                }
            }

            var formTaskNou = new FormTaskNou();
            formTaskNou.MdiParent = this;
            formTaskNou.Show();
        }
    }
}
