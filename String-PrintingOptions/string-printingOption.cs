using System;
using System.Linq; //This library will give access to ".First()"
using System.Text;

class String_PrintingOptions
{
    static void Main()
    {
        //Important!!! Easy to convert "String to Char" and "Char to String"
        /////////////////////////////////
        //Convert.ToString( character );
        //Convert.ToChar( string );
        /////////////////////////////////

        //Convert and reverse: String => Char[] => String
        string input = "Some text here";
        char[] temp = input.ToCharArray();
        Array.Reverse(temp);
        string reverse = new string(temp);
        Console.WriteLine(reverse);

        //Reverse string (simple way)
        string simpleStrRev = new string(input.Reverse().ToArray());
        Console.WriteLine(simpleStrRev);

        //Repeated Strings /Повтарящи се Символи
        //Синтаксиса, по-долу, отпечатва 15 звездички '*'. Тя може да бъде заменена с всичко др.,което преценим, намиращо се в уникодската таблица.
        string text = new string('*', 15);
        Console.WriteLine(text);
        //по-кратък вариянт:: Console.WriteLine(new string('-', 30));

        //Програма за сравение на еднаквост на два стринга, като се пренебрегва значението на ГЛАВНИ/малки букви. Т.е. сравняваме самото съдържание на стринговете, а това дали единия стринг например, започва с главна буква или не, не ни интересува. Това става посредством добавяне на параметъра "StringComparison.CurrentCultureIgnoreCase" в метода "Equals()".
        string hello1 = "hello WORLD";
        string hello2 = "hELLo world";
        Console.WriteLine(hello1.Equals(hello2, StringComparison.CurrentCultureIgnoreCase));  //Equals --> True (с пренебрегване на ГЛАВНИ/малки букви)
        Console.WriteLine(hello1.Equals(hello2));                                             //Eguals --> False (без пренебрегване, стринговете реално са различни)

        //Сравнение по дължина на стринга 
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        Console.WriteLine(first.CompareTo(second)); //това връща като резултат 0 (равни), 1 (ПЪРВИЯТ е по-дълъг), -1 (ВТОРИЯТ е по-дълъг) 

        //Make first letter from string CAPITAL. To using ".First()", "System.Linq" library is needed!
        string someText = "todor";
        Console.WriteLine(someText.First().ToString().ToUpper() + someText.Substring(1));

        //II.Use NORMAL string as a ARRAY of chars (char[]). Very useful option!!!
        string someStr = "some text";
        Console.WriteLine(someStr[0]);
        Console.WriteLine(someStr[1]);
        Console.WriteLine(someStr[2]);
        Console.WriteLine(someStr[3]);

        //III.Reverse "string" DIRECTLY with concatenation
        string normalString = "12345";
        string stringForReverse = null;
        for (int i = 0; i < normalString.Length; i++)
        {
            stringForReverse = normalString[i] + stringForReverse;  //just put new value(string in this case) BEFORE current value
        }

        //IV.Remove elements from string with ".Remove()"
        string numbsAsString = "1234567890";
        ////////////////////////////////////////////////
        string neededNumbs = numbsAsString.Remove(2, 4); //.Remove(startIndex, counter);
        ////////////////////////////////////////////////
        Console.WriteLine(neededNumbs);

        //V.Catch punctuation symbols with "char.IsPunctuation"  //Прихващане на пунктуационни знаци от текст s "char.IsPunctuation"
        ///////////////////////////////////////////////////////
        string textWithPunctuation = "sxrdct?fvz<>guh,(bij;).";  // '<' и '>' НЕ са пунктуационни знаци!
        StringBuilder punctuation = new StringBuilder();
        foreach (char c in textWithPunctuation)
        {
            if (char.IsPunctuation(c))
            {
                punctuation.Append(c);
            }
        }
        ///////////////////////////////////////////////////////
        Console.WriteLine(punctuation);  //output: ?,(;).

        //VI.To remove white-spaces(and other chars) from string see "String.Trim() (and String.Replace)" section/project.

        //VII.String interpolation //Интерполация(вмъкване) на стрингове 
        //dependency: C# 6.0 (.NET 4.5) or higher
        string name = "Toshko";
        string another = $"{name} is programmer guru";
        Console.WriteLine(another);

        //Parse multi-line text in string array
        short numberOfLines = short.Parse(Console.ReadLine());
        //////////////////////////////////////////////////////
        string[] inputData = new string[numberOfLines];
        for (int line = 0; line < numberOfLines; line++)
        {
            inputData[line] = Console.ReadLine().ToString();
        }
        //////////////////////////////////////////////////////

        //Parse multi-line text AS SINGLE line with verbatim string literal(цитиран низ) -> @"myString"
        StringBuilder myText = new StringBuilder();
        string tempInput = string.Empty;
        for (int i = 0; i < 4; i++)
        {
            tempInput = Console.ReadLine();
            myText.Append($@"{tempInput}");
        }
    }
}


//3.Представяне на функцията "ToString". За да представим цялата стойност(в десетичен вид) на "float.MaxValue", трябва да върнем стойноста и в стринг или в BigIneteg. Но за да стане това коректно и без загуба използваме "ToString".
///////////////////////////////////
//double floatMax = float.MaxValue;
//string floatToString = floatMax.ToString("0");
//BigInteger floatToBigInt = BigInteger.Parse(floatMax.ToString("0"));
//
//Console.WriteLine(floatMax + "\n" + floatToString + "\n" + floatToBigInt);
///////////////////////////////////


//4.Търсене в символен низ(string), посредством метода "IndexOf()".
///////////////////////////////////
//string someText = "Introduction to C# book";
//int index = someText.IndexOf("C#");  //Винаги се отбелязва мястото/позицията на първия търсен символ (в случая 'С'), за последващите го втори (в случая '#'), трети и т.н. не се изписва нищо!
//Console.WriteLine(index);
///////////////////////////////////
//За допълнителни примери, виж проект -> IndexOf(string)-Array.IndexOf()