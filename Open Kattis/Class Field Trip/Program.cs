using System;
using System.Collections;
using System.Collections.Generic;

namespace myNameSpace
{
    class program
    {
        static void Main(string[] args) 
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string jointInput = input1 + input2;

            List<char> joinedList = new List<char>();

            for (int i = 0; i < jointInput.Length; i++)
            {
                joinedList.Add(jointInput[i]);
            }
            
            joinedList.Sort();

            string output = string.Empty;

            for (int i = 0; i < joinedList.Count;i++)
            {
                output += joinedList[i];
            }

            Console.WriteLine(output);
        }
    }
}