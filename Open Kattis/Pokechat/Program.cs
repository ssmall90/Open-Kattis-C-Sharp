using System;
using System.Text;
using System.Linq;

class Program
{
    public static void Main()
    {
        string userTxtInput = Console.ReadLine();
        string userIntInput = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < userIntInput.Length; i++)
        {
            if (i % 3 == 0 && i > 0)
            { sb.Append(' '); }
            sb.Append(userIntInput[i]);
        }
        string[] ids = sb.ToString().Split(' ');
        int[] intIds = ids.Select(int.Parse).ToArray();
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < intIds.Length; i++)
        {
            int temp = intIds[i];
            output.Append(userTxtInput[temp - 1]);
        }
        Console.WriteLine(output.ToString());
    }
}