using System; 

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            int monthlyAllowance = int.Parse(Console.ReadLine());
            int numberOfMonths = int.Parse(Console.ReadLine()); 
            int[] arrayOfUsage = new int[numberOfMonths];
            int totalRemaining = monthlyAllowance;

            for (int i = 0; i < numberOfMonths; i++)
            {
                arrayOfUsage[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrayOfUsage.Length; i++)
            {
                totalRemaining -= arrayOfUsage[i];
                totalRemaining += monthlyAllowance;
            }

            Console.WriteLine(totalRemaining);
        }
    }
}