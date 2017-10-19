using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Exceptions_in_Csharp
{
    static void Main(string[] args)
    {
        //1.Found errors in reading files (not finding file error and other)
        string fileForReading = "testDoc.txt";
        try
        {
            TextReader reader = new StreamReader(fileForReading, Encoding.GetEncoding("UTF-8"));
            string textFromFile = reader.ReadToEnd();
            Console.WriteLine(textFromFile);
            reader.Close();
        }
        catch (FileNotFoundException notFoundEx)
        { //if file not found, just output 
            Console.WriteLine("The file with name: \"{0}\" is NOT found!!!", fileForReading);
        }
        catch (IOException IOex)
        { //information for other Input/Output errors
            Console.WriteLine(IOex.Message + "\n" + IOex.StackTrace);
        }
        //1a.If we want to STOP our program
        catch (Exception ex)
        {
            Console.WriteLine("Unhandled exception! {0}", ex.StackTrace);
            Environment.Exit(0);  //<- this is a way stop program immediately
        }

    }
}
