using System;

namespace MyNamespace
{
    class program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] words = input.Split(" ");

            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        count++;
                    }
                }
            }

            if (count > 0)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}


