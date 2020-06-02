namespace ProyectoVotaciones
{
    partial class frmEmitirVoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmitirVoto));
            this.dtagridVoto = new System.Windows.Forms.DataGridView();
            this.Foto_candidato = new System.Windows.Forms.DataGridViewImageColumn();
            this.Bandera_candidato = new System.Windows.Forms.DataGridViewImageColumn();
            this.Datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Escoger = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtonEmitirVoto = new System.Windows.Forms.Button();
            this.BtonAnular = new System.Windows.Forms.Button();
            this.groupDatoVoto = new System.Windows.Forms.GroupBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.LblNombreCandidato = new System.Windows.Forms.Label();
            this.ptCandidato = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtagridVoto)).BeginInit();
            this.groupDatoVoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // dtagridVoto
            // 
            this.dtagridVoto.AllowUserToAddRows = false;
            this.dtagridVoto.AllowUserToDeleteRows = false;
            this.dtagridVoto.AllowUserToResizeColumns = false;
            this.dtagridVoto.AllowUserToResizeRows = false;
            this.dtagridVoto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtagridVoto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtagridVoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtagridVoto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Foto_candidato,
            this.Bandera_candidato,
            this.Datos,
            this.Nombre,
            this.Escoger});
            this.dtagridVoto.Location = new System.Drawing.Point(12, 52);
            this.dtagridVoto.MultiSelect = false;
            this.dtagridVoto.Name = "dtagridVoto";
            this.dtagridVoto.ReadOnly = true;
            this.dtagridVoto.RowHeadersWidth = 70;
            this.dtagridVoto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtagridVoto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtagridVoto.Size = new System.Drawing.Size(1104, 404);
            this.dtagridVoto.TabIndex = 0;
            this.dtagridVoto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtagridVoto_CellContentClick);
            this.dtagridVoto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtagridVoto_CellMouseClick);
            // 
            // Foto_candidato
            // 
            this.Foto_candidato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Foto_candidato.HeaderText = "Candidato";
            this.Foto_candidato.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Foto_candidato.MinimumWidth = 100;
            this.Foto_candidato.Name = "Foto_candidato";
            this.Foto_candidato.ReadOnly = true;
            this.Foto_candidato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto_candidato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Foto_candidato.Width = 200;
            // 
            // Bandera_candidato
            // 
            this.Bandera_candidato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bandera_candidato.HeaderText = "Bandera";
            this.Bandera_candidato.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Bandera_candidato.MinimumWidth = 100;
            this.Bandera_candidato.Name = "Bandera_candidato";
            this.Bandera_candidato.ReadOnly = true;
            this.Bandera_candidato.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Bandera_candidato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Datos
            // 
            this.Datos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Datos.HeaderText = "Partido Politico";
            this.Datos.MinimumWidth = 100;
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            this.Datos.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.HeaderText = "Nombre Candidato";
            this.Nombre.MinimumWidth = 100;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Escoger
            // 
            this.Escoger.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Escoger.HeaderText = "Seleccion";
            this.Escoger.MinimumWidth = 100;
            this.Escoger.Name = "Escoger";
            this.Escoger.ReadOnly = true;
            this.Escoger.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Escoger.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BtonEmitirVoto
            // 
            this.BtonEmitirVoto.BackColor = System.Drawing.Color.Transparent;
            this.BtonEmitirVoto.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.emitiri;
            this.BtonEmitirVoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtonEmitirVoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtonEmitirVoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonEmitirVoto.Location = new System.Drawing.Point(543, 488);
            this.BtonEmitirVoto.Name = "BtonEmitirVoto";
            this.BtonEmitirVoto.Size = new System.Drawing.Size(112, 50);
            this.BtonEmitirVoto.TabIndex = 1;
            this.BtonEmitirVoto.UseVisualStyleBackColor = false;
            this.BtonEmitirVoto.Click += new System.EventHandler(this.BtonEmitirVoto_Click);
            // 
            // BtonAnular
            // 
            this.BtonAnular.BackColor = System.Drawing.Color.Transparent;
            this.BtonAnular.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.BtonAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtonAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtonAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonAnular.Location = new System.Drawing.Point(661, 488);
            this.BtonAnular.Name = "BtonAnular";
            this.BtonAnular.Size = new System.Drawing.Size(112, 50);
            this.BtonAnular.TabIndex = 2;
            this.BtonAnular.UseVisualStyleBackColor = false;
            this.BtonAnular.Click += new System.EventHandler(this.BtonAnular_Click);
            // 
            // groupDatoVoto
            // 
            this.groupDatoVoto.BackColor = System.Drawing.Color.Transparent;
            this.groupDatoVoto.Controls.Add(this.lblPartido);
            this.groupDatoVoto.Controls.Add(this.LblNombreCandidato);
            this.groupDatoVoto.Controls.Add(this.ptCandidato);
            this.groupDatoVoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatoVoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupDatoVoto.Location = new System.Drawing.Point(1142, 52);
            this.groupDatoVoto.Name = "groupDatoVoto";
            this.groupDatoVoto.Size = new System.Drawing.Size(170, 219);
            this.groupDatoVoto.TabIndex = 3;
            this.groupDatoVoto.TabStop = false;
            this.groupDatoVoto.Text = "Datos Voto";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartido.ForeColor = System.Drawing.Color.Transparent;
            this.lblPartido.Location = new System.Drawing.Point(48, 171);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(59, 20);
            this.lblPartido.TabIndex = 2;
            this.lblPartido.Text = "Partido";
            // 
            // LblNombreCandidato
            // 
            this.LblNombreCandidato.AutoSize = true;
            this.LblNombreCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCandidato.ForeColor = System.Drawing.Color.Transparent;
            this.LblNombreCandidato.Location = new System.Drawing.Point(26, 140);
            this.LblNombreCandidato.Name = "LblNombreCandidato";
            this.LblNombreCandidato.Size = new System.Drawing.Size(138, 20);
            this.LblNombreCandidato.TabIndex = 1;
            this.LblNombreCandidato.Text = "NombreCandidato";
            // 
            // ptCandidato
            // 
            this.ptCandidato.Location = new System.Drawing.Point(24, 19);
            this.ptCandidato.Name = "ptCandidato";
            this.ptCandidato.Size = new System.Drawing.Size(128, 106);
            this.ptCandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptCandidato.TabIndex = 0;
            this.ptCandidato.TabStop = false;
            // 
            // frmEmitirVoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1324, 617);
            this.Controls.Add(this.groupDatoVoto);
            this.Controls.Add(this.BtonAnular);
            this.Controls.Add(this.BtonEmitirVoto);
            this.Controls.Add(this.dtagridVoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmitirVoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Voto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmitirVoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtagridVoto)).EndInit();
            this.groupDatoVoto.ResumeLayout(false);
            this.groupDatoVoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptCandidato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtagridVoto;
        private System.Windows.Forms.Button BtonEmitirVoto;
        private System.Windows.Forms.Button BtonAnular;
        private System.Windows.Forms.GroupBox groupDatoVoto;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label LblNombreCandidato;
        private System.Windows.Forms.PictureBox ptCandidato;
        private System.Windows.Forms.DataGridViewImageColumn Foto_candidato;
        private System.Windows.Forms.DataGridViewImageColumn Bandera_candidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Escoger;
    }
}