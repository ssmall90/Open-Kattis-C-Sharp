using System;
using System.Diagnostics;

namespace myNameSpace
{
    public class myProgram
    {
        int stopWatch(ref int[] pTimes, out int output)
        {
            output = 0;
            for (int i = 0; i < pTimes.Length; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    output += (pTimes[i + 1] - pTimes[i]);
                }
                else 
                {
                    output += 0;
                }
            }
            return output;
        }
        static public void Main()
        {
            int numberOfClicks = int.Parse(Console.ReadLine());
            int[] timesStoppedOn = new int[numberOfClicks];
            int output;
            for (int i = 0; i < numberOfClicks; i++)
            {
                timesStoppedOn[i] = int.Parse(Console.ReadLine());
            }
            var myClass = new myProgram();

            if (!(numberOfClicks % 2 == 0))
            {
                Console.WriteLine("still running");
            }
            else
            {
                myClass.stopWatch(ref timesStoppedOn, out output);
                Console.WriteLine(output);
            }
        }
    }
}