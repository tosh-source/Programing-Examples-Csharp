using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringBuilder_LastIndexOf_byTodor
{
    static void Main(string[] args)
    {
        var text = new StringBuilder("some text");
        int myIndexResult = SBLastIndexOf(text, "m");

        Console.WriteLine($"The result of \"LastIndexOf\" method is: {myIndexResult}");
    }

    private static int SBLastIndexOf(StringBuilder text, string valueToSearch)
    {
        char firstChar = valueToSearch[0];
        int indexToReturn = -1;
        bool continueOrNot = true;
        int alreadyChecked = text.Length;

        //1.Start searching
        for (int startIndex = text.Length - 1; startIndex >= 0; startIndex--)
        {
            if (text[startIndex] == firstChar) //if there is matching
            {
                //2.Compare(char by char) the value with the text from current position.
                for (int valueIndex = 0; valueIndex < valueToSearch.Length; valueIndex++)
                {
                    if (valueIndex == 0) indexToReturn = startIndex - valueIndex;
                    alreadyChecked = startIndex - valueIndex;

                    if ((startIndex - valueIndex) < 0)  //check for "OverFlow Exception" and stop, because no chance for possible matches
                    {
                        indexToReturn = -1;
                        continueOrNot = false;
                        break;
                    }
                    else if (text[startIndex - valueIndex] != valueToSearch[valueIndex])  //if all chars of "valueToSearch" not matched, break and return index -1
                    {
                        indexToReturn = -1;
                        break;
                    }
                }
            }

            if (alreadyChecked < startIndex) startIndex = alreadyChecked;

            if (continueOrNot == false || indexToReturn != -1) break;
        }

        return indexToReturn;
    }
}

