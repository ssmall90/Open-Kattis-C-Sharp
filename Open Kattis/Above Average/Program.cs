using System;
using System.Linq;
using System.Xml;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numberOfResuts = int.Parse(Console.ReadLine());
            decimal[] results = new decimal[numberOfResuts];



            for (int i = 0; i < numberOfResuts; i++)
            {
                string input = Console.ReadLine();
                string[] temp = input.Split(" ");
                decimal[] tempResults = temp.Select(decimal.Parse).ToArray();
                decimal AverageScore = CalculateAverage(tempResults);
                results[i] = CalculatePercentOfAboveAverageStudents(AverageScore, tempResults);
            }

            foreach(decimal result in results)
            {
                string answer = result.ToString("F3");
                Console.WriteLine(answer + "%");

            }
        }
        
        public static decimal CalculateAverage(decimal[] testResults)
        {
            decimal total = 0;

            for (int i = 1;i < testResults.Length;i++)
            {
                total += testResults[i];
            }

            return total / (testResults.Length - 1);
        }

        public static decimal CalculatePercentOfAboveAverageStudents(decimal averageScore, decimal[] testResults)
        {
            decimal aboveAverage = 0; 

            for (int i = 1; i < testResults.Length; i++ )
            {
                if (testResults[i] > averageScore)
                {
                    aboveAverage++;
                }
            }
            decimal output = aboveAverage / (testResults.Length - 1m) * 100;
            return Math.Round(output, 3);

        }
    }
}
