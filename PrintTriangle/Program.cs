using System;


class PrintTriangle
{
    static void Main()
    {
        Console.Write("Plese enter number of triangle rows: ");
        int userRowValue = int.Parse(Console.ReadLine());

        for (int row = 1; row <= userRowValue; row++)     //"for" цикъл за редовете (rows) на триъгълника
        {
            for (int columns = 1; columns <= row; columns++)        //"for" цикъл за колоните (columns) на триъгълника
            {
                Console.Write("{0,2} ", columns);        // При форматиращия низ поставяме индекс "2" след обекта (в случая "0" показващ стойностите на "columns") който искаме да се изведем. Така всяка стойност на "columns" получена от цикъла се показва с две позиции на ляво и триъгълника изглежда по-коректно при отпечатване на двуцифрени числа.
            }
            Console.WriteLine();
        }
    }
}

//Тук показвам два залепени огледални триъгълника (увеличаващ и намалящ), които образуват един по-голям триъгълник.
//
//int n = int.Parse(Console.ReadLine());
//
//for (int row = 1; row <= n; row++)
//{
//    for (int column = 1; column <= row; column++)
//    {
//        Console.Write(Convert.ToString(column).PadLeft(2) + " ");   //Тук отпечатването по конзолата съм го представил, нарочно с "PadLeft". Просто за пример. Иначе е еквивалентно с примера по-горе ("{0,2} ", columns).
//    }
//    Console.WriteLine();
//}
//
//for (int rowR = n; rowR >= 0; rowR--)
//{
//    for (int columnsR = 1; columnsR < rowR; columnsR++)
//    {
//        Console.Write("{0,2} ", columnsR);                         //В конкретния случай, форматиращия низ, визуално се представя по същия начин както PadLeft (показан в горния триъгълник).
//    }
//    Console.WriteLine();
//}
