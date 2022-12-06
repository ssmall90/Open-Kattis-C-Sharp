using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string input1 = input.Split(" ")[0];
            string input2 = input.Split(" ")[1];
            int numberOfDescription = Convert.ToInt32(input1);
            int numberOfCarrots = Convert.ToInt32(input2);

            for (int i = 0; i < numberOfDescription; i++)
            {
                Console.ReadLine();
            }

            Console.WriteLine(numberOfCarrots);





        }
    }
}