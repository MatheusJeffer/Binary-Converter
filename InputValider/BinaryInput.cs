using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.InputValider
{
    public class BinaryInput
    {
        public static string Input(string txt)
        {

            string binaryInput = "";
            int characterIndesejado = 0;
            char[] binaryNumbers = { '0', '1' };
            bool loopBreaker = true;

            do
            {
                Console.WriteLine(txt);
                try
                {
                    binaryInput = Console.ReadLine();

                    for (int index = 0; index < binaryInput.Length; index++)
                    {
                        if (!binaryNumbers.Contains(binaryInput[index]))
                        {
                            characterIndesejado++;
                        }
                    }

                    if(characterIndesejado > 0)
                    {
                        characterIndesejado = 0;
                        Console.WriteLine("ERROR 002: WRITE ONHLY BINARY NUMBERS");
                    }
                    else
                    {
                        loopBreaker = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR 001: WRITE ONLY NUMBERS");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("ERROR 003: YOU WRITING NUMBERS ALEM OF PERMITED");
                }

            } while (loopBreaker);




            return binaryInput;
        }



    }
}
