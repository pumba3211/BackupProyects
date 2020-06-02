namespace appMecanicaVarela
{
    partial class frmDashBoard
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
            this.menuRepuestos = new System.Windows.Forms.MenuStrip();
            this.menuItemRepuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAgregarRepuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditarRepuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEliminarRepuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAgregarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEliminarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.repuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRepuestos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuRepuestos
            // 
            this.menuRepuestos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRepuestos,
            this.MenuItemClientes});
            this.menuRepuestos.Location = new System.Drawing.Point(0, 0);
            this.menuRepuestos.Name = "menuRepuestos";
            this.menuRepuestos.Size = new System.Drawing.Size(551, 24);
            this.menuRepuestos.TabIndex = 0;
            this.menuRepuestos.Text = "menuStrip1";
            // 
            // menuItemRepuestos
            // 
            this.menuItemRepuestos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAgregarRepuesto,
            this.MenuItemEditarRepuesto,
            this.MenuItemEliminarRepuesto,
            this.repuestosToolStripMenuItem});
            this.menuItemRepuestos.Name = "menuItemRepuestos";
            this.menuItemRepuestos.Size = new System.Drawing.Size(73, 20);
            this.menuItemRepuestos.Text = "Repuestos";
            // 
            // MenuItemAgregarRepuesto
            // 
            this.MenuItemAgregarRepuesto.Name = "MenuItemAgregarRepuesto";
            this.MenuItemAgregarRepuesto.Size = new System.Drawing.Size(169, 22);
            this.MenuItemAgregarRepuesto.Text = "Agregar Repuesto";
            this.MenuItemAgregarRepuesto.Click += new System.EventHandler(this.MenuItemAgregarRepuesto_Click);
            // 
            // MenuItemEditarRepuesto
            // 
            this.MenuItemEditarRepuesto.Name = "MenuItemEditarRepuesto";
            this.MenuItemEditarRepuesto.Size = new System.Drawing.Size(169, 22);
            this.MenuItemEditarRepuesto.Text = "Editar Repuesto";
            this.MenuItemEditarRepuesto.Click += new System.EventHandler(this.MenuItemEditarRepuesto_Click);
            // 
            // MenuItemEliminarRepuesto
            // 
            this.MenuItemEliminarRepuesto.Name = "MenuItemEliminarRepuesto";
            this.MenuItemEliminarRepuesto.Size = new System.Drawing.Size(169, 22);
            this.MenuItemEliminarRepuesto.Text = "Eliminar Repuesto";
            this.MenuItemEliminarRepuesto.Click += new System.EventHandler(this.MenuItemEliminarRepuesto_Click);
            // 
            // MenuItemClientes
            // 
            this.MenuItemClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAgregarClientes,
            this.MenuItemEditarClientes,
            this.MenuItemEliminarClientes});
            this.MenuItemClientes.Name = "MenuItemClientes";
            this.MenuItemClientes.Size = new System.Drawing.Size(61, 20);
            this.MenuItemClientes.Text = "Clientes";
            // 
            // MenuItemAgregarClientes
            // 
            this.MenuItemAgregarClientes.Name = "MenuItemAgregarClientes";
            this.MenuItemAgregarClientes.Size = new System.Drawing.Size(162, 22);
            this.MenuItemAgregarClientes.Text = "Agregar Clientes";
            this.MenuItemAgregarClientes.Click += new System.EventHandler(this.MenuItemAgregarClientes_Click);
            // 
            // MenuItemEditarClientes
            // 
            this.MenuItemEditarClientes.Name = "MenuItemEditarClientes";
            this.MenuItemEditarClientes.Size = new System.Drawing.Size(162, 22);
            this.MenuItemEditarClientes.Text = "Editar Clientes";
            this.MenuItemEditarClientes.Click += new System.EventHandler(this.MenuItemEditarClientes_Click);
            // 
            // MenuItemEliminarClientes
            // 
            this.MenuItemEliminarClientes.Name = "MenuItemEliminarClientes";
            this.MenuItemEliminarClientes.Size = new System.Drawing.Size(162, 22);
            this.MenuItemEliminarClientes.Text = "Eliminar Clientes";
            this.MenuItemEliminarClientes.Click += new System.EventHandler(this.MenuItemEliminarClientes_Click);
            // 
            // repuestosToolStripMenuItem
            // 
            this.repuestosToolStripMenuItem.Name = "repuestosToolStripMenuItem";
            this.repuestosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.repuestosToolStripMenuItem.Text = "Repuestos";
            this.repuestosToolStripMenuItem.Click += new System.EventHandler(this.repuestosToolStripMenuItem_Click);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 378);
            this.Controls.Add(this.menuRepuestos);
            this.MainMenuStrip = this.menuRepuestos;
            this.Name = "frmDashBoard";
            this.Text = "DashBoard";
            this.menuRepuestos.ResumeLayout(false);
            this.menuRepuestos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuRepuestos;
        private System.Windows.Forms.ToolStripMenuItem menuItemRepuestos;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAgregarRepuesto;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditarRepuesto;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEliminarRepuesto;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAgregarClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditarClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEliminarClientes;
        private System.Windows.Forms.ToolStripMenuItem repuestosToolStripMenuItem;
    }
}