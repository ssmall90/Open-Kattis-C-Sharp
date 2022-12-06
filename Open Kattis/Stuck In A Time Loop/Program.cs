using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main ()
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(i + " " + "Abracadabra");
            }
        }
    }
}