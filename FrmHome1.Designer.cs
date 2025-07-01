namespace AlgoritmosGraficosComputacionales
{
    partial class FrmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuLineas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCircunferencia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuElipse = new System.Windows.Forms.ToolStripMenuItem();
            this.rellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFloodFill = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLineClip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShapeClip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBezierCurve = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBsplineCurve = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLineas,
            this.menuCircunferencia,
            this.menuElipse,
            this.rellenoToolStripMenuItem,
            this.recortesToolStripMenuItem,
            this.curvasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuLineas
            // 
            this.menuLineas.Name = "menuLineas";
            this.menuLineas.Size = new System.Drawing.Size(76, 29);
            this.menuLineas.Text = "Lineas";
            this.menuLineas.Click += new System.EventHandler(this.menuLineas_Click);
            // 
            // menuCircunferencia
            // 
            this.menuCircunferencia.Name = "menuCircunferencia";
            this.menuCircunferencia.Size = new System.Drawing.Size(138, 29);
            this.menuCircunferencia.Text = "Circunferencia";
            this.menuCircunferencia.Click += new System.EventHandler(this.menuCircunferencia_Click);
            // 
            // menuElipse
            // 
            this.menuElipse.Name = "menuElipse";
            this.menuElipse.Size = new System.Drawing.Size(73, 29);
            this.menuElipse.Text = "Elipse";
            this.menuElipse.Click += new System.EventHandler(this.menuElipse_Click);
            // 
            // rellenoToolStripMenuItem
            // 
            this.rellenoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFloodFill});
            this.rellenoToolStripMenuItem.Name = "rellenoToolStripMenuItem";
            this.rellenoToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.rellenoToolStripMenuItem.Text = "Relleno";
            // 
            // recortesToolStripMenuItem
            // 
            this.recortesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLineClip,
            this.menuShapeClip});
            this.recortesToolStripMenuItem.Name = "recortesToolStripMenuItem";
            this.recortesToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.recortesToolStripMenuItem.Text = "Recortes";
            // 
            // curvasToolStripMenuItem
            // 
            this.curvasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBezierCurve,
            this.menuBsplineCurve});
            this.curvasToolStripMenuItem.Name = "curvasToolStripMenuItem";
            this.curvasToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.curvasToolStripMenuItem.Text = "Curvas";
            // 
            // menuFloodFill
            // 
            this.menuFloodFill.Name = "menuFloodFill";
            this.menuFloodFill.Size = new System.Drawing.Size(270, 34);
            this.menuFloodFill.Text = "FloodFill";
            this.menuFloodFill.Click += new System.EventHandler(this.menuFloodFill_Click);
            // 
            // menuLineClip
            // 
            this.menuLineClip.Name = "menuLineClip";
            this.menuLineClip.Size = new System.Drawing.Size(270, 34);
            this.menuLineClip.Text = "Lineas";
            this.menuLineClip.Click += new System.EventHandler(this.menuLineClip_Click);
            // 
            // menuShapeClip
            // 
            this.menuShapeClip.Name = "menuShapeClip";
            this.menuShapeClip.Size = new System.Drawing.Size(270, 34);
            this.menuShapeClip.Text = "Figuras";
            // 
            // menuBezierCurve
            // 
            this.menuBezierCurve.Name = "menuBezierCurve";
            this.menuBezierCurve.Size = new System.Drawing.Size(270, 34);
            this.menuBezierCurve.Text = "Bezier";
            this.menuBezierCurve.Click += new System.EventHandler(this.menuBezierCurve_Click);
            // 
            // menuBsplineCurve
            // 
            this.menuBsplineCurve.Name = "menuBsplineCurve";
            this.menuBsplineCurve.Size = new System.Drawing.Size(270, 34);
            this.menuBsplineCurve.Text = "Bspline";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 617);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Algoritmos Gráficos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuLineas;
        private System.Windows.Forms.ToolStripMenuItem menuCircunferencia;
        private System.Windows.Forms.ToolStripMenuItem menuElipse;
        private System.Windows.Forms.ToolStripMenuItem rellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recortesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFloodFill;
        private System.Windows.Forms.ToolStripMenuItem menuLineClip;
        private System.Windows.Forms.ToolStripMenuItem menuShapeClip;
        private System.Windows.Forms.ToolStripMenuItem menuBezierCurve;
        private System.Windows.Forms.ToolStripMenuItem menuBsplineCurve;
    }
}