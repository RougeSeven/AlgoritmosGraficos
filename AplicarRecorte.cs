using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms;
using System.Security.Policy;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;

namespace AlgoritmoRecorteLineas
{

    internal class AplicarRecorte
    {
        private int Xmin;
        private int Ymin;
        private int Xmax;
        private int Ymax;
        int[] areaCode = { 0, 0, 0, 0 };
        private Pen mPen;
        private Graphics mGraph;
        private SolidBrush mBrush;

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
            picCanvas.Refresh();
        }
        public void drawWindow(PictureBox picCanvas)
        {
            Color backColor = Color.FromArgb(255, 255, 255, 237);
            mPen = new Pen(Color.Black, 2);
            mBrush = new SolidBrush(backColor);
            mGraph=picCanvas.CreateGraphics();
            mGraph.DrawLine(mPen, new Point(0, Ymin), new Point(picCanvas.Width, Ymin));
            mGraph.DrawLine(mPen, new Point(0, Ymax), new Point(picCanvas.Width, Ymax));
            mGraph.DrawLine(mPen, new Point(Xmin, 0), new Point(Xmin, picCanvas.Height));
            mGraph.DrawLine(mPen, new Point(Xmax, 0), new Point(Xmax, picCanvas.Height));
            mGraph.FillRectangle(mBrush, Xmin, Ymin, (Xmax - Xmin), (Ymax - Ymin));
            mGraph.DrawRectangle(mPen, Xmin, Ymin, (Xmax - Xmin), (Ymax - Ymin));
        }
        public void clip(BresenhamLinesAux line, PictureBox picCanvas)
        {
            Point startpoint = line.p_0;
            Point endpoint = line.p_f;
            if (checkPointInArea(startpoint) && checkPointInArea(endpoint))
            {
                //mensaje = "Linea completamente dentro del area visible";
            }
            else
            {
                bool[] codesAND=andOperation(getPointCode(startpoint),getPointCode(endpoint));
                int[] codesANDnumeric = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    codesANDnumeric[i] = Convert.ToInt32(codesAND[i]);
                }

                if (codesANDnumeric.SequenceEqual(areaCode))
                {
                    if(!checkPointInArea(startpoint))
                    {
                        clipIntersection(line, startpoint, "start", picCanvas);
                    }
                    if (!checkPointInArea(endpoint))
                    {
                        clipIntersection(line, endpoint, "end", picCanvas);
                    }
                }
                else
                {
                    removeLine(line, picCanvas);
                }
            }
        }

        public bool checkPointInArea(Point point)
        {
            bool isPointInArea;
            bool[] pointCodeBool=getPointCode(point);
            int[] pointCode= new int[4];
            string code = "";
            for(int i = 0; i< 4; i++)
            {
                pointCode[i] = Convert.ToInt32(pointCodeBool[i]);
                code += pointCode[i].ToString();
            }
            isPointInArea = (pointCode.SequenceEqual(areaCode));
            return isPointInArea;
        }
        public bool[] getPointCode(Point point)
        {
            bool[] code= { point.Y > Ymax, point.Y < Ymin, point.X > Xmax, point.X < Xmin };
            return code;
        }

        public bool[] andOperation(bool[] code1, bool[] code2)
        {
            bool[] andResult= new bool[4];
            for(int i=0; i<4;i++)
            {
                andResult[i]=(code1[i]&&code2[i]);
            }
            return andResult;
        }

        public void removeLine(BresenhamLinesAux line, PictureBox picCanvas)
        {
            mGraph=picCanvas.CreateGraphics();
            mPen=new Pen(Color.White,2);
            line.drawEnd(picCanvas, line.p_0, Color.White);
            line.drawEnd(picCanvas, line.p_f, Color.White);
            //mGraph.DrawLine(mPen, line.p_0, line.p_f);
            foreach (Point linePoint in line.pointsList)
            {
                mGraph.DrawRectangle(mPen, linePoint.X, linePoint.Y,1,1);
            }
        }
        public void clipIntersection(BresenhamLinesAux line, Point pointEx, string type, PictureBox picCanvas)
        {
            line.drawEnd(picCanvas, new Point(pointEx.X, pointEx.Y), Color.White);
            int lineIntersectB = Convert.ToInt32(Math.Round(pointEx.Y - (line.slope * pointEx.X)));
            int intersectX;
            int intersectY;
            Point intersectPoint;
            bool[] code = getPointCode(pointEx);
            if (!code[3]&& !code[2])//Punto justo arriba o justo abajo
            {
                if (code[0])//Completamente arriba
                {
                    intersectY = Ymax;
                }
                else
                {
                    intersectY = Ymin;
                }
                intersectX = line.pointsList.Find(point => point.Y == intersectY).X;
            }
            else//Punto a la derecha o izquierda (Puede ser diagonal)
            {
                if(code[2])//Derecha
                {
                    intersectX = Xmax;
                }
                else//Izquierda
                {
                    intersectX = Xmin;
                }
                intersectY = line.pointsList.Find(point => point.X == intersectX).Y;
                if (!checkPointInArea(new Point(intersectX, intersectY)))//Diagonal por arriba o debajo
                {
                    if (code[0])//Diagonal arriba
                    {
                        intersectY = Ymax;
                    }
                    else
                    {
                        intersectY = Ymin;
                    }
                    intersectX = line.pointsList.Find(point => point.Y == intersectY).X;
                }
            }
            intersectPoint = new Point(intersectX, intersectY);
            List<Point> removedSegment = new List<Point>();
            if(type=="start")
            {
                int i = 0;
                int inIndex=line.pointsList.IndexOf(intersectPoint);
                int exIndex=line.pointsList.IndexOf(pointEx);
                Point linePoint = pointEx;
                while(linePoint!=intersectPoint)
                {
                    linePoint=line.pointsList[i];
                    removedSegment.Add(linePoint);
                    line.pointsList.Remove(linePoint);
                    i++;
                }
                line.p_0=intersectPoint;
            }
            else
            {
                int i = line.pointsList.IndexOf(line.pointsList.Last());
                Point linePoint = line.pointsList.Last();
                while (linePoint != intersectPoint)
                {
                    linePoint = line.pointsList[i];
                    removedSegment.Add(linePoint);
                    line.pointsList.Remove(linePoint);
                    i--;
                }
                line.p_f = intersectPoint;
            }
            removeLineSegment(removedSegment, picCanvas);
            line.drawEnd(picCanvas, new Point(intersectX, intersectY), Color.Red);
        }
        public void removeLineSegment(List<Point> removedSegment, PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.White, 3);
            foreach (Point point in removedSegment)
            {
                mGraph.DrawRectangle(mPen, point.X, point.Y, 1, 1);
            }
        }
    }
}
