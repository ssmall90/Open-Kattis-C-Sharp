using System;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int subStart = 0; 

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                {
                    subStart = i;
                    break;
                }
            }


            string output = input.Substring(subStart);

            Console.WriteLine(output);
        }
    }
}