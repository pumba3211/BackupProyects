namespace ProyectoVotaciones
{
    partial class frmEliminarCandidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarCandidato));
            this.DatosCandidatos = new System.Windows.Forms.DataGridView();
            this.EliminarCandidato = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatosCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosCandidatos
            // 
            this.DatosCandidatos.AllowUserToAddRows = false;
            this.DatosCandidatos.AllowUserToDeleteRows = false;
            this.DatosCandidatos.AllowUserToResizeColumns = false;
            this.DatosCandidatos.AllowUserToResizeRows = false;
            this.DatosCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatosCandidatos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DatosCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DatosCandidatos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.DatosCandidatos.Location = new System.Drawing.Point(12, 73);
            this.DatosCandidatos.Name = "DatosCandidatos";
            this.DatosCandidatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DatosCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosCandidatos.Size = new System.Drawing.Size(649, 354);
            this.DatosCandidatos.TabIndex = 0;
            // 
            // EliminarCandidato
            // 
            this.EliminarCandidato.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Eliminar;
            this.EliminarCandidato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EliminarCandidato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarCandidato.Location = new System.Drawing.Point(427, 21);
            this.EliminarCandidato.Name = "EliminarCandidato";
            this.EliminarCandidato.Size = new System.Drawing.Size(110, 46);
            this.EliminarCandidato.TabIndex = 1;
            this.EliminarCandidato.UseVisualStyleBackColor = true;
            this.EliminarCandidato.Click += new System.EventHandler(this.EliminarCandidato_Click);
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Location = new System.Drawing.Point(543, 22);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(110, 45);
            this.Salir.TabIndex = 19;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Candidatos Registrados";
            // 
            // frmEliminarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(689, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.EliminarCandidato);
            this.Controls.Add(this.DatosCandidatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarCandidato";
            this.Text = "Eliminar Candidato";
            ((System.ComponentModel.ISupportInitialize)(this.DatosCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatosCandidatos;
        private System.Windows.Forms.Button EliminarCandidato;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label label1;
    }
}