using System;
using System.Xml;

namespace myNameSpace
{
    class myProgram
    {
        static void Main()
        {
            int numberOfWords = int.Parse(Console.ReadLine());
            string[] words = new string[numberOfWords];

            for (int i = 0; i < numberOfWords; i++)
                {
                  words[i] = Console.ReadLine();
                }

            for (int i = 0; i < words.Length; i++)
            {
                if ((i % 2 == 0))
                {
                    Console.WriteLine(words[i]);
                }
            }


        }
    }
}