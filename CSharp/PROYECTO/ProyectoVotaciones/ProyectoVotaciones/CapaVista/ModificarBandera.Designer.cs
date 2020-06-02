namespace ProyectoVotaciones.CapaVista
{
    partial class ModificarBandera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarBandera));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Escoger = new System.Windows.Forms.Button();
            this.EspacioBandera = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.openBandera = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EspacioBandera)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Escoger);
            this.groupBox2.Controls.Add(this.EspacioBandera);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 122);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nueva Bandera";
            // 
            // Escoger
            // 
            this.Escoger.BackColor = System.Drawing.Color.Red;
            this.Escoger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Escoger.Location = new System.Drawing.Point(18, 57);
            this.Escoger.Name = "Escoger";
            this.Escoger.Size = new System.Drawing.Size(75, 23);
            this.Escoger.TabIndex = 8;
            this.Escoger.Text = "Escoger";
            this.Escoger.UseVisualStyleBackColor = false;
            this.Escoger.Click += new System.EventHandler(this.Escoger_Click);
            // 
            // EspacioBandera
            // 
            this.EspacioBandera.Location = new System.Drawing.Point(131, 16);
            this.EspacioBandera.Name = "EspacioBandera";
            this.EspacioBandera.Size = new System.Drawing.Size(141, 100);
            this.EspacioBandera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EspacioBandera.TabIndex = 12;
            this.EspacioBandera.TabStop = false;
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salir.ImageKey = "(ninguno)";
            this.Salir.Location = new System.Drawing.Point(143, 159);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(103, 45);
            this.Salir.TabIndex = 24;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Modificar;
            this.Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modificar.Location = new System.Drawing.Point(30, 159);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(107, 45);
            this.Modificar.TabIndex = 23;
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // ModificarBandera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(321, 247);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarBandera";
            this.Text = "ModificarBandera";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EspacioBandera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Escoger;
        private System.Windows.Forms.PictureBox EspacioBandera;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.OpenFileDialog openBandera;
    }
}