using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosComputacionales
{
    internal class DiscreteEllipse
    {
        private Point center;
        private int radiusX;
        private int radiusY;
        private Pen mPen;
        private Graphics mGraph;

        public DiscreteEllipse()
        {
            center = new Point();
            radiusX = 0;
            radiusY = 0;
            mPen = new Pen(Color.Black, 2);
        }
        public void readData(System.Windows.Forms.TextBox txtPx, System.Windows.Forms.TextBox txtPy, System.Windows.Forms.TextBox txtRx, System.Windows.Forms.TextBox txtRy)
        {
            try
            {
                center.X = Convert.ToInt32(txtPx.Text);
                center.Y = Convert.ToInt32(txtPy.Text);
                radiusX = Convert.ToInt32(txtRx.Text);
                radiusY= Convert.ToInt32(txtRy.Text);
            }
            catch
            {
                MessageBox.Show("Entrada incorrecta, por favor solo enteros");
            }
        }

        public void initializeData(System.Windows.Forms.TextBox txtPx, System.Windows.Forms.TextBox txtPy, System.Windows.Forms.TextBox txtRx, System.Windows.Forms.TextBox txtRy, PictureBox picCanvas)
        {
            txtPx.Text = "";
            txtPy.Text = "";
            txtRx.Text = "";
            txtRy.Text = "";
            picCanvas.Refresh();
            center = new Point();
            radiusX = 0;
            radiusY = 0;
        }
        public void calculateCuadrant(PictureBox picCanvas)
        {
            int x = 0;
            int y = radiusY;
            float pR1;
            float pR2;
            Point pointi;
            Point pointf;
            List<Point> cuadrant = new List<Point>();
            //Rango 1
            pointi= new Point(center.X + x, center.Y + y);
            cuadrant.Add(pointi);
            pointf = new Point();
            pR1 = Convert.ToInt32(Math.Pow(radiusY, 2) - (Math.Pow(radiusX, 2) * radiusY) + (Math.Pow(radiusX, 2) / 4));
            while ((2*x*Math.Pow(radiusY,2)) < (2 * y * Math.Pow(radiusX, 2)))
            {
                x++;
                if (pR1 < 0)
                {
                    pR1 += (float)((2 * Math.Pow(radiusY, 2) * x) + Math.Pow(radiusY, 2));
                }
                else
                {
                    y--;
                    pR1 += (float)((2 * Math.Pow(radiusY, 2) * x) - (2 * Math.Pow(radiusX, 2) * y) + Math.Pow(radiusY, 2));
                }
                pointf=new Point(center.X + x, center.Y + y);
                cuadrant.Add(pointf);
            }
            x = pointf.X-center.X;
            y= pointf.Y-center.Y;
            pR2 = (float)((Math.Pow(radiusY,2)*Math.Pow((x + (1/2)),2)) + (Math.Pow(radiusX, 2) * Math.Pow((y-1),2)) - (Math.Pow(radiusX, 2) * Math.Pow(radiusY, 2)));
            while (y >= 0)
            {
                y--;
                if (pR2 < 0)
                {
                    pR2 +=(float)((2 * Math.Pow(radiusX, 2) * y) + Math.Pow(radiusX, 2));
                }
                else
                {
                    x++;
                    pR2 += (float)((2 * Math.Pow(radiusX, 2) * y) - (2 * Math.Pow(radiusY, 2) * x) + Math.Pow(radiusX, 2));
                }
                pointf = new Point(center.X + x, center.Y + y);
                cuadrant.Add(pointf);
            }
            plotCircle(picCanvas, cuadrant);
        }
        public void plotCircle(PictureBox picCanvas,List<Point> cuadrant)
        {
            picCanvas.Refresh();
            SolidBrush mBrush = new SolidBrush(Color.Red);
            mGraph = picCanvas.CreateGraphics();
            mGraph.FillRectangle(mBrush, center.X, center.Y, 3, 3);
            mBrush = new SolidBrush(Color.Black);
            Point[] factors = new Point[cuadrant.Count];
            for (int i = 0; i < cuadrant.Count; i++)
            {
                factors[i] = new Point(cuadrant[i].X - center.X, cuadrant[i].Y - center.Y);
            }


            Point[] cuadrant2 = new Point[cuadrant.Count];
            Point[] cuadrant3 = new Point[cuadrant.Count];
            Point[] cuadrant4 = new Point[cuadrant.Count];

            for (int i = 0; i < cuadrant.Count; i++)
            {
                cuadrant2[i] = new Point(center.X - factors[i].X, center.Y + factors[i].Y);
                cuadrant3[i] = new Point(center.X - factors[i].X, center.Y - factors[i].Y);
                cuadrant4[i] = new Point(center.X + factors[i].X, center.Y - factors[i].Y);
            }
            Point[][] ellipse = {
                   cuadrant.ToArray(), cuadrant2,cuadrant3, cuadrant4
            };

            for (int i = 0; i < cuadrant.Count; i++)
            {
                mGraph.FillRectangle(mBrush, ellipse[0][i].X, ellipse[0][i].Y, 1, 1);
                mGraph.FillRectangle(mBrush, ellipse[1][i].X, ellipse[1][i].Y, 1, 1);
                mGraph.FillRectangle(mBrush, ellipse[2][i].X, ellipse[2][i].Y, 1, 1);
                mGraph.FillRectangle(mBrush, ellipse[3][i].X, ellipse[3][i].Y, 1, 1);
                Thread.Sleep(100);
            }
        }

    }
}
