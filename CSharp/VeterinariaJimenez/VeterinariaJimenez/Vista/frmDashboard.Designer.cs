namespace VeterinariaJimenez.Vista
{
    partial class frmDashboard
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
            this.menuStripDashboard = new System.Windows.Forms.MenuStrip();
            this.animalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripDashboard
            // 
            this.menuStripDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalesToolStripMenuItem});
            this.menuStripDashboard.Location = new System.Drawing.Point(0, 0);
            this.menuStripDashboard.Name = "menuStripDashboard";
            this.menuStripDashboard.Size = new System.Drawing.Size(804, 24);
            this.menuStripDashboard.TabIndex = 0;
            this.menuStripDashboard.Text = "menuStrip1";
            // 
            // animalesToolStripMenuItem
            // 
            this.animalesToolStripMenuItem.Name = "animalesToolStripMenuItem";
            this.animalesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.animalesToolStripMenuItem.Text = "Animales";
            this.animalesToolStripMenuItem.Click += new System.EventHandler(this.animalesToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 430);
            this.Controls.Add(this.menuStripDashboard);
            this.MainMenuStrip = this.menuStripDashboard;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStripDashboard.ResumeLayout(false);
            this.menuStripDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripDashboard;
        private System.Windows.Forms.ToolStripMenuItem animalesToolStripMenuItem;
    }
}