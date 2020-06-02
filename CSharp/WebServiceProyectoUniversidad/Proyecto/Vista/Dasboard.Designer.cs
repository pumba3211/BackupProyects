namespace RecursosHumanos
{
    partial class Dasboard
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
            this.menunicio = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menunicio
            // 
            this.menunicio.Name = "menunicio";
            this.menunicio.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnnosToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.aulasToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.administrativoToolStripMenuItem,
            this.carreraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnnosToolStripMenuItem
            // 
            this.alumnnosToolStripMenuItem.Name = "alumnnosToolStripMenuItem";
            this.alumnnosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.alumnnosToolStripMenuItem.Text = "Alumnnos";
            this.alumnnosToolStripMenuItem.Click += new System.EventHandler(this.alumnnosToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // aulasToolStripMenuItem
            // 
            this.aulasToolStripMenuItem.Name = "aulasToolStripMenuItem";
            this.aulasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aulasToolStripMenuItem.Text = "Aulas";
            this.aulasToolStripMenuItem.Click += new System.EventHandler(this.aulasToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.gruposToolStripMenuItem.Text = "Grupos";
            this.gruposToolStripMenuItem.Click += new System.EventHandler(this.gruposToolStripMenuItem_Click);
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.administrativoToolStripMenuItem.Text = "Administrativo";
            this.administrativoToolStripMenuItem.Click += new System.EventHandler(this.administrativoToolStripMenuItem_Click);
            // 
            // carreraToolStripMenuItem
            // 
            this.carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            this.carreraToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.carreraToolStripMenuItem.Text = "Carrera";
            this.carreraToolStripMenuItem.Click += new System.EventHandler(this.carreraToolStripMenuItem_Click);
            // 
            // Dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 325);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Dasboard";
            this.Text = "Dasboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menunicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carreraToolStripMenuItem;
    }
}