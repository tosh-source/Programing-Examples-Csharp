using System;
using System.Linq;


class printArrays
{
    static void Main()
    {
        //I.Клониране(клониране) на стойност от един масив на друг. ВАЖНО - това е различно от стандартното присвояване на стойности, тук се заделят отделни указатели в паметта и промяната в единия НЕ води до промяна на втоеия масив.
        int[] firstArr = { 1, 2, 3, 4 };
        int[] secondArr = (int[])firstArr.Clone();

        //Ia.Присвояване на стойност от един масив на друг. 
        //ВАЖНО - това е обикновено присвояване на стойност(за разлика от ".Clone()"), тук при някой ВИДОВЕ масиви (напр. при назъбените масиви (Jagged Arrays)) и ТИПОВЕ данни (класовете), ще имат ОБЩА памет.
        //ИНТЕРЕСНО - обикновените едномерни масиви се копират с РАЗЛИЧНИ референции и имат РАЗЛИЧНА памет!
        int[] firstArrA = { 6, 7, 8, 9, 67, 3, 23 };
        int[] secondArrA = new int[4];
        Array.Copy(firstArrA, secondArrA, 4); //Тук числото "4-ри", всъщност е индикатор за дължината на копирващите се ИНДЕКСИ от първия към втория масив. Т.е. ако посичим "3", ще се копират само първите 3-ри(от позиция: 0-вия -> до 2-рия) индекса от първия във втория масив.

        //Ib.Присвояване на стойност от един масив на друг
        //(обикновен метод, двата масива са с ОБЩА памет).
        int[] anotherArray = firstArr;

        //Ic.СЪздаване на масив с командата/метода (Enumerable.Range())
        int[] numbsInRange = Enumerable.Range(1, 12).ToArray();
        //Тази команда е полезна само в случаите когато създаваме масив от ПОРЕДИЦА от числа!

        //II.Min, max, sum. This method, of array printing use "System.Linq" References.
        int[] arrayOfnNumbers = { 1, 2, 3, 4, 5, 6 };  //Array of N numbers  

        int minN = arrayOfnNumbers.Min();              //minimal value of N numbers
        int maxN = arrayOfnNumbers.Max();              //maximal value of N numbers
        int sumN = arrayOfnNumbers.Sum();              //the sum of N numbers
        double avrN = arrayOfnNumbers.Average();       //averave value of N numbers

        Console.Write("The numbers of N sequences is: ");
        foreach (var theNumbs in arrayOfnNumbers)
        {
            Console.Write("{0} ", theNumbs);
        }

        Console.WriteLine("\n----------------------------------");
        Console.WriteLine("Minimal value of N numbers is: {0}", minN);
        Console.WriteLine("Maximal value of N numbers is: {0}", maxN);
        Console.WriteLine("The sum of N numbers is:       {0}", sumN);
        Console.WriteLine("Average value of N numbers is: {0}", avrN);
        Console.WriteLine("----------------------------------");

        //II.Чети масив на един ред посредсвом ".Select(int.Parse)" и ".Split()" и го разпечатай 
        Console.Write("Enter integer array (eg.: 4 5 6 7) \nin single line separated by space: ");
        /////////////////////////////////////////////////////////////////////////////
        int[] someIntArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  //Тази сложна структура от команди казва: Чети елементи от конзолата като стринг и махни "интервалите" (посредством "String.Split()"), като за всеки един от тези елементи, посредством метода "Select", приложи "int.Parse" и накрая ги обърни в масив (".ToArray()") от тип "int".
        Console.WriteLine(string.Join(", ", someIntArr));  //Тази команда обхoжда масива, представяйки го като 'string', на един единствен ред, разделяйки масива с друг текстов стринг(в случая със запетая).
        /////////////////////////////////////////////////////////////////////////////

        //III.Премахване на елемент от масив. 
        //ВАЖНО: този пример показва как се премахват елементи по вид (в случая "int"), НЕ по индекси от масива! Освен това ще бъдат премахнати всички налични съвпадения (с случая всички 4-ки от тип "int").
        Console.WriteLine(new string('-', 34) + "\n" + "How to remove elements:");
        ////////////////////////////////////////////////////
        int[] someArr = { 1, 2, 3, 4, 5, 6, 0, 4, 43, 11 };
        Console.WriteLine(string.Join(", ", someArr));
        someArr = someArr.Except(new int[] { 4 }).ToArray();
        Console.WriteLine(string.Join(", ", someArr));
        ////////////////////////////////////////////////////

        //IIIa.Премахване на елемент от масив, по ИНДЕКСИ.
        int[] anotherArr = { 22, 33, 44, 55, 66, 77, 734875 };
        /////////////////////////////////////////////////
        Array.Clear(anotherArr, 2, 4); //Изчистване на индекси от позиция: 2 с ДЪЛЖИНА 4-ри индекса (т.е. до 6-тия индекс(на пзиция 5)). 
        Console.WriteLine(string.Join(", ", anotherArr));
        Array.Clear(anotherArr, 0, anotherArr.Length); //Изчистване на целия масив
        Console.WriteLine(string.Join(", ", anotherArr));
        /////////////////////////////////////////////////
        //За допълнителни примери: https://msdn.microsoft.com/en-us/library/system.array.clear(v=vs.110).aspx

        //IIIb.Премахване(изтриване) на елемент(и) от многомерен масив (Multidimensional Arrays)
        int[,] someMultiDimtArray = {
            {42,4234,26 },
            {65,76,78 }
        };
        Array.Clear(someMultiDimtArray, 0, 4); //Тук изтриваме първия ред и част от втория. 3 елемента от първи ред + 1 елемент от втория.
        Array.Clear(someMultiDimtArray, 0, 6); //В този случай "6" е СБОРА от елементите в двете измерения.
                                               //6 => "someMultiDimtArray.Length"

        //IV.Сортиране на масив
        Console.WriteLine("\n" + new string('*', 34) + "\nSort array:");
        ////////////////////////////////////////////
        int[] thirdArr = { 4, 2, 6, 3, 22, 1, -9, 0, 1 };
        Array.Sort(thirdArr);
        Console.WriteLine(string.Join(", ", thirdArr));
        ////////////////////////////////////////////
        Console.WriteLine(new string('*', 34));

        //V.String to char array
        /////////////////////////////////////////////////////////////////
        char[] someChar = "conver string to char as array".ToCharArray();
        /////////////////////////////////////////////////////////////////
        Console.WriteLine(someChar[2] + " " + someChar[7]);

        //VI. Binary search in array
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        int searchObject = 5;
        int searchResult = Array.BinarySearch(array, searchObject);
        ///////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Index N: {0}", searchResult);
        ///////////////////////////////////////////////////////////////////////////

        //VIa. Boolean search in array
        /////////////////////////////////////
        Console.WriteLine(array.Contains(5)); //връща "true" или "false", в зависимост от това дали в посочения масив се съдържа съответния елемент
        /////////////////////////////////////

        //Print Multi-Dimensional Array with "foreach"
        int[,] multiDimArr = {
                {332, 3434, 43546, 678 },
                {563,64,37,87658 }
                };

        foreach (var item in multiDimArr)
        {
            Console.WriteLine(item);
        }

        //Print Jagged Arrays with "foreach"
        int[][] jagArr = {
               new int[] {2432,2454,3424,45643,6 },
               new int[] {23,324,355, 65 },
               new int[] {345,45 }
        };
        foreach (var item in jagArr)
        {
            Console.WriteLine(string.Join(", ", item));
        }
    }
}


