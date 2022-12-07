using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("second");
            }
            else
            {
                Console.WriteLine("first");
            }
        }
    }
}