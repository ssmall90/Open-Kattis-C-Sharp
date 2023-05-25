using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int userInput = int.Parse(Console.ReadLine());
            string[] values = new string[userInput];

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Console.ReadLine();
            }

            for (int i = 0; i < values.Length; i++)
            {
                {

                    if (int.Parse(values[i].Split(" ")[0]) > int.Parse(values[i].Split(" ")[1]) - int.Parse(values[i].Split(" ")[2]))
                    {
                        Console.WriteLine("do not advertise");
                    }
                    else if (int.Parse(values[i].Split(" ")[0]) < int.Parse(values[i].Split(" ")[1]) - int.Parse(values[i].Split(" ")[2]))
                    {
                        Console.WriteLine("advertise");
                    }
                    else { Console.WriteLine("does not matter"); }
                }
            }
        }
    }
}