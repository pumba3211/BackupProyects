namespace ProyectoVotaciones.CapaVista
{
    partial class frmModificarPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarPeriodo));
            this.label1 = new System.Windows.Forms.Label();
            this.DatosPeriodos = new System.Windows.Forms.DataGridView();
            this.comboBoxUso = new System.Windows.Forms.ComboBox();
            this.textAñoF = new System.Windows.Forms.TextBox();
            this.textAñoI = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPeriodos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Periodos Registrados";
            // 
            // DatosPeriodos
            // 
            this.DatosPeriodos.AllowUserToAddRows = false;
            this.DatosPeriodos.AllowUserToDeleteRows = false;
            this.DatosPeriodos.AllowUserToResizeColumns = false;
            this.DatosPeriodos.AllowUserToResizeRows = false;
            this.DatosPeriodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatosPeriodos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DatosPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DatosPeriodos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.DatosPeriodos.Location = new System.Drawing.Point(12, 92);
            this.DatosPeriodos.Name = "DatosPeriodos";
            this.DatosPeriodos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DatosPeriodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosPeriodos.Size = new System.Drawing.Size(486, 251);
            this.DatosPeriodos.TabIndex = 21;
            this.DatosPeriodos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DatosPeriodos_MouseClick);
            // 
            // comboBoxUso
            // 
            this.comboBoxUso.FormattingEnabled = true;
            this.comboBoxUso.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboBoxUso.Location = new System.Drawing.Point(588, 173);
            this.comboBoxUso.Name = "comboBoxUso";
            this.comboBoxUso.Size = new System.Drawing.Size(130, 21);
            this.comboBoxUso.TabIndex = 30;
            // 
            // textAñoF
            // 
            this.textAñoF.Location = new System.Drawing.Point(588, 147);
            this.textAñoF.Name = "textAñoF";
            this.textAñoF.Size = new System.Drawing.Size(130, 20);
            this.textAñoF.TabIndex = 29;
            // 
            // textAñoI
            // 
            this.textAñoI.Location = new System.Drawing.Point(588, 119);
            this.textAñoI.Name = "textAñoI";
            this.textAñoI.Size = new System.Drawing.Size(130, 20);
            this.textAñoI.TabIndex = 28;
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(588, 92);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(130, 20);
            this.textID.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(506, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Usar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(506, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Año Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(506, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Año Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(506, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "PeriodoID:";
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salir.ImageKey = "(ninguno)";
            this.Salir.Location = new System.Drawing.Point(615, 200);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(103, 45);
            this.Salir.TabIndex = 32;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Modificar;
            this.Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modificar.Location = new System.Drawing.Point(504, 200);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(107, 45);
            this.Modificar.TabIndex = 31;
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // frmModificarPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(741, 369);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.comboBoxUso);
            this.Controls.Add(this.textAñoF);
            this.Controls.Add(this.textAñoI);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatosPeriodos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarPeriodo";
            this.Text = "frmModificarPeriodo";
            ((System.ComponentModel.ISupportInitialize)(this.DatosPeriodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DatosPeriodos;
        private System.Windows.Forms.ComboBox comboBoxUso;
        private System.Windows.Forms.TextBox textAñoF;
        private System.Windows.Forms.TextBox textAñoI;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Modificar;
    }
}