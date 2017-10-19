using System;
using System.Collections.Generic;
using System.Linq;  //This library is needed to use lambda expression.
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_LINQ
{
    class LambdaExpression_LINQ
    {
        static void Main(string[] args)
        {
            //I. Some Lambda expressions on List collection.
            List<int> someInts = new List<int>();
            someInts.Add(34);
            someInts.Add(4);
            someInts.Add(3434);
            someInts.Add(42);
            someInts.Add(3904);
            someInts.Add(1);
            someInts.Add(6);
            someInts.Add(9);

            //Ia. Return numbers that are >= 40, from lambda expression.
            ////////////////////////////////////////////////////
            var returnLambda = someInts.Where(num => num >= 40);
            ////////////////////////////////////////////////////
            Console.WriteLine("Return numbers that are >= 40, from lambda expression..");
            foreach (var item in returnLambda)
            {
                Console.WriteLine(item);
            }

            //Ib. Return how many numbers are >= from 40.
            /////////////////////////////////////////////////////
            var returnLambda2 = someInts.Count(num => num >= 40);
            /////////////////////////////////////////////////////
            Console.WriteLine("\nReturn how many numbers are >= from 40..\n" + returnLambda2);

            //Ic. Find all EVEN numbers in collection.
            ///////////////////////////////////////////////////////////////
            var findAllEvenNumbers = someInts.FindAll(num => num % 2 == 0);
            ///////////////////////////////////////////////////////////////
            Console.WriteLine("\nFind all EVEN numbers in collection..");
            foreach (var item in findAllEvenNumbers)
            {
                Console.WriteLine(item);
            }

            //Id. Remove all numbers less than 10 and show new List collection.
            ////////////////////////////////////
            someInts.RemoveAll(num => num < 10);
            ////////////////////////////////////
            Console.WriteLine("\nRemove all numbers less than 10 and show new List collection..");
            foreach (var item in someInts)
            {
                Console.WriteLine(item);
            }

            //II. Advanced sorting collections.
            List<string> userName = new List<string>();
            userName.Add("Lasi");
            userName.Add("Pesho");
            userName.Add("Sharo");
            userName.Add("Ome");
            userName.Add("Gosho");
            userName.Add("Balkan Superman");
            //////////////////////////////////////////////////////////////
            var advancedSortResult = userName.OrderBy(user => user.Length) //order elements by Length,
                                             .ThenBy(p => p);              //then sort elements by lexicographical order. This is equivalent to .OrderBy(p => p);
            //////////////////////////////////////////////////////////////
            Console.WriteLine("\nSort elements by length and then sort by its lexicographical order..");
            foreach (var item in advancedSortResult)
            {
                Console.WriteLine(item);
            }

            //III. Find elements in string(text)
            string text = "Todor #123";
            //////////////////////////////////////////////////////////////
            var countLetter = text.Count(letter => char.IsLetter(letter));
            var countDigit = text.Count(digit => char.IsDigit(digit));
            //////////////////////////////////////////////////////////////
            Console.WriteLine("\nText: " + text + "\nLetter in text: " + countDigit + "\nDigit in text:" + countLetter);

        }
    }
}
