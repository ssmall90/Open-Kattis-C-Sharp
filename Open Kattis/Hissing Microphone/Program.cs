using System;
class Program
{
    public static void Main()
    {
        string userInput = Console.ReadLine();
        if (userInput.Contains("ss") || userInput.Contains("SS") || userInput.Contains("Ss") || userInput.Contains("sS"))
        {
            Console.WriteLine("hiss");
        }
        else
        {
            Console.WriteLine("no hiss");
        }
    }
}