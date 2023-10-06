using System;

namespace Mynamespace
{
    class Myprogram
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] inputSplit = input.Split('(', ')');

            if (inputSplit[0] == inputSplit[2])
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("fix");
            }
        }
    }
}

