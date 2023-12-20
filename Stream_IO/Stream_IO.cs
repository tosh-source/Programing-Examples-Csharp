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

//USEFUL METHODS

//1. Set/change new date/time to а specific file.
///////////////////////////////////////////////////////////////////////////////
// Directory.SetCreationTime(@"C:Test\Test.txt", DateTime.Now.AddYears(-1)); //
///////////////////////////////////////////////////////////////////////////////

//2. File/directory operations.
///////////////////////
// Directory.Move(); //
///////////////////////
// File.Move();      //
///////////////////////
// File.Delete();    //
///////////////////////
// File.Copy();      //
///////////////////////

//3. Get info about specific file.
///////////////////////////////////////
// new FileInfo(@"C:Test\Test.txt"); //
///////////////////////////////////////



//Using "StringWriter()" and "StreamReader()" with cooperation of StringBuilder() -> https://www.c-sharpcorner.com/UploadFile/mahesh/stringwriter-in-C-Sharp/
//More examples and how to use Console.SetIn()", "Console.SetOut() and  "Console.OpenStandardInput()" method on "InputOutput-Techniques (Console.SetIn())".
