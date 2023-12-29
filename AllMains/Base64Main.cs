using BinaryConverter.AllMains;
using BinaryConverter.InputValider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_converter.AllMains
{
    public class Base64Main
    {
        public static void Base64ConveterMain()
        {
            string txtInput;
            string binaryTBase64;
            Int64 userInput;
            bool breaker = true;

            do
            {

                Console.WriteLine("=-=-==-=-=-==-=-=-=-==-=-=-=-=-\n" +
                                  "       Base 64 Converter\n" +
                                  "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-="
                                  );
                Console.WriteLine("[1]Characters to Base 64");

                userInput = IntValidator.inputValidator("Switch the options");

                switch (userInput)
                {
                    case 1:
                        txtInput = Console.ReadLine();
                        Console.WriteLine(CharToBase64.CharBase64(txtInput));
                        break;
                    default:
                        Console.WriteLine("This options don't exists.");
                        break;
                }


            } while (breaker);


        }
    }
}
