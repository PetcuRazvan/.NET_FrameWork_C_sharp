namespace Curs5_FirmaApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocheazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatiiSalariatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbfs = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripMenuItem,
            this.operatiiSalariatiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deschideToolStripMenuItem,
            this.stocheazaToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.dateToolStripMenuItem.Text = "Date";
            // 
            // deschideToolStripMenuItem
            // 
            this.deschideToolStripMenuItem.Name = "deschideToolStripMenuItem";
            this.deschideToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.deschideToolStripMenuItem.Text = "Deschide";
            // 
            // stocheazaToolStripMenuItem
            // 
            this.stocheazaToolStripMenuItem.Name = "stocheazaToolStripMenuItem";
            this.stocheazaToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.stocheazaToolStripMenuItem.Text = "Stocheaza";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // operatiiSalariatiToolStripMenuItem
            // 
            this.operatiiSalariatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.operatiiSalariatiToolStripMenuItem.Name = "operatiiSalariatiToolStripMenuItem";
            this.operatiiSalariatiToolStripMenuItem.Size = new System.Drawing.Size(157, 29);
            this.operatiiSalariatiToolStripMenuItem.Text = "Operatii Salariati";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.adaugaToolStripMenuItem.Tag = "A";
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modificaToolStripMenuItem.Tag = "M";
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.stergeToolStripMenuItem.Text = "Sterge";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.sbfs});
            this.statusStrip1.Location = new System.Drawing.Point(0, 463);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(843, 32);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 25);
            this.toolStripStatusLabel1.Text = "Fond Salarii";
            // 
            // sbfs
            // 
            this.sbfs.Name = "sbfs";
            this.sbfs.Size = new System.Drawing.Size(22, 25);
            this.sbfs.Text = "0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Iesire";
            this.toolStripButton1.ToolTipText = "Iesire din aplicatie";
            this.toolStripButton1.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Blue;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(0, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(843, 35);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Lista Salariatilor Firmei";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(0, 101);
            this.gv.MultiSelect = false;
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.RowHeadersWidth = 62;
            this.gv.RowTemplate.Height = 28;
            this.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(843, 362);
            this.gv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Marca";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nume si Prenume";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Numar ore";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Salariul orar";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 495);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocheazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatiiSalariatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sbfs;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

