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
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(110, 85);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(74, 18);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(192, 20);
            this.txtmatricula.TabIndex = 16;
            this.txtmatricula.TextChanged += new System.EventHandler(this.txtmatricula_TextChanged);
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(12, 49);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(40, 13);
            this.lblmarca.TabIndex = 13;
            this.lblmarca.Text = "Marca:";
            this.lblmarca.Click += new System.EventHandler(this.lblmarca_Click);
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.Location = new System.Drawing.Point(12, 21);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(53, 13);
            this.lblmatricula.TabIndex = 12;
            this.lblmatricula.Text = "Matricula:";
            this.lblmatricula.Click += new System.EventHandler(this.lblmatricula_Click);
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(74, 49);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(192, 20);
            this.txtmarca.TabIndex = 22;
            this.txtmarca.TextChanged += new System.EventHandler(this.txtmarca_TextChanged);
            // 
            // AgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 161);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lblmatricula);
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
    }
}