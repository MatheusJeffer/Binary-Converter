using BinaryConverter.BinaryDesconverter;
using BinaryConverter.BinaryConverter;
using System.Text;

namespace Binary_converter.AllMains
{
    public class Decoder
    {
        public static StringBuilder DecoderInput(string input, int bitsLenght, int bitsSplit, char[] mapingListParam, string typeEncode)
        {
            StringBuilder binGen = new StringBuilder();

            StringBuilder finalResult = new StringBuilder(); 
            foreach(char character in input)
            {
                for (Int64 index = 0; index < mapingListParam.Length; index++)
                {
                    if (mapingListParam[index] == character)
                    {
                        binGen.Append(IntBinaryConverter.IntBinary(index, true, bitsLenght));
          
                    }
                }
            }
           List<StringBuilder> finalBin  = SplitBinaries.splitBin(binGen, bitsSplit, typeEncode);

          for(int bins = 0; bins < finalBin.Count; bins++)
          {
                finalResult.Append($"{Convert.ToChar(BinaryToNumber.BinaryToInt(Convert.ToString(finalBin[bins])))}");
          }

            return finalResult;


        }
    }
}
