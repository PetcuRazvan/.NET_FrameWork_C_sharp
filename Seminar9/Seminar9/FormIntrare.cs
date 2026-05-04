using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar9
{
    public partial class FormIntrare : Form
    {
        public FormIntrare()
        {
            InitializeComponent();

            IncarcaDispozitii();
        }

        void IncarcaDispozitii()
        {
            var values = Enum.GetValues(typeof(Dispozitie));

            foreach(var value in values)
            {
                DiszpozitieCBX.Items.Add(value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var intrare = new IntrareJurnal();

            intrare.Titlu = textBox1.Text;
            intrare.Continut = richTextBox1.Text;
            intrare.Data = dateTimePicker1.Value;
            intrare.Dispozitie = (Dispozitie)Enum.Parse(typeof(Dispozitie), DiszpozitieCBX.SelectedItem.ToString());
            intrare.EetePrivat = checkBox1.Checked;

            FakeDatabase.Intrari.Add(intrare);

            DialogResult = DialogResult.OK;
        }
    }
}
