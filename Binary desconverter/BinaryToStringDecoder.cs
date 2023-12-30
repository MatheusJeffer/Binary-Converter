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
        public static StringBuilder Decoder(string binary)
        {


            StringBuilder finalText =  new StringBuilder();
            StringBuilder bin = new StringBuilder(binary);

            List<StringBuilder> binaryList = SplitBinaries.splitBin(bin, 8, "Binary");

            for (int index = 0; index < binaryList.Count; index++)
            {
                finalText.Append(Convert.ToChar(BinaryToNumber.BinaryToInt(Convert.ToString(binaryList[index]))));
            
            }


            return finalText;



        }

    }
}
