using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            string abc = Console.ReadLine();
            int a = 0;
            int b = 0;
            int c = 0;

            

            List<string> numberlist = numbers.Split(" ").ToList();
            List<int> intNumberList = numberlist.Select(int.Parse).ToList();


            intNumberList.Sort();

            foreach(char letter in abc)
            {
                if (letter == 'A')
                {
                    a = intNumberList[0];
                    Console.Write(a + " ");
                }
                else if (letter == 'B')
                {
                    b = intNumberList[1];
                    Console.Write(b + " ");
                }
                else if (letter == 'C')
                {
                    c = intNumberList[2];
                    Console.Write(c + " ");
                }
            }


        }
    }
}