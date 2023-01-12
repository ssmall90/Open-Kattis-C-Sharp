using System;
using System.Globalization;
using System.Linq;

namespace myNameSpace
{
    class myProgram
    {
        int CalculateElectricalOutlet()
        {
            int output = 0;
            string input = Console.ReadLine();
            int[] socketCapacities = input.Split(' ').Select(int.Parse).ToArray();
            socketCapacities = socketCapacities.Skip(1).ToArray();
            foreach (int socket in socketCapacities)
            {
                output += socket;
            }
            output -= (socketCapacities.Length - 1);
            Console.WriteLine(output);
            return output;
        }
        static void Main()
        {
            int output = 0;
            int numberOfTests = int.Parse(Console.ReadLine());
            var myClass = new myProgram();
            int i = numberOfTests;
            

            while(numberOfTests >= 1)
            {
                output = myClass.CalculateElectricalOutlet();
                numberOfTests -= 1;
            }


        }
    }
}