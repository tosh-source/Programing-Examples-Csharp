using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class stringPrintingOption2
{
    static void Main(string[] args)
    {
        //I.Catch multiline text AS one (and print AS multiline text)
        string[] someText = { "This is " ,
                              "Fake Text " ,
                              "Markup Language" };
        ///////////////////////////////////////////////////////////////
        var inputFromConsole = new StringBuilder();
        for (int i = 0; i < someText.Length; i++)
        {
            inputFromConsole.Append(someText[i] + Environment.NewLine);
        }
        ///////////////////////////////////////////////////////////////
        Console.Write(inputFromConsole);

    }
}

