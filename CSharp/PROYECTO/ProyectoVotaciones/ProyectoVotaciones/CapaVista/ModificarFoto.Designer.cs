namespace ProyectoVotaciones.CapaVista
{
    partial class ModificarFoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarFoto));
            this.groupcamara = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDispositivos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.e3 = new System.Windows.Forms.StatusStrip();
            this.Estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.ESpacioCamara = new System.Windows.Forms.PictureBox();
            this.Existente = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.AbrirFoto = new System.Windows.Forms.OpenFileDialog();
            this.groupcamara.SuspendLayout();
            this.e3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESpacioCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // groupcamara
            // 
            this.groupcamara.BackColor = System.Drawing.Color.Transparent;
            this.groupcamara.Controls.Add(this.label5);
            this.groupcamara.Controls.Add(this.cbxDispositivos);
            this.groupcamara.Controls.Add(this.label4);
            this.groupcamara.Controls.Add(this.e3);
            this.groupcamara.Controls.Add(this.ESpacioCamara);
            this.groupcamara.Controls.Add(this.Existente);
            this.groupcamara.Controls.Add(this.btnIniciar);
            this.groupcamara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupcamara.Location = new System.Drawing.Point(12, 12);
            this.groupcamara.Name = "groupcamara";
            this.groupcamara.Size = new System.Drawing.Size(332, 166);
            this.groupcamara.TabIndex = 12;
            this.groupcamara.TabStop = false;
            this.groupcamara.Text = "Foto de candidato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(7, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dispositivo";
            // 
            // cbxDispositivos
            // 
            this.cbxDispositivos.FormattingEnabled = true;
            this.cbxDispositivos.Location = new System.Drawing.Point(6, 93);
            this.cbxDispositivos.Name = "cbxDispositivos";
            this.cbxDispositivos.Size = new System.Drawing.Size(121, 21);
            this.cbxDispositivos.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(7, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Seleccionar Camara";
            // 
            // e3
            // 
            this.e3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Estado});
            this.e3.Location = new System.Drawing.Point(3, 141);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(326, 22);
            this.e3.TabIndex = 14;
            this.e3.Text = "statusStrip1";
            // 
            // Estado
            // 
            this.Estado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(32, 17);
            this.Estado.Text = "Listo";
            // 
            // ESpacioCamara
            // 
            this.ESpacioCamara.Location = new System.Drawing.Point(167, 14);
            this.ESpacioCamara.Name = "ESpacioCamara";
            this.ESpacioCamara.Size = new System.Drawing.Size(141, 100);
            this.ESpacioCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ESpacioCamara.TabIndex = 13;
            this.ESpacioCamara.TabStop = false;
            // 
            // Existente
            // 
            this.Existente.BackColor = System.Drawing.Color.Red;
            this.Existente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Existente.Location = new System.Drawing.Point(6, 37);
            this.Existente.Name = "Existente";
            this.Existente.Size = new System.Drawing.Size(75, 23);
            this.Existente.TabIndex = 8;
            this.Existente.Text = "Existente";
            this.Existente.UseVisualStyleBackColor = false;
            this.Existente.Click += new System.EventHandler(this.Existente_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Red;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Location = new System.Drawing.Point(197, 115);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salir.ImageKey = "(ninguno)";
            this.Salir.Location = new System.Drawing.Point(166, 212);
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
            this.Modificar.Location = new System.Drawing.Point(53, 212);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(107, 45);
            this.Modificar.TabIndex = 23;
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // ModificarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(353, 267);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.groupcamara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarFoto";
            this.Text = "ModificarFoto";
            this.groupcamara.ResumeLayout(false);
            this.groupcamara.PerformLayout();
            this.e3.ResumeLayout(false);
            this.e3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESpacioCamara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupcamara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDispositivos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip e3;
        private System.Windows.Forms.ToolStripStatusLabel Estado;
        private System.Windows.Forms.PictureBox ESpacioCamara;
        private System.Windows.Forms.Button Existente;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.OpenFileDialog AbrirFoto;

    }
}