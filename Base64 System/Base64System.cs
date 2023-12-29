using BinaryConverter.BinaryDesconverter;
using Binary_converter.BinaryConverter;
using BinaryConverter.BinaryConverter;
using BinaryConverter.ProgramData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_converter.AllMains
{
    public class Decoder
    {
        public static string DecoderInput(string input, int bitsLenght, int bitsToFatied, char[] mapingListParam)
        {
            string binGen = "";
            char[] mapingList = mapingListParam;
            string finalResult = ""; 
            foreach(char character in input)
            {
                for (Int64 index = 0; index < mapingList.Length; index++)
                {
                    if (mapingList[index] == character)
                    {
                        binGen += IntBinaryConverter.IntBinary(index, true, bitsLenght);
          
                    }
                }
            }
            List<string> finalBin  = (BinaryDivide.BinaryConvertToString(binGen, bitsToFatied, false));

            for(int bins = 0; bins < finalBin.Count; bins++)
            {
                finalResult += $"{Convert.ToChar(BinaryToNumber.BinaryToInt(finalBin[bins]))}";
            }

            return finalResult;


        }
    }
}
