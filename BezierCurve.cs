using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CurvasBezierAvanzado
{
    internal class BezierCurve
    {
        private static System.Windows.Forms.Timer aTimer;
        private List<PointF> pointsList;
        private List<PointF> curvePoints;
        private int nPoints;
        private Pen mPen;
        private Graphics mGraphs;

        public BezierCurve()
        {
            pointsList = new List<PointF>();
            curvePoints = new List<PointF>();
            nPoints = 0;
            setTimer();
        }
        public void setTimer()
        {
            aTimer = new Timer();
            aTimer.Interval = 100;
            aTimer.Enabled = true;
        }
        public void addPoint(PointF newPoint)
        {
            try
            {
                pointsList.Add(newPoint);
            }
            catch
            {
                MessageBox.Show("Punto no válido");
            }
        }
        public void createLines(PictureBox picCanvas)
        {
            mGraphs=picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 3/4);
            nPoints = pointsList.Count-1;
            for(int i=0;i<pointsList.Count-1;i++)
            {
                mGraphs.DrawLine(mPen, pointsList[i], pointsList[i + 1]);
            }
        }
        public void getCurvePoints()
        {
            int nValue=nPoints;
            float tIncrement=0.01F;
            int k = 0;
            float pointX = 0.0F;
            float pointY = 0.0F;
            float factor;
            PointF newPoint;
            for (float t=0; t<=1;t+=tIncrement)
            {
                while((nValue-k)>=0)
                {
                    factor=(float)(Math.Pow((1-t), (nValue - k)) *Math.Pow(t, k))*combine(nValue,k);
                    pointX+=pointsList[k].X*factor;
                    pointY+=pointsList[k].Y*factor;
                    k++;
                }
                newPoint = new PointF(pointX, pointY);
                curvePoints.Add(newPoint);
                pointX = 0.0F;
                pointY = 0.0F;
                k =0;
            }
        }
        public float combine(int n, int r)
        {
            float combination = factorial(n) / (factorial(n - r)*factorial(r));
            return combination;
        }
        public int factorial(int value)
        {
            int factorial = 1;
            for(int i=value;i>0;i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        public void drawCurve(PictureBox picCanvas)
        {
            mGraphs = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Green, 3/ 4);
            int i = 0;
            aTimer.Tick += (sender,e) =>
                {
                        if (i < curvePoints.Count - 1)
                        {
                            mGraphs.DrawLine(mPen, curvePoints[i], curvePoints[i + 1]);
                            i++;
                            aTimer.Enabled = true;
                        }
                        else
                        {
                            aTimer.Stop();
                            mGraphs.DrawLine(mPen, curvePoints.Last(), pointsList.Last());
                            return;
                        }
            };
            aTimer.Start();
        }
        
        public void drawEnd(PictureBox picCanvas, Point endPoint)
        {
            mPen = new Pen(Color.Red, 2);
            mGraphs = picCanvas.CreateGraphics();
            int radius = 1;
            mGraphs.DrawEllipse(mPen, (endPoint.X - radius), (endPoint.Y - radius), (2 * radius), (2 * radius));
        }
        public void InitializeData(PictureBox picCanvas)
        {
            picCanvas.Refresh();
            pointsList.Clear();
            curvePoints.Clear();
            nPoints = 0;
        }
    }
}
