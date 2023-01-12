using System;
using System.Linq;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            int count = 0; 

            int numberOfTemps = int.Parse(Console.ReadLine());
            string inputTemps = Console.ReadLine();

            int[] intTemperatures = inputTemps.Split(' ').Select(int.Parse).ToArray();

            foreach(int number in intTemperatures)
            {
                if (number < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}