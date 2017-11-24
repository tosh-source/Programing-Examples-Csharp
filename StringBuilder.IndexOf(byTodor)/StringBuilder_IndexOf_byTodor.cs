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

    private static int SBIndexOf(StringBuilder text, string valueToSearch)
    {
        char firstChar = valueToSearch[0];
        int indexToReturn = -1;
        bool continueOrNot = true;
        int alreadyChecked = 0;

        //1.Start searching
        for (int startIndex = 0; startIndex < text.Length; startIndex++)
        {
            if (text[startIndex] == firstChar) //if there is matching
            {
                //2.Compare(char by char) the value with the text from current position.
                for (int valueInddex = 0; valueInddex < valueToSearch.Length; valueInddex++)
                {
                    if (valueInddex == 0) indexToReturn = startIndex + valueInddex;
                    alreadyChecked = startIndex + valueInddex;

                    if ((startIndex + valueInddex) > text.Length - 1)  //check for "OverFlowExeption"
                    {
                        indexToReturn = -1;
                        continueOrNot = false;
                        break;
                    }
                    else if (text[startIndex + valueInddex] != valueToSearch[valueInddex])  //if all chars of "valueToSearch" not matched, break and return index -1
                    {
                        indexToReturn = -1;
                        break;
                    }
                }
            }

            if (alreadyChecked > startIndex) startIndex = alreadyChecked;

            if (continueOrNot == false || indexToReturn != -1) break;
        }

        return indexToReturn;
    }
}

