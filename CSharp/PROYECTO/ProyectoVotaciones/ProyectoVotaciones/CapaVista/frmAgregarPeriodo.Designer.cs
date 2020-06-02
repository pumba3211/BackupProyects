namespace ProyectoVotaciones.CapaVista
{
    partial class frmAgregarPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarPeriodo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textAñoI = new System.Windows.Forms.TextBox();
            this.textAñoF = new System.Windows.Forms.TextBox();
            this.comboBoxUso = new System.Windows.Forms.ComboBox();
            this.Salir = new System.Windows.Forms.Button();
            this.botonAgregarPeriodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PeriodoID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usar:";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(94, 20);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(115, 20);
            this.textID.TabIndex = 4;
            // 
            // textAñoI
            // 
            this.textAñoI.Location = new System.Drawing.Point(94, 47);
            this.textAñoI.Name = "textAñoI";
            this.textAñoI.Size = new System.Drawing.Size(115, 20);
            this.textAñoI.TabIndex = 5;
            // 
            // textAñoF
            // 
            this.textAñoF.Location = new System.Drawing.Point(94, 75);
            this.textAñoF.Name = "textAñoF";
            this.textAñoF.Size = new System.Drawing.Size(115, 20);
            this.textAñoF.TabIndex = 6;
            // 
            // comboBoxUso
            // 
            this.comboBoxUso.FormattingEnabled = true;
            this.comboBoxUso.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboBoxUso.Location = new System.Drawing.Point(94, 101);
            this.comboBoxUso.Name = "comboBoxUso";
            this.comboBoxUso.Size = new System.Drawing.Size(115, 21);
            this.comboBoxUso.TabIndex = 7;
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Location = new System.Drawing.Point(127, 138);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(110, 46);
            this.Salir.TabIndex = 20;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // botonAgregarPeriodo
            // 
            this.botonAgregarPeriodo.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Agregar;
            this.botonAgregarPeriodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botonAgregarPeriodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAgregarPeriodo.Location = new System.Drawing.Point(11, 138);
            this.botonAgregarPeriodo.Name = "botonAgregarPeriodo";
            this.botonAgregarPeriodo.Size = new System.Drawing.Size(110, 46);
            this.botonAgregarPeriodo.TabIndex = 19;
            this.botonAgregarPeriodo.UseVisualStyleBackColor = true;
            this.botonAgregarPeriodo.Click += new System.EventHandler(this.botonAgregarVotante_Click);
            // 
            // frmAgregarPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(244, 190);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.botonAgregarPeriodo);
            this.Controls.Add(this.comboBoxUso);
            this.Controls.Add(this.textAñoF);
            this.Controls.Add(this.textAñoI);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarPeriodo";
            this.Text = "frmAgregarPeriodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textAñoI;
        private System.Windows.Forms.TextBox textAñoF;
        private System.Windows.Forms.ComboBox comboBoxUso;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button botonAgregarPeriodo;
    }
}