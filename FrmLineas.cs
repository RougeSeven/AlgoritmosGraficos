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
    public partial class FrmLineas : Form
    {
        private static FrmLineas instance=new FrmLineas();
        private DiscreteLines dLines = new DiscreteLines();
        private BresenhamLines bresLines = new BresenhamLines();
        private FrmLineas()
        {
            InitializeComponent();
        }
        public static FrmLineas getInstance()
        {
            return instance;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void DiscreteLinePlot(object sender, EventArgs e)
        {
            dLines.getAnimationSpeed(tckSpeed);
            dLines.readData(txtPx1, txtPy1, txtPx2, txtPy2, picCanvas);
            dLines.calculateDiscrete();
            dLines.drawEnds(picCanvas);
            dLines.drawDiscrete(picCanvas,tablePoints);
        }
        private void BresenhamLinePlot(object sender, EventArgs e)
        {
            bresLines.getAnimationSpeed(tckSpeed);
            bresLines.readData(txtPx1, txtPy1, txtPx2, txtPy2);
            bresLines.calculate();
            bresLines.drawEnds(picCanvas);
            bresLines.drawPoints(picCanvas, tablePoints);
        }
        private void reset(object sender, EventArgs e)
        {
            dLines.initializeData(txtPx1,txtPy1,txtPx2,txtPy2,picCanvas,tablePoints);
        }

        private void FrmLineas_Load(object sender, EventArgs e)
        {
            dLines.initializeData(txtPx1, txtPy1, txtPx2, txtPy2, picCanvas,tablePoints);
            bresLines.initializeData(txtPx1, txtPy1, txtPx2, txtPy2, picCanvas, tablePoints);
            lblSpeed.Text = "x" + tckSpeed.Value.ToString();
        }

        private void tckSpeed_Scroll(object sender, EventArgs e)
        {
            lblSpeed.Text = "x" + tckSpeed.Value.ToString();
            dLines.getAnimationSpeed(tckSpeed);
            bresLines.getAnimationSpeed(tckSpeed);
        }
    }
}
