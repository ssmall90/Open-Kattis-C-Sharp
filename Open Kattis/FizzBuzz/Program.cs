using System; 

namespace MyNameSpace
{
    class MyProgram
    {
        public static void Main()
        {
            string userInput = Console.ReadLine();
            string fizz = userInput.Split()[0];
            string buzz = userInput.Split()[1];
            string numberOfLine = userInput.Split()[2];
            int numberOfLines = int.Parse(numberOfLine);


            int fizzNum = int.Parse(fizz);
            int buzzNum = int.Parse(buzz);

            for (int i = 1; i <= numberOfLines; i++)
            {
                if (i % fizzNum == 0)
                {
                    if (i % buzzNum == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (i % buzzNum == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
