namespace TreeView
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
            this.tvAngajati = new System.Windows.Forms.TreeView();
            this.lblNumeComplet = new System.Windows.Forms.Label();
            this.lblFunctie = new System.Windows.Forms.Label();
            this.lblDepartament = new System.Windows.Forms.Label();
            this.lblDataAngajarii = new System.Windows.Forms.Label();
            this.lblSalariu = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.llblManager = new System.Windows.Forms.LinkLabel();
            this.pbAngajati = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // tvAngajati
            // 
            this.tvAngajati.Location = new System.Drawing.Point(12, 12);
            this.tvAngajati.Name = "tvAngajati";
            this.tvAngajati.Size = new System.Drawing.Size(276, 426);
            this.tvAngajati.TabIndex = 0;
            this.tvAngajati.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAngajati_AfterSelect);
            // 
            // lblNumeComplet
            // 
            this.lblNumeComplet.AutoSize = true;
            this.lblNumeComplet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeComplet.Location = new System.Drawing.Point(294, 12);
            this.lblNumeComplet.Name = "lblNumeComplet";
            this.lblNumeComplet.Size = new System.Drawing.Size(98, 32);
            this.lblNumeComplet.TabIndex = 1;
            this.lblNumeComplet.Text = "label1";
            // 
            // lblFunctie
            // 
            this.lblFunctie.AutoSize = true;
            this.lblFunctie.Location = new System.Drawing.Point(294, 44);
            this.lblFunctie.Name = "lblFunctie";
            this.lblFunctie.Size = new System.Drawing.Size(51, 20);
            this.lblFunctie.TabIndex = 2;
            this.lblFunctie.Text = "label1";
            // 
            // lblDepartament
            // 
            this.lblDepartament.AutoSize = true;
            this.lblDepartament.Location = new System.Drawing.Point(295, 85);
            this.lblDepartament.Name = "lblDepartament";
            this.lblDepartament.Size = new System.Drawing.Size(51, 20);
            this.lblDepartament.TabIndex = 3;
            this.lblDepartament.Text = "label1";
            // 
            // lblDataAngajarii
            // 
            this.lblDataAngajarii.AutoSize = true;
            this.lblDataAngajarii.Location = new System.Drawing.Point(298, 122);
            this.lblDataAngajarii.Name = "lblDataAngajarii";
            this.lblDataAngajarii.Size = new System.Drawing.Size(51, 20);
            this.lblDataAngajarii.TabIndex = 4;
            this.lblDataAngajarii.Text = "label1";
            // 
            // lblSalariu
            // 
            this.lblSalariu.AutoSize = true;
            this.lblSalariu.Location = new System.Drawing.Point(295, 165);
            this.lblSalariu.Name = "lblSalariu";
            this.lblSalariu.Size = new System.Drawing.Size(51, 20);
            this.lblSalariu.TabIndex = 5;
            this.lblSalariu.Text = "label1";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(295, 198);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "label1";
            // 
            // llblManager
            // 
            this.llblManager.AutoSize = true;
            this.llblManager.Location = new System.Drawing.Point(295, 234);
            this.llblManager.Name = "llblManager";
            this.llblManager.Size = new System.Drawing.Size(80, 20);
            this.llblManager.TabIndex = 7;
            this.llblManager.TabStop = true;
            this.llblManager.Text = "linkLabel1";
            this.llblManager.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblManager_LinkClicked);
            // 
            // pbAngajati
            // 
            this.pbAngajati.Location = new System.Drawing.Point(550, 12);
            this.pbAngajati.Name = "pbAngajati";
            this.pbAngajati.Size = new System.Drawing.Size(238, 276);
            this.pbAngajati.TabIndex = 8;
            this.pbAngajati.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbAngajati);
            this.Controls.Add(this.llblManager);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSalariu);
            this.Controls.Add(this.lblDataAngajarii);
            this.Controls.Add(this.lblDepartament);
            this.Controls.Add(this.lblFunctie);
            this.Controls.Add(this.lblNumeComplet);
            this.Controls.Add(this.tvAngajati);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAngajati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvAngajati;
        private System.Windows.Forms.Label lblNumeComplet;
        private System.Windows.Forms.Label lblFunctie;
        private System.Windows.Forms.Label lblDepartament;
        private System.Windows.Forms.Label lblDataAngajarii;
        private System.Windows.Forms.Label lblSalariu;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.LinkLabel llblManager;
        private System.Windows.Forms.PictureBox pbAngajati;
    }
}

