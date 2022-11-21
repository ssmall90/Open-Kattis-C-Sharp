using System;
using System.ComponentModel;

namespace myNameSpace
{
    public class myProgram
    {
        static void Main()
        {
            string input = (Console.ReadLine());
            string input1 = input.Split(" ")[0];
            string input2 = input.Split(" ")[1];
            int count = 0;
            int a = Convert.ToInt32(input1);
            int b = Convert.ToInt32(input2);
            if (a == b)
            {
                Console.WriteLine(count);
            }
            else if (a < b)
            {
                while (a < b)
                {
                    a++;
                    count++;
                }
                Console.WriteLine(count);
            }
            else if (a > b)
            {
                if (!(a % 2 == 0))
                {
                    a = a + 1;
                    count++;

                }
                if (a % 2 == 0)
                {
                    do
                    {
                        if (a == b)
                        {
                            goto loop;
                        }
                        if (a % 2 == 0)
                        {
                            a = a / 2;
                            count++;
                        }
                        else if (!(a % 2 == 0))
                        {
                            a = a + 1;
                            count++;
                            a = a / 2;
                            count++;
                        }                 
                    }
                    while (a > b);
                    while (a < b)
                    {
                        a++;
                        count++;
                    }
                        loop:
                    Console.WriteLine(count);
                }
            }

        }

    }
}

