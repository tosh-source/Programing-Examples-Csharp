using System;
using System.Text;

namespace Random_Password_Generator
{
    class Program
    {
        static void Main()
        {
            //symbols
            string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
            string disits = "0123456789";
            string specialSymbols = "!?.,+-*':;<>=@#$%^&~_";

            //input
            Console.Write("Enter password length (min. 4 symbols): ");
            int passsLength = 4; //minimum 4 symbols length
            if (int.TryParse(Console.ReadLine(), out passsLength))
            {
                if (passsLength < 4) passsLength = 4;
            }
            else
            {
                passsLength = 4;
            }

            //algorithm
            Random randomGen = new Random();
            StringBuilder password = new StringBuilder(passsLength);
            StringBuilder temp = new StringBuilder();
            byte lastOne = 0;

            for (int i = 0; i < passsLength; i++)
            {
                PasswordGenerator(uppercaseLetters, lowercaseLetters, disits, specialSymbols, randomGen, password, temp, ref lastOne, ref i);
            }

            //print
            PrintPassword(passsLength, password);
        }

        static void PasswordGenerator(string uppercaseLetters, string lowercaseLetters, string disits, string specialSymbols, Random randomGen, StringBuilder password, StringBuilder temp, ref byte lastOne, ref int i)
        {
            switch (randomGen.Next(1, 5))
            {
                case 1:  //parse uppercaseLetters
                    if (lastOne != 1)
                    {
                        SymbolsGenerator(password, randomGen, temp, uppercaseLetters);
                        lastOne = 1;
                    }
                    else
                    {
                        i--;
                    }
                    break;
                case 2:  //parse lowercaseLetters
                    if (lastOne != 2)
                    {
                        SymbolsGenerator(password, randomGen, temp, lowercaseLetters);
                        lastOne = 2;
                    }
                    else
                    {
                        i--;
                    }
                    break;
                case 3:  //parse digits
                    if (lastOne != 3)
                    {
                        SymbolsGenerator(password, randomGen, temp, disits);
                        lastOne = 3;
                    }
                    else
                    {
                        i--;
                    }
                    break;
                case 4:  //parse specialSymbols
                    if (lastOne != 4)
                    {
                        SymbolsGenerator(password, randomGen, temp, specialSymbols);
                        lastOne = 4;
                    }
                    else
                    {
                        i--;
                    }
                    break;
            }
        }

        static void SymbolsGenerator(StringBuilder password, Random randomGen, StringBuilder temp, string symbols)
        {
            int position = 0;

            //random symbol in random position
            temp.Append(symbols[randomGen.Next(0, symbols.Length)]);
            position = randomGen.Next(0, password.Length);
            password.Insert(position, temp);

            temp.Clear();
        }

        static void PrintPassword(int passsLength, StringBuilder password)
        {
            //password border size
            int consoleLength = Console.WindowWidth;
            if (consoleLength > passsLength) consoleLength = passsLength;

            //password border 1
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + new string('=', consoleLength));

            //print the password
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(password);

            //password border 2
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('=', consoleLength) + "\n");

            Console.ResetColor();
        }
    }
}
