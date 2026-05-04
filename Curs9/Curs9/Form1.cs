using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs9
{
    public partial class Form1 : Form
    {
        List<int> lv = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 3) //deja se numara rowul cu column name si rowul urmator in care o sa pun valori
            {
                lv = new List<int>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        lv.Add(int.Parse(row.Cells[0].Value.ToString()));

                    }
                }
            }
            else
            {
                lv = null;
            }

            gr.Valori = lv;
        }
    }
}
