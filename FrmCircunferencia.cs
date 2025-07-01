using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosPixeles
{
    public partial class FrmCircunferencia : Form
    {
        private static FrmCircunferencia instance=new FrmCircunferencia();
        private DiscreteCircle dCircle=new DiscreteCircle();
        private FrmCircunferencia()
        {
            InitializeComponent();
        }
        public static FrmCircunferencia getInstance()
        {
            return instance;
        }
        private void FrmCircunferencia_Load(object sender, EventArgs e)
        {
            dCircle.initializeData(txtPx,txtPy,txtRadius,picCanvas,tablePoints);
            lblSpeed.Text = "x" + tckSpeed.Value.ToString();
            dCircle.getAnimationSpeed(tckSpeed);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            dCircle.getAnimationSpeed(tckSpeed);
            dCircle.readData(txtPx,txtPy,txtRadius);
            dCircle.calculateOctant(picCanvas,tablePoints);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dCircle.initializeData(txtPx, txtPy, txtRadius, picCanvas, tablePoints);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            
        }

        private void tckSpeed_Scroll(object sender, EventArgs e)
        {
            lblSpeed.Text = "x" + tckSpeed.Value.ToString();
            dCircle.getAnimationSpeed(tckSpeed);
        }
    }
}
