using BinaryConverter.BinaryConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_converter.BinaryConverter
{
    public class StringToBinary
    {
        public static string Input(string text)
        {
            string binary = "";
            string finalBinary = "";
            List<string> allBinary = new List<string> { };
            int asciiChar;
            
            foreach(char charactere in text)
            {
                asciiChar = (int)charactere;

                binary = $"{IntBinaryConverter.IntBinary(asciiChar)}";

                if(binary.Length < 8)
                {
                    for(int _ = binary.Length; _ < 8; _++)
                    {
                        finalBinary += "0";
                    }
                    finalBinary += binary;
                    allBinary.Add(finalBinary);
                    finalBinary = "";
                }
                else
                {
                    finalBinary = binary;
                    allBinary.Add(finalBinary);
                    finalBinary = "";
                }
            }

            for (int index = 0; index < allBinary.Count; index++)
            {
                finalBinary += $"{allBinary[index]} ";

            }

            return finalBinary;
        }



    }
}
