using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace myNameSpace
{
    class myProgram
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            int inputLength = input.Length;
            int index = 0;
            int indexTwo = 0;
            StringBuilder sb = new StringBuilder();
            bool firstOccurence = false;
            int replacement = 0;

            if(int.Parse(input) > 149) 
            {
                index = inputLength - 2;
                indexTwo =inputLength - 1;

                if ((char.GetNumericValue(chars[index]) == 4 && char.GetNumericValue(chars[indexTwo]) == 9) || char.GetNumericValue(chars[index]) > 4)
                {
                    for (int i = 0; i < inputLength; i++)
                    {
                        if(i == index)
                        {
                            sb.Append('9') ;
                        }
                        else
                        {
                            sb.Append(input[i]);
                        }
                    }

                    Console.WriteLine(sb.ToString().TrimStart('0'));

                }
                else
                {
                    for(int i =  inputLength-1 ; i >= 0; i--)
                    {
                        if (firstOccurence == false && i > inputLength - 3)
                        {
                            sb.Append('9');
                        }
                        else if(firstOccurence == false && char.GetNumericValue(chars[i]) == 0 && i > 0)
                        {
                            sb.Append('9');
                        }
                        else if (firstOccurence == false && char.GetNumericValue(chars[i]) > 0)
                        {

                            replacement = (int)char.GetNumericValue(chars[i]);
                            sb.Append(replacement - 1);
                            firstOccurence = true;

                        }
                        else
                        {
                            sb.Append(input[i]);
                        }

                    }
                    char [] finalOutput = sb.ToString().ToCharArray();
                    StringBuilder stringBuilder = new StringBuilder();

                    for (int i = finalOutput.Length - 1; i >= 0; i--)
                    {
                        stringBuilder.Append(finalOutput[i]);
                    }
                    Console.WriteLine(stringBuilder.ToString().TrimStart('0'));

                }

            }
            else
            {
                Console.WriteLine("99");
            }
        }
    }

}
