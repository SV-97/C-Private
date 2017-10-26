using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_FunctionPlotter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Function y=m*x+t"); //Print general syntax of function

            int m = 1; //default value m
            int t = 0; //default value t

            /* How to isNullOrEmpty?
            string mTemp = Console.ReadLine()
            if ( mTemp.isNullOrEmpty )
            { };
            */

            Console.WriteLine("Input m: ");  m = Convert.ToInt32(Console.ReadLine()); //read value for m
            Console.WriteLine("Input t: ");  t = Convert.ToInt32(Console.ReadLine());//read value for t
            Console.WriteLine("Start: "); int start = Convert.ToInt32(Console.ReadLine());//read start value for plotting
            Console.WriteLine("End: "); int end = Convert.ToInt32(Console.ReadLine()); end = +1;//read end value for plotting
            Console.WriteLine("Increment: "); int i = Convert.ToInt32(Console.ReadLine());//read increment size

            Console.WriteLine("X        Y");

            for (int x = start; x < end; x += i) //calculate values
            {
                int y = m * x + t;
                Console.WriteLine( Convert.ToString(x));
                Console.Write( Convert.ToString(y));
            }
        }
    }
}
