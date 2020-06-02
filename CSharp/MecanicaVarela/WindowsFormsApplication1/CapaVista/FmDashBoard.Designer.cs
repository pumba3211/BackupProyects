namespace MecanicaVarela
{
    partial class DashBoard
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
            this.MenuDashboard = new System.Windows.Forms.MenuStrip();
            this.menuItemRepuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemagregarRepuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemeditarRepuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemeliminarRepuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.repuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemagregarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemeditarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemeliminarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuDashboard
            // 
            this.MenuDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRepuestos,
            this.clientesToolStripMenuItem});
            this.MenuDashboard.Location = new System.Drawing.Point(0, 0);
            this.MenuDashboard.Name = "MenuDashboard";
            this.MenuDashboard.Size = new System.Drawing.Size(702, 24);
            this.MenuDashboard.TabIndex = 0;
            this.MenuDashboard.Text = "menuStrip1";
            // 
            // menuItemRepuestos
            // 
            this.menuItemRepuestos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemagregarRepuesto,
            this.MenuItemeditarRepuesto,
            this.MenuItemeliminarRepuesto,
            this.repuestosToolStripMenuItem});
            this.menuItemRepuestos.Name = "menuItemRepuestos";
            this.menuItemRepuestos.Size = new System.Drawing.Size(73, 20);
            this.menuItemRepuestos.Text = "Repuestos";
            this.menuItemRepuestos.Click += new System.EventHandler(this.ssToolStripMenuItem_Click);
            // 
            // MenuItemagregarRepuesto
            // 
            this.MenuItemagregarRepuesto.Name = "MenuItemagregarRepuesto";
            this.MenuItemagregarRepuesto.Size = new System.Drawing.Size(169, 22);
            this.MenuItemagregarRepuesto.Text = "Agregar Repuesto";
            this.MenuItemagregarRepuesto.Click += new System.EventHandler(this.agregarRepuesto_Click);
            // 
            // MenuItemeditarRepuesto
            // 
            this.MenuItemeditarRepuesto.Name = "MenuItemeditarRepuesto";
            this.MenuItemeditarRepuesto.Size = new System.Drawing.Size(169, 22);
            this.MenuItemeditarRepuesto.Text = "Editar Repuesto";
            this.MenuItemeditarRepuesto.Click += new System.EventHandler(this.MenuItemeditarRepuesto_Click);
            // 
            // MenuItemeliminarRepuesto
            // 
            this.MenuItemeliminarRepuesto.Name = "MenuItemeliminarRepuesto";
            this.MenuItemeliminarRepuesto.Size = new System.Drawing.Size(169, 22);
            this.MenuItemeliminarRepuesto.Text = "Eliminar Repuesto";
            this.MenuItemeliminarRepuesto.Click += new System.EventHandler(this.MenuItemeliminarRepuesto_Click);
            // 
            // repuestosToolStripMenuItem
            // 
            this.repuestosToolStripMenuItem.Name = "repuestosToolStripMenuItem";
            this.repuestosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.repuestosToolStripMenuItem.Text = "Repuestos";
            this.repuestosToolStripMenuItem.Click += new System.EventHandler(this.repuestosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemagregarClientes,
            this.MenuItemeditarClientes,
            this.MenuItemeliminarClientes,
            this.clientesToolStripMenuItem1});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // MenuItemagregarClientes
            // 
            this.MenuItemagregarClientes.Name = "MenuItemagregarClientes";
            this.MenuItemagregarClientes.Size = new System.Drawing.Size(162, 22);
            this.MenuItemagregarClientes.Text = "Agregar Clientes";
            this.MenuItemagregarClientes.Click += new System.EventHandler(this.MenuItemagregarClientes_Click);
            // 
            // MenuItemeditarClientes
            // 
            this.MenuItemeditarClientes.Name = "MenuItemeditarClientes";
            this.MenuItemeditarClientes.Size = new System.Drawing.Size(162, 22);
            this.MenuItemeditarClientes.Text = "Editar Clientes";
            this.MenuItemeditarClientes.Click += new System.EventHandler(this.MenuItemeditarClientes_Click);
            // 
            // MenuItemeliminarClientes
            // 
            this.MenuItemeliminarClientes.Name = "MenuItemeliminarClientes";
            this.MenuItemeliminarClientes.Size = new System.Drawing.Size(162, 22);
            this.MenuItemeliminarClientes.Text = "Eliminar Clientes";
            this.MenuItemeliminarClientes.Click += new System.EventHandler(this.MenuItemeliminarClientes_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 347);
            this.Controls.Add(this.MenuDashboard);
            this.MainMenuStrip = this.MenuDashboard;
            this.Name = "DashBoard";
            this.Text = "FmDashBoard";
            this.MenuDashboard.ResumeLayout(false);
            this.MenuDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuDashboard;
        private System.Windows.Forms.ToolStripMenuItem menuItemRepuestos;
        private System.Windows.Forms.ToolStripMenuItem MenuItemagregarRepuesto;
        private System.Windows.Forms.ToolStripMenuItem MenuItemeditarRepuesto;
        private System.Windows.Forms.ToolStripMenuItem MenuItemeliminarRepuesto;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemagregarClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuItemeditarClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuItemeliminarClientes;
        private System.Windows.Forms.ToolStripMenuItem repuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
    }
}