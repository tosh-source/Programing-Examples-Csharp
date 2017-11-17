﻿using System;


class PrintHappyNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());       //тук въвеждам колко цифрени да са отпечатаните щастливи чиса, дву цифрени (2), четири (4), шест цифрени (6) и т.н.
        int startValue = (int)Math.Pow(10, n - 1);   //за да получа началната стойност на всички двуцифрени може да се използва степенуване на числото 10 за най-лесно. Т.е., нач.стойност на всички дву цифрени (2) е равна на 10^(2-1) или десет на втора степен минус (-1)ца. Т.е. 10^1 (десет на първа степен) = 10 , което е началото на вс.двуцифрени числа. Аналогично е и за четери цифрените (4). Или 10^(4-1), което е 10^3=1000 , а както знаем 1000 е първото четерицифрено число.
        int endValue = (int)Math.Pow(10, n) - 1;     //В контекста на написаното на горния ред, тук за крайно число на двуцифрените (2) е (10^2)-1 или десет на степен втора и мн.важно, тук от ПОЛУЧЕНИЯ резултат, който е 100 вадим 1ца, а НЕ от САМАТА степен!! Т.е., 100-1=99, това е последното двуцифрено число. Аналогично и за четерицифрените, (10^4)-1 = 10000-1 = 9999 , а това както знаем е последното четерицифрено число.

        for (int i = startValue; i <= endValue; i++)
        {
            int number = i;

            int firstDigit = 0;
            for (int positon = 1; positon <= (n / 2); positon++)
            {
                int digit = number % 10;
                firstDigit = firstDigit + digit;
                number = number / 10;
            }

            int seccondDigits = 0;
            for (int positon = 1; positon <= (n / 2); positon++)
            {
                int digit = number % 10;
                seccondDigits = seccondDigits + digit;
                number = number / 10;
            }

            if (firstDigit == seccondDigits)
            {
                Console.WriteLine(i);
            }
        }
    }
}

//Опросения пример от книгата на Наков (Въведение ш програмирането)
//
//for (int a = 1; a <= 9; a++)
//{
//    for (int b = 0; b <= 9; b++)
//    {
//        for (int c = 0; c <= 9; c++)
//        {
//            for (int d = 0; d <= 9; d++)
//            {
//                if ((a+b)==(c+d))
//                {
//                    Console.WriteLine("" + a + b + c + d);
//                }
//            }
//        }
//    }
//}



//Още по-опростен и доста по-бърз вариянт с един единствен цикъл.
//
//for (int i = 1000; i <= 9999; i++)
//{
//    int happyNumb = i;
//
//    int d = happyNumb % 10;      //с този математически трик си присвоявам последната цифра от чистоло 1000. В случая си присвоявам 0. Аналогично и за следващите числа от цикъла 1001, 1002 и т.н., присвоявам 1, 2 и т.н.
//    happyNumb = happyNumb / 10;  //по този начин пък махам последната цифра от числото 1000. Т.е като го разделим на 10 се получава 100, защото делим целочислено и последна цифра(остатъка) се губи. Аналогично е и за всички останали числа от цикъла, напр. за 1234 , получавам 123.
//    int c = happyNumb % 10;
//    happyNumb = happyNumb / 10;
//    int b = happyNumb % 10;
//    happyNumb = happyNumb / 10;
//    int a = happyNumb;
//    if ((a + b) == (c + d))
//    {
//        Console.WriteLine("" + a + b + c + d);
//    }
//}