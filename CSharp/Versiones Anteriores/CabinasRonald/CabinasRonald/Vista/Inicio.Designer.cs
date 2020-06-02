namespace CabinasRonald.Vista
{
    partial class Inicio
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CabinasRonald.Properties.Resources.Tille1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(158, 107);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(250, 20);
            this.Usuario.TabIndex = 3;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(158, 168);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(250, 20);
            this.Pass.TabIndex = 4;
            this.Pass.UseSystemPasswordChar = true;
            // 
            // Ingresar
            // 
            this.Ingresar.BackColor = System.Drawing.Color.Transparent;
            this.Ingresar.BackgroundImage = global::CabinasRonald.Properties.Resources.Ingresar1;
            this.Ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ingresar.Location = new System.Drawing.Point(158, 226);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(107, 44);
            this.Ingresar.TabIndex = 5;
            this.Ingresar.UseVisualStyleBackColor = false;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            this.Ingresar.MouseEnter += new System.EventHandler(this.Ingresar_MouseEnter);
            this.Ingresar.MouseLeave += new System.EventHandler(this.Ingresar_MouseLeave);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Cancelar.BackgroundImage = global::CabinasRonald.Properties.Resources.Cancelar1;
            this.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cancelar.Location = new System.Drawing.Point(299, 226);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(109, 44);
            this.Cancelar.TabIndex = 6;
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            this.Cancelar.MouseEnter += new System.EventHandler(this.Cancelar_MouseEnter);
            this.Cancelar.MouseLeave += new System.EventHandler(this.Cancelar_MouseLeave);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CabinasRonald.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(585, 312);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.MouseEnter += new System.EventHandler(this.Inicio_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Inicio_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox Pass;
    }
}