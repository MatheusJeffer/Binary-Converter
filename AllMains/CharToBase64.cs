using Binary_converter.Binary_desconverter;
using Binary_converter.BinaryConverter;
using BinaryConverter.BinaryDesconverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.AllMains
{
    public class CharToBase64
    {

        public static string CharBase64(string input)
        {

            
            string ascii = StringToBinary.Input(input).Replace(" ", "");
            List<string> binaryString = BinaryToString.BinaryConvertToString(ascii, 6, true);
            string base64 = "";
            char[] mapingBase64 = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
                                        'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f',
                                         'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
                                        'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '/'};

                
            for (int bin = 0; bin < binaryString.Count; bin++)
            {
                base64 += mapingBase64[BinaryToNumber.BinaryToInt(binaryString[bin])];
            }

            if(base64.Length % 4 != 0)
            {
                base64 += "==";
            }
            else if (base64.Length % 3 != 0)
            {
                base64 += "="; 
            }
            

            return base64;

        }

    }
}
