using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string[] names = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };

            //sort info on descending order of marks
            SortMarksDesc(names, marks);
            PrintArrays(names, marks);
            Console.WriteLine();

            //sort info on names alphabetically
            SortNamesAlpha(names, marks);
            PrintArrays(names, marks);
        }

        public static void SortMarksDesc(string[] names, int[] marks)
        {
            int biggestPter;
            int marksTemp;
            string namesTemp;
            for (int i=0; i < marks.Length; i++)
            {
                biggestPter = i;
                for(int j = i; j < marks.Length; j++)
                {
                    if (marks[j] > marks[biggestPter])
                    {
                        biggestPter = j;
                    }
                }
                marksTemp = marks[i];   //swap marks
                marks[i] = marks[biggestPter];
                marks[biggestPter] = marksTemp;
                namesTemp = names[i];   //swap names
                names[i] = names[biggestPter];
                names[biggestPter] = namesTemp;
            }
        }

        public static void SortNamesAlpha(string[] names, int[] marks)
        {
            int smallestAlpha;
            int marksTemp;
            string namesTemp;
            for (int i = 0; i < names.Length; i++)
            {
                smallestAlpha = i;
                for (int j = i; j < names.Length; j++)
                {
                    if (names[j].CompareTo(names[smallestAlpha]) == -1)
                    {
                        smallestAlpha = j;
                    }
                }
                marksTemp = marks[i];   //swap marks
                marks[i] = marks[smallestAlpha];
                marks[smallestAlpha] = marksTemp;
                namesTemp = names[i];   //swap names
                names[i] = names[smallestAlpha];
                names[smallestAlpha] = namesTemp;
            }
        }

        public static void PrintArrays(string[] names, int[] marks)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + "\t" + marks[i]);
                Console.WriteLine();
            }
        }
    }
}
