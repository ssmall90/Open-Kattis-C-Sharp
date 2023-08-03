using System;
using System.Xml.Schema;

namespace MyNamespace;

class Program
{
    public static void Main()
    {
        int totalStatues = int.Parse(Console.ReadLine());
        int statuesPrinted = 0;
        int printers = 1;
        int days = 0;

        while (statuesPrinted < totalStatues) 
        {
            if((totalStatues - statuesPrinted) > printers)
            {
                days += 1;
                printers += printers;
            }
            else
            {
                days += 1;
                statuesPrinted += printers;
            }
        }

        Console.WriteLine(days);

    }
}