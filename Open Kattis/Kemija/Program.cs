using System;
using System.Text;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] sentenceSplit = input.Split(" ");

            string[] outputSplit = new string[sentenceSplit.Length];
            StringBuilder sb = new StringBuilder();

            string consonants = ("bcdfghjklmnpqrstvwxyz");
            string vowels = ("aeiou");
            int breakpoint = 0;

            foreach (string word in sentenceSplit)
            {
                int index = 0;
                if(breakpoint > 0 && breakpoint < sentenceSplit.Length)
                {
                    sb.Append(" ");
                }

                while (index < word.Length)
                {
                    if (vowels.Contains(word[index])) 
                    {
                        sb.Append(word[index]);
                        index += 3;
                    }
                    else if (consonants.Contains(word[index])) 
                    { 
                        sb.Append(word[index]);
                        index++;
                    }
                           
                }
                breakpoint++;
            }

            Console.WriteLine(sb.ToString());

        }
    }
}