using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            string[] contestantScores = new string[5];
            int winningScore = 0;
            int position = 0;

            for (int i = 0; i < contestantScores.Length; i++)
            {
                contestantScores[i] = Console.ReadLine();
            }

            int[] scoresInOrder = new int[5];
            for (int i = 0; i < scoresInOrder.Length; i++)
            {
                scoresInOrder[i] = int.Parse(contestantScores[i].Split(' ')[0]) +
                                   int.Parse(contestantScores[i].Split(' ')[1]) +
                                   int.Parse(contestantScores[i].Split(' ')[2]) +
                                   int.Parse(contestantScores[i].Split(' ')[3]);
            }

            for (int i = 0; i < scoresInOrder.Length; ++i)
            {

                if (scoresInOrder[i] > winningScore)
                {
                    winningScore = scoresInOrder[i];
                    position = i + 1;
                }

            }
            Console.WriteLine(position + " " + winningScore);
        }
    }
}