namespace AlgoritmoRecorteLineas
{
    partial class FrmRecorteFiguras
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbControles = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClip = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDrawShape = new System.Windows.Forms.Button();
            this.grbArea = new System.Windows.Forms.GroupBox();
            this.btnRestartClipzone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetArea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYmax = new System.Windows.Forms.TextBox();
            this.txtXmax = new System.Windows.Forms.TextBox();
            this.txtYmin = new System.Windows.Forms.TextBox();
            this.txtXmin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbControles.SuspendLayout();
            this.grbArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Location = new System.Drawing.Point(39, 206);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1122, 377);
            this.picCanvas.TabIndex = 13;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.getShapePoints);
            // 
            // grbControles
            // 
            this.grbControles.Controls.Add(this.label7);
            this.grbControles.Controls.Add(this.label6);
            this.grbControles.Controls.Add(this.label5);
            this.grbControles.Controls.Add(this.btnClip);
            this.grbControles.Controls.Add(this.btnClear);
            this.grbControles.Controls.Add(this.btnDrawShape);
            this.grbControles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbControles.Location = new System.Drawing.Point(512, 12);
            this.grbControles.Name = "grbControles";
            this.grbControles.Size = new System.Drawing.Size(649, 188);
            this.grbControles.TabIndex = 12;
            this.grbControles.TabStop = false;
            this.grbControles.Text = "Acciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(423, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "-Fija el area de recorte, y presiona recortar. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(576, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "-Cuando estén listos, haz click en dibujar para crear la figura";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "-Haz click en el lienzo para crear puntos. ";
            // 
            // btnClip
            // 
            this.btnClip.Location = new System.Drawing.Point(19, 116);
            this.btnClip.Name = "btnClip";
            this.btnClip.Size = new System.Drawing.Size(170, 42);
            this.btnClip.TabIndex = 14;
            this.btnClip.Text = "Recortar";
            this.btnClip.UseVisualStyleBackColor = true;
            this.btnClip.Click += new System.EventHandler(this.clip);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(425, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 42);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Limpiar Pantalla";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clear);
            // 
            // btnDrawShape
            // 
            this.btnDrawShape.Location = new System.Drawing.Point(224, 116);
            this.btnDrawShape.Name = "btnDrawShape";
            this.btnDrawShape.Size = new System.Drawing.Size(179, 42);
            this.btnDrawShape.TabIndex = 12;
            this.btnDrawShape.Text = "Dibujar Figura";
            this.btnDrawShape.UseVisualStyleBackColor = true;
            this.btnDrawShape.Click += new System.EventHandler(this.drawShape);
            // 
            // grbArea
            // 
            this.grbArea.Controls.Add(this.btnRestartClipzone);
            this.grbArea.Controls.Add(this.label4);
            this.grbArea.Controls.Add(this.label3);
            this.grbArea.Controls.Add(this.btnSetArea);
            this.grbArea.Controls.Add(this.label2);
            this.grbArea.Controls.Add(this.label1);
            this.grbArea.Controls.Add(this.txtYmax);
            this.grbArea.Controls.Add(this.txtXmax);
            this.grbArea.Controls.Add(this.txtYmin);
            this.grbArea.Controls.Add(this.txtXmin);
            this.grbArea.Location = new System.Drawing.Point(39, 12);
            this.grbArea.Name = "grbArea";
            this.grbArea.Size = new System.Drawing.Size(467, 188);
            this.grbArea.TabIndex = 11;
            this.grbArea.TabStop = false;
            this.grbArea.Text = "Area de Recorte";
            // 
            // btnRestartClipzone
            // 
            this.btnRestartClipzone.Location = new System.Drawing.Point(257, 142);
            this.btnRestartClipzone.Name = "btnRestartClipzone";
            this.btnRestartClipzone.Size = new System.Drawing.Size(170, 30);
            this.btnRestartClipzone.TabIndex = 14;
            this.btnRestartClipzone.Text = "Reiniciar";
            this.btnRestartClipzone.UseVisualStyleBackColor = true;
            this.btnRestartClipzone.Click += new System.EventHandler(this.resetClipArea);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Xmax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ymax";
            // 
            // btnSetArea
            // 
            this.btnSetArea.Location = new System.Drawing.Point(67, 142);
            this.btnSetArea.Name = "btnSetArea";
            this.btnSetArea.Size = new System.Drawing.Size(170, 30);
            this.btnSetArea.TabIndex = 13;
            this.btnSetArea.Text = "Fijar Area de Recorte";
            this.btnSetArea.UseVisualStyleBackColor = true;
            this.btnSetArea.Click += new System.EventHandler(this.drawClipArea);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ymin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xmin";
            // 
            // txtYmax
            // 
            this.txtYmax.Location = new System.Drawing.Point(288, 97);
            this.txtYmax.Name = "txtYmax";
            this.txtYmax.Size = new System.Drawing.Size(100, 26);
            this.txtYmax.TabIndex = 5;
            // 
            // txtXmax
            // 
            this.txtXmax.Location = new System.Drawing.Point(288, 41);
            this.txtXmax.Name = "txtXmax";
            this.txtXmax.Size = new System.Drawing.Size(100, 26);
            this.txtXmax.TabIndex = 4;
            // 
            // txtYmin
            // 
            this.txtYmin.Location = new System.Drawing.Point(94, 97);
            this.txtYmin.Name = "txtYmin";
            this.txtYmin.Size = new System.Drawing.Size(100, 26);
            this.txtYmin.TabIndex = 3;
            // 
            // txtXmin
            // 
            this.txtXmin.Location = new System.Drawing.Point(103, 41);
            this.txtXmin.Name = "txtXmin";
            this.txtXmin.Size = new System.Drawing.Size(100, 26);
            this.txtXmin.TabIndex = 2;
            // 
            // FrmRecorteFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1186, 599);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.grbControles);
            this.Controls.Add(this.grbArea);
            this.Name = "FrmRecorteFiguras";
            this.Text = "FrmRecorteFiguras";
            this.Load += new System.EventHandler(this.FrmRecorteFiguras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbControles.ResumeLayout(false);
            this.grbControles.PerformLayout();
            this.grbArea.ResumeLayout(false);
            this.grbArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbControles;
        private System.Windows.Forms.Button btnClip;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDrawShape;
        private System.Windows.Forms.GroupBox grbArea;
        private System.Windows.Forms.Button btnRestartClipzone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYmax;
        private System.Windows.Forms.TextBox txtXmax;
        private System.Windows.Forms.TextBox txtYmin;
        private System.Windows.Forms.TextBox txtXmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}