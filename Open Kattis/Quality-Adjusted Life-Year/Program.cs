using System;
using System.Collections.Specialized;
using System.Xml.Schema;

namespace myNameSpace
{
    class myProgram
    {
        public static decimal QAYL(out decimal total)
        {
            string input = Console.ReadLine();
            string input1 = input.Split()[0];
            string input2 = input.Split()[1];
            decimal intInput1 = Convert.ToDecimal(input1);
            decimal intInput2 = Convert.ToDecimal(input2);
            total = intInput1 * intInput2;
            return total;
        }
        static void Main()
        {
            decimal globalCount = 0;
            decimal total = 0;
            string input = Console.ReadLine();
            decimal input1 = Convert.ToDecimal(input);

            for (int i = 0; i < input1; i++)
            {
                QAYL(out globalCount);
                total += globalCount;
            }
            Console.WriteLine(total);
        }
    } 
}