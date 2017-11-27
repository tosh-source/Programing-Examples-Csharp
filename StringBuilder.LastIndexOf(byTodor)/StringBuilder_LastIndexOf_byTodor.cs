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
        int myIndexResult = SBLastIndexOf(text, "me");

        Console.WriteLine($"The result of \"LastIndexOf\" method is: {myIndexResult}");
    }

    private static int SBLastIndexOf(StringBuilder text, string valueToSearch, int? startIndex = null)
    {
        char firstChar = valueToSearch[valueToSearch.Length - 1]; //take the (last)first element
        int indexToReturn = -1;
        bool continueOrNot = true;
        int currentCheckedIndex = text.Length-1;

        //check default value of startIndex
        if (startIndex == null) startIndex = text.Length - 1;

        //Calculations
        //1.Start searching
        for (int textIndex = (int)startIndex; textIndex >= 0; textIndex--)
        {
            if (text[textIndex] == firstChar)  //if there is matching
            {
                //2.Compare(char by char) the value with the text from current position.
                for (int valueIndex = valueToSearch.Length - 1; valueIndex >= 0; valueIndex--)
                {
                    if (valueIndex == valueToSearch.Length - 1)
                    {
                        indexToReturn = textIndex - valueIndex;
                    }
                    currentCheckedIndex = textIndex - (valueToSearch.Length - 1 - valueIndex);

                    if ((textIndex - valueIndex) < 0)  //check for "OverFlow Exception" and stop, because no chance for possible matches
                    {
                        indexToReturn = -1;
                        continueOrNot = false;
                        break;
                    }
                    else if (text[currentCheckedIndex] != valueToSearch[valueIndex])  //if all chars of "valueToSearch" not matched, break and return index -1
                    {
                        indexToReturn = -1;
                        break;
                    }
                }
            }

            if (currentCheckedIndex < textIndex) textIndex = currentCheckedIndex;

            if (continueOrNot == false || indexToReturn != -1) break;
        }

        return indexToReturn;
    }
}

