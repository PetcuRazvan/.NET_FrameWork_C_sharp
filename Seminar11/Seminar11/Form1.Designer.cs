namespace Seminar11
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
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.pdRaport = new System.Drawing.Printing.PrintDocument();
            this.btnGenereazaRaport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(12, 12);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowHeadersWidth = 62;
            this.dgvStudenti.RowTemplate.Height = 28;
            this.dgvStudenti.Size = new System.Drawing.Size(776, 379);
            this.dgvStudenti.TabIndex = 0;
            // 
            // pdRaport
            // 
            this.pdRaport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdRaport_PrintPage);
            // 
            // btnGenereazaRaport
            // 
            this.btnGenereazaRaport.Location = new System.Drawing.Point(609, 397);
            this.btnGenereazaRaport.Name = "btnGenereazaRaport";
            this.btnGenereazaRaport.Size = new System.Drawing.Size(169, 41);
            this.btnGenereazaRaport.TabIndex = 1;
            this.btnGenereazaRaport.Text = "Genereaza raport";
            this.btnGenereazaRaport.UseVisualStyleBackColor = true;
            this.btnGenereazaRaport.Click += new System.EventHandler(this.btnGenereazaRaport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenereazaRaport);
            this.Controls.Add(this.dgvStudenti);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Drawing.Printing.PrintDocument pdRaport;
        private System.Windows.Forms.Button btnGenereazaRaport;
    }
}

