using System;
class Program
{
    public static void Main()
    {
        string userInput = Console.ReadLine();
        int hours = int.Parse(userInput.Split(" ")[0]);
        int minutes = int.Parse(userInput.Split(" ")[1]);
        if (minutes < 45)
        {
           if (hours > 0 ){ hours -= 1; minutes = (100 - 85) + minutes; }
           else{hours = 23; minutes = (100 - 85) + minutes;}
        }
        else{minutes -= 45;}
        Console.WriteLine(hours + " " + minutes);
    }
}