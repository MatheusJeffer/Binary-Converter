using BinaryConverter.BinaryDesconverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_converter.Binary_desconverter
{
    public class BinaryToString
    {
        public static string BinaryConvertToString(string bin)
        {
            string binary = bin.Replace(" ", "").Replace("\n", "");
            string finalBin = "";
            string text = "";
            int index = 0;
            List<string> binaryList = new List<string> { };
            int multiIndex = 7;

            while (true)
            {
                for (int i = index; i < multiIndex; i++)
                {
                    finalBin += binary[i];
                }
           
                binaryList.Add(finalBin);
                 finalBin = "";

                index += 7;
                multiIndex += 7;

                if (index >= binary.Length)
                {
                    break;
                }
            }

            for(int bina = 0; bina < binaryList.Count; bina++)
            {
                text += Convert.ToChar(BinaryToNumber.BinaryToInt( binaryList[bina]));
            }

            return text;

        }

    }
}
