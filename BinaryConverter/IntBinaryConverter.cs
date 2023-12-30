using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.BinaryConverter
{
    public static class IntBinaryConverter
    {
        public static StringBuilder IntBinary(Int64 number, bool zeroFill = false, int bits = 0)
        {
            StringBuilder Binary = new StringBuilder();
            StringBuilder binaryZeroFill = new StringBuilder();
            StringBuilder binaryResult = new StringBuilder();
            for (Int64 numbers = number; numbers > 0; numbers /= 2)
            {
                Binary.Append(numbers % 2);
            }

            for (int index = Binary.Length - 1; index >= 0; index--)
            {
                binaryResult.Append(Binary[index]);
            }
            if (zeroFill)
            {
                for(int _ = Binary.Length; _ < bits; _++)
                {
                    binaryZeroFill.Append("0");
                }
                binaryZeroFill.Append(binaryResult);
                return binaryZeroFill;

            }
            else
            {
                return binaryResult;
            }
        }
    }
}
