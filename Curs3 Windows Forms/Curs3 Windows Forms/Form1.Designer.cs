namespace Curs3_Windows_Forms
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.e1 = new System.Windows.Forms.TextBox();
            this.pe1 = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(28, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Apasa-ma";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // e1
            // 
            this.e1.Location = new System.Drawing.Point(28, 62);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(285, 26);
            this.e1.TabIndex = 1;
            this.e1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.e1_KeyPress);
            // 
            // pe1
            // 
            this.pe1.BackColor = System.Drawing.SystemColors.Window;
            this.pe1.Location = new System.Drawing.Point(28, 183);
            this.pe1.Name = "pe1";
            this.pe1.ReadOnly = true;
            this.pe1.Size = new System.Drawing.Size(285, 26);
            this.pe1.TabIndex = 2;
            // 
            // lb
            // 
            this.lb.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 23;
            this.lb.Location = new System.Drawing.Point(28, 245);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(285, 188);
            this.lb.TabIndex = 3;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 496);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.pe1);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox e1;
        private System.Windows.Forms.TextBox pe1;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.ErrorProvider err;
    }
}

