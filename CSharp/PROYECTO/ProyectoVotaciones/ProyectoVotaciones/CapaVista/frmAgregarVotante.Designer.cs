namespace ProyectoVotaciones
{
    partial class frmAgregarVotante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarVotante));
            this.botonAgregarVotante = new System.Windows.Forms.Button();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.Cedula = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.textApellido1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupcamara = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDispositivos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.ESpacioCamara = new System.Windows.Forms.PictureBox();
            this.Existente = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.comboPrivilegios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textApellido2 = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.OpenAgregarFoto = new System.Windows.Forms.OpenFileDialog();
            this.groupcamara.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESpacioCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAgregarVotante
            // 
            this.botonAgregarVotante.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Agregar;
            this.botonAgregarVotante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botonAgregarVotante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAgregarVotante.Location = new System.Drawing.Point(315, 224);
            this.botonAgregarVotante.Name = "botonAgregarVotante";
            this.botonAgregarVotante.Size = new System.Drawing.Size(110, 46);
            this.botonAgregarVotante.TabIndex = 0;
            this.botonAgregarVotante.UseVisualStyleBackColor = true;
            this.botonAgregarVotante.Click += new System.EventHandler(this.botonAgregarVotante_Click);
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(51, 31);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(129, 20);
            this.textCedula.TabIndex = 1;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(50, 82);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(129, 20);
            this.textNombre.TabIndex = 2;
            // 
            // Cedula
            // 
            this.Cedula.AutoSize = true;
            this.Cedula.BackColor = System.Drawing.Color.Transparent;
            this.Cedula.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cedula.Location = new System.Drawing.Point(48, 12);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(54, 19);
            this.Cedula.TabIndex = 3;
            this.Cedula.Text = "Cedula";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nombre.Location = new System.Drawing.Point(48, 54);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(60, 19);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "Nombre";
            // 
            // textApellido1
            // 
            this.textApellido1.Location = new System.Drawing.Point(50, 130);
            this.textApellido1.Name = "textApellido1";
            this.textApellido1.Size = new System.Drawing.Size(129, 20);
            this.textApellido1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apellido1";
            // 
            // groupcamara
            // 
            this.groupcamara.BackColor = System.Drawing.Color.Transparent;
            this.groupcamara.Controls.Add(this.label5);
            this.groupcamara.Controls.Add(this.cbxDispositivos);
            this.groupcamara.Controls.Add(this.label4);
            this.groupcamara.Controls.Add(this.statusStrip1);
            this.groupcamara.Controls.Add(this.ESpacioCamara);
            this.groupcamara.Controls.Add(this.Existente);
            this.groupcamara.Controls.Add(this.btnIniciar);
            this.groupcamara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupcamara.Location = new System.Drawing.Point(327, 12);
            this.groupcamara.Name = "groupcamara";
            this.groupcamara.Size = new System.Drawing.Size(332, 166);
            this.groupcamara.TabIndex = 12;
            this.groupcamara.TabStop = false;
            this.groupcamara.Text = "Foto de candidato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
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
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(7, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Seleccionar Camara";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Estado});
            this.statusStrip1.Location = new System.Drawing.Point(3, 141);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(326, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
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
            this.Existente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Location = new System.Drawing.Point(197, 115);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // comboPrivilegios
            // 
            this.comboPrivilegios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboPrivilegios.FormattingEnabled = true;
            this.comboPrivilegios.Items.AddRange(new object[] {
            "Votante",
            "Administrador"});
            this.comboPrivilegios.Location = new System.Drawing.Point(51, 224);
            this.comboPrivilegios.Name = "comboPrivilegios";
            this.comboPrivilegios.Size = new System.Drawing.Size(129, 21);
            this.comboPrivilegios.TabIndex = 13;
            this.comboPrivilegios.SelectedIndexChanged += new System.EventHandler(this.comboPrivilegios_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Privilegios";
            // 
            // textApellido2
            // 
            this.textApellido2.Location = new System.Drawing.Point(50, 179);
            this.textApellido2.Name = "textApellido2";
            this.textApellido2.Size = new System.Drawing.Size(129, 20);
            this.textApellido2.TabIndex = 16;
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Location = new System.Drawing.Point(210, 127);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(0, 13);
            this.contraseña.TabIndex = 17;
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Location = new System.Drawing.Point(431, 224);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(110, 46);
            this.Salir.TabIndex = 18;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // OpenAgregarFoto
            // 
            this.OpenAgregarFoto.FileName = "openFileDialog1";
            // 
            // frmAgregarVotante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(687, 295);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.textApellido2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPrivilegios);
            this.Controls.Add(this.groupcamara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textApellido1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCedula);
            this.Controls.Add(this.botonAgregarVotante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarVotante";
            this.Text = "Agregar Votante";
            this.groupcamara.ResumeLayout(false);
            this.groupcamara.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESpacioCamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAgregarVotante;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label Cedula;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textApellido1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupcamara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDispositivos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Estado;
        private System.Windows.Forms.PictureBox ESpacioCamara;
        private System.Windows.Forms.Button Existente;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox comboPrivilegios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textApellido2;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.OpenFileDialog OpenAgregarFoto;
    }
}