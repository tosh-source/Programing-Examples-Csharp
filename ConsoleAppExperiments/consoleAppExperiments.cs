using System;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

class consoleAppExperiments
{
    static void Main()
    {
        //var input = new StringReader("test me");
        //Console.SetIn(input);

        List<StringBuilder> listOfSB = new List<StringBuilder>();

        listOfSB.Add(new StringBuilder("Me"));
        listOfSB.Add(new StringBuilder("you"));
        listOfSB.Add(new StringBuilder("Allibaba"));

        listOfSB[1] = listOfSB[1].Append(" and"); //add element to the second StringBuilder
        listOfSB[2] = listOfSB[2].Append("!");    //add element to the third StringBuilder

        Console.WriteLine(string.Join(" ", listOfSB));


        //StringBuilder output = new StringBuilder();
        //output.Append(tmp[1].ToUpper());
        //Console.WriteLine(output);
        string str = "some text here";
        str.IndexOf()
    }
}
