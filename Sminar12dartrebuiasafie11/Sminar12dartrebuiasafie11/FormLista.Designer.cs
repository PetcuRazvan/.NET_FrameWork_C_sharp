namespace Sminar12dartrebuiasafie11
{
    partial class FormLista
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
            this.lvTaskuri = new System.Windows.Forms.ListView();
            this.cmsTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.marcheazaCaEfectuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redeschideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTaskuri
            // 
            this.lvTaskuri.HideSelection = false;
            this.lvTaskuri.Location = new System.Drawing.Point(12, 12);
            this.lvTaskuri.Name = "lvTaskuri";
            this.lvTaskuri.Size = new System.Drawing.Size(776, 426);
            this.lvTaskuri.TabIndex = 0;
            this.lvTaskuri.UseCompatibleStateImageBehavior = false;
            this.lvTaskuri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvTaskuri_MouseClick);
            // 
            // cmsTask
            // 
            this.cmsTask.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcheazaCaEfectuatToolStripMenuItem,
            this.redeschideToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.cmsTask.Name = "cmsTask";
            this.cmsTask.Size = new System.Drawing.Size(259, 133);
            this.cmsTask.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTask_Opening);
            // 
            // marcheazaCaEfectuatToolStripMenuItem
            // 
            this.marcheazaCaEfectuatToolStripMenuItem.Name = "marcheazaCaEfectuatToolStripMenuItem";
            this.marcheazaCaEfectuatToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.marcheazaCaEfectuatToolStripMenuItem.Text = "Marcheaza ca efectuat";
            this.marcheazaCaEfectuatToolStripMenuItem.Click += new System.EventHandler(this.marcheazaCaEfectuatToolStripMenuItem_Click);
            // 
            // redeschideToolStripMenuItem
            // 
            this.redeschideToolStripMenuItem.Name = "redeschideToolStripMenuItem";
            this.redeschideToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.redeschideToolStripMenuItem.Text = "Redeschide";
            this.redeschideToolStripMenuItem.Click += new System.EventHandler(this.redeschideToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvTaskuri);
            this.Name = "FormLista";
            this.Text = "FormLista";
            this.cmsTask.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTaskuri;
        private System.Windows.Forms.ContextMenuStrip cmsTask;
        private System.Windows.Forms.ToolStripMenuItem marcheazaCaEfectuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redeschideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
    }
}