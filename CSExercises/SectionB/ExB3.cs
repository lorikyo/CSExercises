using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter salary: ");
            string salString = Console.ReadLine();
            string income = CalculateIncome(salString);
            Console.WriteLine(income);
        }

        public static string CalculateIncome(string salaryStr)
        {
            //YOUR CODE HERE
            double housingAllowance, transportAllowance;
            double salaryDbl = Convert.ToDouble(salaryStr);
            housingAllowance = 10.00/100*salaryDbl;
            transportAllowance = 3.0 / 100 * salaryDbl;
            double incomeDbl = salaryDbl + housingAllowance + transportAllowance;
            string incomeStr = string.Format("{0:c}", incomeDbl);
            //Console.WriteLine(housingAllowance);
            return incomeStr;
        }
    }
}
