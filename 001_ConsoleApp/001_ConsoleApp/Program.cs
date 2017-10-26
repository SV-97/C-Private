using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What is your name? "); //Print Line
            string name = Console.ReadLine(); //assign variable "name" with data type "string" value from console input
            Console.WriteLine("Hello " + name); //Print New Line with string and Variable

            var variable1 = "Schoki";
            Console.WriteLine(variable1);
            //variable1 = 123; //not allowed since variable is defined with different data type
            Console.WriteLine("variable1 is a {0}", variable1.GetTypeCode()); //Outputs data type of variable

            Console.WriteLine("Enter integer value");
            int number = Convert.ToInt16(Console.ReadLine()); //Read string from console, convert to Int16, assign to variable
            Console.WriteLine("Is {0} number {1} bigger 9 OR is {0} number {1} smaller or equal to 7?");
            if ((number > 9) || (number <= 7)) //If statement with logic OR (&& AND ; || OR ; ^ XOR ; ! NOT)
            {
                Console.WriteLine("Yes it is");
            } else {
                Console.WriteLine("No it isn't");
            }

            for (int i = 0; i < 10; i++) //For integer "i" from 1-9 in increments of 1
            {
                Console.Write(i); //Print "i" to console
            }



        }
    }
}
