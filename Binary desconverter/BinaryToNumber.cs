using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.BinaryDesconverter
{
    public class BinaryToNumber
    {

        public static Int64 BinaryToInt(string binaryNumber)
        {
            Int64 results = 0;
            string binary = binaryNumber;
            int index = 0;

            for(int number = binary.Length - 1; number >= 0; number--)
            {
                results += Convert.ToInt64(binary[index].ToString()) * Convert.ToInt64(  Math.Pow(2, number));
                index++;
            }
            return results;
        } 
    }
}
