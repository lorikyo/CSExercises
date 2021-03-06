using System;

namespace CSExercises
{
    //Using iteration write a C# program to determine 
    //the square root of a given number (N). If required, 
    //your instructor would explain the method using a numerical example.  
    //Many efficient methods are available; we use a simple one 
    //for demonstrating the looping.

    //STEPS:

    //a.	Take as input the number for finding the square root.
    //b. Take a random number between 1 and N using the function RND.Let the integer be called a Guess, G (not necessarily an integer). 
    //c. If the Guess is correct then G* G should be N.
    //d. If not use the following formula iteratively until G* G approximates to N to an accuracy of 5 decimal places:
    //		G = (G +  N/G) / 2

    //      Input     Output
    //      0	        0.000
    //      25	        5
    //      3	        1.732


    public class ExD4
    {
        public static void Main(string[] args)
        {
            Console.Write("enter number for finding square root: ");
            double input = Convert.ToInt32(Console.ReadLine());
            double ans = SQT(input);
            Console.WriteLine(ans);
        }

        public static double SQT(double n)
        {
            //YOUR CODE HERE
            int N = Convert.ToInt32(n);
            Random r = new Random();
            int guess = r.Next(1, N);
            double g = Convert.ToDouble(guess);
            while (Math.Abs(n - g * g) > 0.00001)
            {
                g = (g + n / g) / 2.0;
            }
            return g;
            
        }
    }
}
