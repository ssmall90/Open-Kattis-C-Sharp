using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int userInput = int.Parse(Console.ReadLine());

            int count = 1;
            int squareRootValue = 3;
            int temp = 0;

            if (userInput > 1)
            {
                do
                {
                    temp = (squareRootValue * 2) - 1;
                    squareRootValue = temp;
                    count++;
                }

                while (count < userInput);
                Console.WriteLine(squareRootValue * squareRootValue);
            }
            else
            {
                Console.WriteLine(squareRootValue * squareRootValue);
            }

        }
    }
}