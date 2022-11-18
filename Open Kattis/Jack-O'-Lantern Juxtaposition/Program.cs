using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string numberOfEyeDesigns = input.Split(" ")[0]; 
            string numberOfNoseDesigns = input.Split(" ")[1];
            string numberOfMouthDesigns = input.Split(" ")[2];
            int numberOfEyeDesigns1 = Convert.ToInt32(numberOfEyeDesigns);
            int numberOfNoseDesigns1 = Convert.ToInt32(numberOfNoseDesigns);
            int numberOfMouthDesigns1 = Convert.ToInt32(numberOfMouthDesigns);
            Console.WriteLine(numberOfEyeDesigns1 * numberOfNoseDesigns1 * numberOfMouthDesigns1);
        }
    } 
}