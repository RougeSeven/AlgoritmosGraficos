namespace CurvasBezierAvanzado
{
    partial class FrmBezier
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
            this.grbControl = new System.Windows.Forms.GroupBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Location = new System.Drawing.Point(384, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(848, 557);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            // 
            // grbControl
            // 
            this.grbControl.Controls.Add(this.btnDraw);
            this.grbControl.Controls.Add(this.btnClear);
            this.grbControl.Location = new System.Drawing.Point(12, 12);
            this.grbControl.Name = "grbControl";
            this.grbControl.Size = new System.Drawing.Size(357, 557);
            this.grbControl.TabIndex = 1;
            this.grbControl.TabStop = false;
            this.grbControl.Text = "Controles";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(71, 55);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(206, 46);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Dibujar Curva";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.drawLines);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(71, 121);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(206, 46);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBezier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1244, 593);
            this.Controls.Add(this.grbControl);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmBezier";
            this.Text = "Curvas Bezier";
            this.Load += new System.EventHandler(this.FrmBezier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbControl;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDraw;
    }
}