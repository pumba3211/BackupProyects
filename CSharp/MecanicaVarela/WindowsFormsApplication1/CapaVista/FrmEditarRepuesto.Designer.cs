namespace MecanicaVarela
{
    partial class FrmEditarRepuesto
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
            this.Cancelar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.CheckbossGravado = new System.Windows.Forms.CheckBox();
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
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtprecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImpuetso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(184, 262);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 40;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(80, 262);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 39;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // CheckbossGravado
            // 
            this.CheckbossGravado.AutoSize = true;
            this.CheckbossGravado.Location = new System.Drawing.Point(80, 228);
            this.CheckbossGravado.Name = "CheckbossGravado";
            this.CheckbossGravado.Size = new System.Drawing.Size(67, 17);
            this.CheckbossGravado.TabIndex = 38;
            this.CheckbossGravado.Text = "Grabado";
            this.CheckbossGravado.UseVisualStyleBackColor = true;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(80, 165);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(171, 20);
            this.txtprecio.TabIndex = 37;
            // 
            // TxtImpuetso
            // 
            this.TxtImpuetso.Location = new System.Drawing.Point(80, 201);
            this.TxtImpuetso.Name = "TxtImpuetso";
            this.TxtImpuetso.Size = new System.Drawing.Size(171, 20);
            this.TxtImpuetso.TabIndex = 36;
            // 
            // labe2
            // 
            this.labe2.AutoSize = true;
            this.labe2.Location = new System.Drawing.Point(20, 172);
            this.labe2.Name = "labe2";
            this.labe2.Size = new System.Drawing.Size(40, 13);
            this.labe2.TabIndex = 35;
            this.labe2.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Impuesto:";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(80, 133);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(171, 20);
            this.TxtCantidad.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cantidad:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(80, 102);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(171, 20);
            this.txtMarca.TabIndex = 31;
            // 
            // txtModelo
            // 
            this.txtModelo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtModelo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtModelo.Location = new System.Drawing.Point(80, 71);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(171, 20);
            this.txtModelo.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 20);
            this.txtNombre.TabIndex = 29;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Modelo:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(20, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 13);
            this.label.TabIndex = 26;
            this.label.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "ID:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(80, 6);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(171, 20);
            this.TxtID.TabIndex = 42;
            // 
            // FrmEditarRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 308);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label5);
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
            this.Name = "FrmEditarRepuesto";
            this.Text = "Editar  Repuesto";
            ((System.ComponentModel.ISupportInitialize)(this.txtprecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImpuetso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.CheckBox CheckbossGravado;
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
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtID;
    }
}