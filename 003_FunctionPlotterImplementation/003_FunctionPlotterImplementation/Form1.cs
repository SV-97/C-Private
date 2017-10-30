using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_FunctionPlotterImplementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Btn_done_Click(object sender, EventArgs e)
        {
           
            string m = Txt_m.Text;
            string t = Txt_t.Text;
            string Start = Txt_Lo.Text;
            string End = Txt_Hi.Text;
            string i = Txt_i.Text;
            double[,] values = Program.Calculator( m, t, Start, End , i); //Call Calculator method

            for (int i1 = 0; i1 < values.GetLength(0); i1++) //Write X and Y values into Listboxes
            {
                ListView1.Items.Add(Convert.ToString(values[i1,0]));
                ListView2.Items.Add(Convert.ToString(values[i1,1]));
            };
           
        }

    }
}

namespace System.Drawing
{
    class Drawing
    {
        public void DrawCurvePointTension(PaintEventArgs PlotBox1)
        {

            // Create pens.
            Pen redPen = new Pen(Color.Red, 3);
            Pen greenPen = new Pen(Color.Green, 3);

            // Create points that define curve.
            Point point1 = new Point(50, 50);
            Point point2 = new Point(100, 25);
            Point point3 = new Point(200, 5);
            Point point4 = new Point(250, 50);
            Point point5 = new Point(300, 100);
            Point point6 = new Point(350, 200);
            Point point7 = new Point(250, 250);
            Point[] curvePoints = { point1, point2, point3, point4, point5, point6, point7 };

            // Draw lines between original points to screen.
            PlotBox1.Graphics.DrawLines(redPen, curvePoints);

            // Create tension.
            float tension = 1.0F;

            // Draw curve to screen.
            PlotBox1.Graphics.DrawCurve(greenPen, curvePoints, tension);
        }
    }
}