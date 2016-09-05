using System;

namespace CSExercises
{
    //Given a number find out its factorial.  

    //Write two different C# program variations for 
    //the problem:
    //a.Using increment counter
    //b.Using a decrement counter.

    //Carefully study the similarities and differences 
    //between the two approaches.
    //List the conditions, if any, under which your program 
    //is likely to fail

    public class ExE1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fact1 = CalculateFactorialInc(n);
            Console.WriteLine(fact1);

            int fact2 = CalculateFactorialDec(n);
            Console.WriteLine(fact2);
        }

        public static int CalculateFactorialInc(int n)
        {
            //YOUR CODE HERE
            //int i = 1;
            int factorial = 1;
            //while (i <= n)
            //{
            //    factorial = factorial * i;
            //    i++;
            //}
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
                return factorial;


        }

        public static int CalculateFactorialDec(int n)
        {
            //YOUR CODE HERE
            //int i = n-1;
            int factorial = n;
            //while (i >= 1)
            //{
            //    factorial = factorial * i;
            //    i--;
            //}
            for (int i = n-1; i >= 1; i--)
            {
                factorial = factorial * i;
            }
                return factorial;


        }


    }
}
