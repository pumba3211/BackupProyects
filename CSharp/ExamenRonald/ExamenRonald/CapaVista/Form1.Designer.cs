namespace ExamenRonald
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CargarCodigoElectoral = new System.Windows.Forms.Button();
            this.CargarPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CargarCodigoElectoral
            // 
            this.CargarCodigoElectoral.Location = new System.Drawing.Point(12, 12);
            this.CargarCodigoElectoral.Name = "CargarCodigoElectoral";
            this.CargarCodigoElectoral.Size = new System.Drawing.Size(630, 55);
            this.CargarCodigoElectoral.TabIndex = 0;
            this.CargarCodigoElectoral.Text = "CargarCodigoElectoral";
            this.CargarCodigoElectoral.UseVisualStyleBackColor = true;
            this.CargarCodigoElectoral.Click += new System.EventHandler(this.CargarCodigoElectoral_Click);
            // 
            // CargarPersona
            // 
            this.CargarPersona.Location = new System.Drawing.Point(12, 84);
            this.CargarPersona.Name = "CargarPersona";
            this.CargarPersona.Size = new System.Drawing.Size(630, 81);
            this.CargarPersona.TabIndex = 1;
            this.CargarPersona.Text = "CargarPersonas";
            this.CargarPersona.UseVisualStyleBackColor = true;
            this.CargarPersona.Click += new System.EventHandler(this.CargarPersona_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 272);
            this.Controls.Add(this.CargarPersona);
            this.Controls.Add(this.CargarCodigoElectoral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CargarCodigoElectoral;
        private System.Windows.Forms.Button CargarPersona;
    }
}

