using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Two_Objects_Technique
{
    class Compare_Technique
    {
        static void Main(string[] args)
        {
            //1.Сравение на еднаквост на два стринга, като се пренебрегва значението на ГЛАВНИ/малки букви. Т.е. сравняваме самото съдържание на стринговете, а това дали единия стринг например, започва с главна буква или не, не ни интересува. Това става посредством добавяне на параметъра "StringComparison.CurrentCultureIgnoreCase" в метода "Equals()".
            string hello1 = "hello WORLD";
            string hello2 = "hELLo world";
            ////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine(hello1.Equals(hello2, StringComparison.CurrentCultureIgnoreCase));  //Equals --> True (с пренебрегване на ГЛАВНИ/малки букви)
            Console.WriteLine(hello1.Equals(hello2));                                             //Eguals --> False (без пренебрегване, стринговете реално са различни)
            ////////////////////////////////////////////////////////////////////////////////////
            //ВАЖНО! - методът ".Equals()", сравнява стринговите литерали буква по буква, според "Unicode" таблицата, и е ПО-точния вариянт(виж: ) за сравнение на стрингове.

            //1a.Всъщност методът ".Equals()", сравнява два обекта (objects), без значение дали са string, int и т.н.
            int num1 = 1;
            int num2 = 23;
            Console.WriteLine("\n" + num1.Equals(num2) + "\n");

            //2. Сравняване на стрингове с метода ".CompareTo()".
            string score = "sCore";
            string scary = "scary";
            //////////////////////////////////////////
            Console.WriteLine(score.CompareTo(scary)); //output: 1 /Вория стринг(scary) е лексикографски ПРЕДИ първия(score). Т.е., ПЪРВИЯ обект е ПО-ГОЛЯМ!
            Console.WriteLine(scary.CompareTo(score)); //output:-1 (първия стринг е лексикографски ПРЕДИ втория) Т.е., ВТОРИЯ обект е ПО-ГОЛЯМ!
            Console.WriteLine(scary.CompareTo(scary)); //output: 0 (равни)
            //////////////////////////////////////////
            //ВАЖНО! - Ако исползвахме методът ".Equals()", резултата щеше да е ОБРАТЕН. Защото според "Unicode"таблицата, символа 'C' е преди 'c'!!! Но тук, при метода ".CompareTo()" малките букви са ПРЕДИ големите.

            //2a. Сравняване на стрингове с метода "string.Compare(string strA, string strB, bool ignoreCase)". 
            //
            //Важът СЪЩИТЕ правила както при ".CompareTo()", просто и тук също може да излираме 
            //значението на ГЛАВНИ/малки букви (в последната команда "bool ignoreCase" - "true" или "false")!
            string alpha = "alpha";
            string score1 = "sCorE";
            string score2 = "score";
            Console.WriteLine();
            ////////////////////////////////////////////////////////
            Console.WriteLine(string.Compare(alpha, score1, false));  //output: -1 (първия стринг е лексикографски ПРЕДИ втория)
            Console.WriteLine(string.Compare(score1, score2, false)); //output:  1
            Console.WriteLine(string.Compare(score1, score2, true));  //output:  0 (тук "bool ignoreCase" е включен: -> true, и се пренебрегва значението на ГОЛЕМИ/малки букви)
            Console.WriteLine(string.Compare(score1, score2, StringComparison.CurrentCultureIgnoreCase));
            ////////////////////////////////////////////////////////
            Console.WriteLine();

            //3.Побитово пресмятане на по-голямата от две стойности.
            int a = 1990;
            int b = 2011;
            int m = a - ((a - b) & ((a - b) >> 31)); //Изразът ((a - b) >> 31)) всъщност връща като краен резултат само -1 или 0 (при а < b = -1 , докато a > b = 0).
            Console.WriteLine(m);

            //4.Compare objects (by reference)  //Сравенение на обекти (по референция)
            //
            //Чрез метода "object.ReferenceEquals(objA, objB)" два обекта се сравняват по тяхната
            //рефенция. Т.е., дали сочат към едно и също място в паметта. 
            
            int[] arr = { 346, 6455, 543, 511 };
            int[] arr2 = arr;
            List<int> firstList = new List<int>(arr);
            List<int> secondList = new List<int>(firstList);
            /////////////////////////////////////////////////////////////////
            bool isEqualArray = object.ReferenceEquals(arr, arr2);
            bool isEqualList = object.ReferenceEquals(firstList, secondList);
            /////////////////////////////////////////////////////////////////
            Console.WriteLine($"\nIs equal this Arrays: {isEqualArray}"
                            + $"\nIs equal this Lists<int>: {isEqualList}");

        }
    }
}
