using BinaryConverter.BinaryDesconverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.BinaryDesconverter
{
    public class BinaryToStringDecoder
    {
        public static string Decoder(string binary)
        {


            string finalText = "";
            string bin = binary;

            List<string> binaryList = BinaryDivide.BinaryConvertToString(bin, 8, false);

            for (int index = 0; index < binaryList.Count; index++)
            {
                finalText += Convert.ToChar(BinaryToNumber.BinaryToInt(binaryList[index]));
            
            }


            return finalText;



        }

    }
}
