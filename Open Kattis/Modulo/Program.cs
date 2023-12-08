using System;
using System.Collections.Generic;

namespace Mynamespace
{
    class Myprogram
    {
        public static void Main(string[] args)
        {
            int currnetNumber = 0;
            int value = 0;
            List<int> numList = new List<int>();

            int inputCounter = 10;

            while(inputCounter > 0)
            {
                currnetNumber = int.Parse(Console.ReadLine());

                value = currnetNumber % 42;

                if (!numList.Contains(value))
                {
                    numList.Add(value);
                }

                inputCounter--;
            }

            Console.WriteLine(numList.Count);
        }
    }
}
