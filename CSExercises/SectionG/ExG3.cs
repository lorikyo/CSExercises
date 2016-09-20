using System;

namespace CSExercises
{
    //The C# language gives facilities for changing cases all to upper or lower - 
    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
    //Example
    //“institute of systems science”   =>   “Institute Of System Science”

    public class ExG3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string newphrase = ToTitleCase(phrase);

            Console.WriteLine(newphrase);
        }

        public static string ToTitleCase(string phrase)
        {
            //YOUR CODE HERE
            string newPhrase = phrase;
            string character;
            for(int i =0; i<newPhrase.Length; i++)  //for each space inside string, ToUpper() the following character
            {
                if(newPhrase.Substring(i,1) == " ")
                {
                    character = newPhrase.Substring(i + 1, 1).ToUpper();
                    newPhrase = newPhrase.Substring(0, i+1) + character + newPhrase.Substring(i + 2, newPhrase.Length - i-2);
                }
            }
            character = newPhrase.Substring(0, 1).ToUpper();    //ToUpper() 1st character in string
            newPhrase = character + newPhrase.Substring(1, newPhrase.Length - 1);

            return newPhrase;
        }
    }
}
