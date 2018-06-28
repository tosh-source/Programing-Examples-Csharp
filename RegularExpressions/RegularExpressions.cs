using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; //turn this library ON to use "Regular Expressions" (Regex)
using System.Threading.Tasks;

class RegularExpressions
{
    static void Main(string[] args)
    {
        //I.MASK phone numbers with asterisks
        string peresonalInfo = "John's number: 0898880022\nSnoop Dog can be " + "found at 0888445566 \nSuperman's mobile number: 0887654321";
        string censuredInfo = Regex.Replace(peresonalInfo, "(08)[0-9]{8}", "$1********");
        Console.WriteLine(censuredInfo);

        //II.Is FIND word in given text string?
        string someText = "some text here";
        string pattern = "here";
        bool isHere = Regex.IsMatch(someText, string.Format(@"\b{0}\b", pattern));  //"\b" is match word boundary. //"\b" е ограниетонито(начало и край) на думата
        Console.WriteLine(isHere);

        //III.Split string (and KEEP delimiter) with Regular Expressions techniques. //Разделяне на стрингове (и задържане на разделителите) посредством Регулярни Изрази.
        //==========================================================================
        //if split chars are: '.' and '!' the expression(which KEEP delimiter), look like this:
        string text = "Software developers like to solve problems. If they are no problems handily available, they will create their own problems!";
        /////////////////////////////////////////////////////
        string[] sentence = Regex.Split(text, @"(?<=[.!])");
        /////////////////////////////////////////////////////
        //the Regex.Split pattern structure is: (?<=[PATTERN])
        //If you looking for delimiter: '.' , ',' and ';' the regular expression will be:
        //////////////////////////////////
        //Regex.Split(text, @"(?<=[.,;])")
        //////////////////////////////////

        //IV.Return FIRST founded number as index
        //see more examples -> https://stackoverflow.com/questions/5591747/can-i-use-regex-to-find-the-index-of-x?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
        string str = "my 2nd text string";
        int result = -1;
        ///////////////////////////////////////
        result = Regex.Match(str, @"\d").Index;
        Console.WriteLine("\nReturn first founded number as index:\n" + result);
        ///////////////////////////////////////
        result = Regex.Match(str, @"[0-9]").Index;
        Console.WriteLine(result);
        ///////////////////////////////////////

        //V.Find entire number
        str = "my 235345 text strings";
        string seccondResult;
        ////////////////////////////////
        seccondResult = Regex.Match(str, @"\d+").ToString();
        Console.WriteLine($"\nFind entire number: {seccondResult}");

        //VI.Find and return number with three digits in it (no more, no less)
        string threeDigits = Regex.Match(str, @"\d..").ToString();
        Console.WriteLine($"\nThree digits: {threeDigits}");

        //VII.Get length of digit
        int numbLength = Regex.Match(str, @"\d+").Length;
        Console.WriteLine($"\nNumber length: {numbLength}");

    }
}

//Regex.Match method, return type: System.Text.RegularExpressions.Match
//more info: https://msdn.microsoft.com/en-us/library/twcw2f1c(v=vs.110).aspx