using System.Numerics;
using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            BigInteger val1 = BigInteger.Parse(Console.ReadLine());
            BigInteger val2 = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(val1 + val2);

        }
    }
}