//Вкарване на стойност на масив и последващото му представяне в конзолата с два различни типа цикли, както и без цикъл с една единствена команда
//
////1.Enter the Lenght of Array (Тук се вкарва дължината (Lenght) на масива)
//int n = int.Parse(Console.ReadLine()); 
//int[] arr = new int[n];
//
////2.Now enter the Arrays (В този цикъл се вкарват самите стойности на масива)
//for (int i = 0; i < arr.Length; i++)  //Тука 'arr.Length' може да бъде заменето с 'n', което е дължината на масива вкарана от потребителя. Без значение е, работи еднакво!
//{
//    Console.Write("Array {0}: ", i + 1);
//    arr[i] = int.Parse(Console.ReadLine());
//}
//
////3.Present with foreach loop
//Console.WriteLine("\nPrint with \'foreach-loop\':");
//foreach (var theNumbs in arr)
//{
//    Console.WriteLine(theNumbs);
//}
////3a.Present with for loop
//Console.WriteLine("\nPrint with \'for-loop\':");
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}
////4.Present without 'loops'
//Console.WriteLine("\nPrint with \'string.Join()\' commands:");
//Console.WriteLine(string.Join(", ", arr));  //Тази команда обхoжда масива, представяйки го като 'string', на един единствен ред, разделяйки масива с друг текстов стринг(в случая със запетая).
