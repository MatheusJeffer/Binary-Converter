using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Binary_converter.AllMains;
using BinaryConverter.InputValider;
namespace BinaryConverter.AllMains
{
    public class ProgramMain
    {

        public static void Main()
        {
            Int64 userInput = 0;
            bool loopBreak = true;

            do
            {

                Console.WriteLine("=~=~=~=~==~=~=~~==~~==~=~==~=\n" +
                                  "          Convete\nr" +
                                  "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine(" [1]Binary converter\n [2]Base64 converter");
                userInput = IntValidator.inputValidator("Switch one of options");

                switch (userInput)
                {
                    case 1:
                        BinaryMain.BinaryConveterMain();
                        break;
                    case 2:
                        Base64Main.Base64ConveterMain();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("This options not exists.");
                        break;
                }


            } while (loopBreak);



        }




    }
}
