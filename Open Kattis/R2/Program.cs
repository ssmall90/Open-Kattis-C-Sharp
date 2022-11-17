using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            string input = (Console.ReadLine());
            string r1 = input.Split(" ")[0];
            string s = input.Split(" ")[1];

           int s11 = Convert.ToInt32(s);
           int r11 = Convert.ToInt32(r1);

            Console.WriteLine((s11 * 2) - r11);
           
        }
    }
}