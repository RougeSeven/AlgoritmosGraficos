using System;
using System.Collections;
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
    public partial class FrmRecorte : Form
    {
        private BresenhamLinesAux bresLines=new BresenhamLinesAux();
        private AplicarRecorte lineClipper=new AplicarRecorte();
        private List<BresenhamLinesAux> lineList;
        private Bitmap canvas;
        private Bitmap lineCanvas;
        private Bitmap clipAreaCanvas;

        private bool secondClick;
        public FrmRecorte()
        {
            InitializeComponent();
            secondClick = false;
            lineList = new List<BresenhamLinesAux>();
        }

        private void grbControles_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs ev = (MouseEventArgs)e;
            bresLines.drawEnd(picCanvas, ev.Location, Color.Blue);
            if (!secondClick)
            {
                bresLines = new BresenhamLinesAux();
                bresLines.getStart(ev.Location);
                secondClick = true;
            }
            else
            {
                bresLines.getEnd(ev.Location);
                MessageBox.Show(bresLines.p_0.ToString() + " y " + bresLines.p_f.ToString());
                bresLines.calculate();
                bresLines.getPoints();
                bresLines.drawPoints(picCanvas);
                lineList.Add(bresLines);
                secondClick = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            lineList.Clear();
        }

        private void btnRestartClipzone_Click(object sender, EventArgs e)
        {
            lineClipper.initializeData(txtXmin,txtYmin,txtXmax, txtYmax, picCanvas);
        }
        private void drawClipArea(object sender, EventArgs e)
        {
            lineClipper.readData(txtXmin, txtYmin, txtXmax, txtYmax);
            lineClipper.drawWindow(picCanvas);
        }
        private void clip(object sender, EventArgs e)
        {
            foreach (var line in lineList)
            {
                lineClipper.clip(line,picCanvas);
            }
        }
    }
}
