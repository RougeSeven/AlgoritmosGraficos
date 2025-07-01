using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurvasBezierAvanzado
{
    public partial class FrmBezier : Form
    {
        private static FrmBezier instance=new FrmBezier();
        private BezierCurve bzCurve=new BezierCurve();
        private FrmBezier()
        {
            InitializeComponent();
            bzCurve.InitializeData(picCanvas);
        }
        public static FrmBezier getInstance()
        {
            return instance;
        }

        private void drawLines(object sender, EventArgs e)
        {
            bzCurve.createLines(picCanvas);
            bzCurve.getCurvePoints();
            bzCurve.drawCurve(picCanvas);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bzCurve.InitializeData(picCanvas);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs ev = (MouseEventArgs)e;
            bzCurve.drawEnd(picCanvas,ev.Location);
            bzCurve.addPoint(ev.Location);
        }

        private void FrmBezier_Load(object sender, EventArgs e)
        {

        }
    }
}
