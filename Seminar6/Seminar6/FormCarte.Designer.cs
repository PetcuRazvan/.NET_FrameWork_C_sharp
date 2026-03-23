namespace Seminar6
{
    partial class FormCarte
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
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.nmrAnAparitie = new System.Windows.Forms.NumericUpDown();
            this.cmbGen = new System.Windows.Forms.ComboBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAnAparitie = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.epCarti = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmrAnAparitie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCarti)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(108, 12);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(308, 26);
            this.txtTitlu.TabIndex = 0;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(108, 44);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(308, 26);
            this.txtAutor.TabIndex = 1;
            // 
            // nmrAnAparitie
            // 
            this.nmrAnAparitie.Location = new System.Drawing.Point(108, 77);
            this.nmrAnAparitie.Name = "nmrAnAparitie";
            this.nmrAnAparitie.Size = new System.Drawing.Size(308, 26);
            this.nmrAnAparitie.TabIndex = 2;
            // 
            // cmbGen
            // 
            this.cmbGen.FormattingEnabled = true;
            this.cmbGen.Location = new System.Drawing.Point(108, 110);
            this.cmbGen.Name = "cmbGen";
            this.cmbGen.Size = new System.Drawing.Size(309, 28);
            this.cmbGen.TabIndex = 3;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(12, 18);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(38, 20);
            this.lblTitlu.TabIndex = 4;
            this.lblTitlu.Text = "Titlu";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(12, 50);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(48, 20);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Text = "Autor";
            // 
            // lblAnAparitie
            // 
            this.lblAnAparitie.AutoSize = true;
            this.lblAnAparitie.Location = new System.Drawing.Point(12, 83);
            this.lblAnAparitie.Name = "lblAnAparitie";
            this.lblAnAparitie.Size = new System.Drawing.Size(85, 20);
            this.lblAnAparitie.TabIndex = 6;
            this.lblAnAparitie.Text = "An aparitie";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(12, 118);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(40, 20);
            this.lblGen.TabIndex = 7;
            this.lblGen.Text = "Gen";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(190, 144);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(106, 33);
            this.btnSalveaza.TabIndex = 8;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(315, 144);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(102, 33);
            this.btnAnuleaza.TabIndex = 9;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            // 
            // epCarti
            // 
            this.epCarti.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epCarti.ContainerControl = this;
            // 
            // FormCarte
            // 
            this.AcceptButton = this.btnAnuleaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(472, 200);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.lblAnAparitie);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.cmbGen);
            this.Controls.Add(this.nmrAnAparitie);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitlu);
            this.Name = "FormCarte";
            this.Text = "FormCarte";
            ((System.ComponentModel.ISupportInitialize)(this.nmrAnAparitie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCarti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.NumericUpDown nmrAnAparitie;
        private System.Windows.Forms.ComboBox cmbGen;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblAnAparitie;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider epCarti;
    }
}