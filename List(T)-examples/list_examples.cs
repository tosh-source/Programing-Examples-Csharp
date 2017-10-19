using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class list_examples
{
    static void Main(string[] args)
    {
        //I.СЪздаване на List.
        List<int> someList = new List<int>();
        //Добавяне на елементи
        someList.Add(55);
        someList.Add(234);
        someList.Add(111);
        someList.Add(53476);
        someList.Add(111);
        //същите могат да бъдат добавени и по алтернатиен начин:
        //someList.AddRange(new[] { 55, 234, 111, 53476, 111 });
        //като стойностите могат да бъдат подадени горе, директно след декларирането "new List<int>(new[] { 55, 234, 111, 53476, 111 });"

        //Ia.Принтиране посредством String.Join.
        Console.WriteLine(string.Join(", ", someList));  //Тази команда обхoжда масива, представяйки го като 'string', на един единствен ред, разделяйки масива с друг текстов стринг(в случая със запетая).

        //Ia-1.Вмъкване(Insert) на елемент по индекс и принтиране със String.Join. 
        someList.Insert(4, 88); //В този случай, на индекс-4 принадлежи "int->111". След вмъквамето той ще стане индекс-5 (a на негово място ще застане "int->88").
        Console.WriteLine(string.Join(", ", someList));
        //Ако List беше празен и искам да присвоявам стойности по индекс(не с командата ".Add()"), 
        //горния пример щеше да има следния вид(.Insert(n-1, value)), почвам от: 
        //someList.Insert(0, 55) , someList.Insert(1, 234) .... до: someList.Insert(4, 111)

        //Ia-2.Премахване(Remove) на елемени от List и отпечатване със String.Join.
        //
        //Ia-2.a1.премахване на елемент (от зададения в скобите, в случая integer)
        someList.Remove(111); //премахва първия срещнат елемент
        Console.WriteLine(string.Join(", ", someList));

        //Ia-2.a2. премахване на ВСИЧКИ елементи от масив (List).
        //-премахване с цикъл
        List<int> theList = new List<int> { 1, 1, 2, 3, 1, 4, 5, 6, 7, 8, 9, 1, 11, 2 };
        Console.WriteLine(new string('-', 34) + "\n" + string.Join(", ", theList));
        ///////////////////////////////////////
        for (int i = 0; i < theList.Count; i++)  
        {
            theList.Remove(1);   //този пример премахва ВСИЧКИ единици от редицата
        }
        ///////////////////////////////////////

        //-премахване с ".RemoveAll()" със Lambda изрази (горния пример на един ред)
        /////////////////////////////////
        //theList.RemoveAll(x => x == 1);  //използва "using System.Linq;"
        ///////////////////////////////// 
        Console.WriteLine(string.Join(", ", theList) + "\n" + new string('-', 34));


        //Ia-2.b. премахване на елементи по индекс
        someList.RemoveAt(2); 
        Console.WriteLine(string.Join(", ", someList));

        //Ia-2.c. Премахване(изчистване) на ВСИЧКИ елемнти в "List<>"
        //////////////////////////////////////////
        //someList.RemoveRange(0, someList.Count);  //Премахва всички стойности по индекс в диапазона от "0", до края(дължината) на List (someList.Count) 
        //////////////////////////////////////////
        //Друга опция е с командата ".Clear()"
        ////////////////////
        //someList.Clear();
        ////////////////////

        //Ib.Принтиране с цикъл
        for (int i = 0; i < someList.Count; i++)
        {
            Console.Write(someList[i] + " ");
        }
        Console.Write("| ");
        for (int i = someList.Count - 1; i >= 0; i--)  //Принтиране в обратен ред
        {
            Console.Write(someList[i] + " ");
        }
        Console.WriteLine();

        //II.Представяне на броя индекси и РЕАЛНО заеманите блокове памет (Capacity)
        for (int i = 0; i < someList.Count; i++)
        {
            Console.WriteLine("Index: {0} | Capacity: {1}", someList.Count, someList.Capacity);
        }
        //ВАЖНО-Както се вижда горе нашия List<T> има големина от 4 индекса, НО капацитета ("Capacity") му 
        //се е увиличил до 8 индекса (след попълване и на 4-тия индекс). Затова може да използваме зачистващата
        //команда ".TrimExcess()", която премахва неизползваните индекси(елементи) от паметта!!!
        someList.TrimExcess();
        Console.WriteLine("\nAfter \".TrimExcess()\" finction:");
        foreach (var item in someList)
        {
            Console.WriteLine("Index: {0} | Capacity: {1}", someList.Count, someList.Capacity);
        }

        //III.Разширен пример за използване на List<string> с данни във вид на шаблон (пр:"65" + "#" + (34 + 1006)-->"65#1040"), 
        //с последващото им сортиране и присвояване, на стойностите ПРЕДИ и СЛЕД "хаш"(#) символа.
        Console.WriteLine(new string('-', 34));
        //////////////////////////////////////////////////////////
        List<string> abc = new List<string>();
        abc.Add("65" + "#" + (34 + 1006).ToString());
        abc.Add("2" + "#" + (3 + 400).ToString());
        abc.Add("5" + "#" + (34 + 1000).ToString());
        abc.Sort(); //sort the array(List)
        List<string> parseHere = new List<string>();
        int signHashPosition = 0;
        //parse from 0 to "#" position
        for (int i = 0; i < abc.Count; i++)
        {
            signHashPosition = abc[i].IndexOf("#");
            parseHere.Add(abc[i].Substring(0, signHashPosition));
        }
        //parse from "#" position to the end of array(List)
        for (int i = 0; i < abc.Count; i++)
        {
            signHashPosition = abc[i].IndexOf("#");
            parseHere.Add(abc[i].Substring(signHashPosition + 1));
        }
        //////////////////////////////////////////////////////////
        Console.WriteLine(string.Join(", ", parseHere));
        Console.WriteLine(new string('-', 34));

    }
}