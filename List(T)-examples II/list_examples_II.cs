using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class list_examples_II
{
    static void Main(string[] args)
    {
        //I.Списък от Списъци (аналогия на "Jagged Arrays")  //погледни видео: "Масиви - 5 фев.2015 - Ники (1:27:55 сек)"//
        List<List<int>> listOfListOfIntegers = new List<List<int>>();
        listOfListOfIntegers.Add(new List<int>());   //създавае на първи СПИСЪК В "списъка от списъци" (иначе ще бъде празен)
        listOfListOfIntegers[0].Add(342);   //подаване на някакв стойност в "първия СПИСЪК" (намираща се под индекс номер "0")
        Console.WriteLine(listOfListOfIntegers[0][0]);
        listOfListOfIntegers[0][0] = 23;   //промяна на същата тази стойност ("342")
        Console.WriteLine(listOfListOfIntegers[0][0]);

        //II. Is List HAVE a value?  //Проверка дали List съдържа НЯКАКВА стойност.
        List<int> someList = new List<int>();
        someList.Add(346); //1. parse integer value: 346
        ///////////////////////////////////////////
        for (int i = 0; i < 2; i++)
        {
            if ((someList.Count - 1) >= 0)  //the condition "someList.Count-1" just return "-1", if the "List" is empty. (защото брояча "Count", връща, че няма нито един елент, а 0 - 1 = -1)
            {
                Console.WriteLine("HAS a value");
            }
            else
            {
                Console.WriteLine("has NO value");
            }
            someList.Clear(); //2. Clear integer value: 346
        }
        ///////////////////////////////////////////
        
        //IIa. Проверка дали List съдържа ОПРЕДЕЛЕНА стойност, посредством функцията ".Contains()".
        someList.Add(8776);
        ////////////////////////////
        if (someList.Contains(8776))
        {
            Console.WriteLine("on first position List HAS a value");
        }
        ////////////////////////////

        //III. List of StringBuilders (List<StringBuilder>)
        List<StringBuilder> listOfSB = new List<StringBuilder>();
        /////////////////////////////////////////
        listOfSB.Add(new StringBuilder("Me"));
        listOfSB.Add(new StringBuilder("you"));
        listOfSB.Add(new StringBuilder("Allibaba"));

        listOfSB[1] = listOfSB[1].Append(" and"); //add element to the second StringBuilder
        listOfSB[2] = listOfSB[2].Append("!");    //add element to the third StringBuilder
        /////////////////////////////////////////
        Console.WriteLine(string.Join(" ", listOfSB));

    }
}

