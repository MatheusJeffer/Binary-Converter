using BinaryConverter.BinaryDesconverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.BinaryDesconverter
{
    public class BinaryDivide
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
                        if (isBase64)
                        {
                            finalBin += "0";
                        }
                        else
                        {
                            newBin += "0";
                        }
                    }

                    index += bits;

                    if (isBase64)
                    {
                        binaryList.Add(finalBin);
                        finalBin = "";
                    }
                    else 
                    {
                        newBin += finalBin;
                        binaryList.Add(newBin);
                        newBin = "";
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
