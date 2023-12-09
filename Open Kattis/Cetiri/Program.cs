using System;
using System.Linq;
using System.Collections.Generic;

namespace Mynamespace
{
    class Myprogram
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> values = new List<int> { int.Parse(input.Split(" ")[0]),
                                             int.Parse(input.Split(" ")[1]),
                                             int.Parse(input.Split(" ")[2])};

            values.Sort();

            int gap_A = values[1] - values[0];
            int gap_B = values[2] - values[1];

            int difference = int.Max(gap_A, gap_B) / 2;

            if(gap_A == gap_B)
            {
                Console.WriteLine(values[2] + difference * 2);
            }

            else if(gap_A > gap_B)
            {
                Console.WriteLine(values[0] + difference);
            }

            else
            {
                Console.WriteLine(values[1] + difference);
            }
                
            
        }
    }
}
