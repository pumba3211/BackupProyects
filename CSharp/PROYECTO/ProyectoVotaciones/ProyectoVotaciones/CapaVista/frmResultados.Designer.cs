namespace ProyectoVotaciones
{
    partial class frmResultados
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CharGraficos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textCantidadVotos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.charporcentaje = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureprimero = new System.Windows.Forms.PictureBox();
            this.lblprimero = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picturesegundo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picturetercero = new System.Windows.Forms.PictureBox();
            this.lblsegundo = new System.Windows.Forms.Label();
            this.lbltercero = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CharGraficos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charporcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureprimero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesegundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturetercero)).BeginInit();
            this.SuspendLayout();
            // 
            // CharGraficos
            // 
            chartArea1.Name = "ChartArea1";
            this.CharGraficos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CharGraficos.Legends.Add(legend1);
            this.CharGraficos.Location = new System.Drawing.Point(31, 51);
            this.CharGraficos.Name = "CharGraficos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Porcentaje de votos";
            this.CharGraficos.Series.Add(series1);
            this.CharGraficos.Size = new System.Drawing.Size(480, 255);
            this.CharGraficos.TabIndex = 0;
            this.CharGraficos.Text = "chart1";
            // 
            // textCantidadVotos
            // 
            this.textCantidadVotos.Enabled = false;
            this.textCantidadVotos.Location = new System.Drawing.Point(172, 389);
            this.textCantidadVotos.Name = "textCantidadVotos";
            this.textCantidadVotos.Size = new System.Drawing.Size(100, 20);
            this.textCantidadVotos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Votos Emitidos";
            // 
            // charporcentaje
            // 
            chartArea2.Name = "ChartArea1";
            this.charporcentaje.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.charporcentaje.Legends.Add(legend2);
            this.charporcentaje.Location = new System.Drawing.Point(534, 50);
            this.charporcentaje.Name = "charporcentaje";
            series2.ChartArea = "ChartArea1";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Porcentaje de votos";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series2.ShadowColor = System.Drawing.Color.Gray;
            this.charporcentaje.Series.Add(series2);
            this.charporcentaje.Size = new System.Drawing.Size(480, 255);
            this.charporcentaje.TabIndex = 3;
            this.charporcentaje.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(198, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Votos Emitidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(708, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porcentajes en votos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(298, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "1° Lugar";
            // 
            // pictureprimero
            // 
            this.pictureprimero.Location = new System.Drawing.Point(366, 372);
            this.pictureprimero.Name = "pictureprimero";
            this.pictureprimero.Size = new System.Drawing.Size(100, 72);
            this.pictureprimero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureprimero.TabIndex = 7;
            this.pictureprimero.TabStop = false;
            // 
            // lblprimero
            // 
            this.lblprimero.AutoSize = true;
            this.lblprimero.BackColor = System.Drawing.Color.Transparent;
            this.lblprimero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblprimero.Location = new System.Drawing.Point(363, 353);
            this.lblprimero.Name = "lblprimero";
            this.lblprimero.Size = new System.Drawing.Size(27, 13);
            this.lblprimero.TabIndex = 8;
            this.lblprimero.Text = "lbl°1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(501, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "2° Lugar";
            // 
            // picturesegundo
            // 
            this.picturesegundo.Location = new System.Drawing.Point(581, 372);
            this.picturesegundo.Name = "picturesegundo";
            this.picturesegundo.Size = new System.Drawing.Size(100, 72);
            this.picturesegundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturesegundo.TabIndex = 10;
            this.picturesegundo.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(731, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "3° Lugar";
            // 
            // picturetercero
            // 
            this.picturetercero.Location = new System.Drawing.Point(815, 372);
            this.picturetercero.Name = "picturetercero";
            this.picturetercero.Size = new System.Drawing.Size(100, 72);
            this.picturetercero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturetercero.TabIndex = 12;
            this.picturetercero.TabStop = false;
            // 
            // lblsegundo
            // 
            this.lblsegundo.AutoSize = true;
            this.lblsegundo.BackColor = System.Drawing.Color.Transparent;
            this.lblsegundo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsegundo.Location = new System.Drawing.Point(578, 353);
            this.lblsegundo.Name = "lblsegundo";
            this.lblsegundo.Size = new System.Drawing.Size(27, 13);
            this.lblsegundo.TabIndex = 13;
            this.lblsegundo.Text = "lbl°2";
            // 
            // lbltercero
            // 
            this.lbltercero.AutoSize = true;
            this.lbltercero.BackColor = System.Drawing.Color.Transparent;
            this.lbltercero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltercero.Location = new System.Drawing.Point(813, 353);
            this.lbltercero.Name = "lbltercero";
            this.lbltercero.Size = new System.Drawing.Size(27, 13);
            this.lbltercero.TabIndex = 14;
            this.lbltercero.Text = "lbl°2";
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.Salir;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salir.ImageKey = "(ninguno)";
            this.Salir.Location = new System.Drawing.Point(924, 427);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(103, 45);
            this.Salir.TabIndex = 33;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::ProyectoVotaciones.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1039, 484);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.lbltercero);
            this.Controls.Add(this.lblsegundo);
            this.Controls.Add(this.picturetercero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picturesegundo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblprimero);
            this.Controls.Add(this.pictureprimero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.charporcentaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCantidadVotos);
            this.Controls.Add(this.CharGraficos);
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CharGraficos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charporcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureprimero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesegundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturetercero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CharGraficos;
        private System.Windows.Forms.TextBox textCantidadVotos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart charporcentaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureprimero;
        private System.Windows.Forms.Label lblprimero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picturesegundo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picturetercero;
        private System.Windows.Forms.Label lblsegundo;
        private System.Windows.Forms.Label lbltercero;
        private System.Windows.Forms.Button Salir;
    }
}