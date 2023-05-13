using System;

namespace MyNameSpace
{
    class MyProgram
    {
        public static void Main()
        {
            decimal userInput = decimal.Parse(Console.ReadLine());
            Console.WriteLine(userInput - 1);
        }
    }
}