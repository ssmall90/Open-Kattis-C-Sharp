using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main ()
        {
            int ace = 11;
            int king = 4;
            int queen = 3;
            int jack = 2;
            int ten = 10;
            int nine = 0;
            int total = 0;


            string input = Console.ReadLine();
            string numberOfHands = input.Split(' ')[0];
            string dominantSuit = input.Split(' ')[1];

            string[] handsPlayed = new string[int.Parse(numberOfHands) * 4];

            for (int i = 0; i < handsPlayed.Length; i++)
            {
                handsPlayed[i] = Console.ReadLine();
            }

            for (int i = 0; i < handsPlayed.Length; i++)
            {
                if (handsPlayed[i].Remove(0,1) == dominantSuit)
                {

                    if (handsPlayed[i].Remove(1, 1) == "A")
                    {
                        total += ace;
                    }
                    else if (handsPlayed[i].Remove(1, 1) == "K")
                    {
                        total += king;
                    }
                    else if (handsPlayed[i].Remove(1, 1) == "Q")
                    {
                        total += queen;
                    }
                    else if (handsPlayed[i].Remove(1, 1) == "J")
                    {
                        total += 20;
                    }
                    else if (handsPlayed[i].Remove(1, 1) == "T")
                    {
                        total += ten;
                    }
                    else if (handsPlayed[i].Remove(1, 1) == "9")
                    {
                        total += 14;
                    }
                    else total += 0;
                }
                else if (handsPlayed[i].Remove(0, 1) != dominantSuit)
                {
                    if (handsPlayed[i].Remove(1, 1) == "A")
                    {
                        total += ace;
                    }
                    else if (handsPlayed[i].Remove(1, 1) == "K")
                    {
                        total += king;
                    }
                    else if (handsPlayed[i].Remove(1, 1) == "Q")
                    {
                        total += queen;
                    }
                    else if (handsPlayed[i].Remove(1, 1) == "J")
                    {
                        total += jack;
                    }
                    else if (handsPlayed[i].Remove(1, 1) == "T")
                    {
                        total += ten;
                    }
                    else if (handsPlayed[i].Remove(1, 1) == "9")
                    {
                        total += nine;
                    }
                    else total += 0;
                }


            }

            Console.WriteLine(total);

        }
    }
}