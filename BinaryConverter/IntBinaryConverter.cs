using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.BinaryConverter
{
    public static class IntBinaryConverter
    {
        public static string IntBinary(Int64 number, bool zeroFill = false, int bits = 0)
        {
            string Binary = "";
            string BinaryResult = "";
            string nb = "";
            Int64 numberBin = number;
            for (Int64 numbers = numberBin; numbers > 0; numbers /= 2)
            {
                Binary += numbers % 2;
            }

            for (int index = Binary.Length - 1; index >= 0; index--)
            {
                BinaryResult += Binary[index];
            }
            if (zeroFill)
            {
                for(int _ = Binary.Length; _ < bits; _++)
                {
                    nb += "0";
                }
                nb += BinaryResult;
                return nb;

            }
            else
            {
                return BinaryResult;
            }
        }
    }
}
