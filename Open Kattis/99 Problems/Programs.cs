using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            int output = 0;
            int input = double.Parse(Console.ReadLine());

            if (input < 100)
            {
                output = 99;
            }

            if (input >= 100)
            {
               output = Math.Round(input / 100d, 0) * 100;
            }

            Console.WriteLine(output);


        }
    }
  
}