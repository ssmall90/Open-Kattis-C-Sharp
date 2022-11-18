using System;
using System.Xml;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            string input = Console.ReadLine(); 
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    Console.Write(input[i]);
                }
            }

        }
    }
}