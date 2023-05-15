using System;
namespace MyNamespace
{
    class program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            string[] values = input2.Split(" ");
            double total = 0;
            int count = 0; 

            foreach (string value in values)
            {
                if (int.Parse(value) > 0)
                {
                    total += int.Parse(value);
                }
                else if (int.Parse (value) < 0) 
                {
                    count++;
                }
            }

            Console.WriteLine(total / (values.Length - count));
        }

    }
}
