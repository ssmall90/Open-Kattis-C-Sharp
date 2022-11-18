using System;
using System.Xml;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            string number1 = numbers.Split()[0];
            string number2 = numbers.Split()[1];

            int firstNumber = Convert.ToInt32(number1);
            int secondNumber = Convert.ToInt32(number2);

            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}