namespace AlgoritmosPixeles
{
    partial class FrmLineas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnDibujarD = new System.Windows.Forms.Button();
            this.grbControles = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBresenham = new System.Windows.Forms.Button();
            this.grbEnds = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPy1 = new System.Windows.Forms.TextBox();
            this.txtPx1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPy2 = new System.Windows.Forms.TextBox();
            this.txtPx2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbControles.SuspendLayout();
            this.grbEnds.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.picCanvas.Location = new System.Drawing.Point(388, 66);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(940, 532);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.getPoints);
            // 
            // btnDibujarD
            // 
            this.btnDibujarD.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujarD.Location = new System.Drawing.Point(30, 42);
            this.btnDibujarD.Name = "btnDibujarD";
            this.btnDibujarD.Size = new System.Drawing.Size(241, 37);
            this.btnDibujarD.TabIndex = 11;
            this.btnDibujarD.Text = "Dibujar Línea Discreta";
            this.btnDibujarD.UseVisualStyleBackColor = true;
            this.btnDibujarD.Click += new System.EventHandler(this.DiscreteLinePlot);
            // 
            // grbControles
            // 
            this.grbControles.Controls.Add(this.btnBorrar);
            this.grbControles.Controls.Add(this.btnBresenham);
            this.grbControles.Controls.Add(this.btnDibujarD);
            this.grbControles.Location = new System.Drawing.Point(21, 369);
            this.grbControles.Name = "grbControles";
            this.grbControles.Size = new System.Drawing.Size(306, 229);
            this.grbControles.TabIndex = 12;
            this.grbControles.TabStop = false;
            this.grbControles.Text = "Controles";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(36, 159);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(222, 37);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar Pantalla";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.reset);
            // 
            // btnBresenham
            // 
            this.btnBresenham.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBresenham.Location = new System.Drawing.Point(30, 99);
            this.btnBresenham.Name = "btnBresenham";
            this.btnBresenham.Size = new System.Drawing.Size(235, 37);
            this.btnBresenham.TabIndex = 12;
            this.btnBresenham.Text = "Dibujar línea de Bresehnam";
            this.btnBresenham.UseVisualStyleBackColor = true;
            this.btnBresenham.Click += new System.EventHandler(this.BresenhamLinePlot);
            // 
            // grbEnds
            // 
            this.grbEnds.Controls.Add(this.label10);
            this.grbEnds.Controls.Add(this.label11);
            this.grbEnds.Controls.Add(this.txtPy1);
            this.grbEnds.Controls.Add(this.txtPx1);
            this.grbEnds.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEnds.Location = new System.Drawing.Point(21, 197);
            this.grbEnds.Name = "grbEnds";
            this.grbEnds.Size = new System.Drawing.Size(306, 77);
            this.grbEnds.TabIndex = 14;
            this.grbEnds.TabStop = false;
            this.grbEnds.Text = "Punto Inicial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "Y:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "X:";
            // 
            // txtPy1
            // 
            this.txtPy1.Location = new System.Drawing.Point(185, 34);
            this.txtPy1.Name = "txtPy1";
            this.txtPy1.ReadOnly = true;
            this.txtPy1.Size = new System.Drawing.Size(100, 29);
            this.txtPy1.TabIndex = 13;
            // 
            // txtPx1
            // 
            this.txtPx1.Location = new System.Drawing.Point(36, 34);
            this.txtPx1.Name = "txtPx1";
            this.txtPx1.ReadOnly = true;
            this.txtPx1.Size = new System.Drawing.Size(100, 29);
            this.txtPx1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "X:";
            // 
            // txtPy2
            // 
            this.txtPy2.Location = new System.Drawing.Point(185, 41);
            this.txtPy2.Name = "txtPy2";
            this.txtPy2.ReadOnly = true;
            this.txtPy2.Size = new System.Drawing.Size(100, 29);
            this.txtPy2.TabIndex = 18;
            // 
            // txtPx2
            // 
            this.txtPx2.Location = new System.Drawing.Point(36, 41);
            this.txtPx2.Name = "txtPx2";
            this.txtPx2.ReadOnly = true;
            this.txtPx2.Size = new System.Drawing.Size(100, 29);
            this.txtPx2.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPx2);
            this.groupBox1.Controls.Add(this.txtPy2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 83);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Punto Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "1. Haz click para crear los 2 puntos (Inicial y FInal)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "2. Elige una de las opciones de dibujo";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "3. Para volver a empezar, haz clic en \"Borrar\"";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(491, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "Algoritmos de Dibujo de Líneas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmLineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1387, 610);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbEnds);
            this.Controls.Add(this.grbControles);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmLineas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLineas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbControles.ResumeLayout(false);
            this.grbEnds.ResumeLayout(false);
            this.grbEnds.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnDibujarD;
        private System.Windows.Forms.GroupBox grbControles;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBresenham;
        private System.Windows.Forms.GroupBox grbEnds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPy2;
        private System.Windows.Forms.TextBox txtPx2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPy1;
        private System.Windows.Forms.TextBox txtPx1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

