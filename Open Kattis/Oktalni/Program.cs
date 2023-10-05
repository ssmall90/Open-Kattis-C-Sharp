using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mynamespace
{
    class Myprogram
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> inputValues = new List<int>();
            List<int> outputValues = new List<int>();
            StringBuilder sb = new StringBuilder();
            int count = 0;
            int octalVal = 0;

            foreach (var val in input)
            {
                inputValues.Add((int)char.GetNumericValue(val));
            }

            for(int i = inputValues.Count - 1; i >= 0; i--)
            {
                switch (count)
                {
                    case 0: outputValues.Add(inputValues[i] * 1);
                        break;
                    case 1:
                        outputValues.Add(inputValues[i] * 2);
                        break;
                    case 2:
                        outputValues.Add(inputValues[i] * 4);
                        foreach(var val in outputValues)
                        {
                            octalVal += (int)val;
                        }
                        sb.Append(octalVal.ToString());
                        octalVal = 0;
                        outputValues.Clear();
                        break;

                }
                count++;
                if (count >= 3)
                {
                    count = 0;
                }
            }

            if (outputValues.Count % 3 == 0)
            {
                Console.WriteLine(sb.ToString());
            }
            else if (outputValues.Count % 3 == 1)
            {
                sb.Append(outputValues.Last());
            }
            else if (outputValues.Count % 3 == 2)
            {
                octalVal = 0;
                octalVal = outputValues.Last() + outputValues[outputValues.Count - 2];
                sb.Append(octalVal.ToString());

            }

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                Console.Write(sb[i].ToString());
            }
        }
    }
}

