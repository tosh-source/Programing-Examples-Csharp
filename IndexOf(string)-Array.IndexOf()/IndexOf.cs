using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf_string__Array.IndexOf__
{
    class IndexOf
    {
        static void Main(string[] args)
        {
            //I.Search (and return index) in string with ".IndexOf()" method.
            //NOTE: started from 0 position -> till the end.
            /////////////////////////////////
            string someText = "Introduction to C# book";
            int index = someText.IndexOf("C#");  //Винаги се отбелязва мястото/позицията на първия търсен символ (в случая 'С'), за последващите го втори (в случая '#'), трети и т.н. не се изписва нищо!
            Console.WriteLine(index);
            /////////////////////////////////

            //Ia.Search (and return index) in string with ".LastIndexOf()" method.
            //NOTE: started from the end position -> till the beginning.
            //////////////////////////////////////////
            int lastIndex = someText.LastIndexOf("o");  //This will return first founded letter "o" from LAST position of the string.
            //////////////////////////////////////////
            Console.WriteLine(lastIndex);

            //II.Search (and return index) of multiple chars in string with ".IndexOfAny()"
            /////////////////////////////////////////////////////////////////////
            string anotherText = "some text here";
            int resul = anotherText.IndexOf('e', 0);
            int resul2 = anotherText.IndexOfAny(new char[] { 'e', 'o', 't' }, 0); //".IndexOfAny()" намира всички изброени в масива символи и показва индекса на този, който е намерен пръв
            /////////////////////////////////////////////////////////////////////

            //III.Search (and return index) of string in array of strings with "Array.IndexOf()".
        }
    }
}
