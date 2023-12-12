using System;
using System.Runtime;

namespace Mynamespace
{
    class Myprogram
    {
        public static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string[] responses = new string[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                if (input.Split(" ")[0] == "Simon" && input.Split(" ")[1] == "says")
                {

                    responses[i] = input.Substring(11, input.Length - 11);
                }

            }
            foreach (string response in responses)
            {
                if (response != "")
                {
                    Console.WriteLine(response);
                }
            }
        }
    }
}
