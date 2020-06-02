using System.Drawing;
namespace ProyectoVotaciones
{
    partial class frmAgregarCandidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCandidato));
            this.botonIngresarCandidato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombreCandidato = new System.Windows.Forms.TextBox();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.Escoger = new System.Windows.Forms.Button();
            this.textPartido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupcamara = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDispositivos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.e3 = new System.Windows.Forms.StatusStrip();
            this.Estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.ESpacioCamara = new System.Windows.Forms.PictureBox();
            this.Existente = new System.Windows.Forms.Button();
            this.EspacioBandera = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Salir = new System.Windows.Forms.Button();
            this.openFotoCandidato = new System.Windows.Forms.OpenFileDialog();
            this.openBandera = new System.Windows.Forms.OpenFileDialog();
            this.groupcamara.SuspendLayout();
            this.e3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESpacioCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EspacioBandera)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonIngresarCandidato
            // 
            this.botonIngresarCandidato.BackColor = System.Drawing.Color.Transparent;
            this.botonIngresarCandidato.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Agregar;
            this.botonIngresarCandidato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botonIngresarCandidato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonIngresarCandidato.Location = new System.Drawing.Point(46, 281);
            this.botonIngresarCandidato.Name = "botonIngresarCandidato";
            this.botonIngresarCandidato.Size = new System.Drawing.Size(109, 44);
            this.botonIngresarCandidato.TabIndex = 0;
            this.botonIngresarCandidato.UseVisualStyleBackColor = false;
            this.botonIngresarCandidato.Click += new System.EventHandler(this.botonIngresarCandidato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // textNombreCandidato
            // 
            this.textNombreCandidato.Location = new System.Drawing.Point(46, 92);
            this.textNombreCandidato.Name = "textNombreCandidato";
            this.textNombreCandidato.Size = new System.Drawing.Size(131, 20);
            this.textNombreCandidato.TabIndex = 2;
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(46, 155);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(131, 20);
            this.textApellidos.TabIndex = 3;
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSize = true;
            this.Apellidos.BackColor = System.Drawing.Color.Transparent;
            this.Apellidos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Apellidos.Location = new System.Drawing.Point(43, 132);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(69, 19);
            this.Apellidos.TabIndex = 4;
            this.Apellidos.Text = "Apellidos";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(46, 35);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(131, 20);
            this.textID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(43, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id";
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
            this.Escoger.Click += new System.EventHandler(this.button3_Click);
            // 
            // textPartido
            // 
            this.textPartido.Location = new System.Drawing.Point(46, 211);
            this.textPartido.Name = "textPartido";
            this.textPartido.Size = new System.Drawing.Size(131, 20);
            this.textPartido.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(42, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Partido";
            // 
            // groupcamara
            // 
            this.groupcamara.BackColor = System.Drawing.Color.Transparent;
            this.groupcamara.Controls.Add(this.maskedTextBox1);
            this.groupcamara.Controls.Add(this.label5);
            this.groupcamara.Controls.Add(this.cbxDispositivos);
            this.groupcamara.Controls.Add(this.label4);
            this.groupcamara.Controls.Add(this.e3);
            this.groupcamara.Controls.Add(this.ESpacioCamara);
            this.groupcamara.Controls.Add(this.Existente);
            this.groupcamara.Controls.Add(this.btnIniciar);
            this.groupcamara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupcamara.Location = new System.Drawing.Point(288, 12);
            this.groupcamara.Name = "groupcamara";
            this.groupcamara.Size = new System.Drawing.Size(332, 192);
            this.groupcamara.TabIndex = 11;
            this.groupcamara.TabStop = false;
            this.groupcamara.Text = "Foto de candidato";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(9, 121);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dispositivo";
            // 
            // cbxDispositivos
            // 
            this.cbxDispositivos.FormattingEnabled = true;
            this.cbxDispositivos.Location = new System.Drawing.Point(9, 78);
            this.cbxDispositivos.Name = "cbxDispositivos";
            this.cbxDispositivos.Size = new System.Drawing.Size(121, 21);
            this.cbxDispositivos.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Seleccionar Camara";
            // 
            // e3
            // 
            this.e3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Estado});
            this.e3.Location = new System.Drawing.Point(3, 167);
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
            this.Existente.Location = new System.Drawing.Point(6, 23);
            this.Existente.Name = "Existente";
            this.Existente.Size = new System.Drawing.Size(75, 23);
            this.Existente.TabIndex = 8;
            this.Existente.Text = "Existente";
            this.Existente.UseVisualStyleBackColor = false;
            this.Existente.Click += new System.EventHandler(this.button4_Click);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Escoger);
            this.groupBox2.Controls.Add(this.EspacioBandera);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(288, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 122);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bandera de partido";
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Location = new System.Drawing.Point(161, 281);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(107, 44);
            this.Salir.TabIndex = 36;
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // openFotoCandidato
            // 

            // 
            // frmAgregarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(666, 352);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupcamara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPartido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.textNombreCandidato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonIngresarCandidato);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarCandidato";
            this.Text = "Agregar Candidato";

            this.groupcamara.ResumeLayout(false);
            this.groupcamara.PerformLayout();
            this.e3.ResumeLayout(false);
            this.e3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESpacioCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EspacioBandera)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            openFotoCandidato.ShowDialog();
            try
            {
                if (openFotoCandidato.FileName != "")
                {
                    ESpacioCamara.Image = Image.FromFile(openFotoCandidato.FileName);
                }

            }
            catch (System.Exception)
            {

                throw;

            }

        }

        #endregion

        private System.Windows.Forms.Button botonIngresarCandidato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombreCandidato;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.Label Apellidos;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button Escoger;
        private System.Windows.Forms.TextBox textPartido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupcamara;
        private System.Windows.Forms.Button Existente;
        private System.Windows.Forms.PictureBox EspacioBandera;
        private System.Windows.Forms.PictureBox ESpacioCamara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip e3;
        private System.Windows.Forms.ToolStripStatusLabel Estado;
        private System.Windows.Forms.ComboBox cbxDispositivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.OpenFileDialog openFotoCandidato;
        private System.Windows.Forms.OpenFileDialog openBandera;
    }
}