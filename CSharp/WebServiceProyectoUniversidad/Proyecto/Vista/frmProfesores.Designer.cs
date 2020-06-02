namespace RecursosHumanos.Vista
{
    partial class frmProfesores
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProfesor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdProfesor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.comboCarrera = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrera)).BeginInit();
            this.groupDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(321, 251);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(208, 251);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dtCarrera
            // 
            this.dtCarrera.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCarrera.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dtCarrera.Location = new System.Drawing.Point(75, 36);
            this.dtCarrera.Name = "dtCarrera";
            this.dtCarrera.Size = new System.Drawing.Size(352, 83);
            this.dtCarrera.TabIndex = 19;
            // 
            // groupDatos
            // 
            this.groupDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupDatos.Controls.Add(this.label3);
            this.groupDatos.Controls.Add(this.comboCarrera);
            this.groupDatos.Controls.Add(this.label2);
            this.groupDatos.Controls.Add(this.txtNombreProfesor);
            this.groupDatos.Controls.Add(this.label1);
            this.groupDatos.Controls.Add(this.txtIdProfesor);
            this.groupDatos.Location = new System.Drawing.Point(74, 125);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(353, 111);
            this.groupDatos.TabIndex = 18;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "Datos Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Carrera";
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
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.Location = new System.Drawing.Point(27, 69);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.Size = new System.Drawing.Size(295, 20);
            this.txtNombreProfesor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Profesor";
            // 
            // txtIdProfesor
            // 
            this.txtIdProfesor.Location = new System.Drawing.Point(27, 33);
            this.txtIdProfesor.Name = "txtIdProfesor";
            this.txtIdProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtIdProfesor.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(95, 251);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // comboCarrera
            // 
            this.comboCarrera.FormattingEnabled = true;
            this.comboCarrera.Location = new System.Drawing.Point(188, 32);
            this.comboCarrera.Name = "comboCarrera";
            this.comboCarrera.Size = new System.Drawing.Size(134, 21);
            this.comboCarrera.TabIndex = 8;
            // 
            // frmProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 311);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dtCarrera);
            this.Controls.Add(this.groupDatos);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmProfesores";
            this.Text = "frmProfesores";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCarrera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdProfesor;
        private System.Windows.Forms.Button btnAgregar;
    }
}