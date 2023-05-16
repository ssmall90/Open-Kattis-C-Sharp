using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            char[] moves = userInput.ToCharArray();
            int currentPosition = 1;

            for (int i = 0; i < moves.Length; i++)
            {

                switch (currentPosition)
                {
                    case 1: if (moves[i] == 'A') { currentPosition = 2; }
                            else if (moves[i] == 'B') { currentPosition = 1; }
                            else if (moves[i] == 'C') { currentPosition = 3; }
                        break;
                    case 2:
                        if (moves[i] == 'A') { currentPosition = 1; }
                        else if (moves[i] == 'B') { currentPosition = 3; }
                        else if (moves[i] == 'C') { currentPosition = 2; }
                        break;
                    case 3:
                        if (moves[i] == 'A') { currentPosition = 3; }
                        else if (moves[i] == 'B') { currentPosition = 2; }
                        else if (moves[i] == 'C') { currentPosition = 1; }
                        break;
                }

            }

            Console.WriteLine(currentPosition);
        }
    }
}