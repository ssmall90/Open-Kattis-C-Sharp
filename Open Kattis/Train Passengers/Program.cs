using System;
using System.Linq;

namespace myNameSpace
{
    public class myProgram
    {
        string passengerCalculation(ref int[,] passengerMoves, int capacity, int arrayIndex, int peopleOnTrain, int numberOfStops)
        {
            if (arrayIndex >= numberOfStops)
            {
                return "possible";
            }

            peopleOnTrain -= passengerMoves[arrayIndex, 0];

            if (peopleOnTrain < 0)
            {
                return "impossible";
            }
            peopleOnTrain += passengerMoves[arrayIndex, 1];

            if (peopleOnTrain > capacity)
            {
                return "impossible";
            }
            if ((peopleOnTrain < capacity && peopleOnTrain + passengerMoves[arrayIndex, 2] > capacity))
            {
                return "impossible";
            }
            if (peopleOnTrain > 0 && arrayIndex == numberOfStops -1)
            {
                return "impossible";
            }
            return passengerCalculation(ref passengerMoves, capacity, arrayIndex + 1, peopleOnTrain, numberOfStops);

        }
        public static void Main()
        {
            var mc = new myProgram();

            string input = Console.ReadLine();
            string[] input1 = input.Split(" ");
            int[] inputToInts = input1.Select(int.Parse).ToArray();

            int trainCapacity = inputToInts[0];
            int numberOfStops = inputToInts[1];

            int[,] passengerMovement = new int[numberOfStops, 3];

            for (int i = 0; i < numberOfStops; i++)
            {
                string stopDeatils = Console.ReadLine();
                string[] stopDeatilsSplit = stopDeatils.Split(" ");
                int[] stopDetailsToInts = stopDeatilsSplit.Select(int.Parse).ToArray();

                for (int j = 0; j < stopDetailsToInts.Length; j++)
                {
                    passengerMovement[i, j] = stopDetailsToInts[j];
                }

            }

            Console.WriteLine(mc.passengerCalculation(ref passengerMovement, trainCapacity, 0, 0, numberOfStops));
        }
    }

}






//int spaceRemaing = capacity - passengerMoves[arrayIndex,0];
//int passengersOnPlatform = passengerMoves[arrayIndex, 2];

//if (passengerMoves[arrayIndex, 1] + spaceRemaing > capacity)
//{
//    Console.WriteLine("impossible");
//} 
//if (spaceRemaing < 0)
//{
//    Console.WriteLine("impossible");
//}
//if (spaceRemaing + passengersOnPlatform < capacity)
//{
//    Console.WriteLine("impossible");
//}

//return spaceRemaing;


