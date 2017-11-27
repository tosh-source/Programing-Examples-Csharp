using System;
using System.Text;

class StringBuilder_IndexOf_byTodor
{
    static void Main(string[] args)
    {
        var text = new StringBuilder("some text");
        int myIndexResult = SBIndexOf(text, "m");

        Console.WriteLine($"The result is: {myIndexResult}");
    }

    private static int SBIndexOf(StringBuilder text, string valueToSearch, int? startIndex = null)
    {
        char firstChar = valueToSearch[0];  //take the first element
        int indexToReturn = -1;
        bool continueOrNot = true;
        int currentCheckedIndex = 0;

        //check default value of startIndex
        if (startIndex == null) startIndex = 0; 

        //Calculations
        //1.Start searching
        for (int textIndex = (int)startIndex; textIndex < text.Length; textIndex++)
        {
            if (text[textIndex] == firstChar)  //if there is matching
            {
                //2.Compare(char by char) the value with the text from current position.
                for (int valueIndex = 0; valueIndex < valueToSearch.Length; valueIndex++)
                {
                    if (valueIndex == 0) indexToReturn = textIndex + valueIndex;
                    currentCheckedIndex = textIndex + valueIndex;

                    if (currentCheckedIndex > text.Length - 1)  //check for "OverFlow Exception" and stop, because no chance for possible matches
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

            if (currentCheckedIndex > textIndex) textIndex = currentCheckedIndex;

            if (continueOrNot == false || indexToReturn != -1) break;
        }

        return indexToReturn;
    }
}

