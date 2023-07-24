using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace MyNamespce
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numberOfEntries= int.Parse(Console.ReadLine());
            string entriesString = Console.ReadLine();

            string[] allValues = entriesString.Split();
            int total = 0;

            for(int i =0; i < allValues.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(allValues[i]))
                {
                    if (int.Parse(allValues[i]) < 0)
                    {
                        total += int.Parse(allValues[i]);
                    }
                }
                continue;
            }

            if(total < 0)
            {
                string output = total.ToString().Substring(1);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
