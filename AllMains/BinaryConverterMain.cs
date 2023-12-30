using System;
using BinaryConverter.InputValider;
using BinaryConverter.BinaryConverter;
using BinaryConverter.BinaryDesconverter;
using Binary_converter.BinaryConverter;
using System.Diagnostics;
using System.Text;
namespace BinaryConverter.AllMains
{
    public static class BinaryMain
    {
        public static void BinaryConveterMain()
        {
            bool loopBreaker = true;
            string directory;
            long intInput;
            string binaryInput;
            string userInput = "";


            do
            {

                Console.WriteLine("==-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-==\n" +
                                  "        Binary Conventer\n" +
                                  "==-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=="
                                  );

                Console.WriteLine(" [1]Convert number to Binary\n [2]Convert Binary to number\n " +
                           " [3]Letter to binary\n [4]Binary To Letter\n [5]Decode archive\n [6]Back");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        intInput = IntValidator.inputValidator("Write number");
                        Console.WriteLine($"O binário do número {intInput} é [{IntBinaryConverter.IntBinary(intInput, false, 0)}]");

                        break;
                    case "2":
                        binaryInput = BinaryInput.Input("Write binary");
                        Console.WriteLine($"O binário {userInput} representa o número [{BinaryToNumber.BinaryToInt(binaryInput)}]");
                        break;
                    case "3":
                        userInput = Console.ReadLine();
                        Console.WriteLine($"O texto {userInput} representa o binario {StringToBinary.Input(userInput)}");
                        break;
                    case "4":
                        binaryInput = Console.ReadLine();
                        Console.WriteLine($"{BinaryToStringDecoder.Decoder(binaryInput)}");
                        break;
                    case "5":
                        Console.WriteLine("Write the directory of archive .txt with binary");
                        try
                        {

                            using (var reader = new StreamReader(Console.ReadLine()))
                            {
                                Console.WriteLine(BinaryToStringDecoder.Decoder(reader.ReadLine()));
                            }
                        }
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine("This file not exist");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"ERROR {ex}");
                        }
                        break;
                    case "6":
                        loopBreaker = false;
                        break;
                    default:
                        Console.WriteLine("This option don't exists.");
                        break;
                }

            } while (loopBreaker);

        }
    }


}