using System;
namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            int widthOfCake = int.Parse(Console.ReadLine());
            int numberOfPieces = int.Parse(Console.ReadLine());
            int area = 0;
            for (int i = 0; i < numberOfPieces; i++)
            {
                string [] sizeOfPieces = Console.ReadLine().Split(" ");
                area += Convert.ToInt32(sizeOfPieces[0]) * Convert.ToInt32(sizeOfPieces[1]);
            }
            Console.WriteLine(area / widthOfCake);
        }    
    }
}