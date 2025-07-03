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
        private Point center;
        private bool centerChoice;
        private FrmCircunferencia()
        {
            InitializeComponent();
            center = new Point(picCanvas.Width/2, picCanvas.Height/2);
            txtPx.Text = center.X.ToString();
            txtPy.Text = center.Y.ToString();
            centerChoice = true;
        }
        public static FrmCircunferencia getInstance()
        {
            return instance;
        }
        private void FrmCircunferencia_Load(object sender, EventArgs e)
        {
            dCircle.initializeData(txtPx,txtPy,txtRadius,picCanvas);
            center = new Point(picCanvas.Width / 2, picCanvas.Height / 2);
            txtPx.Text = center.X.ToString();
            txtPy.Text = center.Y.ToString();
            drawCenter();
            centerChoice = true;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if(validateCircle())
            {
                centerChoice = false;
                dCircle.readData(txtPx, txtPy, txtRadius);
                dCircle.calculateOctant(picCanvas);
                drawCenter();
            }
        }
        private bool validateCircle()
        {
            if(Convert.ToInt32(txtRadius.Text)<=0)
            {
                MessageBox.Show("Error. Ingresa un radio mayor a 0");
                return false;
            }
            else if (((center.X - Convert.ToInt32(txtRadius.Text)) < 0) || ((center.Y - Convert.ToInt32(txtRadius.Text)) < 0)
                || ((center.X + Convert.ToInt32(txtRadius.Text)) < 0) || ((center.Y + Convert.ToInt32(txtRadius.Text)) < 0)
                )
            {
                MessageBox.Show("Error. El radio es demasiado grande. Cambia el valor del radio o el centro");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dCircle.initializeData(txtPx, txtPy, txtRadius, picCanvas);
            center = new Point();
            centerChoice =true;
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs ev = (MouseEventArgs)e;
            if (centerChoice)
            {
                center = ev.Location;
                txtPx.Text=center.X.ToString();
                txtPy.Text = center.Y.ToString();
                drawCenter();
            }

        }
        private void drawCenter()
        {
            picCanvas.Refresh();
            Graphics mGraph = picCanvas.CreateGraphics();
            Pen mPen = new Pen(Color.Red, 2);
            mGraph.DrawEllipse(mPen, center.X, center.Y, 4, 4);
        }
        
    }
}
