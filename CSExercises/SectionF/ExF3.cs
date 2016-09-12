using System;
using System.Threading;

namespace CSExercises
{
    //The marks of students are stored in a two dimensional array with 
    //the subjects represented in columns and the students in the rows. 
    //That is Row 1 would pertain to Student 1 and the scores that this student 
    //has obtained is stored in various columns in row 1.  Assuming that there are 
    //12 students in a class and 4 subjects, write a program that would do the following:
    //  a.Compute the total marks obtained each student.
    //  b.Compute the class average and standard deviation* of Marks for each subject.
    //  c.Determine the overall average of marks for the whole class for each subjects.

    //Note:   
    //calculation of standard deviation is not required for first time exercise 
    //you may only compute the average – those needing additional practice 
    //may compute standard deviation)

    //Standard Deviation is square root of variance where Variance is given by:
    //	VARIANCE = { [SUM OF(Xi - M)2] / N }; i = 1 to N
    //      N is number of data elements(Xi) and
    //      M is mean(average). 

    public class ExF3
    {
        public static void Main(string[] args)
        {
            int[,] marks = new int[,]
            {
                {56,84,68,29},
                {94,73,31,96},
                {41,63,36,90},
                {99,9,18,17},
                {62,3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72}
            };

            int[] total = CalculateTotalMarks(marks);
            double[] avg = CalculateStudentAverage(marks);
            double[] avgPerSubject = CalculateSubjectAverage(marks);
            double[] variance = CalculateVariance(marks);
            double[] stdDev = CalculateStdDeviation(marks);

            //Console.WriteLine(marks.GetLength(1));

            for (int row = 0; row < 12; row++)
            {
                Console.WriteLine("Total marks for student {0}: {1}", row, total[row]);
                Console.WriteLine("Avg marks for student {0}: {1}", row, avg[row]);
            }
            Console.WriteLine();

            for (int col = 0; col < 4; col++)
            {
                Console.WriteLine("Avg marks for subject {0}: {1}", col, avgPerSubject[col]);
                Console.WriteLine("Variance marks for subject {0}: {1}", col, variance[col]);
                Console.WriteLine("Std Deviation marks for subject {0}: {1}", col, stdDev[col]);
            }

        }

        //calculates total marks for 4 subjects for each student (row)
        //returns an array of 12 totals
        public static int[] CalculateTotalMarks(int[,] marks)
        {
            int[] total = new int[12];
            //YOUR CODE HERE
            int rowSum;
            for (int i = 0; i < total.Length; i++)
            {
                rowSum = 0;
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    rowSum = rowSum + marks[i, j];
                }
                total[i] = rowSum;
            }
            return total;
        }

        //calculates the average mark for each student
        //returns array of 12 averages
        public static double[] CalculateStudentAverage(int[,] marks)
        {
            double[] avg = new double[12];
            //YOUR CODE HERE
            //int[] total = new int[12];
            int[] total = CalculateTotalMarks(marks);
            double rowAvg;
            for (int i = 0; i < avg.Length; i++)
            {
                rowAvg = total[i] / Convert.ToDouble(marks.GetLength(1));
                avg[i] = rowAvg;
            }
            return avg;
        }

        //calculate average mark for 1 subject
        //returns array of 4 averages
        public static double[] CalculateSubjectAverage(int[,] marks)
        {
            double[] avgPerSubject = new double[4];
            //YOUR CODE HERE
            int colSum;
            double colAvg;
            for (int j = 0; j < marks.GetLength(1); j++)    //for each 4 subjects
            {
                colSum = 0;
                for (int i = 0; i < marks.GetLength(0); i++)    //for each 12 students
                {
                    colSum = colSum + marks[i, j];          //sum of marks by all students for that 1 subject
                }
                colAvg = colSum / Convert.ToDouble(marks.GetLength(0));
                avgPerSubject[j] = colAvg;
            }
            return avgPerSubject;
        }

        public static double[] CalculateVariance(int[,] marks)
        {
            double[] variance = new double[4];
            //YOUR CODE HERE - bonus questions
            //VARIANCE = { [SUM OF(Xi - M)2] / N
            //double[] avgPerSubject = new double[4];
            double[] avgPerSubject = CalculateStudentAverage(marks);
            double sum;
            for (int j = 0; j < marks.GetLength(1); j++)    //for each 4 subjects
            {
                sum = 0;
                for (int i = 0; i < marks.GetLength(0); i++)    //for each 12 students
                {
                    sum = sum + Math.Pow((marks[i, j] - avgPerSubject[j]), 2);          //sum of marks by all students for that 1 subject
                }
                variance[j] = sum / marks.GetLength(0);
            }
            return variance;
        }

        public static double[] CalculateStdDeviation(int[,] marks)
        {
            double[] stdDev = new double[4];
            //double[] variance = new double[4];
            double[] variance = CalculateVariance(marks);
            for(int j=0; j<4; j++)
            {
                stdDev[j] = Math.Sqrt(variance[j]);
            }
            return stdDev;
        }
    }
}

