using System;

namespace Mynamespace
{
    class Myprogram
    {
        public static void Main(string[] args)
        {
            int setDistance = int.Parse(Console.ReadLine());
            int result = WoodCombinations.CountCombinations(setDistance);
            Console.WriteLine(result);
        }
    }

    static class WoodCombinations
    {
        public static int CountCombinations(int distance)
        {

            int[] counts = new int[distance + 1];

            counts[0] = 1;


            for (int i = 1; i <= distance; i++)
            {
                if (i >= 1)
                    counts[i] += counts[i - 1];
                if (i >= 2)
                    counts[i] += counts[i - 2];
                if (i >= 3)
                    counts[i] += counts[i - 3];
            }

            return counts[distance];
        }
    }

}
