using System;


class CharTricks
{
    static void Main()
    {
        //Important!!! Easy to convert "String to Char" and "Char to String"
        /////////////////////////////////
        //Convert.ToString( character );
        //Convert.ToChar( string );
        /////////////////////////////////

        //I. Програмата превръща и представя уникодските символи в числата съответстващи на номера в Unicode таблицата.
        char symbol = 'a';
        Console.WriteLine("The code of '" + symbol + "' is: {0}", (int)symbol);
        symbol = 'b';
        Console.WriteLine("The code of '" + symbol + "' is: {0}", (int)symbol); //пример с форматиращ низ "{0}"
        symbol = 'A';
        Console.WriteLine("The code of '" + symbol + "' is: " + (int)symbol);   //пример с обикновена конкатенация "+"

        //II. Прихващане на 0 и 1
        Console.WriteLine("\nType 1 or 0..");
        char someChar = char.Parse(Console.ReadLine());
        ///////////////////////////////
        int charToInt = someChar - '0';
        ///////////////////////////////
        Console.WriteLine(charToInt); //Идеята е, че ако очакваме 0 и 1 като вход и от тях извадим кода в "Unicide" таблицата на "0"-та, ще получим 0 или 1, като int, без да парсваме. Пример: '0'(код: 48) - '0'(код: 48) => 48-48=0 ; Пример: '1'(код: 49) - '0'(код: 48) => 49-48=1 
        //Същия пример, но със "string"
        string someString = "00001001";
        ///////////////////////////////////////
        int stringToInt = someString[7] - '0';
        int stringToInt2 = someString[6] - '0';
        ///////////////////////////////////////
        Console.WriteLine(stringToInt + " " + stringToInt2 + "\n");

        //III. Return bool values from "Char.Is..."  
        char charToTest = 'D';
        /////////////////////////////////////////////////
        Console.WriteLine(char.IsUpper(charToTest));
        Console.WriteLine(char.IsPunctuation(charToTest));  //Indicates whether the specified Unicode character is categorized as a punctuation mark (.,?! and etc.).
        Console.WriteLine(char.IsWhiteSpace(charToTest));
        Console.WriteLine(char.IsLetter(charToTest));
        Console.WriteLine(char.IsNumber(charToTest)); //Char.IsNumber() determines as true any Char member of Numeric UnicodeCategory: DecimalDigitNumber, LetterNumber and OtherNumber.
        Console.WriteLine(char.IsDigit(charToTest));  //Char.IsDigit() determines as true Decimal digit character, a character in the range 0 through 9 (and some other Thai digit characters). Char.IsDigit() determines member from Numeric UnicodeCategory: DecimalDigitNumber.
        /////////////////////////////////////////////////
        //NOTE: more info about Char.IsNumber() & Char.IsDigit() visit: https://stackoverflow.com/questions/228532/difference-between-char-isdigit-and-char-isnumber-in-c-sharp

    }
}
