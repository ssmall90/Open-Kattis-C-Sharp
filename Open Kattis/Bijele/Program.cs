using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace MyNamespace
{
    class program
    {
        public static void Main()
        {
            string userInput = Console.ReadLine();
            string[] userValues = userInput.Split(' ');
            StringBuilder output = new StringBuilder();
            List <int> pieces = new List<int>();
            List <int> correctValues = new List<int>() {1,1,2,2,2,8};
            

            for (int i = 0; i< userValues.Length; i++)
            {
                int temp = int.Parse(userValues[i]);
                pieces.Add(temp);
                output.Append(helpers.CalculateDifference(pieces[i], correctValues[i]) + " ");
            }

            output.Length--;
            Console.WriteLine(output.ToString());
        }

        class helpers
        {
            public static int CalculateDifference(int val, int correctval)
            {
                int count = 0;

                if (val < correctval)
                {
                    for (int i = val; i < correctval; i++)
                    {
                        count++;
                    }
                }
                if (val > correctval)
                {
                    for (int i = val; i > correctval; i--)
                    {
                        count--;
                    }
                }
                if (val == correctval)
                {
                    return count;
                }

                return count;
            }
        }
    }
}