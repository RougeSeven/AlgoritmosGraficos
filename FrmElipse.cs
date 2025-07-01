using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosComputacionales
{
    public partial class FrmElipse : Form
    {
        private static FrmElipse instance=new FrmElipse();
        private DiscreteEllipse dEllipse = new DiscreteEllipse();
        private FrmElipse()
        {
            InitializeComponent();
        }

        public static FrmElipse getInstance()
        {
            return instance;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void drawEllipse(object sender, EventArgs e)
        {
            if(validateInputs())
            {
                dEllipse.readData(txtPx, txtPy, txtRx, txtRy);
                dEllipse.calculateCuadrant(picCanvas);
            }
        }

        private bool validateInputs()
        {
            if(Convert.ToInt32(txtPx.Text) < 0)
            {
                MessageBox.Show("Error. Por favor ingrese un valor en X mayor a 0");
                return false;
            }else if(Convert.ToInt32(txtPy.Text) < 0)
            {
                MessageBox.Show("Error. Por favor ingrese un valor en Y mayor a 0");
                return false;
            }
            else if (Convert.ToInt32(txtRx.Text) < 0)
            {
                MessageBox.Show("Error. Por favor ingrese un radio de X mayor a 0");
                return false;
            }
            else if (Convert.ToInt32(txtRy.Text) < 0)
            {
                MessageBox.Show("Error. Por favor ingrese un radio de Y mayor a 0");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void reset(object sender, EventArgs e)
        {
            dEllipse.initializeData(txtPx, txtPy, txtRx, txtRy, picCanvas);
        }
        private void clearCanvas(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }
        private void FrmElipse_Load(object sender, EventArgs e)
        {
            dEllipse.initializeData(txtPx, txtPy, txtRx, txtRy, picCanvas);
        }
    }
}
