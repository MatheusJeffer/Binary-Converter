using BinaryConverter.BinaryDesconverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.BinaryDesconverter
{
    public class SplitBinaries
    {
        public static List<StringBuilder> splitBin(StringBuilder bina, int bits, string typeEncode) 
        {
            StringBuilder binary = new StringBuilder();
            binary = bina.Replace(" ", "");
            
            int index = 0;
            List<StringBuilder> binaList = new List<StringBuilder> { };
            int nextIndex = bits;

            while (true)
            {
                StringBuilder binaResult = new StringBuilder();
                StringBuilder binaLeftZeroFill = new StringBuilder();

                if (binary.Length - index >= bits)
                {
                    for (int i = index; i < nextIndex; i++)
                    {
                        binaResult.Append(binary[i]);
                    }

                    binaList.Add(binaResult);

                    index += bits;
                    nextIndex += bits;
                }
                else
                {
                    for(int i = index; i < binary.Length; i++)
                    {
                        binaResult.Append(binary[i]);
                    }

                    for(int zeros = binaResult.Length; zeros < bits; zeros++)
                    {
                        if (typeEncode == "base64")
                        {
                            binaResult.Append("0");
                        }
                        else
                        {
                            binaLeftZeroFill.Append("0");
                        }
                    }

                    index += bits;

                    if (typeEncode == "base64")
                    {
                        binaList.Add(binaResult);
                    }
                    else 
                    {
                        binaLeftZeroFill.Append(binaResult);
                        binaList.Add(binaLeftZeroFill);

                    }

                }

                if (binary.Length - index <= 0)
                {
                    break;
                }
            }

            return binaList;

        }

    }
}
