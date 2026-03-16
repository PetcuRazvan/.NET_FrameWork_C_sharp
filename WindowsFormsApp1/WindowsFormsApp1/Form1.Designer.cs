namespace WindowsFormsApp1
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
            this.dvgAngajati = new System.Windows.Forms.DataGridView();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgAngajati
            // 
            this.dvgAngajati.AllowUserToAddRows = false;
            this.dvgAngajati.AllowUserToDeleteRows = false;
            this.dvgAngajati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAngajati.Location = new System.Drawing.Point(12, 52);
            this.dvgAngajati.MultiSelect = false;
            this.dvgAngajati.Name = "dvgAngajati";
            this.dvgAngajati.ReadOnly = true;
            this.dvgAngajati.RowHeadersWidth = 62;
            this.dvgAngajati.RowTemplate.Height = 28;
            this.dvgAngajati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAngajati.Size = new System.Drawing.Size(762, 393);
            this.dvgAngajati.TabIndex = 0;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(12, 465);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(94, 45);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Location = new System.Drawing.Point(112, 465);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(110, 45);
            this.btnEditeaza.TabIndex = 2;
            this.btnEditeaza.Text = "Editeaza";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(228, 465);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(102, 45);
            this.btnSterge.TabIndex = 3;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 534);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dvgAngajati);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvgAngajati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgAngajati;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.Button btnSterge;
    }
}

