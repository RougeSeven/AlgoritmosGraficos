using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosPixeles
{
    internal class mPlot
    {
        private Pen mPen;
        private Graphics mGraph;
        private Point cursorPoint;
        private int pointNumber;
        public mPlot()
        {
            pointNumber = 0;
            cursorPoint = new Point(0, 0);
        }

        public void InitializeComponents(PictureBox picCanvas)
        {
            pointNumber = 0;
            picCanvas.Refresh();
            cursorPoint = new Point(0, 0);
        }
        public void plotLines(PictureBox picCanvas, Point cursorClick, Bitmap canvas)
        {

            mGraph = Graphics.FromImage(canvas);
            mPen = new Pen(Color.Black, 2);
            //Graficado de la linea
            mGraph.DrawLine(mPen, cursorPoint, cursorClick);
            cursorPoint = cursorClick;
            picCanvas.Image = canvas;
        }
    }
}
