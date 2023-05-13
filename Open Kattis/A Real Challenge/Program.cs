using System;

namespace MyNameSpace
{
    class MyProgram
    {
        public static void Main()
        {
            string userInput = Console.ReadLine();
            decimal areaOfField = decimal.Parse(userInput);
            decimal perimeter = (decimal)Math.Sqrt((double)areaOfField) * 4;
            Console.WriteLine(perimeter);
        }
    }
}