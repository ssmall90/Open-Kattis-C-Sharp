using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            double output = 0;
            int input = int.Parse(Console.ReadLine());

            if (input < 100)
            {
                output = 99;
            }

            if (input >= 100)
            {
                input += 2;
                output = (input + 50) / 100 * 100 - 1;
            }

            Convert.ToInt32(output);

            Console.WriteLine(output);

            input = 0;


        }
    }

}
