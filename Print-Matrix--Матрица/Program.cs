using System;


class Matrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());  //Задаване на стойност (за редовете на матрицата) от потребителя.
        int counter = 0;                        //Тази стойност изчислява всички направени цикли.

        for (int row = 0; row < n; row++)
        {
            for (int column = 0, pointer = row; column < n; column++)
            {
                pointer++;                      //Тази променлива изписва редовете и колоните на матрицата.
                Console.Write("{0,3}", pointer);
                counter++;                      //Брояча на вътрешния цикъл.
            }
            Console.WriteLine();
            counter++;                          //Брояча на външния цикъл.
        }
        Console.WriteLine("This Matrix is used {0} nested loops", counter);
    }
}


//2-ри вариянт на същата задача
//
//int n = int.Parse(Console.ReadLine());
//int pointer = 0;
//for (int row = 0; row < n; row++)
//{
//    for (int column = 0; column < n; column++)
//    {
//        pointer = column + row;
//        Console.Write("{0,3}", pointer);
//    }
//    Console.WriteLine();
//}


//3-ти и най-кратък вариянт на същата задача
//
//int n = int.Parse(Console.ReadLine());
//for (int row = 0; row < n; row++)
//{
//    for (int column = 0; column < n; column++)
//    {
//        Console.Write("{0,3}", column + row);
//    }
//    Console.WriteLine();
//}
