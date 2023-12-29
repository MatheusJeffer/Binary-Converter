using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.InputValider
{
    public class IntValidator
    {

        public static Int64 inputValidator(string txt)
        {

            bool loopBreaker = true;
            Int64 intInput = 0;
            do
            {
                Console.WriteLine(txt);
                try
                {
                    intInput = Convert.ToInt64(Console.ReadLine());
                    loopBreaker = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR 001: WRITE ONLY NUMBER.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"ERROR 002: WRITE NUMBERS BETWEEN 0 AND {Int64.Max} ");
                }
            } while (loopBreaker);

            return intInput;

        }

    }
}
