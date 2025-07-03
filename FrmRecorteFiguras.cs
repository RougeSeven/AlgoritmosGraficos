using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoRecorteLineas
{
    public partial class FrmRecorteFiguras : Form
    {
        private ShapeClipper shapeClip = new ShapeClipper();
        private List<Point> shapePoints;
        private List<BresenhamLinesAux> shapeEdges;
        private Graphics mGraph;
        private SolidBrush mBrush;
        private BresenhamLinesAux cursorLine;
        public FrmRecorteFiguras()
        {
            InitializeComponent();
            shapePoints = new List<Point>();
            shapeEdges = new List<BresenhamLinesAux>();
            mGraph=picCanvas.CreateGraphics();
            cursorLine = new BresenhamLinesAux();
        }

        private void FrmRecorteFiguras_Load(object sender, EventArgs e)
        {
            shapeClip.initializeData(txtXmin,txtYmin, txtXmax, txtYmax, picCanvas);
        }

        private void drawClipArea(object sender, EventArgs e)
        {
            shapeClip.readData(txtXmin, txtYmin, txtXmax, txtYmax);
            shapeClip.drawWindow(picCanvas);
        }

        private void resetClipArea(object sender, EventArgs e)
        {
            shapeClip.initializeData(txtXmin, txtYmin, txtXmax, txtYmax, picCanvas);
        }
        private void clip(object sender, EventArgs e)
        {
            shapeClip.clipShape(shapePoints,shapeEdges);
            shapeClip.drawClippedShape(picCanvas);
        }

        private void drawShape(object sender, EventArgs e)
        {
            getShapeLines();
            Point[] shape=shapePoints.ToArray();
            mBrush=new SolidBrush(Color.Green);
            mGraph.FillPolygon(mBrush, shape);
        }
        private void getShapePoints(object sender, EventArgs e)
        {

            
           MouseEventArgs ev = (MouseEventArgs)e;
            shapePoints.Add(ev.Location);
            cursorLine.drawEnd(picCanvas, ev.Location, Color.Red);
        }
        private void getShapeLines()
        {
            cursorLine=new BresenhamLinesAux();
            for (int i = 0; i < shapePoints.Count; i++)
            {
                if(i== shapePoints.Count-1)
                {
                    cursorLine.getStart(shapePoints.Last());
                    cursorLine.getEnd(shapePoints.First());
                }
                else
                {
                    cursorLine.getStart(shapePoints[i]);
                    cursorLine.getEnd(shapePoints[i+1]);
                }
                cursorLine.calculate();
                cursorLine.getPoints();
                shapeEdges.Add(cursorLine);
                cursorLine = new BresenhamLinesAux();
            }
        }

        public void clipShape(object sender, EventArgs e)
        {
            
        }
        public void clear(object sender, EventArgs e)
        {
            shapeClip.initializeData(txtXmin, txtYmin, txtXmax, txtYmax, picCanvas);
            shapePoints.Clear();
            shapeEdges.Clear();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
