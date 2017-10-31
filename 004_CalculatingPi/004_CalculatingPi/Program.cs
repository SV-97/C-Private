using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_CalculatingPi
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = 1000000;
            double[] array = new double [end/2];
            int j = 0;
            double pi = 0;

            for (int i = 1; i < end; i += 2) //writes odd numbers into array
            {
                array[j] = i;
                j++;
            }

                for (int i = 0; i < array.GetLength(0); i++)
            {
                pi += Math.Pow(-1.0, Convert.ToDouble(i)) * (4/array[i]);
            }
            Console.WriteLine(pi);
        }
    }
}