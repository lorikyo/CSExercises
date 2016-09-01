using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter temperature in Centigrade scale: ");
            string tempCentStr = Console.ReadLine();
            double tempCentDbl = Convert.ToDouble(tempCentStr);
            double tempFahDbl = ConvertToFahrenheit(tempCentDbl);
            Console.WriteLine(tempFahDbl);
        }

        public static double ConvertToFahrenheit(double c)
        {
            //YOUR CODE HERE - convert celcius to fahrenheit
            double tFah = 1.8*c + 32;
            return tFah;

        }
    }
}
