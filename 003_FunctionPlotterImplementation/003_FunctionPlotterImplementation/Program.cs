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
        }

        internal static double[,] Calculator(string m_in, string t_in, string start_in, string end_in, string i_in) //Takes user-input Parameters for m and t and a value range and plots a graph for a function of general type y=mx+t
        {
            Console.WriteLine("Function y=m*x+t"); //Print general syntax of function
            Console.WriteLine("Function y={0}*x+{1}", m_in, t_in); //Print specific syntax of function

            m_in.Replace(".",","); //Substringsubstitution to assure valid float-values in arithmetics
            t_in.Replace(".", ",");
            i_in.Replace(".", ",");

            double m = CheckInput( m_in, "m" ); //Check for null values and convert string to double - deprecated with the introduction of textboxes - remove in future version
            double t = CheckInput( t_in, "t" ); //Check for null values and convert string to double - deprecated with the introduction of textboxes - remove in future version
            int start = Convert.ToInt32( start_in ); //read start value for plotting
            int end = Convert.ToInt32( end_in ); end += 1; //read end value for plotting(incremented by 1)
            double i = Convert.ToDouble( i_in ); //read increment size
                
            int iterations = Convert.ToInt32(Math.Floor((end - start )/ i )); //number of iterations to define length of multi-dimensional array
            double[,] values = new double[iterations,2];
            int iteration = 0;

            Console.WriteLine("m {0} ; t {1}", m, t);
            Console.WriteLine("X        Y");

             for (double x = start; x < end; x += i) //calculate values
             {
                double y = m * x + t;
                Console.WriteLine("{0}        {1}", Convert.ToString(x), Convert.ToString(y));
                values[iteration, 0] = x;
                values[iteration, 1] = y;
                iteration += 1;
             }
            Console.WriteLine("array is {0}", values);
             return values;
        }

        static double CheckInput(string varValue, string varName) //method to check if input was given and manage fallback values
        {
            double output;

            Console.WriteLine("Input {0}: ", varName); //read value for variable
            if (String.IsNullOrEmpty(varValue) == true) //check if no input was given
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
                        output = 1;
                        break;
                }
            }
            else
            {
                output = Convert.ToDouble(varValue); //write input to actual operation variable
            };

            return output;
        }
    }
}

namespace System.Drawing
{
    class Drawing
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