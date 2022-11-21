using System;
using System.ComponentModel;

namespace myNameSpace
{
    public class myProgram
    {
        static void Main()
        {
            int blocksRemaining = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i < blocksRemaining; i += 2)
            {
                blocksRemaining -= (i * i);
                count++;
                if (blocksRemaining - (i + 2) * (i + 2) < 0)
                {
                    goto end;
                }
            }
        end:;
            Console.WriteLine(count);
        }
    }
}