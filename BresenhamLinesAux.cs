using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlgoritmoRecorteLineas
{
    class BresenhamLinesAux
    {
        public Point p_0;
        public Point p_f;
        private float diff_x;
        private float diff_y;
        private int k;
        private int p;
        private int b;
        private int const_add;
        private int const_sub;
        public float slope;
        private Pen mPen;
        private bool negativeHorizontally;
        private bool negativeVertically;
        private Graphics mGraph;
        public List<Point> pointsList;

        public BresenhamLinesAux()
        {
            p_0 = new Point();
            p_f = new Point();
            diff_x = 0.0f;
            diff_y = 0.0f;
            slope = 0.0f;
            k = 0;
            p = 0;
            b = 0;
            const_add = 0;
            const_sub = 0;
            pointsList = new List<Point>();
        }
        public void getStart(Point pStart)
        {
            try
            {
                p_0 = pStart;
            }
            catch
            {
                MessageBox.Show("Error al seleccionar los puntos");
            }
        }
        public void getEnd(Point pEnd)
        {
            try
            {
                p_f = pEnd;
            }
            catch
            {
                MessageBox.Show("Error al seleccionar los puntos");
            }
        }

        public void initializeData(PictureBox picCanvas)
        {
            p_0 = new Point();
            p_f = new Point();
            diff_x = 0.0f;
            diff_y = 0.0f;
            slope = 0.0f;
            k= 0;
            p = 0;
            b = 0;
            const_add = 0;
            const_sub = 0;
        }
        public void calculate()
        {
            negativeHorizontally = (p_f.X> p_0.X) ? false : true;
            negativeVertically = (p_f.Y > p_0.Y) ? false : true;
            diff_x = (float)(Math.Abs(p_f.X - p_0.X));
            diff_y = (float)(Math.Abs(p_f.Y - p_0.Y));
            slope = diff_y / diff_x;
            b = Convert.ToInt32(Math.Round(p_0.Y - (slope * p_0.X)));
            if (diff_x > diff_y)
            {
                //Pendiente menor a 1
                k = Convert.ToInt32(diff_x);
                p = (2 * Convert.ToInt32(diff_y)) - Convert.ToInt32(diff_x);
                const_add = (2 * Convert.ToInt32(diff_y));
                const_sub = (2 * Convert.ToInt32(diff_y)) - (2 * Convert.ToInt32(diff_x));
            }
            else
            {
                k = Convert.ToInt32(diff_y);
                p = (2 * Convert.ToInt32(diff_x)) - Convert.ToInt32(diff_y);
                const_add = (2 * Convert.ToInt32(diff_x));
                const_sub = (2 * Convert.ToInt32(diff_x)) - (2 * Convert.ToInt32(diff_y));
            }
        }

        public void getPoints()
        {
            int p_k = p;
            Point pointi = p_0;
            pointsList.Add(p_0);
            Point pointf = new Point();
            for (int i = 0; i < k; i++)
            {
                if (p_k < 0)
                {
                    p_k = p_k + const_add;
                    if (slope < 1)
                    {
                        pointf.X = (!negativeHorizontally) ? pointi.X + 1 : pointi.X - 1;
                        pointf.Y = pointi.Y;
                    }
                    else
                    {
                        pointf.Y = (!negativeVertically) ? pointi.Y + 1 : pointi.Y - 1;
                        pointf.X = pointi.X;
                    }
                }
                else
                {
                    p_k = p_k + const_sub;
                    pointf.X = (!negativeHorizontally) ? pointi.X + 1 : pointi.X - 1;
                    pointf.Y = (!negativeVertically) ? pointi.Y + 1 : pointi.Y - 1;
                }
                                pointsList.Add(pointf);
                pointi = pointf;
                pointsList.Add(pointf);
            }
        }
        public void drawPoints(PictureBox picCanvas)
        {
            Graphics mGraph;
            mGraph=picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 3);
            for(int i = 0; i < pointsList.Count-1; i++)
            {
                mGraph.DrawLine(mPen, pointsList[i],pointsList[i+1]);
            }
            
        }
        public void drawEnd(PictureBox picCanvas, Point endPoint, Color markerColor)
        {
            mPen = new Pen(markerColor, 2);
            mGraph = picCanvas.CreateGraphics();
            int radius = 5;
            mGraph.DrawEllipse(mPen, (endPoint.X - radius), (endPoint.Y - radius), (2 * radius), (2 * radius));
        }
    }
}
