using System;

namespace MyNameSpace
{
    class Program
    {
        public static void Main()
        {
            string gameWord = Console.ReadLine();
            string permutation = Console.ReadLine();

            int count = 0;

            char[] gameWordArr = gameWord.ToCharArray();
            char[] guess = new char[gameWord.Length];



            for (int i = 0; count < 10; i++)
            {
                char c = permutation[i];

                if (gameWord.Contains(c))
                {
                    for (int j = 0; j < gameWord.Length; j++)
                    {
                        if (c == gameWordArr[j])
                        {
                            guess[j] = c;
                        }

                    }
                }
                else
                {
                    count++;
                }
            }

            string output = new string(guess);

            bool hasWon = string.Equals(gameWord, output);

            if (hasWon)
            {
                Console.WriteLine("WIN");
            }
            else
            {
                Console.WriteLine("LOSE");
            }
        }
    }
}
