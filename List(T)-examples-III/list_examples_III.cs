using System;
using System.Collections.Generic;
using System.Linq;  //LINQ is needed to use ToList() and ToArray() methods
using System.Text;
using System.Threading.Tasks;


class list_examples_III
{
    static void Main(string[] args)
    {
        //1.Using LINQ methods, ToList() and ToArray().
        //NOTE: most easy way to convert List > Array > List. 

        //1a. Array > List
        List<int> listOfInts = new[] { 1, 2, 3, 4, 5, 6 }.ToList();

        //List > Array
        decimal[] arrayOfDeci = new List<decimal> { 12.5m, 23.8m, 98m, 1235m }.ToArray();

        //2.Using LINQ ForEach (method).
        var list = new List<int>(Enumerable.Range(0, 10));
        list.ForEach(Console.WriteLine);

        List<int> integers = new List<int> { 100, 200, 300, 400, 500 };
        List<string> strings = new List<string> { "aa", "bb", "cc", "dd" };
        integers.ForEach(Console.WriteLine);
        strings.ForEach(Console.WriteLine);
        //NOTE: Console.Write not work correctly for now!

        //2a.ForEach + lambda expression
        list.ForEach(item => Console.Write(item));
    }
}

