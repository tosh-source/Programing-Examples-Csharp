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
        //I. File writing (stream output)
        string filePath = @"..\..\";
        string fileName = "testDoc.txt";
        //////////////////////////////////////////////////////////////
        using (StreamWriter fileWriter = new StreamWriter(filePath + fileName))  //<- or: "TextWriter writer = new StreamWriter(fileName);" 
        { //"using { }" code block replace .Close() method
            for (int numbs = 1; numbs <= 350; numbs++)
            {
                fileWriter.WriteLine(numbs);
            }
        }
        //////////////////////////////////////////////////////////////
        
        //II. File reading (stream input)
        string fileForReading = @"..\..\testDoc.txt";
        /////////////////////////////////////////////////////
        TextReader reader = new StreamReader(fileForReading);  //<- or: "StreamReader streamReader = new StreamReader(fileForReading);"
        string textFromFile = reader.ReadToEnd(); //.ReadLine() will read ONLY first line of document, .ReadToEnd() read all line of document. 
        Console.WriteLine(textFromFile);
        reader.Close(); //The stream need to be CLOSED! Or just use "using { }" code block, instead this.
        /////////////////////////////////////////////////////

    }
}
