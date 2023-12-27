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
            string Binary = "";
            int asciiChar;
            
            foreach(char charactere in text)
            {
                asciiChar = (int)charactere;

                Binary += $"{IntBinaryConverter.IntBinary(asciiChar)} ";
            }



            return Binary;




        }



    }
}
