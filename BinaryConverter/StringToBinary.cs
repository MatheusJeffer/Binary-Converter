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
        public static StringBuilder Input(string text)
        {
            StringBuilder binary = new StringBuilder();
            int asciiChar;
            
            foreach(char characters in text)
            {
                    asciiChar = (int)characters;

                    binary.Append($"{IntBinaryConverter.IntBinary(asciiChar, true, 8)} ");

            }



            return binary;
        }



    }
}
