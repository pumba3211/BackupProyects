namespace ProyectoVotaciones
{
    partial class frmModificarCandidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarCandidato));
            this.DGTCandidatos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textPartido = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.Label();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.textNombreCandidato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textVotos = new System.Windows.Forms.TextBox();
            this.Modificar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Modificarbandera = new System.Windows.Forms.Button();
            this.Modificarfoto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPeriodos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGTCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGTCandidatos
            // 
            this.DGTCandidatos.AllowUserToAddRows = false;
            this.DGTCandidatos.AllowUserToDeleteRows = false;
            this.DGTCandidatos.AllowUserToResizeColumns = false;
            this.DGTCandidatos.AllowUserToResizeRows = false;
            this.DGTCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGTCandidatos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGTCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGTCandidatos.Location = new System.Drawing.Point(12, 85);
            this.DGTCandidatos.Name = "DGTCandidatos";
            this.DGTCandidatos.ReadOnly = true;
            this.DGTCandidatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGTCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGTCandidatos.Size = new System.Drawing.Size(558, 314);
            this.DGTCandidatos.TabIndex = 2;
            this.DGTCandidatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGTCandidatos_KeyPress);
            this.DGTCandidatos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGTCandidatos_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(582, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Partido";
            // 
            // textPartido
            // 
            this.textPartido.Location = new System.Drawing.Point(585, 249);
            this.textPartido.Name = "textPartido";
            this.textPartido.Size = new System.Drawing.Size(131, 20);
            this.textPartido.TabIndex = 15;
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSize = true;
            this.Apellidos.BackColor = System.Drawing.Color.Transparent;
            this.Apellidos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Apellidos.Location = new System.Drawing.Point(582, 170);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(69, 19);
            this.Apellidos.TabIndex = 14;
            this.Apellidos.Text = "Apellidos";
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(585, 193);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(131, 20);
            this.textApellidos.TabIndex = 13;
            // 
            // textNombreCandidato
            // 
            this.textNombreCandidato.Location = new System.Drawing.Point(585, 130);
            this.textNombreCandidato.Name = "textNombreCandidato";
            this.textNombreCandidato.Size = new System.Drawing.Size(131, 20);
            this.textNombreCandidato.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(581, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(582, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Id";
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(585, 74);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(131, 20);
            this.textID.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(582, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Votos";
            // 
            // textVotos
            // 
            this.textVotos.Location = new System.Drawing.Point(585, 305);
            this.textVotos.Name = "textVotos";
            this.textVotos.Size = new System.Drawing.Size(131, 20);
            this.textVotos.TabIndex = 20;
            // 
            // Modificar
            // 
            this.Modificar.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Modificar;
            this.Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modificar.Location = new System.Drawing.Point(463, 411);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(107, 45);
            this.Modificar.TabIndex = 21;
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salir.ImageKey = "(ninguno)";
            this.Salir.Location = new System.Drawing.Point(585, 411);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(103, 45);
            this.Salir.TabIndex = 22;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "Candidatos Registrados";
            // 
            // Modificarbandera
            // 
            this.Modificarbandera.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.m_bandera;
            this.Modificarbandera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Modificarbandera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modificarbandera.Location = new System.Drawing.Point(238, 410);
            this.Modificarbandera.Name = "Modificarbandera";
            this.Modificarbandera.Size = new System.Drawing.Size(106, 46);
            this.Modificarbandera.TabIndex = 24;
            this.Modificarbandera.UseVisualStyleBackColor = true;
            this.Modificarbandera.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Modificarfoto
            // 
            this.Modificarfoto.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.mod1;
            this.Modificarfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Modificarfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modificarfoto.Location = new System.Drawing.Point(350, 411);
            this.Modificarfoto.Name = "Modificarfoto";
            this.Modificarfoto.Size = new System.Drawing.Size(107, 46);
            this.Modificarfoto.TabIndex = 25;
            this.Modificarfoto.UseVisualStyleBackColor = true;
            this.Modificarfoto.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(581, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Periodo";
            // 
            // comboBoxPeriodos
            // 
            this.comboBoxPeriodos.FormattingEnabled = true;
            this.comboBoxPeriodos.Location = new System.Drawing.Point(586, 360);
            this.comboBoxPeriodos.Name = "comboBoxPeriodos";
            this.comboBoxPeriodos.Size = new System.Drawing.Size(130, 21);
            this.comboBoxPeriodos.TabIndex = 27;
            this.comboBoxPeriodos.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriodos_SelectedIndexChanged);
            // 
            // frmModificarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(754, 474);
            this.Controls.Add(this.comboBoxPeriodos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Modificarfoto);
            this.Controls.Add(this.Modificarbandera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.textVotos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPartido);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.textNombreCandidato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGTCandidatos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarCandidato";
            this.Text = "Modificar Candidato";
            ((System.ComponentModel.ISupportInitialize)(this.DGTCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGTCandidatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPartido;
        private System.Windows.Forms.Label Apellidos;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.TextBox textNombreCandidato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textVotos;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Modificarbandera;
        private System.Windows.Forms.Button Modificarfoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPeriodos;
    }
}