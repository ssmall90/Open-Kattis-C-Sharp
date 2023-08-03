using System;
using System.Text;
using System.Linq;

namespace MyNamespace;

class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string values = Console.ReadLine();

        string[] valuesStringArray = values.Split(" ");
        int[] valuesIntArray = valuesStringArray.Select(int.Parse).ToArray(); 

        int lengthOfList = int.Parse(input.Split(" ")[0]);
        int zoomIndex = int.Parse(input.Split(" ")[1]);

        int count = 1;

        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < valuesIntArray.Length; i++)
        {
            if(count == zoomIndex)
            {
                sb.Append(valuesIntArray[i] + " ");
                count = 1;
            }
            else
            {
                count++;
            }
        }

        sb.ToString().TrimEnd();
        Console.WriteLine(sb);
    }
}