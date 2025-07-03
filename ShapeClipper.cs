using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoRecorteLineas
{
    internal class ShapeClipper
    {
        private int Xmin;
        private int Ymin;
        private int Xmax;
        private int Ymax;
        int[] areaCode = { 0, 0, 0, 0 };
        private Pen mPen;
        private Graphics mGraph;
        private List<Point> clippedShape;
        private SolidBrush mBrush;

        public ShapeClipper()
        {
            Xmax = 0;
            Ymax = 0;
            Xmin = 0;
            Ymin = 0;
        }
        public void readData(System.Windows.Forms.TextBox txtPminX, System.Windows.Forms.TextBox txtPminY, System.Windows.Forms.TextBox txtPmaxX, System.Windows.Forms.TextBox txtPmaxY)
        {
            try
            {
                Xmin = Convert.ToInt32(txtPminX.Text);
                Ymin = Convert.ToInt32(txtPminY.Text);
                Xmax = Convert.ToInt32(txtPmaxX.Text);
                Ymax = Convert.ToInt32(txtPmaxY.Text);
            }
            catch
            {
                MessageBox.Show("Entrada incorrecta, por favor solo enteros");
            }
        }
        public void initializeData(System.Windows.Forms.TextBox txtXmin, System.Windows.Forms.TextBox txtYmin,
            System.Windows.Forms.TextBox txtXmax, System.Windows.Forms.TextBox txtYmax,
            PictureBox picCanvas)
        {
            txtXmin.Text = "";
            txtXmax.Text = "";
            txtYmin.Text = "";
            txtYmax.Text = "";
            Xmax = 0;
            Ymax = 0;
            Xmin = 0;
            Ymin = 0;
            picCanvas.Refresh();
        }
        public void drawWindow(PictureBox picCanvas)
        {
            Color backColor = Color.FromArgb(80, 27, 110, 237);
            mPen = new Pen(Color.Black, 2);
            mBrush = new SolidBrush(backColor);
            mGraph = picCanvas.CreateGraphics();
            mGraph.DrawLine(mPen, new Point(0, Ymin), new Point(picCanvas.Width, Ymin));
            mGraph.DrawLine(mPen, new Point(0, Ymax), new Point(picCanvas.Width, Ymax));
            mGraph.DrawLine(mPen, new Point(Xmin, 0), new Point(Xmin, picCanvas.Height));
            mGraph.DrawLine(mPen, new Point(Xmax, 0), new Point(Xmax, picCanvas.Height));
        }

        public void drawClippedShape(PictureBox picCanvas)
        {
            mGraph=picCanvas.CreateGraphics();
            mBrush = new SolidBrush(Color.Red);
            picCanvas.Refresh();
            mGraph.FillPolygon(mBrush, clippedShape.ToArray());
            drawWindow(picCanvas);
        }
        public void clipShape(List<Point> vertixes, List<BresenhamLinesAux> edges)
        {
            clippedShape = new List<Point>();
            for(int i=0;i<edges.Count;i++)
            {
                getIntersections(edges[i]);
            }
        }
        public void getIntersections(BresenhamLinesAux line)
        {
            if(checkPointInArea(line.p_0)&&checkPointInArea(line.p_f))
            {
                clippedShape.Add(line.p_f);
            }
            else if(!checkPointInArea(line.p_0) && checkPointInArea(line.p_f))
            {
                if (pointInCorner(line.p_0)&& !line.pointsList.Contains(getCorner(line.p_0)))
                {
                    clippedShape.Add(getCorner(line.p_0));
                }
                clippedShape.Add(intersectionPoint(line, line.p_0));
                clippedShape.Add(line.p_f);
            }
            else if (checkPointInArea(line.p_0) && !checkPointInArea(line.p_f))
            {
                clippedShape.Add(intersectionPoint(line, line.p_f));
                if(pointInCorner(line.p_f) && !line.pointsList.Contains(getCorner(line.p_f)))
                {
                    clippedShape.Add(getCorner(line.p_f));
                }
            }
            else
            {
                bool[] codesAND = andOperation(getPointCode(line.p_0), getPointCode(line.p_f));
                int[] codesANDnumeric = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    codesANDnumeric[i] = Convert.ToInt32(codesAND[i]);
                }
                if (codesANDnumeric.SequenceEqual(areaCode))
                {
                    clippedShape.Add(intersectionPoint(line, line.p_0));
                    clippedShape.Add(intersectionPoint(line, line.p_f));
                }
            }
        }

        public Point intersectionPoint(BresenhamLinesAux line, Point pointOut)
        {
            Point intersectPoint=new Point();
            bool[] code = getPointCode(pointOut);
            if (!code[3] && !code[2])//Punto justo arriba o justo abajo
            {
                if (code[0])//Completamente arriba
                {
                    intersectPoint.Y = Ymax;
                }
                else
                {
                    intersectPoint.Y = Ymin;
                }
                intersectPoint.X = line.pointsList.Find(point => point.Y == intersectPoint.Y).X;
            }
            else//Punto a la derecha o izquierda (Puede ser diagonal)
            {
                if (code[2])//Derecha
                {
                    intersectPoint.X = Xmax;
                }
                else//Izquierda
                {
                    intersectPoint.X = Xmin;
                }
                intersectPoint.Y = line.pointsList.Find(point => point.X == intersectPoint.X).Y;
                if (!checkPointInArea(intersectPoint))//Diagonal por arriba o debajo
                {
                    if (code[0])//Diagonal arriba
                    {
                        intersectPoint.Y = Ymax;
                    }
                    else
                    {
                        intersectPoint.Y = Ymin;
                    }
                    intersectPoint.X = line.pointsList.Find(point => point.Y == intersectPoint.Y).X;
                }
            }
            return intersectPoint;
        }
        public bool pointInCorner(Point point)
        {
            bool[] code = getPointCode(point);
            if ((code[0] || code[1]) && (code[2] || code[3]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool[] andOperation(bool[] code1, bool[] code2)
        {
            bool[] andResult = new bool[4];
            for (int i = 0; i < 4; i++)
            {
                andResult[i] = (code1[i] && code2[i]);
            }
            return andResult;
        }
        public Point getCorner(Point point)
        {
            Point cornerPoint=new Point();
            bool[] code = getPointCode(point);
            if(code[0])
            {
                cornerPoint.Y = Ymax;
            }
            else if(code[1])
            {
                cornerPoint.Y=Ymin;
            }
            if(code[2])
            {
                cornerPoint.X = Xmax;
            }
            else if( code[3])
            {
                cornerPoint.X=Xmin;
            }
            return cornerPoint;
        }
        public bool checkPointInArea(Point point)
        {
            bool isPointInArea;
            bool[] pointCodeBool = getPointCode(point);
            int[] pointCode = new int[4];
            string code = "";
            for (int i = 0; i < 4; i++)
            {
                pointCode[i] = Convert.ToInt32(pointCodeBool[i]);
                code += pointCode[i].ToString();
            }
            isPointInArea = (pointCode.SequenceEqual(areaCode));
            return isPointInArea;
        }
        public bool[] getPointCode(Point point)
        {
            bool[] code = { point.Y > Ymax, point.Y < Ymin, point.X > Xmax, point.X < Xmin };
            return code;
        }
    }
}
