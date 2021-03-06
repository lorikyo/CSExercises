using System;

namespace CSExercises
{
    //Use Euclid's Algorithm given below to determine 
    //the LCM and HCF for given two integer numbers.

    //- Take in as input two numbers A and B.
    
    //-	Subtract the smaller of the two numbers from 
    //  the Larger Number and assign the answer to the larger number.

    //-	The above process is repeated until both the numbers are equal, say X.
    //-	Apparently the residual number (X) that we have obtained is the HCF.

    //-	LCM could then be computed using the formula(A* B)/HCF

    //-	Print out your answers.


    public class ExD2
    {
        public static void Main(string[] args)
        {
            int hcf = 0, lcm = 0;
            Console.Write("enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter number B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            CalculateHCFAndLCM(A, B, ref hcf, ref lcm);
            Console.WriteLine("A \t B \t HCF \t LCM");
            Console.WriteLine("{0} \t {1} \t {2} \t {3}", A, B, hcf, lcm);
        }

        public static void CalculateHCFAndLCM(int a, int b, ref int hcf, ref int lcm)
        {
            //YOUR CODE HERE
            //Don't worry about the use of "ref" keyword here. 
            //At the end of the method, assign the HCF value to the hcf parameter
            //and LCM to the lcm parameter. hcf = <some value>; lcm=<some value>;
            int A = a, B = b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;  
            }
            hcf = a;
            lcm = (A * B) / hcf;
        }
    }
}
