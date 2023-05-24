using System;
using System.Text;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            string userInput = Console.ReadLine();
            StringBuilder text = new StringBuilder();
            for (int i =0; i < userInput.Length; i++)
            {
                
                if (i % 3 == 0 && i > 0 )
                {
                    text.Append(" ");
                }

                text.Append(userInput[i]);
                
            }

            string[] threeLetterArr = text.ToString().Split(" ");
            int count = 0;

            for (int i = 0; i < threeLetterArr.Length; i++)
            {
                if (! threeLetterArr[i].Substring(0, 1).Contains('P'))
                {
                    count++;
                }
                if (!threeLetterArr[i].Substring(1, 1).Contains('E'))
                {
                    count++;
                }
                if (!threeLetterArr[i].Substring(2, 1).Contains('R'))
                {
                    count++;
                }

            }

            Console.WriteLine(count);
        }
    }
}