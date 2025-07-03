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
        private bool secondClick;
        private Point[] ends;
        private FrmLineas()
        {
            InitializeComponent();
            ends = new Point[2];
            secondClick = false;
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
            dLines.readData(txtPx1, txtPy1, txtPx2, txtPy2);
            dLines.calculateDiscrete();
            dLines.drawEnds(picCanvas);
            dLines.drawDiscrete(picCanvas);
        }
        private void BresenhamLinePlot(object sender, EventArgs e)
        {
            bresLines.readData(txtPx1, txtPy1, txtPx2, txtPy2);
            bresLines.calculate();
            bresLines.drawEnds(picCanvas);
            bresLines.drawPoints(picCanvas);
        }
        private void reset(object sender, EventArgs e)
        {
            dLines.initializeData(txtPx1,txtPy1,txtPx2,txtPy2,picCanvas);
            ends= new Point[2];
            secondClick= false;
        }

        private void FrmLineas_Load(object sender, EventArgs e)
        {
            dLines.initializeData(txtPx1, txtPy1, txtPx2, txtPy2, picCanvas);
            bresLines.initializeData(txtPx1, txtPy1, txtPx2, txtPy2, picCanvas);
        }

       
        
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void getPoints(object sender, EventArgs e)
        {
            MouseEventArgs ev = (MouseEventArgs)e;
            if (!secondClick)
            {
                txtPx1.Text = ev.Location.X.ToString();
                txtPy1.Text = ev.Location.Y.ToString();
                ends[0] = ev.Location;
                secondClick = true;
            }
            else
            {
                txtPx2.Text = ev.Location.X.ToString();
                txtPy2.Text = ev.Location.Y.ToString();
                ends[1] = ev.Location;
                secondClick = false;
            }
            drawPointMarker();
        }
        private void drawPointMarker()
        {
            Graphics mGraph=picCanvas.CreateGraphics();
            Pen mPen=new Pen(Color.Red, 2);
            for(int i = 0; i < 2; i++)
            {
                if (ends[i].X!=0 && ends[i].Y!=0)
                {
                    mGraph.DrawEllipse(mPen, ends[i].X, ends[i].Y, 4, 4);
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
