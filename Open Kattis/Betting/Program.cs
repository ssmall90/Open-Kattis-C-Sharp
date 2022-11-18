using System;
using System.Xml;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            int ratio1 = int.Parse(Console.ReadLine());
            int ratio2 = 100 - ratio1;

            Console.WriteLine(100f / ratio1);
            Console.WriteLine(100f / ratio2);

        }
    }
}