namespace Seminar6
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
            this.lvCarti = new System.Windows.Forms.ListView();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCarti
            // 
            this.lvCarti.HideSelection = false;
            this.lvCarti.Location = new System.Drawing.Point(12, 12);
            this.lvCarti.Name = "lvCarti";
            this.lvCarti.Size = new System.Drawing.Size(978, 452);
            this.lvCarti.TabIndex = 0;
            this.lvCarti.UseCompatibleStateImageBehavior = false;
            this.lvCarti.View = System.Windows.Forms.View.Details;
            this.lvCarti.SelectedIndexChanged += new System.EventHandler(this.lvCarti_SelectedIndexChanged);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(13, 471);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(96, 31);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Location = new System.Drawing.Point(116, 471);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(115, 31);
            this.btnEditeaza.TabIndex = 2;
            this.btnEditeaza.Text = "Editeaza";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 577);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lvCarti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCarti;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnEditeaza;
    }
}

