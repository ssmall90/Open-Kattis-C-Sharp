using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDead = 0;
            int countAlive = 0;

            string userInput = Console.ReadLine();
            string[] data = userInput.Split(" ");

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Contains(":)")) 
                {
                    countAlive++;
                }
                if (data[i].Contains(":("))
                {
                    countDead++;
                }
            }

            if (countAlive == 0 && countDead == 0)
            {
                Console.WriteLine("machine");
            }
            else if(countAlive > 0 )
            {
                if (countDead == 0)
                {
                    Console.WriteLine("alive");
                }
                else
                {
                    Console.WriteLine("double agent");
                }
            }
            else if (countDead > 0)
            {
                Console.WriteLine("undead");
            }

            
        }
    }
}