using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class RegularExpressions_II
{
    static void Main(string[] args)
    {
        //I.Use Regex and match only we have input text with pattern: one Letter, one Digit (e.g. "D4"). No more, no less!! 
        while (true)
        {
            Console.Write("Enter text with pattern: one Letter, one Digit: ");
            /////////////////////////////////////
            var letterPattern = "[a-z]";
            var digitPattern = "[0-9]";
            var endString = @"\z";
            var letterAndDigitPattern = @"";

            letterAndDigitPattern += letterPattern + digitPattern + endString;

            var input = Console.ReadLine();

            var result = Regex.IsMatch(input, letterAndDigitPattern);
            Console.WriteLine("IsMatch: " + result);
            /////////////////////////////////////
        }
    }
}

