namespace ProyectoVotaciones
{
    partial class frmModificarVotante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarVotante));
            this.DGTVotantes = new System.Windows.Forms.DataGridView();
            this.contraseña = new System.Windows.Forms.Label();
            this.textApellido2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboPrivilegios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textApellido1 = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Cedula = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textVoto = new System.Windows.Forms.TextBox();
            this.Modificar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ModificarFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGTVotantes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGTVotantes
            // 
            this.DGTVotantes.AllowUserToAddRows = false;
            this.DGTVotantes.AllowUserToDeleteRows = false;
            this.DGTVotantes.AllowUserToResizeColumns = false;
            this.DGTVotantes.AllowUserToResizeRows = false;
            this.DGTVotantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGTVotantes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGTVotantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTVotantes.Location = new System.Drawing.Point(12, 57);
            this.DGTVotantes.Name = "DGTVotantes";
            this.DGTVotantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGTVotantes.Size = new System.Drawing.Size(558, 314);
            this.DGTVotantes.TabIndex = 1;
            this.DGTVotantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTVotantes_CellContentClick);
            this.DGTVotantes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGTVotantes_CellMouseClick);
            this.DGTVotantes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGTVotantes_MouseClick);
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Location = new System.Drawing.Point(741, 195);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(0, 13);
            this.contraseña.TabIndex = 28;
            // 
            // textApellido2
            // 
            this.textApellido2.Location = new System.Drawing.Point(580, 306);
            this.textApellido2.Name = "textApellido2";
            this.textApellido2.Size = new System.Drawing.Size(129, 20);
            this.textApellido2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(575, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Privilegios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(576, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Apellido2";
            // 
            // comboPrivilegios
            // 
            this.comboPrivilegios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboPrivilegios.FormattingEnabled = true;
            this.comboPrivilegios.Items.AddRange(new object[] {
            "Votante ",
            "Administrador"});
            this.comboPrivilegios.Location = new System.Drawing.Point(576, 170);
            this.comboPrivilegios.Name = "comboPrivilegios";
            this.comboPrivilegios.Size = new System.Drawing.Size(129, 21);
            this.comboPrivilegios.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(575, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Apellido1";
            // 
            // textApellido1
            // 
            this.textApellido1.Location = new System.Drawing.Point(579, 261);
            this.textApellido1.Name = "textApellido1";
            this.textApellido1.Size = new System.Drawing.Size(129, 20);
            this.textApellido1.TabIndex = 22;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nombre.Location = new System.Drawing.Point(572, 96);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(83, 19);
            this.Nombre.TabIndex = 21;
            this.Nombre.Text = "Contraseña";
            // 
            // Cedula
            // 
            this.Cedula.AutoSize = true;
            this.Cedula.BackColor = System.Drawing.Color.Transparent;
            this.Cedula.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cedula.Location = new System.Drawing.Point(572, 51);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(54, 19);
            this.Cedula.TabIndex = 20;
            this.Cedula.Text = "Cedula";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(576, 216);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(129, 20);
            this.textNombre.TabIndex = 19;
            // 
            // textCedula
            // 
            this.textCedula.Enabled = false;
            this.textCedula.Location = new System.Drawing.Point(576, 73);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(129, 20);
            this.textCedula.TabIndex = 18;
            this.textCedula.TextChanged += new System.EventHandler(this.textCedula_TextChanged);
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(576, 125);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(129, 20);
            this.textContraseña.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(576, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(576, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ha votado:";
            // 
            // textVoto
            // 
            this.textVoto.Enabled = false;
            this.textVoto.Location = new System.Drawing.Point(580, 351);
            this.textVoto.Name = "textVoto";
            this.textVoto.Size = new System.Drawing.Size(129, 20);
            this.textVoto.TabIndex = 33;
            // 
            // Modificar
            // 
            this.Modificar.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Modificar;
            this.Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modificar.Location = new System.Drawing.Point(490, 388);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(108, 49);
            this.Modificar.TabIndex = 34;
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Location = new System.Drawing.Point(604, 388);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(105, 49);
            this.Salir.TabIndex = 35;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(7, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 26);
            this.label6.TabIndex = 36;
            this.label6.Text = "Votantes Registrados";
            // 
            // ModificarFoto
            // 
            this.ModificarFoto.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.mod_foto;
            this.ModificarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ModificarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarFoto.Location = new System.Drawing.Point(373, 388);
            this.ModificarFoto.Name = "ModificarFoto";
            this.ModificarFoto.Size = new System.Drawing.Size(111, 49);
            this.ModificarFoto.TabIndex = 37;
            this.ModificarFoto.UseVisualStyleBackColor = true;
            this.ModificarFoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmModificarVotante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(722, 449);
            this.Controls.Add(this.ModificarFoto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.textVoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.textApellido2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPrivilegios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textApellido1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCedula);
            this.Controls.Add(this.DGTVotantes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarVotante";
            this.Text = "Modificar Votante";
            ((System.ComponentModel.ISupportInitialize)(this.DGTVotantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGTVotantes;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.TextBox textApellido2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboPrivilegios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textApellido1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Cedula;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textVoto;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ModificarFoto;
    }
}