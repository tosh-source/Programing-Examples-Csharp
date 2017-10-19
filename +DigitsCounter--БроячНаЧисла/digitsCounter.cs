using System;
using System.Numerics;
using System.Threading;
using System.Globalization;

class digitsCounter
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;  //унифициране на настройките (international Culture) на конзолата. Така тя винаги ще търси точка за разделител на числото, не запетая.
        while (true)
        {
            //Digits counter е програма, която преброява броя на цифрите в дадено число
            //1.
            Console.Title = "Digits counter";
            Console.WriteLine("You can enter, integer and real number (with limitation of 254 digits)..");   //Консолата има ограничение от 254 значещи цифри за едно число.
            string userInputValue = Console.ReadLine();
            userInputValue = userInputValue.Replace(',', '.');
            double valueAsDouble = 0.0;

            if (double.TryParse(userInputValue, out valueAsDouble))
            {
                //2.Double value to Integer algorithm
                double doubleToInteger = valueAsDouble;
                byte doubleToIntCounter = 0;
                while (doubleToInteger >= 1)   //Алгоритъм за пресмятане дължината на десетичната дроб ПРЕДИ запетаята!
                {
                    doubleToInteger = doubleToInteger / 10;
                    doubleToIntCounter++;
                }
                BigInteger userInputValueAsInteger = (BigInteger)(valueAsDouble * Math.Pow(10, (userInputValue.Length - (doubleToIntCounter + 1))));   //Формула която връща реално число към цяло число, запазвайки ВСИЧКИ въдевени от потребителя цифри. НАпр: 12,345 (double) ==> 12345 (int). Алгоритъм: integer = double(въведена от потребителя) * (10 ^ (дължина на стринга, нспр:->12,345->5+1(заради запетаята) = 6 символа) - ((броя на цифрите в числото преди запетаята, напр: 12,345->12,*** = 2 броя цифри) + 1(символа запетая от преди малко, който трябва да извадим от ДЪЛЖИНАТА на стринга. Напр: 12,345=6 символа, но броя на цифрите е = 5) ))
                //3.Value length algorithm
                byte counter = 0;   //В случая, поради ограничението на конзолата (254 цифри за число), не е нужно използване на по-голям тип данни.
                while (userInputValueAsInteger >= 1)
                {
                    userInputValueAsInteger = userInputValueAsInteger / 10;
                    counter++;
                }
                //4.Checke if user value is integer, not floating point number. The int number increase(++) with "1".
                BigInteger testValueIfInt = 0;
                if (BigInteger.TryParse(userInputValue, out testValueIfInt))
                {
                    counter++;   //Тъй като при число с плаваща запетая, алгоритъма вади един брой от цифрите на изброеното число заради запетаята(12,345->6 символа->5 цифри), то тук, в тази част на кода, ако въведеното от потребителя, е цяло число (integer) единицата се възтановява.
                }

                //5.Print
                Console.WriteLine("The value has a: {0} digits", counter);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter integer or real number!");
                Console.ResetColor();
            }

            //00.Continue program loop-------------------------------
            Console.Write("Continue? Y/n (or simply press enter): ");
            string userChoice = Console.ReadLine();
            if ((userChoice == "N") || (userChoice == "n"))
            {
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(new string('-', 10));
                Console.ResetColor();
            }
        }
    }
}


//The original code algorithm.
//////////////////////////////////////////////////////////////////////////
//decimal value = decimal.MaxValue;
//long counter = 0;
//while (value >= 1)
//{
//    value = value / 10;
//    counter++;
//}
//Console.WriteLine("The value: {0} \nhas a: {1} digits", value, counter);
//////////////////////////////////////////////////////////////////////////