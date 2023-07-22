using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNamespace
{
    class program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == chars[i+1])
                {
                    continue;
                }
                else
                {
                    sb.Append(chars[i]);
                }
            }

            sb.Append(chars.Last());

            Console.WriteLine(sb.ToString());


        }
    }
}