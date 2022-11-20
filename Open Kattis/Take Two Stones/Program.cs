using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            int numberOfStones = int.Parse(Console.ReadLine());
            int remainingStones = numberOfStones;


            for (int i = 0; i < numberOfStones; i += 2)
            {
                remainingStones = remainingStones - 2;
                if (remainingStones <=1)
                {
                    break;
                }
            }

            if (remainingStones % 2 == 0)
            {
                Console.WriteLine("Bob");
            }
            else if (!(remainingStones % 2 == 0))
            {
                Console.WriteLine("Alice");
            }

        }
    }
}