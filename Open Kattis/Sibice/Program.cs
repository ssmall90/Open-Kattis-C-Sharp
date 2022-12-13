using System;

namespace myNameSpace
{
    class myProgram
    {
        double diagonalCalculator(ref float length, ref float width, out double output)
        {
           
            return output = (length * length) + (width * width);

        }
        static void Main()
        {
            string input = Console.ReadLine();
            string numberOfMatches = input.Split(" ")[0];
            string widthOfBoxString = input.Split(" ")[1];
            string lengthOfBoxString = input.Split(" ")[2];
            float widthOfBox = float.Parse(widthOfBoxString);
            float lengthOfBox = float.Parse(lengthOfBoxString);

            double finalOutput;
            double diagonalOutput = 0 ;

            float[] lengthOfMatches = new float[int.Parse(numberOfMatches)];

            for (int i = 0; i < lengthOfMatches.Length; i++)
            {
                lengthOfMatches[i] = float.Parse(Console.ReadLine());
            }

            var myClass = new myProgram();

            myClass.diagonalCalculator(ref widthOfBox, ref lengthOfBox, out diagonalOutput);

            finalOutput = Math.Sqrt(diagonalOutput);


            for (int i = 0; i < lengthOfMatches.Length; i++)
            {
                if (lengthOfMatches[i] > finalOutput)
                {
                    Console.WriteLine("NE");
                }
                else if (lengthOfMatches[i] <= finalOutput)
                {
                    Console.WriteLine("DA");
                }
            }
        }
    }
}