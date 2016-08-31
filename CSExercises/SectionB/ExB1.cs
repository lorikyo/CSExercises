using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("enter double precision number to square root: ");
            string inputString = Console.ReadLine();
            double inputDbl = Convert.ToDouble(inputString);
            double result = SQRT(inputDbl);
            Console.WriteLine(result);
        }

        public static double SQRT(double x)
        {
            //YOUR CODE HERE: return the square root of x
            double ans = Math.Sqrt(x);
            return ans;

        }
    }
}
