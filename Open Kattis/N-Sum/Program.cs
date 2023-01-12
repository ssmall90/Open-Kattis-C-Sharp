using System;
using System.Linq;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int output = 0;

            int[] numbersToAdd = input.Split(' ').Select(int.Parse).ToArray();

            foreach(int number in numbersToAdd)
            {
                output += number;
            }

            Console.WriteLine(output);
        }
    }
}