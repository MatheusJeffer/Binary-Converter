using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.BinaryConverter
{
    public static class IntBinaryConverter
    {
        public static string IntBinary(Int64 number)
        {
            string Binary = "";
            string BinaryResult = "";
            Int64 numberBin = number;
            for (Int64 numbers = numberBin; numbers > 0; numbers /= 2)
            {
                Binary += numbers % 2;
            }

            for (int index = Binary.Length - 1; index >= 0; index--)
            {
                BinaryResult += Binary[index];
            }
            return BinaryResult;
        }
    }
}
