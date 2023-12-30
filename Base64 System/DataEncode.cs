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
    public class DataEncode : Data
    {

        public static StringBuilder Encode(string input, int bitsLenght, char[] mapingChar, string TypeCodification)
        {

            
            StringBuilder ascii = StringToBinary.Input(input).Replace(" ", "");
            List<StringBuilder> binaryString = SplitBinaries.splitBin(ascii, bitsLenght, TypeCodification);
            StringBuilder codificationResult = new StringBuilder();


            for (int bin = 0; bin < binaryString.Count; bin++)
            {
                codificationResult.Append(mapingChar[BinaryToNumber.BinaryToInt(Convert.ToString(binaryString[bin]))]);
            }


            return codificationResult;

        }

    }
}
