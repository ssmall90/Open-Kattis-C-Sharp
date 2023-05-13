using System;

namespace myNameSpace
{
    class myProgram
    {
        public static void Main()
        {
            decimal totalArea = 0;
            string userInput = Console.ReadLine();
            decimal costOfSeed = decimal.Parse(userInput);
            string userInput2 = Console.ReadLine();
            int numberOfLawns = int.Parse(userInput2);

            for (int i = 0; i < numberOfLawns; i++)
            {
                string userInputLoop = Console.ReadLine();
                string width = userInputLoop.Split()[0];
                string length = userInputLoop.Split()[1];
                decimal widthNum = decimal.Parse(width);
                decimal lengthNum = decimal.Parse(length);
                decimal total = widthNum * lengthNum;
                totalArea += total;
            }
            decimal output = totalArea * costOfSeed;
            Console.WriteLine(output);
        }
    }
}