using Binary_converter.BinaryConverter;
using BinaryConverter.BinaryDesconverter;
using BinaryConverter.ProgramData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.Base64Converter
{
    public class CharToBase64 : Data
    {

        public static string CharBase64(string input)
        {

            
            string ascii = StringToBinary.Input(input).Replace(" ", "");
            List<string> binaryString = BinaryDivide.BinaryConvertToString(ascii, 6, true);
            string base64 = "";
        
                
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
