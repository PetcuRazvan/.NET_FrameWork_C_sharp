namespace WindowsFormsApp1
{
    partial class FormAngajat
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
            this.components = new System.ComponentModel.Container();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblDataAngajarii = new System.Windows.Forms.Label();
            this.lblSalariu = new System.Windows.Forms.Label();
            this.lblDepartament = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.cmbDepartament = new System.Windows.Forms.ComboBox();
            this.txtSalariu = new System.Windows.Forms.TextBox();
            this.dtpDataAngajarii = new System.Windows.Forms.DateTimePicker();
            this.chkEstePermanent = new System.Windows.Forms.CheckBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.epFormAngajat = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epFormAngajat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(12, 15);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(51, 20);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblDataAngajarii
            // 
            this.lblDataAngajarii.AutoSize = true;
            this.lblDataAngajarii.Location = new System.Drawing.Point(12, 145);
            this.lblDataAngajarii.Name = "lblDataAngajarii";
            this.lblDataAngajarii.Size = new System.Drawing.Size(109, 20);
            this.lblDataAngajarii.TabIndex = 1;
            this.lblDataAngajarii.Text = "Data Angajarii";
            // 
            // lblSalariu
            // 
            this.lblSalariu.AutoSize = true;
            this.lblSalariu.Location = new System.Drawing.Point(12, 113);
            this.lblSalariu.Name = "lblSalariu";
            this.lblSalariu.Size = new System.Drawing.Size(58, 20);
            this.lblSalariu.TabIndex = 2;
            this.lblSalariu.Text = "Salariu";
            // 
            // lblDepartament
            // 
            this.lblDepartament.AutoSize = true;
            this.lblDepartament.Location = new System.Drawing.Point(12, 81);
            this.lblDepartament.Name = "lblDepartament";
            this.lblDepartament.Size = new System.Drawing.Size(103, 20);
            this.lblDepartament.TabIndex = 3;
            this.lblDepartament.Text = "Departament";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(12, 47);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(73, 20);
            this.lblPrenume.TabIndex = 4;
            this.lblPrenume.Text = "Prenume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(149, 9);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(315, 26);
            this.txtNume.TabIndex = 5;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(149, 41);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(315, 26);
            this.txtPrenume.TabIndex = 6;
            // 
            // cmbDepartament
            // 
            this.cmbDepartament.FormattingEnabled = true;
            this.cmbDepartament.Items.AddRange(new object[] {
            "HR",
            "IT",
            "Edu",
            "FR",
            "IP"});
            this.cmbDepartament.Location = new System.Drawing.Point(149, 73);
            this.cmbDepartament.Name = "cmbDepartament";
            this.cmbDepartament.Size = new System.Drawing.Size(315, 28);
            this.cmbDepartament.TabIndex = 7;
            // 
            // txtSalariu
            // 
            this.txtSalariu.Location = new System.Drawing.Point(149, 107);
            this.txtSalariu.Name = "txtSalariu";
            this.txtSalariu.Size = new System.Drawing.Size(315, 26);
            this.txtSalariu.TabIndex = 8;
            // 
            // dtpDataAngajarii
            // 
            this.dtpDataAngajarii.Location = new System.Drawing.Point(149, 139);
            this.dtpDataAngajarii.Name = "dtpDataAngajarii";
            this.dtpDataAngajarii.Size = new System.Drawing.Size(315, 26);
            this.dtpDataAngajarii.TabIndex = 9;
            // 
            // chkEstePermanent
            // 
            this.chkEstePermanent.AutoSize = true;
            this.chkEstePermanent.Location = new System.Drawing.Point(149, 171);
            this.chkEstePermanent.Name = "chkEstePermanent";
            this.chkEstePermanent.Size = new System.Drawing.Size(150, 24);
            this.chkEstePermanent.TabIndex = 10;
            this.chkEstePermanent.Text = "Este Permanent";
            this.chkEstePermanent.UseVisualStyleBackColor = true;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(254, 201);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(102, 41);
            this.btnSalveaza.TabIndex = 11;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(362, 201);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(102, 41);
            this.btnAnuleaza.TabIndex = 12;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            // 
            // epFormAngajat
            // 
            this.epFormAngajat.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epFormAngajat.ContainerControl = this;
            // 
            // FormAngajat
            // 
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(507, 262);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.chkEstePermanent);
            this.Controls.Add(this.dtpDataAngajarii);
            this.Controls.Add(this.txtSalariu);
            this.Controls.Add(this.cmbDepartament);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblDepartament);
            this.Controls.Add(this.lblSalariu);
            this.Controls.Add(this.lblDataAngajarii);
            this.Controls.Add(this.lblNume);
            this.Name = "FormAngajat";
            this.Text = "FormAngajat";
            ((System.ComponentModel.ISupportInitialize)(this.epFormAngajat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblDataAngajarii;
        private System.Windows.Forms.Label lblSalariu;
        private System.Windows.Forms.Label lblDepartament;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.ComboBox cmbDepartament;
        private System.Windows.Forms.TextBox txtSalariu;
        private System.Windows.Forms.DateTimePicker dtpDataAngajarii;
        private System.Windows.Forms.CheckBox chkEstePermanent;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider epFormAngajat;
    }
}