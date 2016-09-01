using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
 	// y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter x: ");
            string xStr = Console.ReadLine();
            double xDbl = Convert.ToDouble(xStr);
            double yDbl = CalculateY(xDbl);
            Console.WriteLine(yDbl);
        }

        public static double CalculateY(double x)
        {
            //YOUR CODE HERE
            double y = 5 * Math.Pow(x, 2) - 4 * x + 3;
            return y;
        }
    }
}
