using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            double x1, y1, x2, y2;
            string X1, Y1, X2, Y2;
            Console.Write("enter x1: ");
            X1 = Console.ReadLine();
            x1 = Convert.ToDouble(X1);
            Console.Write("enter y1: ");
            Y1 = Console.ReadLine();
            y1 = Convert.ToDouble(Y1);
            Console.Write("enter x2: ");
            X2 = Console.ReadLine();
            x2 = Convert.ToDouble(X2);
            Console.Write("enter y2: ");
            Y2 = Console.ReadLine();
            y2 = Convert.ToDouble(Y2);
            double dist = CalculateDistance(x1, y1, x2, y2);
            Console.WriteLine(dist);
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE
            double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return dist;
        }
    }
}
