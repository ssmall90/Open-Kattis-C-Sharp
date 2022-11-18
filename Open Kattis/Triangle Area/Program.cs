using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            string input = (Console.ReadLine());
            string baseOfTriangle = input.Split(" ")[0];
            string heightOfTriangle = input.Split(" ")[1];

            int baseOfTriangle1 = Convert.ToInt32(baseOfTriangle);
            int heightOfTriangle1 = Convert.ToInt32(heightOfTriangle);

            float areaOfTriangle = ((baseOfTriangle1 * heightOfTriangle1) / 2f);

            Console.WriteLine(areaOfTriangle);

        }
    }
}