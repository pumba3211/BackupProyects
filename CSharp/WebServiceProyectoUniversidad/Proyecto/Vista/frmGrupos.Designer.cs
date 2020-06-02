namespace RecursosHumanos.Vista
{
    partial class frmGrupos
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
            this.txtAula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCarrera = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrera)).BeginInit();
            this.groupDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(296, 226);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(183, 226);
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
            this.dtCarrera.Location = new System.Drawing.Point(50, 11);
            this.dtCarrera.Name = "dtCarrera";
            this.dtCarrera.Size = new System.Drawing.Size(352, 83);
            this.dtCarrera.TabIndex = 19;
            // 
            // groupDatos
            // 
            this.groupDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupDatos.Controls.Add(this.txtAula);
            this.groupDatos.Controls.Add(this.label4);
            this.groupDatos.Controls.Add(this.txtProfesor);
            this.groupDatos.Controls.Add(this.label3);
            this.groupDatos.Controls.Add(this.label2);
            this.groupDatos.Controls.Add(this.txtNombreCarrera);
            this.groupDatos.Controls.Add(this.label1);
            this.groupDatos.Controls.Add(this.txtIdCarrera);
            this.groupDatos.Location = new System.Drawing.Point(49, 100);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(353, 111);
            this.groupDatos.TabIndex = 18;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "Datos Grupo";
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(247, 69);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(100, 20);
            this.txtAula.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Aula";
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(134, 33);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(213, 20);
            this.txtProfesor.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Carrera";
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(6, 69);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(216, 20);
            this.txtNombreCarrera.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Grupo";
            // 
            // txtIdCarrera
            // 
            this.txtIdCarrera.Location = new System.Drawing.Point(6, 33);
            this.txtIdCarrera.Name = "txtIdCarrera";
            this.txtIdCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtIdCarrera.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(70, 226);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 261);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dtCarrera);
            this.Controls.Add(this.groupDatos);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmGrupos";
            this.Text = "frmGrupos";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCarrera;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfesor;
    }
}