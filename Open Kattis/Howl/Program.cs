using System;
using System.Linq;
using System.Text;

namespace MyNamespce
{
    class Program
    {
        public static void Main()
        {
            string fenirHowl = Console.ReadLine();

            StringBuilder howl = new StringBuilder();
            howl.Append("AWH");

            for (int i = 0; i < fenirHowl.Length; i++)
            {
                howl.Append("O");

            }

            Console.WriteLine(howl.ToString());
        }
    }
}