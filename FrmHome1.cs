using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoritmosPixeles;
using CurvasBezierAvanzado;

namespace AlgoritmosGraficosComputacionales
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void menuCircunferencia_Click(object sender, EventArgs e)
        {
            FrmCircunferencia fCircunferencia = FrmCircunferencia.getInstance();
            fCircunferencia.MdiParent = this;
            fCircunferencia.Show();
        }

        private void menuFloodFill_Click(object sender, EventArgs e)
        {
            FrmRelleno fRelleno = FrmRelleno.getInstance();
            fRelleno.MdiParent = this;
            fRelleno.Show();
        }

        private void menuLineas_Click(object sender, EventArgs e)
        {
            FrmLineas fLineas = FrmLineas.getInstance();
            fLineas.MdiParent = this;
            fLineas.Show();
        }

        private void menuLineClip_Click(object sender, EventArgs e)
        {
            //Arreglar Bresenham primero
        }

        private void menuBezierCurve_Click(object sender, EventArgs e)
        {
            FrmBezier fBezier = FrmBezier.getInstance();
            fBezier.MdiParent = this;
            fBezier.Show();
        }

        private void menuElipse_Click(object sender, EventArgs e)
        {
            FrmElipse fElipse = FrmElipse.getInstance();
            fElipse.MdiParent = this;
            fElipse.Show();
        }
    }
}
