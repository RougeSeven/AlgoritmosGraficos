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
    public partial class FrmRelleno : Form
    {
        private static FrmRelleno instance= new FrmRelleno();
        private RellenoInundado mRelleno=new RellenoInundado();
        private mPlot mLinea=new mPlot();
        private String mode;
        private Bitmap canvas;
        private FrmRelleno()
        {
            InitializeComponent();
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            mode = "";
        }
        public static FrmRelleno getInstance()
        {
            return instance;
        }

        private void FrmRelleno_Load(object sender, EventArgs e)
        {
            mLinea.InitializeComponents(picCanvas);
            mRelleno.InitializeData(pointsTable);
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            mode = "draw";
            lblSpeed.Text = "x" + tcbSpeed.Value.ToString();
            btnDrawLine.Select();
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs ev = (MouseEventArgs)e;
            if (mode=="draw")
            {
                mLinea.plotLines(picCanvas, ev.Location,canvas);
            }
            else
            {
                mRelleno.getStartPoint(ev.Location);
                mRelleno.fillShape(picCanvas,canvas, pointsTable);
            }
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            mode = "draw";
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            mode = "fill";
        }

        private void tcbSpeed_Scroll(object sender, EventArgs e)
        {
            lblSpeed.Text = "x" + tcbSpeed.Value.ToString();
            mRelleno.getAnimationSpeed(tcbSpeed);
        }
    }
}
