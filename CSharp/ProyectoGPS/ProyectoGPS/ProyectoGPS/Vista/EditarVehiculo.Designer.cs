namespace ProyectoGPS.Vista
{
    partial class EditarVehiculo
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
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblmatricula = new System.Windows.Forms.Label();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmarca
            // 
            this.txtmarca.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.txtmarca.Location = new System.Drawing.Point(104, 76);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(174, 26);
            this.txtmarca.TabIndex = 27;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Sienna;
            this.btnEditar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(344, 38);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtmatricula
            // 
            this.txtmatricula.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.txtmatricula.Location = new System.Drawing.Point(104, 22);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(174, 26);
            this.txtmatricula.TabIndex = 25;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmarca.Location = new System.Drawing.Point(12, 76);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(62, 22);
            this.lblmarca.TabIndex = 24;
            this.lblmarca.Text = "Marca:";
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatricula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmatricula.Location = new System.Drawing.Point(12, 22);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(86, 22);
            this.lblmatricula.TabIndex = 23;
            this.lblmatricula.Text = "Matricula:";
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Sienna;
            this.Cerrar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cerrar.Location = new System.Drawing.Point(517, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(40, 31);
            this.Cerrar.TabIndex = 28;
            this.Cerrar.Text = "X";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // EditarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(557, 120);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lblmatricula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarVehiculo";
            this.Text = "EditarVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblmatricula;
        private System.Windows.Forms.Button Cerrar;
    }
}