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
            this.SuspendLayout();
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(74, 50);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(192, 20);
            this.txtmarca.TabIndex = 27;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(110, 86);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(74, 19);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(192, 20);
            this.txtmatricula.TabIndex = 25;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(12, 50);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(40, 13);
            this.lblmarca.TabIndex = 24;
            this.lblmarca.Text = "Marca:";
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.Location = new System.Drawing.Point(12, 22);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(53, 13);
            this.lblmatricula.TabIndex = 23;
            this.lblmatricula.Text = "Matricula:";
            // 
            // EditarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lblmatricula);
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
    }
}