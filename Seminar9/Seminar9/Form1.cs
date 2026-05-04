using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Seminar9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IntrariListView.View = View.Details;
            IntrariListView.Columns.Add("Titlu", 200);
            IntrariListView.Columns.Add("Continut", 200);

            IntrariListView.FullRowSelect = true;
            IntrariListView.MultiSelect = false;

            IncarcaJurnal();
        }

        private void IncarcaJurnal()
        {
            IntrariListView.Items.Clear();
            foreach(var item in FakeDatabase.Intrari)
            {
                var listViewItem = new ListViewItem();
                listViewItem.Tag = item;
                listViewItem.Text = item.Titlu;
                listViewItem.SubItems.Add(item.Continut);

                IntrariListView.Items.Add(listViewItem);
            }
        }

        private void adaugaIntrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formIntrare = new FormIntrare())
            {
                if (formIntrare.ShowDialog() == DialogResult.OK)
                {
                    IncarcaJurnal();
                }
            }
        }

        private void salveazaBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Binary files (*.bin)|*.bin|All files|*.*";  //daca aleg binary files, imi filtreaza dupa ce am dupa bara, daca aleg all files, imi filtreaza dupa *.*, adica tpate fisierele
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = saveFileDialog.FileName;

                    var formatter = new BinaryFormatter();
                    using (var stream = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(stream, FakeDatabase.Intrari);
                        MessageBox.Show("Serializarea s-a efectuat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void deschideBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Binary files (*.bin)|*.bin|All files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var formatter = new BinaryFormatter();
                    using (var stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        FakeDatabase.Intrari = (List<IntrareJurnal>)formatter.Deserialize(stream);
                        IncarcaJurnal();

                    }
                }
            }

        }

        private void salveazaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML file (*.xml)|*.xml|All files|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var serializer = new XmlSerializer(typeof(Jurnal));
                    using (var stream = new StreamWriter(saveFileDialog.FileName))
                    {
                        serializer.Serialize(stream, new Jurnal()
                        {
                            Intrari = FakeDatabase.Intrari
                        });

                        MessageBox.Show("Serializarea s-a efectuat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void deschideXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML file (*.xml)|*.xml|All files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var serializer = new XmlSerializer(typeof(Jurnal));
                    using (var stream = new StreamReader(openFileDialog.FileName))
                    {
                        var jurnal = (Jurnal)serializer.Deserialize(stream);
                        FakeDatabase.Intrari = jurnal.Intrari;
                        IncarcaJurnal();
                    }
                }
            }
        }
    }
}
