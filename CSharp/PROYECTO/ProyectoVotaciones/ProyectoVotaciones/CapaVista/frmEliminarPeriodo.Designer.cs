﻿namespace ProyectoVotaciones.CapaVista
{
    partial class frmEliminarPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarPeriodo));
            this.DatosPeriodos = new System.Windows.Forms.DataGridView();
            this.Salir = new System.Windows.Forms.Button();
            this.EliminarPeriodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPeriodos)).BeginInit();
            this.SuspendLayout();
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
            this.DatosPeriodos.Location = new System.Drawing.Point(22, 80);
            this.DatosPeriodos.Name = "DatosPeriodos";
            this.DatosPeriodos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DatosPeriodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosPeriodos.Size = new System.Drawing.Size(486, 251);
            this.DatosPeriodos.TabIndex = 1;
            this.DatosPeriodos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DatosCandidatos_MouseClick);
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Location = new System.Drawing.Point(399, 26);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(109, 50);
            this.Salir.TabIndex = 22;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // EliminarPeriodo
            // 
            this.EliminarPeriodo.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Eliminar;
            this.EliminarPeriodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EliminarPeriodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarPeriodo.Location = new System.Drawing.Point(283, 26);
            this.EliminarPeriodo.Name = "EliminarPeriodo";
            this.EliminarPeriodo.Size = new System.Drawing.Size(110, 50);
            this.EliminarPeriodo.TabIndex = 21;
            this.EliminarPeriodo.UseVisualStyleBackColor = true;
            this.EliminarPeriodo.Click += new System.EventHandler(this.EliminarVotante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Periodos Registrados";
            // 
            // frmEliminarPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(529, 352);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.EliminarPeriodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatosPeriodos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarPeriodo";
            this.Text = "frmEliminarPeriodo";
            ((System.ComponentModel.ISupportInitialize)(this.DatosPeriodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatosPeriodos;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button EliminarPeriodo;
        private System.Windows.Forms.Label label1;

    }
}