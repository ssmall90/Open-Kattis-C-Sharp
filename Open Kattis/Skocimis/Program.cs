using System;
using System.Collections.Generic;

namespace Mynamespace
{
    class Myprogram
    {
        public static void Main(string[] args)
        {

            string input = Console.ReadLine();

            List<int> inputs = new List<int> { };

            inputs.Add(int.Parse(input.Split(" ")[0]));
            inputs.Add(int.Parse(input.Split(" ")[1]));
            inputs.Add(int.Parse(input.Split(" ")[2]));

            int possibleResult1 = inputs[2] - inputs[1] - 1;
            int possibleResult2 = inputs[1] - inputs[0] - 1;

            if (possibleResult1 > possibleResult2)
            {
                Console.WriteLine(possibleResult1);
            }
            else
            {
                Console.WriteLine(possibleResult2);
            }
        }
    }
}
