using System;

namespace Mynamespace
{
    class MyProgram
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double a = double.Parse(input.Split(" ")[0]);
            double b = double.Parse(input.Split(" ")[1]);
            double c = double.Parse(input.Split(" ")[2]);
            double d = double.Parse(input.Split(" ")[3]);

            var MyMethod = new MyMethods();
            double output = MyMethod.MaxArea(a, b, c, d);

            Console.WriteLine(output.ToString());
        }


    }

    public class MyMethods
    {
         public double MaxArea(double a, double b, double c, double d)
        {
            double semiPerimeter = SemiPerimeter(a, b, c, d);
            return Formula(a, b, c, d, semiPerimeter);
            
        }

        public double SemiPerimeter(double a, double b, double c, double d)
        {
            return (a + b + c + d) / 2;
        }

        public double Formula(double a, double b, double c, double d, double semiP)
        {
            return Math.Sqrt(
                            (semiP - a) *
                            (semiP - b) *
                            (semiP - c) *
                            (semiP - d)
                            );
        }
    }

}