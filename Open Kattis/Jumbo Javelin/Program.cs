using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main ()
        {
            string input = Console.ReadLine ();
            int intInput = Convert.ToInt32 (input);
            int[] inputArray = new int[intInput];
            int total = 0;

            for (int i = 0; i < intInput; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine()) ;
                total += inputArray[i];
            }
            total -= (intInput -1); 

            Console.WriteLine(total);

        }
    }
}