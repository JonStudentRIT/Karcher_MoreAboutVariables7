using System;

namespace MoreAboutVariables7
{
    /* Author: Jonathan Karcher
     * Purpose: Display a string that the user enters in reverse order
     * Restrictions: None
     */
    class Program
    {
        /* Method: Main
         * Purpose: Ask the user for a string and then display it in reverse order
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            // create a string to hold input;
            string input = "";
            // create a string to hold the reverse string;
            string reverse = "";
            // prompt the user for a string
            Console.WriteLine("Enter a sequence of chars to be displayed in reverse order");
            // strore the users string
            input = Console.ReadLine();
            // store each char starting with the last and ending with the first
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse = reverse + input[i];
            }
            // output the reverse string
            Console.Write(reverse);
            // add a newLine for formating
            Console.WriteLine();
        }
    }
}
