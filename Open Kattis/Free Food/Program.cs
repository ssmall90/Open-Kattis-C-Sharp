using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace Mynamespace
{
    class Myprogram
    {
        public static void Main(string[] args)
        {
            int numberOfEvents = int.Parse(Console.ReadLine());
            List<int> inputs = new List<int>();

            for (int i = 0; i < numberOfEvents; i++)
            {
                string eventDates = Console.ReadLine();
                inputs.Add(int.Parse(eventDates.Split(" ")[0]));
                inputs.Add(int.Parse(eventDates.Split(" ")[1]));

            }

            int counter = 0;

            List<int> duplicateDates = new List<int>();

            for(int i = 0; i < inputs.Count; i = i +2)
            {
                
                if (inputs[i] == inputs[i + 1] && !duplicateDates.Contains(inputs[i]))
                {
                    counter++;
                    duplicateDates.Add(inputs[i]);
                }
                else
                {

                    for (int j = inputs[i]; j <= inputs[i + 1]; j++)
                    {

                        if (!duplicateDates.Contains(j))
                        {
                            counter++;
                            duplicateDates.Add(j);
                        }
                    }
                }

            }

                Console.WriteLine(counter); 
        }
    }
}
