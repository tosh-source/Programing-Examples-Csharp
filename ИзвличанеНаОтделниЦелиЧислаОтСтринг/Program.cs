using System;


class ИзвличанеНаОтделниЦелиЧислаОтСтринг
{
    static void Main()
    {
        string strAsNum = "1234";
        int num = int.Parse(strAsNum);

        int d = num % 10;
        num = num / 10;
        int c = num % 10;
        num = num / 10;
        int b = num % 10;
        num = num / 10;
        int a = num;

        Console.WriteLine("The String (as number) is: {0} \nThe number (from String) as four digits are: {1}, {2}, {3}, {4}", strAsNum, a, b, c, d);
    }
}

//Примера по-гоер е взет от алгоритъма за намираане на щастливи 
//числа (А+B==C+D, т.е. нарп., 9898 е щастливо число, защото 
//разделяйки го на две полувини, 9+8=18 и 9+8 пак е = на 18).
//
//for (int i = 1000; i <= 9999; i++)
//{
//    int number = i;

//    int d = number % 10;
//    number = number / 10;
//    int c = number % 10;
//    number = number / 10;
//    int b = number % 10;
//    number = number / 10;
//    int a = number;
//    if (a + b == c + d)
//    {
//        Console.WriteLine(" " + a + b + c + d);
//    }
//}