using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MyNamespace
{
    class program
    {
        public static void Main()
        {
            int numberOfMenus = int.Parse(Console.ReadLine());
            Dictionary<int , string> menuChoices = new Dictionary<int , string>();

            for (int i = 0; i < numberOfMenus; i++)
            {
                string input = Console.ReadLine();
                int menuNumber = int.Parse(input.Split(" ")[0]);
                if (menuNumber < 9)
                {
                    string menuOptions = input.Substring(1);
                    menuChoices[i] = menuNumber + menuOptions;
                }
                else if (menuNumber > 0)
                {
                    string menuOptions = input.Substring(2);
                    menuChoices[i] = menuNumber + menuOptions;
                }

            }

            string output = menuChoices[0];
            string[] outputOptions = output.Split(" ");
            for (int i = 0; i < outputOptions.Length;i++)
            {
                Console.WriteLine(outputOptions[i]);
            }
            
        }
    }
}