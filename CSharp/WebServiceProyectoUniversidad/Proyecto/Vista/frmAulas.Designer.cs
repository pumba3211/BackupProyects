namespace RecursosHumanos.Vista
{
    partial class frmAulas
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
            this.dtAula = new System.Windows.Forms.DataGridView();
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreAula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdAula = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtAula)).BeginInit();
            this.groupDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(275, 241);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(162, 241);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dtAula
            // 
            this.dtAula.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAula.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dtAula.Location = new System.Drawing.Point(49, 21);
            this.dtAula.Name = "dtAula";
            this.dtAula.Size = new System.Drawing.Size(301, 77);
            this.dtAula.TabIndex = 9;
            // 
            // groupDatos
            // 
            this.groupDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupDatos.Controls.Add(this.label2);
            this.groupDatos.Controls.Add(this.txtNombreAula);
            this.groupDatos.Controls.Add(this.label1);
            this.groupDatos.Controls.Add(this.txtIdAula);
            this.groupDatos.Location = new System.Drawing.Point(49, 110);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(301, 111);
            this.groupDatos.TabIndex = 8;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "Datos Aula";
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
            // txtNombreAula
            // 
            this.txtNombreAula.Location = new System.Drawing.Point(27, 69);
            this.txtNombreAula.Name = "txtNombreAula";
            this.txtNombreAula.Size = new System.Drawing.Size(185, 20);
            this.txtNombreAula.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Aula";
            // 
            // txtIdAula
            // 
            this.txtIdAula.Location = new System.Drawing.Point(27, 33);
            this.txtIdAula.Name = "txtIdAula";
            this.txtIdAula.Size = new System.Drawing.Size(100, 20);
            this.txtIdAula.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(49, 241);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 283);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dtAula);
            this.Controls.Add(this.groupDatos);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmAulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAulas";
            ((System.ComponentModel.ISupportInitialize)(this.dtAula)).EndInit();
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dtAula;
        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdAula;
        private System.Windows.Forms.Button btnAgregar;
    }
}