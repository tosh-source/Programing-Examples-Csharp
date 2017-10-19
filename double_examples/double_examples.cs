using System;
using System.Numerics;

namespace double_examples
{
    class double_examples
    {
        static void Main()
        {
            double floatMax = float.MaxValue;
            BigInteger floatToBigInt = BigInteger.Parse(floatMax.ToString("0"));
            Console.WriteLine(floatMax + "\n" + floatToBigInt + "\n");

            double doubleMax = double.MaxValue;
            BigInteger doubleToBigInt = BigInteger.Parse((double.MaxValue).ToString("0"));
            Console.WriteLine(doubleMax + "\n" + doubleToBigInt + "\n");

            //"double" може да показва число с дължина от 15 цифри. Без значение от мястото на десетичната запетая, в крайна сметка числото ще бъде закръглено, и ОБЩАТА му дължина ще е 15 знака.
            double TEST1 = 1.12345678901234567890;
            Console.WriteLine(TEST1);
            double TEST2 = 56.12345678901234567890;
            Console.WriteLine(TEST2);
            double TEST3 = 56789.12345678991234567899;  //Тук след 9-ката, поставям пак 9-ка, вместо "0". Тъй като закръглянето става точно на нея и я премахва, а така излиза, че "double" може показва число с дължина от 14 цифри, вместо 15, което не е вярно.
            Console.WriteLine(TEST3);
        }
    }
}
