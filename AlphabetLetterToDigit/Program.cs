using System;
using System.Collections.Generic;
using System.Text;

namespace AlphabetLetterToDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load in the alphabet in corresponding indices - 1.
            char[] alphabet = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            Console.WriteLine("\nEnter your words, then press enter when complete:");
            string input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\n\nYour encoded message is:\n\n");
            StringBuilder sb = new StringBuilder();

            // Strip out any input that isn't a letter.
            foreach (char c in input)
            {
                if(char.IsLetter(c))
                {
                    sb.Append(c);
                }
            }

            string validatedInput = sb.ToString().ToUpper();
            List<int> output = new List<int>();

            // for each letter, find and output the corresponding number.
            foreach (char c in validatedInput)
            {
                output.Add(Array.IndexOf(alphabet, c) + 1);
            }

            foreach (int digit in output)
            {
                Console.Write($"{digit} ");
            }

            Console.WriteLine($"\n\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}
