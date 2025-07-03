using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AlgoritmosPixeles
{
    internal class DiscreteLines
    {
        private Point p_0;
        private Point p_f;
        private float diff_x;
        private float diff_y;
        private int k;
        private float slope;
        private bool fullyVertical;
        private bool negativeX;
        private bool negativeY;
        private List<Point> points;
        private Pen mPen;
        private Graphics mGraph;


        public DiscreteLines()
        {
            p_0 = new Point();
            p_f = new Point();
            diff_x = 0.0f;
            diff_y = 0.0f;
            slope = 0.0f;
            k = 0;
            fullyVertical = false;
            negativeX = false;
            negativeY = false;
            points = new List<Point>();
        }

        public void readData(System.Windows.Forms.TextBox txtPx1, System.Windows.Forms.TextBox txtPy1, System.Windows.Forms.TextBox txtPx2, System.Windows.Forms.TextBox txtPy2)
        {
            try
            {
                p_0.X =Convert.ToInt32(txtPx1.Text);
                p_0.Y = Convert.ToInt32(txtPy1.Text);
                p_f.X = Convert.ToInt32(txtPx2.Text);
                p_f.Y = Convert.ToInt32(txtPy2.Text);
            }
            catch
            {
                MessageBox.Show("Entrada incorrecta, por favor solo enteros");
            }
        }

        public void initializeData(System.Windows.Forms.TextBox txtPx1, System.Windows.Forms.TextBox txtPy1, System.Windows.Forms.TextBox txtPx2,
            System.Windows.Forms.TextBox txtPy2, PictureBox picCanvas)
        {
            txtPx1.Text = "";
            txtPx2.Text = "";
            txtPy1.Text = "";
            txtPy2.Text = "";
            picCanvas.Refresh();
            p_0 = new Point();
            p_f = new Point();
            diff_x = 0.0f;
            diff_y = 0.0f;
            slope = 0.0f;
            k = 0;
            fullyVertical = false;
            negativeX = false;
            negativeY = false;
            points.Clear();
        }

        public void calculateDiscrete()
        {
            diff_x = (float)(Math.Abs(p_f.X - p_0.X));
            negativeX = ((p_f.X - p_0.X) < 0);
            diff_y = (float)(Math.Abs(p_f.Y - p_0.Y));
            negativeY = ((p_f.Y - p_0.Y) < 0);
            if(diff_y==0)
            {
                slope = 0.0f;
                fullyVertical = true;
            }
            else
            {
                slope = diff_y / diff_x;
            }
            if (diff_x > diff_y)
            {
                //Pendiente menor a 1
                k = Convert.ToInt32(diff_x);
            }
            else
            {
                k = Convert.ToInt32(diff_y);
            }
        }
        public void drawEnds(PictureBox picCanvas)
        {
            mPen = new Pen(Color.Blue, 2);
            mGraph = picCanvas.CreateGraphics();
            int radius = 5;
            mGraph.DrawEllipse(mPen, (p_0.X - radius), (p_0.Y - radius), (2 * radius), (2 * radius));
            mGraph.DrawEllipse(mPen, (p_f.X - radius), (p_f.Y - radius), (2 * radius), (2 * radius));
        }

        public void drawDiscrete(PictureBox picCanvas)
        {
            picCanvas.Refresh();
            drawEnds(picCanvas);
            mPen = new Pen(Color.Black, 2);
            mGraph = picCanvas.CreateGraphics();
            Point pointi = new Point();
            Point pointf = new Point();
            float coordenate_k = (slope < 1) ? p_0.Y : p_0.X;
            float factor = (slope < 1) ? slope : (1/slope);
            pointi = p_0;
            points.Add(pointi);
            for (int i = 1; i <= k; i++)
            {
                if(!fullyVertical)
                {
                    coordenate_k = (float)(coordenate_k + factor);
                    if (slope < 1)
                    {
                        pointf.X = (!negativeX) ? pointi.X + 1 : pointi.X - 1;
                        pointf.Y = Convert.ToInt32(Math.Round(coordenate_k));
                    }
                    else
                    {
                        pointf.Y = (!negativeY) ? pointi.Y + 1 : pointi.Y - 1;
                        pointf.X = Convert.ToInt32(Math.Round(coordenate_k));
                    }
                }
                else
                {
                    pointf.X = pointi.X;
                    pointf.Y = (!negativeY) ? pointi.Y + 1 : pointi.Y - 1;
                }
                    mGraph.DrawLine(mPen, pointi, pointf);
                points.Add(pointf);
                Thread.Sleep(25);
                pointi = pointf;
            }
        }
    }
}
