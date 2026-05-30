using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IncarcaNivel();
            pbAngajati.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void IncarcaNivel(TreeNode root = null, Angajat manager = null)
        {
            var angajati = FakeDatabase.Angajati.Where(a => a.ManagerId == manager?.Id).ToList();
            foreach( var a in angajati)
            {
                var node = new TreeNode(a.NumeComplet);
                node.Tag = a;

                if (root != null)
                {
                    root.Nodes.Add(node);
                }
                else
                {
                    tvAngajati.Nodes.Add(node);
                }

                IncarcaNivel(node, a);
            }
        }

        private void tvAngajati_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var angajat = e.Node.Tag as Angajat;
            lblNumeComplet.Text = angajat.NumeComplet;
            lblFunctie.Text = $"Functie: {angajat.Functie}";
            lblDepartament.Text = $"Departament: {angajat.Functie}";
            lblDataAngajarii.Text = $"Data Angajarii: {angajat.DataAngajarii.ToString("dd.MM.yyyy")}";
            lblSalariu.Text = $"Salariu: {angajat.Salariu.ToString("F0")}";
            lblEmail.Text = $"Email: {angajat.Email}";

            if (angajat.ManagerId == null)
            {
                llblManager.Visible = false;
            }
            else
            {
                var manager = FakeDatabase.Angajati.First(a => a.Id == angajat.ManagerId);

                llblManager.Visible = true;
                llblManager.Text = $"Manager: {manager.NumeComplet}";
                llblManager.Tag = manager;
            }

            var path = Path.Combine(Application.StartupPath, "Images", angajat.NumeImagine);
            var oldImage = pbAngajati.Image;
            oldImage?.Dispose(); //ar dura prea mult pt ggarbage collector
            
            if (File.Exists(path))
            {
                pbAngajati.Image = Image.FromFile(path);
            }
        }

        private void llblManager_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var manager = llblManager.Tag as Angajat;

            foreach(TreeNode node in tvAngajati.Nodes)
            {
                CautaManager(node, manager);
            }
        }

        private void CautaManager(TreeNode root, Angajat manager)
        {
            if ((root.Tag as Angajat) == manager)
            {
                tvAngajati.SelectedNode = root;
            }
            else
            {
                foreach (TreeNode node in root.Nodes)
                {
                        CautaManager(node, manager);
                }
            }    
        }
    }
}
