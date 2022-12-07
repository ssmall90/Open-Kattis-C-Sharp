using System;
using System.Collections.Generic;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<char> outputList = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                outputList.Add(input[i]);

                if (input[i] == 'e')
                {
                    outputList[i] = 'e';
                    outputList.Add('e');
                }
            }
            foreach(char c in outputList)
            {
                Console.Write(c);
            }

        }
    }
}