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
        //////////////////////////////////////////////////////////////////
        var inputFromConsole = new StringBuilder();
        for (int i = 0; i < someText.Length; i++)
        {
            if (i < someText.Length - 1) //add NewLine to the end of every row(with text), except the last one
            {
                inputFromConsole.Append(someText[i] + Environment.NewLine);
            }
            else
            {
                inputFromConsole.Append(someText[i]);
            }
        }
        //////////////////////////////////////////////////////////////////
        Console.WriteLine(inputFromConsole);


    }
}

