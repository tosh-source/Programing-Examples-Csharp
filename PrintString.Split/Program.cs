using System;
using System.Collections.Generic; //Библиотека за масиви.
using System.Linq; //Библиотеката дава възможност за използване на т.нар. "Extension methods", тя поддържа функцията ".Select(int.Parse)".
using System.Text.RegularExpressions; //Библиотека за "Regular Expression".

class Program
{
    static void Main()
    {
        //I.Командата String.Split() парсната в масив.
        string myName = "Todor Apostolov Chupov";            //Много Важно! Самата комадна '.Split' хваща интервала между имената ми, именно затова изрично се посочва интервал (' ') след  
        string[] catchTheSpaceOfmyName = myName.Split(' ');  //командата. Това от своя страна вкарано в масив може да бъде изведено на отделен ред, например с цикъл.

        foreach (var splitedWords in catchTheSpaceOfmyName)  //После посредством цикъл извеждам имената си на отделен ред
        {
            Console.WriteLine(splitedWords);
        }

        //Ia.Сбит вариянт на "String.Split()"
        Console.Write("Enter array (eg.: 4 5 6 7 OR eg: 4,5,6,7) in \nsingle line separated by space or comma: ");
        ///////////////////////////////////////////////////////
        string[] someString = Console.ReadLine().Split(' ', ',');
        Console.WriteLine(string.Join("\n", someString));  //Тази команда обхoжда масива, представяйки го като 'string', на един единствен ред, разделяйки масива с друг текстов стринг(в случая със знака за "нов ред" -> "\n").
        ///////////////////////////////////////////////////////

        //II.Чети масив на един ред посредсвом ".Select(int.Parse)" и ".Split()" и го разпечатай 
        Console.Write("Enter integer array (eg.: 4 5 6 7) \nin single line separated by space: ");
        //Вариянт с int[]
        /////////////////////////////////////////////////////////////////////////////
        int[] someIntArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  //Тази сложна структура от команди казва: Чети елементи от конзолата като стринг и махни "интервалите" (посредством "String.Split()"), като за всеки един от тези елементи, посредством метода "Select", приложи "int.Parse" и накрая ги обърни в масив (".ToArray()") от тип "int".
        Console.WriteLine(string.Join(", ", someIntArr));  //Тази команда обхoжда масива, представяйки го като 'string', на един единствен ред, разделяйки масива с друг текстов стринг(в случая със запетая).
        /////////////////////////////////////////////////////////////////////////////
        //Вариянт с List<int>
        ///////////////////////////////////////////////////////////////////////////////////
        //List<int> someListInt = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        ///////////////////////////////////////////////////////////////////////////////////

        //II.Методика която зачиства допълнително въведени символи (интервали, запетайки, тирета 
        //и т.н.) при въвеждането на данни от потребителя, посредством масив от "char" и командата ", StringSplitOptions.RemoveEmptyEntries".
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write((new string('=', 20)) + "\nPlease enter some string array separated by \nspace, comma, dot and etc. (eg.: 43 56, 3. 65 ! ? * 345,4,     354): ");
        ///////////////////////////////////////////////////
        string[] anotherStrArr = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '?', '*' }, StringSplitOptions.RemoveEmptyEntries);
        ///////////////////////////////////////////////////
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine((new string('=', 20)) + "\n" + string.Join(", ", anotherStrArr));
        //
        //IIa.Същия пример, само, че вече с ЦЕЛИ стрингове(не просто 'char') за разделител!
        //идеята е, че ако искам да разделя думите по ", " (запетая, последвана от интервал), с горната
        //методика няма как да се получи. Затова може да добавим цели масиви от СТРИНГОВЕ за раздеелитл.
        Console.ResetColor();
        Console.WriteLine("Please enter some names separated by space and comma (eg: toshko, vlad, haralampi, pesho)..");
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        string[] anotherStrArr2 = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);  //ВАЖНО–когато използваме string[], като разделител, ВИНАГИ, накрая трябва да поставим StringSplitOptions.
        ///////////////////////////////////////////////////////////////////////////////////////////////////  //Като, ако не искаме да премахва празни пространства просто като аргумент използваме "StringSplitOptions.None"
        Console.WriteLine(string.Join(" >> ", anotherStrArr2));

        //III.Split string (and KEEP delimiter) with Regular Expressions techniques. //Разделяне на стрингове (и задържане на разделителите) посредством Регулярни Изрази.
        //==========================================================================
        //if split chars are: '.' and '!' the expression(which KEEP delimiter), look like this:
        string text = "Software developers like to solve problems. If they are no problems handily available, they will create their own problems!";
        /////////////////////////////////////////////////////
        string[] sentence = Regex.Split(text, @"(?<=[.!])");
        /////////////////////////////////////////////////////
        //the Regex.Split pattern structure is: (?<=[PATTERN])
        //If you looking for delimiter: '.' , ',' and ';' the regular expression will be:
        //////////////////////////////////
        //Regex.Split(text, @"(?<=[.,;])")
        //////////////////////////////////

    }
}
