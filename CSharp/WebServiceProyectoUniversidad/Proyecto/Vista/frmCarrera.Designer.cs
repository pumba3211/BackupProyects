namespace RecursosHumanos.Vista
{
    partial class frmCarrera
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtCarrera = new System.Windows.Forms.DataGridView();
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCarrera = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrera)).BeginInit();
            this.groupDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(316, 237);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(203, 237);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dtCarrera
            // 
            this.dtCarrera.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCarrera.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dtCarrera.Location = new System.Drawing.Point(70, 22);
            this.dtCarrera.Name = "dtCarrera";
            this.dtCarrera.Size = new System.Drawing.Size(352, 83);
            this.dtCarrera.TabIndex = 14;
            // 
            // groupDatos
            // 
            this.groupDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupDatos.Controls.Add(this.label3);
            this.groupDatos.Controls.Add(this.comboEstado);
            this.groupDatos.Controls.Add(this.label2);
            this.groupDatos.Controls.Add(this.txtNombreCarrera);
            this.groupDatos.Controls.Add(this.label1);
            this.groupDatos.Controls.Add(this.txtIdCarrera);
            this.groupDatos.Location = new System.Drawing.Point(69, 111);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(353, 111);
            this.groupDatos.TabIndex = 13;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "Datos Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre ";
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(27, 69);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(185, 20);
            this.txtNombreCarrera.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Carrera";
            // 
            // txtIdCarrera
            // 
            this.txtIdCarrera.Location = new System.Drawing.Point(27, 33);
            this.txtIdCarrera.Name = "txtIdCarrera";
            this.txtIdCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtIdCarrera.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(90, 237);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(236, 68);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(86, 21);
            this.comboEstado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 283);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dtCarrera);
            this.Controls.Add(this.groupDatos);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarrera";
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrera)).EndInit();
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dtCarrera;
        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCarrera;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label3;
    }
}