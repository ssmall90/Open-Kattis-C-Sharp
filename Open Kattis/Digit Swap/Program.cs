using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            string safeCode = Console.ReadLine();
            string lastDigit = safeCode.Substring(safeCode.Length - 1, 1);
            string firstDigit = safeCode.Substring(0,1);
            string reversedSafeCode = lastDigit + firstDigit;
            int output = int.Parse(reversedSafeCode);
            Console.WriteLine(output);
        }
    }
}