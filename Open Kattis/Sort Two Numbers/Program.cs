using System;
using System.Runtime.ExceptionServices;

namespace MmyNameSpace
{
    class myProgram
    {
        static void Main ()
        {
            string input = Console.ReadLine ();
            string firstNumber = input.Split(" ")[0];
            string secondNumber = input.Split(" ")[1];
            int firstNumber1 = Convert.ToInt32(firstNumber);
            int secondNumber1 = Convert.ToInt32(secondNumber);

            if (firstNumber1 < secondNumber1)
            {
                Console.WriteLine($"{firstNumber1} {secondNumber1}");
            }
            else if (secondNumber1 < firstNumber1)
            {
                Console.WriteLine($"{secondNumber1} {firstNumber1}");
            }
            else
            {
                Console.WriteLine($"{firstNumber1} {secondNumber1}");
            }
        }
    }
}