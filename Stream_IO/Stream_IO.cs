using System;
using System.Collections.Generic;
using System.IO; //this library is needed for using stream operations
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Stream_IO
{
    static void Main(string[] args)
    {
        string filePath = @"..\..\";
        string fileName = "testDoc.txt";

        //I. File writing (stream output)
        //////////////////////////////////////////////////////////////
        using (StreamWriter fileWriter = new StreamWriter(filePath + fileName))  //<- or: "TextWriter writer = new StreamWriter(filePath + fileName);" 
        { //"using { }" code block replace .Close() method
            for (int numbs = 1; numbs <= 350; numbs++)
            {
                fileWriter.WriteLine(numbs);
            }
        }
        //////////////////////////////////////////////////////////////

        //II. File reading (stream input)
        /////////////////////////////////////////////////////
        TextReader reader = new StreamReader(filePath + fileName);  //<- or: "StreamReader streamReader = new StreamReader(filePath + fileName);"
        string textFromFile = reader.ReadToEnd(); //.ReadLine() will read ONLY first line of document, .ReadToEnd() read all line of document. 
        Console.WriteLine(textFromFile);
        reader.Close(); //The stream need to be CLOSED! Or just use "using { }" code block, instead this.
        /////////////////////////////////////////////////////

    }
}
