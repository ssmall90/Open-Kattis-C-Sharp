using System;
using System.Linq;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            string [] outputs = new string[numberOfInputs];

            for (int i = 0; i < numberOfInputs; i++)
            {
                int currentValue = int.Parse(Console.ReadLine());
                outputs[i] = Factorial(currentValue).ToString();
            }

            foreach (string val in outputs)
            {
                Console.WriteLine(val.Last());
            }
        }

        public static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number-1);
            
        }
    }
}