using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Mynamespace
{
    class Myprogram
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();


            int count = 0;

            foreach(char c in input)
            {
                if(!sb.ToString().Contains(c))
                {
                    sb.Append(c);
                }
            }

            List<int> ints = new List<int>();
            
            foreach(char c in sb.ToString())
            {
                int numberOfOccurences = input.Where(letter => letter.Equals(c)).Count();
                ints.Add(numberOfOccurences);

            }

            foreach(char num in ints)
            {
                if(num == 1)
                {
                    count++;
                }
                
                if(num > 1 &&  num % 2 != 0)
                {
                    count++;
                }

            }

            if(count == 0)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(count - 1);
            }

        }
    }
}
