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
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
            lvTaskuri.View = View.Details;
            lvTaskuri.FullRowSelect = true;
            lvTaskuri.MultiSelect = false;

            var latime = lvTaskuri.ClientSize.Width;

            lvTaskuri.Items.Clear();
            lvTaskuri.Columns.Add("Titlu", latime / 5);
            lvTaskuri.Columns.Add("Descriere", latime / 5);
            lvTaskuri.Columns.Add("Prioritate", latime / 5);
            lvTaskuri.Columns.Add("Data creare", latime / 5);
            lvTaskuri.Columns.Add("Efectuat", latime / 5);

            RefreshLista();
        }

        private void RefreshLista()
        {
            lvTaskuri.Items.Clear();

            foreach( var task in FakeDatabase.Taskuri)
            {
                var item = new ListViewItem(task.Titlu);
                item.SubItems.Add(task.Descriere);
                item.SubItems.Add(task.Prioritate.ToString());
                item.SubItems.Add(task.DataCreare.ToString("dd.MM.yyyy"));
                item.SubItems.Add(task.Efectuat ? "Efectuat" : "In desfasurare");
                item.Tag = task;

                if (task.Efectuat)
                {
                    item.Font = new Font("Arial", 10, FontStyle.Italic);
                }
                else
                {
                    item.Font = new Font ("Arial", 10, FontStyle.Bold);
                }

                lvTaskuri.Items.Add(item);
            }
        }

        private void lvTaskuri_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            var info = lvTaskuri.HitTest(e.X, e.Y);
            if (info == null) return;

            var point = new Point(e.X + 50, e.Y + 110);
            cmsTask.Show(point);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var task = lvTaskuri.SelectedItems[0].Tag as TodoTask;

            if (MessageBox.Show($"Sunteti sigur ca vreti sa stergeti \"{task.Titlu}\"", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FakeDatabase.Taskuri.Remove(task);

            }
            RefreshLista();
        }

        private void marcheazaCaEfectuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var task = lvTaskuri.SelectedItems[0].Tag as TodoTask; //luam adresa la task

            if (task != null)
            {
                task.Efectuat = true;
                RefreshLista();
            }
        }

        private void redeschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var task = lvTaskuri.SelectedItems[0].Tag as TodoTask; //luam adresa la task

            if (task != null)
            {
                task.Efectuat = false;
                RefreshLista();
            }
        }

        private void cmsTask_Opening(object sender, CancelEventArgs e)
        {
            var task = lvTaskuri.SelectedItems[0].Tag as TodoTask;

            if (task != null)
            {
                if (task.Efectuat)
                {
                    cmsTask.Items[0].Enabled = false;
                    cmsTask.Items[1].Enabled = true;
                }
                else
                {
                    cmsTask.Items[1].Enabled = false;
                    cmsTask.Items[0].Enabled = true;
                }
            }
        }
    }
}
