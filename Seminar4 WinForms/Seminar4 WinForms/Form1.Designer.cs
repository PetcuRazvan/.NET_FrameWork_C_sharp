namespace Seminar4_WinForms
{
    partial class Form1 //partial inseamna ca putem imparti clasa in mai multe fisiere
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdaugaContact = new System.Windows.Forms.Button();
            this.chkNotificariActive = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lstContacte = new System.Windows.Forms.ListBox();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnAdaugaContact);
            this.groupBox1.Controls.Add(this.chkNotificariActive);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblNume);
            this.groupBox1.Controls.Add(this.txtNume);
            this.groupBox1.Controls.Add(this.txtPrenume);
            this.groupBox1.Controls.Add(this.lblPrenume);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Contact";
            // 
            // btnAdaugaContact
            // 
            this.btnAdaugaContact.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdaugaContact.Location = new System.Drawing.Point(85, 200);
            this.btnAdaugaContact.Name = "btnAdaugaContact";
            this.btnAdaugaContact.Size = new System.Drawing.Size(166, 40);
            this.btnAdaugaContact.TabIndex = 9;
            this.btnAdaugaContact.Text = "Adauga contact";
            this.btnAdaugaContact.UseVisualStyleBackColor = false;
            this.btnAdaugaContact.Click += new System.EventHandler(this.btnAdaugaContact_Click);
            // 
            // chkNotificariActive
            // 
            this.chkNotificariActive.AutoSize = true;
            this.chkNotificariActive.Location = new System.Drawing.Point(85, 169);
            this.chkNotificariActive.Name = "chkNotificariActive";
            this.chkNotificariActive.Size = new System.Drawing.Size(141, 24);
            this.chkNotificariActive.TabIndex = 8;
            this.chkNotificariActive.Text = "Notificari active";
            this.chkNotificariActive.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(85, 104);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(166, 26);
            this.txtTelefon.TabIndex = 5;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(6, 110);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(62, 20);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(6, 78);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(51, 20);
            this.lblNume.TabIndex = 3;
            this.lblNume.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(85, 72);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(166, 26);
            this.txtNume.TabIndex = 2;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(85, 39);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(166, 26);
            this.txtPrenume.TabIndex = 1;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(6, 45);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(73, 20);
            this.lblPrenume.TabIndex = 0;
            this.lblPrenume.Text = "Prenume";
            // 
            // lstContacte
            // 
            this.lstContacte.FormattingEnabled = true;
            this.lstContacte.ItemHeight = 20;
            this.lstContacte.Location = new System.Drawing.Point(283, 52);
            this.lstContacte.Name = "lstContacte";
            this.lstContacte.Size = new System.Drawing.Size(283, 384);
            this.lstContacte.TabIndex = 1;
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(283, 12);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(283, 26);
            this.txtCautare.TabIndex = 2;
            this.txtCautare.TextChanged += new System.EventHandler(this.txtCautare_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.lstContacte);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registru Contact";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.CheckBox chkNotificariActive;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Button btnAdaugaContact;
        private System.Windows.Forms.ListBox lstContacte;
        private System.Windows.Forms.TextBox txtCautare;
    }
}

