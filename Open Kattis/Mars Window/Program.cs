using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            int a = input - 2017;

            int b = a * 12 - 4; 

            int c = b % 26; 

            if (c < 12)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}