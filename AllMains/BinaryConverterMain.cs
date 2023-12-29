using System;
using BinaryConverter.InputValider;
using BinaryConverter.BinaryConverter;
using BinaryConverter.BinaryDesconverter;
using Binary_converter.BinaryConverter;
using Binary_converter.Binary_desconverter;
using System.Diagnostics;
namespace BinaryConverter.AllMains
{
    public static class BinaryMain
    {
        public static void BinaryConveterMain()
        {
            bool loopBreaker = true;
            string directory;
            long intInput;
            string userInput = "";


            do
            {

                Console.WriteLine("==-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-==\n" +
                                  "        Binary Conventer\n" +
                                  "==-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=="
                                  );

                Console.WriteLine(" [1]Convert number to Binary\n [2]Convert Binary to number\n [3]Letter to binary\n [4]Binary To Letter");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        intInput = IntValidator.inputValidator("Write number");
                        Console.WriteLine($"O binário do número {intInput} é [{IntBinaryConverter.IntBinary(intInput)}]");

                        break;
                    case "2":
                        userInput = BinaryInput.Input("Write binary");
                        Console.WriteLine($"O binário {userInput} representa o número [{BinaryToNumber.BinaryToInt(userInput)}]");


                        break;
                    case "3":
                        userInput = Console.ReadLine();
                        Console.WriteLine($"O texto {userInput} representa o binario {StringToBinary.Input(userInput)}");
                        break;
                    case "4":
                        userInput = Console.ReadLine();
                        Console.WriteLine($"{BinaryToString.BinaryConvertToString(userInput)}");
                        break;
                    case "5":
                        Console.WriteLine("Write the directory of archive .txt with binary");
                        try
                        {

                            using (var reader = new StreamReader(Console.ReadLine()))
                            {
                                Console.WriteLine(BinaryToString.BinaryConvertToString(reader.ReadLine()));
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
                    default:
                        Console.WriteLine("This option don't exists.");
                        break;
                }

            } while (loopBreaker);

        }
    }


}