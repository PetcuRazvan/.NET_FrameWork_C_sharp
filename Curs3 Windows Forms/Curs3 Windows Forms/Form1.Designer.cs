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
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.vizualizare = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.vizualizare.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(74, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Apasa-ma";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // e1
            // 
            this.e1.Location = new System.Drawing.Point(74, 13);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(285, 26);
            this.e1.TabIndex = 1;
            this.e1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.e1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.e1_KeyPress);
            this.e1.Validating += new System.ComponentModel.CancelEventHandler(this.e1_Validating);
            // 
            // pe1
            // 
            this.pe1.BackColor = System.Drawing.SystemColors.Window;
            this.pe1.Location = new System.Drawing.Point(74, 86);
            this.pe1.Name = "pe1";
            this.pe1.ReadOnly = true;
            this.pe1.Size = new System.Drawing.Size(285, 26);
            this.pe1.TabIndex = 2;
            this.pe1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb
            // 
            this.lb.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 23;
            this.lb.Location = new System.Drawing.Point(12, 119);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(415, 119);
            this.lb.TabIndex = 3;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(12, 244);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(285, 164);
            this.lv.TabIndex = 4;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numarul";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Patratul";
            this.columnHeader2.Width = 150;
            // 
            // vizualizare
            // 
            this.vizualizare.Controls.Add(this.radioButton3);
            this.vizualizare.Controls.Add(this.radioButton2);
            this.vizualizare.Controls.Add(this.radioButton1);
            this.vizualizare.Location = new System.Drawing.Point(304, 244);
            this.vizualizare.Name = "vizualizare";
            this.vizualizare.Size = new System.Drawing.Size(123, 164);
            this.vizualizare.TabIndex = 5;
            this.vizualizare.TabStop = false;
            this.vizualizare.Text = "Vizualizare";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "D";
            this.radioButton1.Text = "tabel";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Tag = "L";
            this.radioButton2.Text = "lista";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 96);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Tag = "T";
            this.radioButton3.Text = "titlu";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 419);
            this.Controls.Add(this.vizualizare);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.pe1);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.vizualizare.ResumeLayout(false);
            this.vizualizare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox e1;
        private System.Windows.Forms.TextBox pe1;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox vizualizare;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

