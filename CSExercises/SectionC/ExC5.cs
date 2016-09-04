using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("please enter 3 digit integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isArmstrong = IsArmstrongNumber(n);
            Console.WriteLine(isArmstrong);
            //if (isArmstrong)
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");
        }


        public static bool IsArmstrongNumber(int n)
        {
            //YOUR CODE HERE
            bool result;
            int hundred, ten, one;
            hundred = n / 100;
            //Console.WriteLine(hundred);
            ten = (n - hundred*100)/10;
            //Console.WriteLine(ten);
            one = n - hundred*100 - ten*10;
            //Console.WriteLine(one);
            if (n == (Math.Pow(hundred, 3) + Math.Pow(ten, 3) + Math.Pow(one, 3)))
                result = true;
            else
                result = false;
            return result;
        }
    }
}