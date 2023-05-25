using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < userInput.Length - 1; i++)
            {

                for (int j = i + 1; j < userInput.Length; j++)
                {

                    if (userInput[j] == userInput[i])
                    {
                        count++;
                        break;
                    }
                }

                if (count > 0)
                {
                    break;
                }

            }
            if (count > 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}