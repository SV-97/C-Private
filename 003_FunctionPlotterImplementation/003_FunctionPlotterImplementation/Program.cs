using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_FunctionPlotterImplementation
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Calculator(); //Call Calculator method

            void Calculator() //Takes user-input Parameters for m and t and a value range and plots a graph for a function of general type y=mx+t
            {

                Console.WriteLine("Function y=m*x+t"); //Print general syntax of function

                double m = CheckInput("m");
                double t = CheckInput("t");

                //toDo: While-loop for input of start, end and increment parameters
                Console.WriteLine("Start: "); int start = Convert.ToInt32(Console.ReadLine()); //read start value for plotting
                Console.WriteLine("End: "); int end = Convert.ToInt32(Console.ReadLine()); end += 1; //read end value for plotting(incremented by 1)
                Console.WriteLine("Increment: "); double i = Convert.ToDouble(Console.ReadLine()); //read increment size

                Console.WriteLine("X        Y");

                for (double x = start; x < end; x += i) //calculate values
                {
                    double y = m * x + t;
                    Console.WriteLine("{0}        {1}", Convert.ToString(x), Convert.ToString(y));
                }
            }

            double CheckInput(string varName) //method to check if input was given and manage fallback values
            {
                double output;

                Console.WriteLine("Input {0}: ", varName); string varTemp = Console.ReadLine(); //read value for variable
                if (String.IsNullOrEmpty(varTemp) == true) //check if no input was given
                {
                    switch (varName) // fallback value
                    {
                        case "m":
                            output = 1;
                            break;

                        case "t":
                            output = 0;
                            break;

                        default: //default not used yet; maybe used in functions of higher order?
                            output = 0;
                            break;
                    }
                }
                else
                {
                    output = Convert.ToDouble(varTemp); //write input to actual operation variable
                };

                return output;
            }

        }
    }
}

namespace System.Drawing
{
    class drawing
    {
        private void DrawCurvePointTension(PaintEventArgs e)
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
            e.Graphics.DrawLines(redPen, curvePoints);

            // Create tension.
            float tension = 1.0F;

            // Draw curve to screen.
            e.Graphics.DrawCurve(greenPen, curvePoints, tension);
        }
    }
}