namespace AlgoritmoRecorteLineas
{
    partial class FrmRecorte
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
            this.grbArea = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYmax = new System.Windows.Forms.TextBox();
            this.txtXmax = new System.Windows.Forms.TextBox();
            this.txtYmin = new System.Windows.Forms.TextBox();
            this.txtXmin = new System.Windows.Forms.TextBox();
            this.grbControles = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnSetArea = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnClip = new System.Windows.Forms.Button();
            this.btnRestartClipzone = new System.Windows.Forms.Button();
            this.grbArea.SuspendLayout();
            this.grbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
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
            this.grbArea.Location = new System.Drawing.Point(12, 30);
            this.grbArea.Name = "grbArea";
            this.grbArea.Size = new System.Drawing.Size(467, 188);
            this.grbArea.TabIndex = 0;
            this.grbArea.TabStop = false;
            this.grbArea.Text = "Area de Recorte";
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
            // grbControles
            // 
            this.grbControles.Controls.Add(this.btnClip);
            this.grbControles.Controls.Add(this.btnClear);
            this.grbControles.Controls.Add(this.btnDrawLine);
            this.grbControles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbControles.Location = new System.Drawing.Point(485, 30);
            this.grbControles.Name = "grbControles";
            this.grbControles.Size = new System.Drawing.Size(649, 188);
            this.grbControles.TabIndex = 1;
            this.grbControles.TabStop = false;
            this.grbControles.Text = "Acciones";
            this.grbControles.Enter += new System.EventHandler(this.grbControles_Enter);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(420, 62);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 42);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Limpiar Pantalla";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(224, 62);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(179, 42);
            this.btnDrawLine.TabIndex = 12;
            this.btnDrawLine.Text = "Dibujar Linea";
            this.btnDrawLine.UseVisualStyleBackColor = true;
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
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Location = new System.Drawing.Point(12, 224);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1122, 377);
            this.picCanvas.TabIndex = 10;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClip
            // 
            this.btnClip.Location = new System.Drawing.Point(19, 62);
            this.btnClip.Name = "btnClip";
            this.btnClip.Size = new System.Drawing.Size(170, 42);
            this.btnClip.TabIndex = 14;
            this.btnClip.Text = "Recortar";
            this.btnClip.UseVisualStyleBackColor = true;
            this.btnClip.Click += new System.EventHandler(this.clip);
            // 
            // btnRestartClipzone
            // 
            this.btnRestartClipzone.Location = new System.Drawing.Point(257, 142);
            this.btnRestartClipzone.Name = "btnRestartClipzone";
            this.btnRestartClipzone.Size = new System.Drawing.Size(170, 30);
            this.btnRestartClipzone.TabIndex = 14;
            this.btnRestartClipzone.Text = "Reiniciar";
            this.btnRestartClipzone.UseVisualStyleBackColor = true;
            this.btnRestartClipzone.Click += new System.EventHandler(this.btnRestartClipzone_Click);
            // 
            // FrmRecorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1146, 613);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.grbControles);
            this.Controls.Add(this.grbArea);
            this.Name = "FrmRecorte";
            this.Text = "FrmRecorte";
            this.grbArea.ResumeLayout(false);
            this.grbArea.PerformLayout();
            this.grbControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbArea;
        private System.Windows.Forms.GroupBox grbControles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYmax;
        private System.Windows.Forms.TextBox txtXmax;
        private System.Windows.Forms.TextBox txtYmin;
        private System.Windows.Forms.TextBox txtXmin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnSetArea;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnClip;
        private System.Windows.Forms.Button btnRestartClipzone;
    }
}