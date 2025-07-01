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
            this.grbPoints = new System.Windows.Forms.GroupBox();
            this.tablePoints = new System.Windows.Forms.DataGridView();
            this.grbEnds = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPy2 = new System.Windows.Forms.TextBox();
            this.txtPx2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPy1 = new System.Windows.Forms.TextBox();
            this.txtPx1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tckSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbControles.SuspendLayout();
            this.grbPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePoints)).BeginInit();
            this.grbEnds.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.picCanvas.Location = new System.Drawing.Point(344, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(569, 532);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnDibujarD
            // 
            this.btnDibujarD.Location = new System.Drawing.Point(51, 38);
            this.btnDibujarD.Name = "btnDibujarD";
            this.btnDibujarD.Size = new System.Drawing.Size(187, 37);
            this.btnDibujarD.TabIndex = 11;
            this.btnDibujarD.Text = "Líneas Discretas";
            this.btnDibujarD.UseVisualStyleBackColor = true;
            this.btnDibujarD.Click += new System.EventHandler(this.DiscreteLinePlot);
            // 
            // grbControles
            // 
            this.grbControles.Controls.Add(this.btnBorrar);
            this.grbControles.Controls.Add(this.btnBresenham);
            this.grbControles.Controls.Add(this.btnDibujarD);
            this.grbControles.Location = new System.Drawing.Point(32, 181);
            this.grbControles.Name = "grbControles";
            this.grbControles.Size = new System.Drawing.Size(285, 234);
            this.grbControles.TabIndex = 12;
            this.grbControles.TabStop = false;
            this.grbControles.Text = "Controles";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(51, 161);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(182, 37);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Limpiar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.reset);
            // 
            // btnBresenham
            // 
            this.btnBresenham.Location = new System.Drawing.Point(51, 99);
            this.btnBresenham.Name = "btnBresenham";
            this.btnBresenham.Size = new System.Drawing.Size(182, 37);
            this.btnBresenham.TabIndex = 12;
            this.btnBresenham.Text = "Líneas de Bresehnam";
            this.btnBresenham.UseVisualStyleBackColor = true;
            this.btnBresenham.Click += new System.EventHandler(this.BresenhamLinePlot);
            // 
            // grbPoints
            // 
            this.grbPoints.Controls.Add(this.tablePoints);
            this.grbPoints.Location = new System.Drawing.Point(919, 14);
            this.grbPoints.Name = "grbPoints";
            this.grbPoints.Size = new System.Drawing.Size(405, 530);
            this.grbPoints.TabIndex = 13;
            this.grbPoints.TabStop = false;
            this.grbPoints.Text = "Pixeles";
            // 
            // tablePoints
            // 
            this.tablePoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePoints.Location = new System.Drawing.Point(6, 19);
            this.tablePoints.Name = "tablePoints";
            this.tablePoints.RowHeadersVisible = false;
            this.tablePoints.RowHeadersWidth = 12;
            this.tablePoints.RowTemplate.Height = 28;
            this.tablePoints.Size = new System.Drawing.Size(393, 496);
            this.tablePoints.TabIndex = 0;
            // 
            // grbEnds
            // 
            this.grbEnds.Controls.Add(this.label7);
            this.grbEnds.Controls.Add(this.label8);
            this.grbEnds.Controls.Add(this.txtPy2);
            this.grbEnds.Controls.Add(this.txtPx2);
            this.grbEnds.Controls.Add(this.label9);
            this.grbEnds.Controls.Add(this.label10);
            this.grbEnds.Controls.Add(this.label11);
            this.grbEnds.Controls.Add(this.txtPy1);
            this.grbEnds.Controls.Add(this.txtPx1);
            this.grbEnds.Controls.Add(this.label12);
            this.grbEnds.Location = new System.Drawing.Point(32, 33);
            this.grbEnds.Name = "grbEnds";
            this.grbEnds.Size = new System.Drawing.Size(290, 132);
            this.grbEnds.TabIndex = 14;
            this.grbEnds.TabStop = false;
            this.grbEnds.Text = "Puntos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "X:";
            // 
            // txtPy2
            // 
            this.txtPy2.Location = new System.Drawing.Point(185, 98);
            this.txtPy2.Name = "txtPy2";
            this.txtPy2.Size = new System.Drawing.Size(100, 26);
            this.txtPy2.TabIndex = 18;
            // 
            // txtPx2
            // 
            this.txtPx2.Location = new System.Drawing.Point(185, 48);
            this.txtPx2.Name = "txtPx2";
            this.txtPx2.Size = new System.Drawing.Size(100, 26);
            this.txtPx2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Punto final:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Y:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "X:";
            // 
            // txtPy1
            // 
            this.txtPy1.Location = new System.Drawing.Point(39, 101);
            this.txtPy1.Name = "txtPy1";
            this.txtPy1.Size = new System.Drawing.Size(100, 26);
            this.txtPy1.TabIndex = 13;
            // 
            // txtPx1
            // 
            this.txtPx1.Location = new System.Drawing.Point(39, 51);
            this.txtPx1.Name = "txtPx1";
            this.txtPx1.Size = new System.Drawing.Size(100, 26);
            this.txtPx1.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Punto inicial:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSpeed);
            this.groupBox3.Controls.Add(this.tckSpeed);
            this.groupBox3.Location = new System.Drawing.Point(32, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 100);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Velocidad de la animacion";
            // 
            // tckSpeed
            // 
            this.tckSpeed.Location = new System.Drawing.Point(17, 25);
            this.tckSpeed.Minimum = 1;
            this.tckSpeed.Name = "tckSpeed";
            this.tckSpeed.Size = new System.Drawing.Size(191, 69);
            this.tckSpeed.TabIndex = 16;
            this.tckSpeed.Value = 1;
            this.tckSpeed.Scroll += new System.EventHandler(this.tckSpeed_Scroll);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(214, 36);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(16, 20);
            this.lblSpeed.TabIndex = 17;
            this.lblSpeed.Text = "x";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmLineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1387, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbEnds);
            this.Controls.Add(this.grbPoints);
            this.Controls.Add(this.grbControles);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmLineas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLineas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbControles.ResumeLayout(false);
            this.grbPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePoints)).EndInit();
            this.grbEnds.ResumeLayout(false);
            this.grbEnds.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnDibujarD;
        private System.Windows.Forms.GroupBox grbControles;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBresenham;
        private System.Windows.Forms.GroupBox grbPoints;
        private System.Windows.Forms.DataGridView tablePoints;
        private System.Windows.Forms.GroupBox grbEnds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPy2;
        private System.Windows.Forms.TextBox txtPx2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPy1;
        private System.Windows.Forms.TextBox txtPx1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar tckSpeed;
        private System.Windows.Forms.Label lblSpeed;
    }
}

