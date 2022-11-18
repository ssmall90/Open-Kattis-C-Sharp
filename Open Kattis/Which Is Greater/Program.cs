using System;
using System.Xml;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            string firstNumber = numbers.Split(" ")[0];
            string secondNumber = numbers.Split(" ")[1];
            int firstNumber1 = Convert.ToInt32(firstNumber);
            int secondNumber1 = Convert.ToInt32(secondNumber);
            if (firstNumber1 > secondNumber1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}