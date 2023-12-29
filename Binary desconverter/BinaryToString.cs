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
        public static List<string> BinaryConvertToString(string bin, int bits, bool isBase64) 
        {
            string binary = bin.Replace(" ", "");
            string finalBin = "";
            string newBin = "";
            string text = "";
            int index = 0;
            List<string> binaryList = new List<string> { };
            int multiIndex = bits;

            while (true)
            {
                if (binary.Length - index >= bits)
                {
                    for (int i = index; i < multiIndex; i++)
                    {
                        finalBin += binary[i];
                    }

                    binaryList.Add(finalBin);
                    finalBin = "";

                    index += bits;
                    multiIndex += bits;
                }
                else
                {
                    for(int i = index; i < binary.Length; i++)
                    {
                        finalBin += binary[i];
                    }

                    for(int zeros = finalBin.Length; zeros < bits; zeros++)
                    {
                        if (!isBase64)
                        {
                            newBin += "0";

                        }
                        else
                        {
                            finalBin += "0";
                        }
                    }

                    index += bits;

                    if (!isBase64)
                    {
                        newBin = finalBin;
                        binaryList.Add(newBin);
                        newBin = "";
                    }
                    else
                    {
                        binaryList.Add(finalBin);
                        finalBin = "";

                    }

                }

                if (binary.Length - index <= 0)
                {
                    break;
                }
            }

            return binaryList;

        }

    }
}
