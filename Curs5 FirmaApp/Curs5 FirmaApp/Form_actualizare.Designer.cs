namespace Curs5_FirmaApp
{
    partial class Form_actualizare
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSalariuOra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNrOre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumePrenume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(162, 41);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(206, 26);
            this.tbMarca.TabIndex = 1;
            this.tbMarca.Text = "0";
            this.tbMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(42, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(254, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Anuleaza";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbSalariuOra
            // 
            this.tbSalariuOra.Location = new System.Drawing.Point(162, 141);
            this.tbSalariuOra.Name = "tbSalariuOra";
            this.tbSalariuOra.Size = new System.Drawing.Size(206, 26);
            this.tbSalariuOra.TabIndex = 5;
            this.tbSalariuOra.Text = "0";
            this.tbSalariuOra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "salariu/ora";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNrOre
            // 
            this.tbNrOre.Location = new System.Drawing.Point(162, 109);
            this.tbNrOre.Name = "tbNrOre";
            this.tbNrOre.Size = new System.Drawing.Size(206, 26);
            this.tbNrOre.TabIndex = 7;
            this.tbNrOre.Text = "0";
            this.tbNrOre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "nr ore";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNumePrenume
            // 
            this.tbNumePrenume.Location = new System.Drawing.Point(162, 73);
            this.tbNumePrenume.Name = "tbNumePrenume";
            this.tbNumePrenume.Size = new System.Drawing.Size(206, 26);
            this.tbNumePrenume.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nume Prenume";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_actualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 335);
            this.Controls.Add(this.tbNumePrenume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNrOre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSalariuOra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_actualizare";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbSalariuOra;
        public System.Windows.Forms.TextBox tbNrOre;
        public System.Windows.Forms.TextBox tbNumePrenume;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbMarca;
        public System.Windows.Forms.Button button1;
    }
}