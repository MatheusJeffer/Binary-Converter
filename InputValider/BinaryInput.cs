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
            int characterUnwated = 0;
            char[] binaryNumbers = { '0', '1' };
            bool loopBreaker = true;

            do
            {
                Console.WriteLine(txt);
                try
                {
                    binaryInput = Console.ReadLine();

                    foreach(char character in binaryInput)
                    {
                        if (!binaryNumbers.Contains(character) && character != ' ')
                        {
                            characterUnwated++;
                        }
                    }

                    if(characterUnwated > 0)
                    {
                        characterUnwated = 0;
                        Console.WriteLine("ERROR 002: WRITE ONHLY BINARY NUMBERS");
                    }
                    else
                    {
                        loopBreaker = false;
                    }
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("ERROR 003: YOU EXCEEDED THE LIMIT OF CHARACTERS.");
                }

            } while (loopBreaker);




            return binaryInput;
        }



    }
}
