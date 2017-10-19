using System;
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
