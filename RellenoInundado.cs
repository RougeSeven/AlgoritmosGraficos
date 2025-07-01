using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data;
using System.Reflection;

namespace AlgoritmosPixeles
{
    internal class RellenoInundado
    {
        private Graphics mGraph;
        private SolidBrush mBrush;
        private Point startpoint;
        private DataTable pointsList;
        private int delayFactor;
        
        public RellenoInundado()
        {
            mBrush = new SolidBrush(Color.LightCoral);
            startpoint = new Point();
            createPointsTable();
        }
        public void InitializeData(DataGridView pointsTable)
        {
            pointsTable.Rows.Clear();
            pointsList.Rows.Clear();
            pointsTable.DataSource = pointsList;
            foreach (DataGridViewColumn col in pointsTable.Columns)
            {
                col.Width = pointsTable.Width/3;
            }
        }
        public void getAnimationSpeed(TrackBar tckSpeed)
        {
            try
            {
                delayFactor = 1 + (5 * (tckSpeed.Maximum - tckSpeed.Value));
            }
            catch
            {
                MessageBox.Show("Valor fuera de límites");
            }
        }
        public void createPointsTable()
        {
            pointsList = new DataTable();
            pointsList.Columns.Add("Pixel", typeof(int));
            pointsList.Columns.Add("Valor X", typeof(int));
            pointsList.Columns.Add("Valor Y", typeof(int));
        }
        public void getStartPoint(Point mouseClick)
        {
            startpoint = mouseClick;
        }
 
        public bool getPixelatedColorss(int x, int y, Bitmap canvas)
        {
            if (x < 0 || y < 0 || x >= canvas.Width || y >= canvas.Height)
            {
                MessageBox.Show("Coordenadas fuera de rango.");
                return false;
            }
            Color pixelColor=canvas.GetPixel(x,y);
            if(pixelColor.ToArgb()!=Color.Black.ToArgb() && pixelColor.ToArgb()!=mBrush.Color.ToArgb())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void fillShape(PictureBox picCanvas, Bitmap canvas, DataGridView pointsTable)
        {

            Task.Run(() => { floodFillIterative(picCanvas, canvas, pointsTable); });
        }
        public void FillPoint(int x, int y, PictureBox picCanvas, Bitmap canvas)
        {
            mGraph = Graphics.FromImage(canvas);
            canvas.SetPixel(x, y, mBrush.Color);
            if (picCanvas.InvokeRequired)
            {
                picCanvas.Invoke((MethodInvoker)(() => {
                    picCanvas.Image = (Bitmap)canvas.Clone();
                }));
            }
        }

        public void floodFillIterative(PictureBox picCanvas, Bitmap canvas, DataGridView pointsTable)
        {
            Queue<Point> puntos = new Queue<Point>();
            pointsTable.DataSource = pointsList;
            puntos.Enqueue(startpoint);//Encolar el punto inicial
            Point puntoActual;//Crear un punto en blanco para iterar
            int counter = 0;
            while(puntos.Count>0)
            {
                puntoActual = puntos.Dequeue();//Saca el punto actual
                if(puntoActual.X<0 || puntoActual.X>canvas.Width || puntoActual.Y<0 || puntoActual.Y>canvas.Height)
                {
                    return;
                }
                if(getPixelatedColorss(puntoActual.X,puntoActual.Y,canvas))//Si el punto no esta pintado ya
                {
                    FillPoint(puntoActual.X, puntoActual.Y, picCanvas, canvas);

                    if (pointsTable.InvokeRequired)
                    {
                        pointsTable.Invoke((MethodInvoker)(() =>
                        {
                            pointsList.Rows.Add(counter, puntoActual.X, puntoActual.Y);
                            pointsTable.Refresh();
                            pointsTable.FirstDisplayedScrollingRowIndex = pointsTable.Rows.Count - 1;
                        }));
                    }

                    counter++;
                    Thread.Sleep(delayFactor);


                    puntos.Enqueue(new Point(puntoActual.X, puntoActual.Y + 1));//Norte
                    puntos.Enqueue(new Point(puntoActual.X + 1, puntoActual.Y));//Este
                    puntos.Enqueue(new Point(puntoActual.X, puntoActual.Y - 1));//Sur
                    puntos.Enqueue(new Point(puntoActual.X - 1, puntoActual.Y));//Oeste
                }
            }
        }
    }

}
