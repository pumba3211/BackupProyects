namespace MecanicaVarela
{
    partial class FrmAgregarRepuesto
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
            this.label = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.NumericUpDown();
            this.TxtImpuetso = new System.Windows.Forms.NumericUpDown();
            this.labe2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckbossGravado = new System.Windows.Forms.CheckBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtprecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImpuetso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(25, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Nombre:";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(85, 147);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(171, 20);
            this.txtprecio.TabIndex = 22;
            this.txtprecio.ValueChanged += new System.EventHandler(this.txtprecio_ValueChanged);
            // 
            // TxtImpuetso
            // 
            this.TxtImpuetso.Location = new System.Drawing.Point(85, 183);
            this.TxtImpuetso.Name = "TxtImpuetso";
            this.TxtImpuetso.Size = new System.Drawing.Size(171, 20);
            this.TxtImpuetso.TabIndex = 21;
            this.TxtImpuetso.ValueChanged += new System.EventHandler(this.TxtImpuetso_ValueChanged);
            // 
            // labe2
            // 
            this.labe2.AutoSize = true;
            this.labe2.Location = new System.Drawing.Point(25, 154);
            this.labe2.Name = "labe2";
            this.labe2.Size = new System.Drawing.Size(40, 13);
            this.labe2.TabIndex = 20;
            this.labe2.Text = "Precio:";
            this.labe2.Click += new System.EventHandler(this.labe2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Impuesto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(85, 115);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(171, 20);
            this.TxtCantidad.TabIndex = 18;
            this.TxtCantidad.ValueChanged += new System.EventHandler(this.TxtCantidad_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cantidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(85, 84);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(171, 20);
            this.txtMarca.TabIndex = 16;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtModelo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtModelo.Location = new System.Drawing.Point(85, 53);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(171, 20);
            this.txtModelo.TabIndex = 15;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 20);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Marca:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Modelo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CheckbossGravado
            // 
            this.CheckbossGravado.AutoSize = true;
            this.CheckbossGravado.Location = new System.Drawing.Point(85, 210);
            this.CheckbossGravado.Name = "CheckbossGravado";
            this.CheckbossGravado.Size = new System.Drawing.Size(67, 17);
            this.CheckbossGravado.TabIndex = 23;
            this.CheckbossGravado.Text = "Grabado";
            this.CheckbossGravado.UseVisualStyleBackColor = true;
            this.CheckbossGravado.CheckedChanged += new System.EventHandler(this.CheckbossGravado_CheckedChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(85, 244);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 24;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(189, 244);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 25;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // FrmAgregarRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 313);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.CheckbossGravado);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.TxtImpuetso);
            this.Controls.Add(this.labe2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Name = "FrmAgregarRepuesto";
            this.Text = "               Agregar Repuesto";
            ((System.ComponentModel.ISupportInitialize)(this.txtprecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImpuetso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown txtprecio;
        private System.Windows.Forms.NumericUpDown TxtImpuetso;
        private System.Windows.Forms.Label labe2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckbossGravado;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
    }
}