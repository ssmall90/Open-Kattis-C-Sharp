using System;

namespace myNameSpace
{
    class program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string vowels = "aeiou";
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            { 
                
                if (vowels.Contains(input[i]))
                {
                    count++;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}