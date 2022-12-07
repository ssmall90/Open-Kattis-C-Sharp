using System;
using System.Linq;

namespace myNameSpace
{
    class myProgram
    {
        static void Main ()
        {
            string input = Console.ReadLine ();
            string[] inputValues = input.Split(" ");
            float totalCapacity = float.Parse(inputValues[0]);
            float truckWeight = float.Parse(inputValues[1]);
            float numberOfItems = float.Parse(inputValues[2]);

            string weightOfItems = Console.ReadLine();
            string[] weightOfItemsArray = weightOfItems.Split(" ");
            float[] weightOfItemsArrayfloats = weightOfItemsArray.Select(float.Parse).ToArray();

            float totalWeightOfItems = 0;

            for (float i = 0; i < weightOfItemsArrayfloats.Length; i++)
            {
               totalWeightOfItems += weightOfItemsArrayfloats[(int)i];
            }

            float ninetyPercentOfCapacity = (((totalCapacity - truckWeight) / 100) * 90);

            int output = (int)ninetyPercentOfCapacity - (int)totalWeightOfItems;



            if (output <= 0)
            {
                Console.WriteLine(0);
            }
            else { Console.WriteLine(output);
            }
        }
    } 
}