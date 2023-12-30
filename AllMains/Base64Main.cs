using BinaryConverter.AllMains;
using BinaryConverter.InputValider;
using System;
using BinaryConverter.Base64Converter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryConverter.ProgramData;

namespace Binary_converter.AllMains
{
    public class Base64Main 
    {
        public static void Base64ConveterMain()
        {
            string txtInput;
            StringBuilder Base64 = new StringBuilder();
            Int64 userInput;
            bool breaker = true;

            do
            {

                Console.WriteLine("=-=-==-=-=-==-=-=-=-==-=-=-=-=-\n" +
                                  "       Base 64 Converter\n" +
                                  "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-="
                                  );
                Console.WriteLine(" [1]Characters to Base 64\n [2]Base64 to characters");

                userInput = IntValidator.inputValidator("Switch the options");

                switch (userInput)
                {
                    case 1:
                        txtInput = Console.ReadLine();
                        Base64.Append(DataEncode.Encode(txtInput, 6, Data.MapingBase64, "base64"));
                       
                        if(Base64.Length % 4 != 0)
                        {
                            Base64.Append("==");
                        }
                        else if (Base64.Length % 3 != 0)
                        {
                            Base64.Append("=");
                        }

                        Console.WriteLine($"Result: [{Base64}]");
                        Base64.Clear();
                        break;
                    case 2:
                        txtInput = Console.ReadLine();

                        Console.WriteLine(Decoder.DecoderInput(txtInput, 6, 8, Data.MapingBase64, "base64"));
                        break;
                    case 3:
                        breaker = false;
                        break;
                    default:
                        Console.WriteLine("This options don't exists.");
                        break;
                }


            } while (breaker);


        }
    }
}
