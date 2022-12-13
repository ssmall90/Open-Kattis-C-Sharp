using System;
using System.Linq;

namespace myNameSpace
{
    class myProgram
    {
        public double calculations(ref double[] pValues, ref double[] pPowers, out double result)
        {
            result = 0; 

            for (int i = 0; i < pValues.Length; i++)
            {
                pValues[i] = Math.Pow(pValues[i], pPowers[i]);
            }

            for (int i = 0; i < pValues.Length; i++)
            {
                result += pValues[i];
            }
            return result;
            
        }

        public static void Main ()
        {
            int numberOfEntries = int.Parse(Console.ReadLine());
            string [] entries = new string [numberOfEntries];
            string[] powerOfs = new string[numberOfEntries];
            double output = 0; 

            for (int i = 0; i < numberOfEntries; i++)
            {
                entries[i] = Console.ReadLine();
            }

            for (int i = 0; i < powerOfs.Length; i++)
            {
                powerOfs[i] = entries[i].Substring(entries[i].Length - 1);
                entries[i] = entries[i].Remove(entries[i].Length-1,1);
            }

            double[] powerOfsDoubles = powerOfs.Select(double.Parse).ToArray();
            double[] entriesDoubles = entries.Select(double.Parse).ToArray();

            var myClass = new myProgram();
            myClass.calculations(ref entriesDoubles, ref powerOfsDoubles, out output);

            int finalOutput = (int)output;

            Console.WriteLine(finalOutput);
        }
    }
}