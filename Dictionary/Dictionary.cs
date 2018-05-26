using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            //I.Create Dictionaries and get values of his keys with "TryGetValue" method.
            Dictionary<string, string> myDictionary = new Dictionary<string, string>(); //better to use "var"
            myDictionary.Add("txt", "notepad.exe");
            myDictionary.Add("rtf", "wordpad.exe");
            myDictionary.Add("docx", "winword.exe");

            string simpleText = "txt";
            string wordDocutemnt = "docx";

            string programToOpen = myDictionary[simpleText]; //better to use "var"
            Console.WriteLine(programToOpen);

            if (myDictionary.TryGetValue(wordDocutemnt, out programToOpen)) //Note that if the dictionary doesn't have the key that we looking for, the code will thrown an exception.
            {
                Console.WriteLine(programToOpen);
            }
            else
            {
                Console.WriteLine("Not found!");
            }

            //II.Try to add key value, that already exist.
            //Note: Dictionaries can NOT add key/value that already exist, and will throws an exception!
            string richTextFormat = "rtf";
            string associatedProgram = "wordpad.exe";

            try
            {
                myDictionary.Add(richTextFormat, associatedProgram);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nThe program:{associatedProgram} already/key exist in the Dictionary!");
                Console.WriteLine(ex.Message + "\n");
            }
            
        }
    }
}

//URL: https://stackoverflow.com/questions/12169443/get-dictionary-value-by-key?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
//URL: https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.110).aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-1
