using System; 

namespace myNameSpace
{
    class myProgram
    {
        static void Main ()
        {
            int intInput1 = int.Parse(Console.ReadLine());  
            int intInput2 = int.Parse(Console.ReadLine());


            if (intInput1 > 0 && intInput2 > 0)
            {
                Console.WriteLine("1");
            }
            else if (intInput1 < 0 && intInput2 < 0)
            {
                Console.WriteLine("3");
            }
            else if (intInput1 > 0 && intInput2 < 0)
            {
                Console.WriteLine("4");
            }
            else if (intInput1 < 0 && intInput2 > 0)
            {
                Console.WriteLine("2");
            }
        }
    }
}

