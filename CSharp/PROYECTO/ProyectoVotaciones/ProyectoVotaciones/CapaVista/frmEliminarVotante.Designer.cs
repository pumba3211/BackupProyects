namespace ProyectoVotaciones
{
    partial class frmEliminarVotante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarVotante));
            this.DGTVotantes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.EliminarVotante = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGTVotantes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGTVotantes
            // 
            this.DGTVotantes.AllowUserToAddRows = false;
            this.DGTVotantes.AllowUserToDeleteRows = false;
            this.DGTVotantes.AllowUserToResizeColumns = false;
            this.DGTVotantes.AllowUserToResizeRows = false;
            this.DGTVotantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGTVotantes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGTVotantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTVotantes.Location = new System.Drawing.Point(15, 112);
            this.DGTVotantes.Name = "DGTVotantes";
            this.DGTVotantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGTVotantes.Size = new System.Drawing.Size(739, 293);
            this.DGTVotantes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votantes Registrados";
            // 
            // EliminarVotante
            // 
            this.EliminarVotante.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Eliminar;
            this.EliminarVotante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EliminarVotante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarVotante.Location = new System.Drawing.Point(529, 56);
            this.EliminarVotante.Name = "EliminarVotante";
            this.EliminarVotante.Size = new System.Drawing.Size(110, 50);
            this.EliminarVotante.TabIndex = 2;
            this.EliminarVotante.UseVisualStyleBackColor = true;
            this.EliminarVotante.Click += new System.EventHandler(this.EliminarVotante_Click);
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Location = new System.Drawing.Point(645, 56);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(109, 50);
            this.Salir.TabIndex = 19;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // frmEliminarVotante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(763, 417);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.EliminarVotante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGTVotantes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarVotante";
            this.Text = "Eliminar Votante";
            ((System.ComponentModel.ISupportInitialize)(this.DGTVotantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGTVotantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EliminarVotante;
        private System.Windows.Forms.Button Salir;
    }
}