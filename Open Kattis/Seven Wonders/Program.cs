using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace Mynamespace
{
    class Myprogram
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int tCount = 0;
            int cCount = 0;
            int gCount = 0;

            foreach(char letter in input)
            {
                switch(letter)
                {
                    case 'T': 
                        tCount++;
                        break;
                    case 'G':
                        gCount++;
                        break;
                    case 'C':
                        cCount++;
                        break;
                }
            }

            int total = (tCount * tCount) + (cCount * cCount) + (gCount * gCount); 

            if (tCount == 0 || gCount == 0 || cCount == 0 )
            {
                Console.WriteLine(total);
            }
            else
            {
                int totalRevised = 0;
                int lowestValue = 0; 

               List<int> values = new List<int> { cCount,
                                                  gCount,
                                                  tCount};

                lowestValue = values.Min();

                totalRevised = (lowestValue * 7) + total;

                Console.WriteLine(totalRevised);

            }


        }
    }
}
