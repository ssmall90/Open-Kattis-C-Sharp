using System;

namespace myNameSpace
{
    public class myProgram
    {

        public void findAverage(ref int pRemaining, out float pMaxAverage, out float pMinAverage )
        {
            
            pMaxAverage = pRemaining * 3;
            pMinAverage = pRemaining * -3;
            
        }
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");
            int numberOfJudges = int.Parse(input[0]);
            int judgesThatHaveVoted = int.Parse(input[1]);
            int totalVote = 0;
            int remaingingVotes = numberOfJudges - judgesThatHaveVoted;
            float lowestAverage;
            float highestAverage;

            for (int i = 0; i < judgesThatHaveVoted; i++)
            {
                totalVote += int.Parse(Console.ReadLine());
            }

            var myClass = new myProgram();
            myClass.findAverage(ref remaingingVotes, out highestAverage, out lowestAverage );

            Console.WriteLine(((lowestAverage + totalVote) / numberOfJudges) + " " + ((highestAverage + totalVote) / numberOfJudges)) ;
        }
    }
}