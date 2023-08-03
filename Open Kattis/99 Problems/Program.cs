using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace myNameSpace
{
    class myProgram
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());


            static int GetClosestNumberEndingIn99(int inputNumber)
            {
                int modResult = inputNumber % 100; // Get the last two digits of the input number

                if (modResult == 99 || modResult >= 50) // If the last two digits are 99 or closer to 99, round up
                {
                    Console.WriteLine( inputNumber + 100 - modResult);
                    return inputNumber + 100 - modResult;
                }
                else // If the last two digits are closer to 0, round down
                {
                    Console.WriteLine( inputNumber - modResult);
                    return inputNumber - modResult;
                }
            }

            if (input < 149)
            {
                Console.WriteLine("99");
            }
            else
            {
                GetClosestNumberEndingIn99(input);

            }

        }
    }

}
