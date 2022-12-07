using System;

namespace myNAmeSpace
{
    class myProgram
    {
        static void Main ()
        {
            int count = 0;
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (i < 3)
                {
                    if (input[i] == '5')
                    {
                        count++;
                    }
                    else if (!(input[i] == '5'))
                    {
                        count--;
                    }
                }

            }

            if (count == 3)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}