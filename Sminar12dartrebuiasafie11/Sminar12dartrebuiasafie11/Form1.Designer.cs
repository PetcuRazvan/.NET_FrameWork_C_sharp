namespace Sminar12dartrebuiasafie11
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taskuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaTaskuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskuriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taskuriToolStripMenuItem
            // 
            this.taskuriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaTaskuriToolStripMenuItem,
            this.taskNouToolStripMenuItem});
            this.taskuriToolStripMenuItem.Name = "taskuriToolStripMenuItem";
            this.taskuriToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.taskuriToolStripMenuItem.Text = "Task-uri";
            // 
            // listaTaskuriToolStripMenuItem
            // 
            this.listaTaskuriToolStripMenuItem.Name = "listaTaskuriToolStripMenuItem";
            this.listaTaskuriToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listaTaskuriToolStripMenuItem.Text = "Lista Task-uri";
            this.listaTaskuriToolStripMenuItem.Click += new System.EventHandler(this.listaTaskuriToolStripMenuItem_Click);
            // 
            // taskNouToolStripMenuItem
            // 
            this.taskNouToolStripMenuItem.Name = "taskNouToolStripMenuItem";
            this.taskNouToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.taskNouToolStripMenuItem.Text = "Task nou";
            this.taskNouToolStripMenuItem.Click += new System.EventHandler(this.taskNouToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 564);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taskuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaTaskuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskNouToolStripMenuItem;
    }
}

