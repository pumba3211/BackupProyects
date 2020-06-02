namespace MecanicaVarela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextUser = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.textclave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextUser
            // 
            this.TextUser.Location = new System.Drawing.Point(95, 9);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(239, 20);
            this.TextUser.TabIndex = 0;
            this.TextUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(27, 12);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuario";
            // 
            // textclave
            // 
            this.textclave.Location = new System.Drawing.Point(95, 44);
            this.textclave.Name = "textclave";
            this.textclave.PasswordChar = 'W';
            this.textclave.Size = new System.Drawing.Size(239, 20);
            this.textclave.TabIndex = 2;
            this.textclave.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clave";
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonAceptar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BotonAceptar.FlatAppearance.BorderSize = 0;
            this.BotonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BotonAceptar.Image")));
            this.BotonAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonAceptar.Location = new System.Drawing.Point(85, 108);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(93, 35);
            this.BotonAceptar.TabIndex = 4;
            this.BotonAceptar.UseVisualStyleBackColor = false;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BotonCancelar.Image")));
            this.BotonCancelar.Location = new System.Drawing.Point(202, 108);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(88, 35);
            this.BotonCancelar.TabIndex = 5;
            this.BotonCancelar.TabStop = false;
            this.BotonCancelar.UseVisualStyleBackColor = false;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(368, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.BotonAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 207);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textclave);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.TextUser);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextUser;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox textclave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

