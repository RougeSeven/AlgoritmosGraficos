using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms;
using System.Threading;
using System.Data;
using System.Reflection;

namespace AlgoritmosPixeles
{
    internal class DiscreteCircle
    {
        private Point center;
        private int radius;
        private Pen mPen;
        private Graphics mGraph;
        private DataTable points;
        private int delayFactor;

        public DiscreteCircle()
        {
            center = new Point();
            radius = 0;
            mPen=new Pen(Color.Black,2);
            createPointsTable();
            delayFactor = 0;
        }
        public void createPointsTable()
        {
            points = new DataTable();
            points.Columns.Add("Pixel", typeof(int));
            points.Columns.Add("Valor X", typeof(int));
            points.Columns.Add("Valor Y", typeof(int));
        }
        public void getAnimationSpeed(System.Windows.Forms.TrackBar tckSpeed)
        {
            try
            {
                delayFactor = 1 + (5 * (tckSpeed.Maximum-tckSpeed.Value));
            }
            catch
            {
                MessageBox.Show("Valor fuera de límites");
            }
        }
        public void readData(System.Windows.Forms.TextBox txtPx, System.Windows.Forms.TextBox txtPy, System.Windows.Forms.TextBox txtRadius)
        {
            try
            {
                center.X = Convert.ToInt32(txtPx.Text);
                center.Y = Convert.ToInt32(txtPy.Text);
                radius = Convert.ToInt32(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Entrada incorrecta, por favor solo enteros");
            }
        }

        public void initializeData(System.Windows.Forms.TextBox txtPx, System.Windows.Forms.TextBox txtPy, System.Windows.Forms.TextBox txtRadius, PictureBox picCanvas, DataGridView pointsTable)
        {
            txtPx.Text = "";
            txtPy.Text = "";
            txtRadius.Text = "";
            picCanvas.Refresh();
            center = new Point();
            radius = 0;
            points.Rows.Clear();
            pointsTable.DataSource = points;
            delayFactor = 0;
            foreach (DataGridViewColumn col in pointsTable.Columns)
            {
                col.Width = pointsTable.Width / 3;
            }
        }
        public void calculate()
        {
            int k=0;
            if(radius%2==0)
            {
                k = (radius / 2) + 1;
            }
            else
            {
                k = Convert.ToInt32(Math.Round((double)radius/2));
            }
        }
        public void calculateOctant(PictureBox picCanvas, DataGridView pointsTable)
        {
            int x = 0;
            int y = radius;
            int p = 1-radius;
            Point pointi= new Point(center.X+x, center.Y+y);
            Point pointf= new Point();
            int k = 0;
            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p = p + (2 * x) + 3;
                }
                else
                {
                    y--;
                    p = p + 2 * (x - y) + 5;
                }
                k++;
            }
            Point[] octant = new Point[k+1];
            octant[0]=pointi;
            x = 0;
            y = radius;
            p = 1 - radius;
            int i = 0;
            while (x<y)
            {
                x++;
                if (p< 0)
                {
                    p = p + (2 * x) + 3;
                }
                else
                {
                    y--;
                    p = p + 2 * (x - y) + 5;
                }
                pointf= new Point(center.X + x, center.Y + y);
                i++;
                octant[i]=pointf;
            }
            plotCircle(picCanvas, octant, pointsTable);
        }
        public void plotCircle(PictureBox picCanvas, Point[] octant, DataGridView pointsTable)
        {
            SolidBrush mBrush = new SolidBrush(Color.Black);
            mGraph = picCanvas.CreateGraphics();
            picCanvas.Refresh();
            Point[] factors = new Point[octant.Length];
            for (int i = 0; i < octant.Length; i++)
            {
                factors[i] = new Point(octant[i].X - center.X, octant[i].Y - center.Y);
            }


            Point[] octant2 = new Point[octant.Length];
            Point[] octant3 = new Point[octant.Length];
            Point[] octant4 = new Point[octant.Length];
            Point[] octant5 = new Point[octant.Length];
            Point[] octant6 = new Point[octant.Length];
            Point[] octant7 = new Point[octant.Length];
            Point[] octant8 = new Point[octant.Length];

            for (int i = 0; i < octant.Length; i++)
            {
                octant2[i] = new Point(center.X + factors[i].Y, center.Y + factors[i].X);
                octant3[i] = new Point(center.X + factors[i].Y, center.Y - factors[i].X);
                octant4[i] = new Point(center.X + factors[i].X, center.Y - factors[i].Y);
                octant5[i] = new Point(center.X - factors[i].X, center.Y - factors[i].Y);
                octant6[i] = new Point(center.X - factors[i].Y, center.Y - factors[i].X);
                octant7[i] = new Point(center.X - factors[i].Y, center.Y + factors[i].X);
                octant8[i] = new Point(center.X - factors[i].X, center.Y + factors[i].Y);
            }
            Point[][] circulo= {
                   octant4, octant3, octant2, octant, octant8, octant7, octant6, octant5
            };

            for (int i=0;i<8;i++)
            {
                for(int j = 0; j < octant.Length; j++)
                {
                    mGraph.FillRectangle(mBrush, circulo[i][j].X, circulo[i][j].Y, 1, 1);
                    Thread.Sleep(delayFactor);
                    points.Rows.Add(((8*i)+j), circulo[i][j].X, circulo[i][j].Y);
                    if (pointsTable.InvokeRequired)
                    {
                        pointsTable.Invoke((MethodInvoker)(() =>
                        {
                            pointsTable.Refresh();
                            pointsTable.FirstDisplayedScrollingRowIndex = pointsTable.Rows.Count - 1;
                        }));
                    }
                }
            }
        }

    }
}
