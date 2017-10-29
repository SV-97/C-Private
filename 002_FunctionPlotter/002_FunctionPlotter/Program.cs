using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_FunctionPlotter
{
    class Program
    {
        static void Main(string[] args) //Takes user-input Parameters for m and t and a value range and plots a graph for a function of general type y=mx+t
        {
            
            Console.WriteLine("Function y=m*x+t"); //Print general syntax of function

            double m = CheckInput( "m" );
            double t = CheckInput( "t" );

            //toDo: While-loop for input of start, end and increment parameters
            Console.WriteLine( "Start: " ); int start = Convert.ToInt32( Console.ReadLine() ); //read start value for plotting
            Console.WriteLine( "End: " ); int end = Convert.ToInt32( Console.ReadLine() ); end += 1; //read end value for plotting(incremented by 1)
            Console.WriteLine( "Increment: " ); double i = Convert.ToDouble( Console.ReadLine() ); //read increment size

            Console.WriteLine("X        Y");

            for (double x = start; x < end; x += i) //calculate values
            {
                double y = m * x + t;
                Console.WriteLine("{0}        {1}", Convert.ToString( x ), Convert.ToString( y ) );
            }
        }

        static double CheckInput( string varName ) //method to check if input was given and manage fallback values
        {
            double output ;

            Console.WriteLine( "Input {0}: ", varName ); string varTemp = Console.ReadLine(); //read value for variable
            if (String.IsNullOrEmpty( varTemp ) == true) //check if no input was given
            {
                switch ( varName ) // fallback value
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
                output = Convert.ToDouble( varTemp ); //write input to actual operation variable
            };

            return output;
        }
    }
}
