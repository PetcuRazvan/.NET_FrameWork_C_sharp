namespace Seminar9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IntrariListView = new System.Windows.Forms.ListView();
            this.jurnalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaIntrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.jurnalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaBinarToolStripMenuItem,
            this.salveazaXMLToolStripMenuItem,
            this.deschideBinarToolStripMenuItem,
            this.deschideXMLToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salveazaBinarToolStripMenuItem
            // 
            this.salveazaBinarToolStripMenuItem.Name = "salveazaBinarToolStripMenuItem";
            this.salveazaBinarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salveazaBinarToolStripMenuItem.Text = "Salveaza binar";
            this.salveazaBinarToolStripMenuItem.Click += new System.EventHandler(this.salveazaBinarToolStripMenuItem_Click);
            // 
            // salveazaXMLToolStripMenuItem
            // 
            this.salveazaXMLToolStripMenuItem.Name = "salveazaXMLToolStripMenuItem";
            this.salveazaXMLToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salveazaXMLToolStripMenuItem.Text = "Salveaza XML";
            this.salveazaXMLToolStripMenuItem.Click += new System.EventHandler(this.salveazaXMLToolStripMenuItem_Click);
            // 
            // deschideBinarToolStripMenuItem
            // 
            this.deschideBinarToolStripMenuItem.Name = "deschideBinarToolStripMenuItem";
            this.deschideBinarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deschideBinarToolStripMenuItem.Text = "Deschide binar";
            this.deschideBinarToolStripMenuItem.Click += new System.EventHandler(this.deschideBinarToolStripMenuItem_Click);
            // 
            // deschideXMLToolStripMenuItem
            // 
            this.deschideXMLToolStripMenuItem.Name = "deschideXMLToolStripMenuItem";
            this.deschideXMLToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deschideXMLToolStripMenuItem.Text = "Deschide XML";
            this.deschideXMLToolStripMenuItem.Click += new System.EventHandler(this.deschideXMLToolStripMenuItem_Click);
            // 
            // IntrariListView
            // 
            this.IntrariListView.HideSelection = false;
            this.IntrariListView.Location = new System.Drawing.Point(12, 36);
            this.IntrariListView.Name = "IntrariListView";
            this.IntrariListView.Size = new System.Drawing.Size(570, 576);
            this.IntrariListView.TabIndex = 1;
            this.IntrariListView.UseCompatibleStateImageBehavior = false;
            // 
            // jurnalToolStripMenuItem
            // 
            this.jurnalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaIntrareToolStripMenuItem});
            this.jurnalToolStripMenuItem.Name = "jurnalToolStripMenuItem";
            this.jurnalToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.jurnalToolStripMenuItem.Text = "Jurnal";
            // 
            // adaugaIntrareToolStripMenuItem
            // 
            this.adaugaIntrareToolStripMenuItem.Name = "adaugaIntrareToolStripMenuItem";
            this.adaugaIntrareToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.adaugaIntrareToolStripMenuItem.Text = "Adauga Intrare";
            this.adaugaIntrareToolStripMenuItem.Click += new System.EventHandler(this.adaugaIntrareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 624);
            this.Controls.Add(this.IntrariListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideXMLToolStripMenuItem;
        private System.Windows.Forms.ListView IntrariListView;
        private System.Windows.Forms.ToolStripMenuItem jurnalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaIntrareToolStripMenuItem;
    }
}

