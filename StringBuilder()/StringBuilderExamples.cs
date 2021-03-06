﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder__
{
    class StringBuilderExamples
    {
        static void Main(string[] args)
        {
            //I.How to use .SubString() in StringBuilder(). 
            //There is NO special method with name "SubString" here. This function is covered FROM  
            //another method, ".ToString()", which is DIFFERENT from another ".ToString()" implementations.
            StringBuilder sb = new StringBuilder("This is a Test");
            /////////////////////////////////
            string test = sb.ToString(10, 4); //equivalent to -> .Substring(startIndex, length)
            /////////////////////////////////
            Console.WriteLine(test);   // output = Test


            //II. List of StringBuilders (List<StringBuilder>)
            //see project: List(T)-examples II -> III.List of StringBuilders


            //III.Add string elements in different position on "List of StringBuilders"
            List<StringBuilder> listOfSB = new List<StringBuilder>();
            /////////////////////////////////////////////
            listOfSB.Add(new StringBuilder("Me"));
            listOfSB.Add(new StringBuilder("you"));
            listOfSB.Add(new StringBuilder("Allibaba"));
            /////////////////////////////////////////////
            listOfSB[1] = listOfSB[1].Append(" and"); //add element to the second StringBuilder
            listOfSB[2] = listOfSB[2].Append("!");    //add element to the third StringBuilder
            /////////////////////////////////////////////
            Console.WriteLine(string.Join(" ", listOfSB));

            
            //IV.Convert "List of StringBuilders" to -> StringBuilder()
            StringBuilder someSB = new StringBuilder(string.Join(" ", listOfSB));
            Console.WriteLine(someSB);


            //V.Use ToUpper(), ToLower"(), Reverse() and Replace() in StringBuilder
            var sb1 = new StringBuilder("my text HeRe");
            var sb2 = new StringBuilder();
            //////////////////////////////////////////////////////
            sb2.Append(sb1.ToString(3, 4).ToUpper());
            Console.WriteLine(sb2);
            Console.WriteLine(sb1.ToString(8, 4).ToLower());        //print directly
            Console.WriteLine(sb1.ToString().Reverse().ToArray());
            Console.WriteLine(sb1.Replace("text", "", 3, 4));       //<-Replace(string oldValue, string newValue, int startIndex, int count)
            //////////////////////////////////////////////////////


            //See also: //VI.Create Array of "StringBuilders" --> in project: "Arrays(JaggedArrays and MultiDimArrays)" 
        }
    }
}

//  StringBuilder most used options:
//  ////////////////////////////////
//  - StringBuilder example = new StringBuilder(int capacity); – constructor
//  with an initial capacity parameter.Example: StringBuilder(10);
//  It may be used to set the buffer size in advance if we have
//  estimates of the number of iterations and concatenations, which will be
//  performed. This way we can save unnecessary dynamic memory
//  allocations.
//  - .Capacity – returns the buffer size (total number of used and unused
//  positions in the buffer).
//  - .Length – returns length of string saved in the variable(number of used
//  positions in the buffer)
//  - .Indexer[int index] – return the character stored in given position.
//  - .Append(...) – appends string, number or other value after the last
//  character in the buffer.
//  - .Clear(...) – removes all characters from the buffer(deletes it).
//  - .Remove(int startIndex, int length) – removes(deletes) string from
//  the buffer with a given start position and length.
//  Chapter 13. Strings and Text Processing
//  487
//  - .Insert(int offset, string str) – inserts a string in a given start
//  position(offset).
//  - .Replace(string oldValue, string newValue) – replaces all occurren-
//  ces of a given substring with another substring.
//  - .ToString() – returns the StringBuilder object content as a string
//  object. 
//  - ToString() (aka .SubString()) this method that takes two arguments, 
//  exactly as Substring(startIndex, length).
