namespace ProyectoGPS.Vista
{
    partial class AgregarVehiculo
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblmatricula = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Sienna;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(333, 39);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 40);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtmatricula
            // 
            this.txtmatricula.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatricula.Location = new System.Drawing.Point(107, 18);
            this.txtmatricula.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(174, 26);
            this.txtmatricula.TabIndex = 16;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.BackColor = System.Drawing.Color.Maroon;
            this.lblmarca.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmarca.Location = new System.Drawing.Point(13, 74);
            this.lblmarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(62, 22);
            this.lblmarca.TabIndex = 13;
            this.lblmarca.Text = "Marca:";
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.BackColor = System.Drawing.Color.Maroon;
            this.lblmatricula.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatricula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmatricula.Location = new System.Drawing.Point(13, 22);
            this.lblmatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(86, 22);
            this.lblmatricula.TabIndex = 12;
            this.lblmatricula.Text = "Matricula:";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(107, 71);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(173, 26);
            this.txtmarca.TabIndex = 22;
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Sienna;
            this.Cerrar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cerrar.Location = new System.Drawing.Point(518, -1);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(39, 31);
            this.Cerrar.TabIndex = 29;
            this.Cerrar.Text = "X";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // AgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(557, 120);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lblmatricula);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarVehiculo";
            this.Text = "AgregarVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblmatricula;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Button Cerrar;
    }
}