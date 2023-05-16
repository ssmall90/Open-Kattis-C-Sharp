using System;
using System.Xml.Linq;
using System.Collections.Generic;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
    
            int numberOfDataSet = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDataSet; i++)
            {
                string userInput = Console.ReadLine();
                int baseNum = int.Parse(userInput.Split(" ")[1]);
                int input = int.Parse(userInput.Split(" ")[2]);
                int result = 0;

                List<int> inputToNewBase = new List<int>();
                while (input != 0)
                {
                    inputToNewBase.Add((input % baseNum));
                    input = input / baseNum;
                }
                while (inputToNewBase.Count > 0)
                {
                    int removed = inputToNewBase[0];
                    inputToNewBase.RemoveAt(0);

                    result += (int)Math.Pow(removed, 2);
                }
                Console.WriteLine((i + 1) + " " + result);
            }

        }
    }
}