using System;
namespace MyNamespace
{
    class program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(int.Parse(input.Split(" ")[0]) + int.Parse(input.Split(" ")[1])); 
        }

    }
}
