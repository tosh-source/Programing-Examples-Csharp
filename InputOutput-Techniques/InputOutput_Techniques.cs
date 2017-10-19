using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;   //Библиотеката нужна за "Encoding.Unicode" или "Encoding.UTF8" поддръжка от конзолата. 
using System.Threading;  //Библиотеката нужна за "Console StandartRegionalSettings", тя съдържа: Thread.
using System.Globalization;  //Библиотеката нужна за "Console StandartRegionalSettings", тя съдържа: CultureInfo.
using System.IO;  //this library is needed to use "System.Path" class

class InputOutput_Techniques
{
    static void Main()
    {
        //I.Console StandartRegionalSettings
        ///////////////////////////////////////////////////////////////////
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        ///////////////////////////////////////////////////////////////////
        //Този ред трябва да бъде добавен за да може конзолата да работи с унифицирани (Американски) регионални настройки. 
        //Защото за различните култури(регионални настройки) разделителя на числата има различно значение! При бъларска -> разделителя е 
        //запетая "," (напр: 1,2) , а при американската разделитяля е точка "." (напр: 1.2) и самата запетая се ползва единствено за 
        //визуално разделяне на хилядите (напр: 1,000.3 -> e всъщност хиляда цяло и три спрямо българската култура!!!). Това е ИЗКЛЮЧИТЕЛНО важно, 
        //защото програмата ще има много различно поведение ако се влияе от културата на компютъра!
        Console.WriteLine(3.54); // 3.54 -->за сравение при българските ще се визуализира 3,54

        //Ia.ръчна промяна на културата(RegionalSettings) на конзолата (виж стр. 186 от книгата Въведение в програмирането със C#)
        ////////////////////////////////////////////////////////////////////////////
        //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        ////////////////////////////////////////////////////////////////////////////
        //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");
        ////////////////////////////////////////////////////////////////////////////
        //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-GB");
        ////////////////////////////////////////////////////////////////////////////

        //Ib.Допълнителна превантивна мярка към горната точка (след прилагането на интернационалната култура към конзолата).
        Console.WriteLine("Enter REAL number /choice format 1,23 or 1.23 -> the result ALWAYS will be in format 1.23/");
        string someValue = Console.ReadLine();
        someValue = someValue.Replace(',', '.');       //С функцията ".Replace", ако потребителя ЕВЕНТУАЛНО въведе запетая (",") то тя се замества с точка (".")
        float valueAsFloat = float.Parse(someValue);   //Така "float" ще очаква (заради въведената култура) от потребителя, разделителя на числото (дробта) всеки път да се бележи с точка (напр: 1,23) и ще го получи дори и потребителя да го направи със запетая. Напр: 1,23 ==> 1.23 (заради заместването което сме задали във функцията ".Replace").
        Console.WriteLine(valueAsFloat);

        //II.Formatted string (форматиращи низове). Пример 1
        string a = "some text";
        string b = "AliExpress and Alibaba";
        ulong aInt = 12345934598358;
        int bInt = 1234567890;
        Console.WriteLine("|{0,-25}|{1,15:X}|", a, aInt);
        Console.WriteLine("|{0,-25}|{1,15}|", b, bInt);
        //IIa.Друг, по-компактен варянт за форматиране към "пример 1".
        /////////////////////////////////////////
        string formatedText = "|{0,-25}|{1,15}|";
        /////////////////////////////////////////
        //Подходяща техника за обработка на голямо количество данни. С един ред могат да се обработват всички редове.
        Console.WriteLine(formatedText, a, aInt);
        Console.WriteLine(formatedText, b, bInt);
        //Недостатъци, данните трябва да са сходни по вид, защото не могат да се обработват поотделно. Напр., както "пример 1, точка II" форматиращия низ е зададен да преобразува "aInt" в шестнайсетична бройна система, но в същия пример на точка IIа това е невъзможно. 

        //IIb.Демонстрация на форматиращите низове, показващи датата и часа (DateTime.Now), плюс демонстрация на променливата "var" в комбиция с "formatted string".
        Console.WriteLine("{0:yy-MM-dd | hh:mm:ss}", DateTime.Now);  //ВАЖНО! - "MM" е форматът за месеци, а "mm" за минути. Лесно се бъркат!

        var vr = string.Format("{0:yy-MM-dd | hh:mm:ss}", DateTime.Now);  //ВАЖНО! - "MM" е форматът за месеци, а "mm" за минути. Лесно се бъркат!
        vr = vr + " || " + 12345;
        Console.WriteLine(vr);

        //III.Console Encoding 
        char tab = '\t';        //чрез тази комбинация се създава табулация (може да бъде вкарано директно в стринг, като ефекта е същия, тук в "char" е просто за демонстрация)
        char nLine = '\n';      //създаване на нов ред (може да бъде вкарано директно в стринг, като ефекта е същия, тук в "char" е просто за демонстрация)
        string fName = "Тодор";
        string lName = "Чупов";
        string names = fName + nLine + tab + lName + nLine + tab + "©";  //специален символ от "Unicode" таблицата
        Console.OutputEncoding = Encoding.Unicode;    //зареждане на "Unicode" таблицата в консолата (добре е да се избере фонта "Consolas"-в настройките на консолата, което пак не гарантира 100%-тово представяне на Unicode таблицата)
        Console.WriteLine(tab + names + "\\\\\\\\");

        //IV.Console clear screen
        //Console.Clear();   //С тази команда се изчиства всичко изписвано до момента от конзолата. Много подходява е например ако се постави в израз "if (true)" с някакво условие. Например: "ако едикакво си изчисти всичко на конзолата".

        //V.System Environment /достъпване на полезна информация за системата посредством класът "Environment"/
        string str1 = Convert.ToString(Environment.MachineName);
        string str3 = Convert.ToString(Environment.Is64BitProcess);
        string str4 = Convert.ToString(Environment.Is64BitOperatingSystem);
        string str5 = Convert.ToString(Environment.ProcessorCount);
        string str6 = Convert.ToString(Environment.SystemDirectory);
        string strOSver = Convert.ToString(Environment.OSVersion);
        string strCLRver = Convert.ToString(Environment.Version);
        Console.WriteLine("MachineName:            {0}", str1);
        Console.WriteLine("Is64BitProcess:         {0}", str3);
        Console.WriteLine("Is64BitOperatingSystem: {0}", str4);
        Console.WriteLine("ProcessorCount:         {0}", str5);
        Console.WriteLine("SystemDirectory:        {0}", str6);
        Console.WriteLine("OSVersion:              {0}", strOSver);
        Console.WriteLine(".NET CLR version:       {0}", strCLRver);  //short solution: Console.WriteLine(Environment.Version);

        //Va. Get column numbers of current Console window
        Console.Write("\n" + "Column numbers of current Console window: ");
        //////////////////////////////////////////////
        Console.WriteLine(Console.WindowWidth);
        //////////////////////////////////////////////

        //VI.Using "System.Path" class (този клас дава информация за файлофе и директории)
        string fileName = @"C:\Temp\test.txt";
        //////////////////////////////////////////////////////
        string getDirectory = Path.GetDirectoryName(fileName);
        string getFileName = Path.GetFileName(fileName);
        string getFileExtension = Path.GetExtension(fileName);
        //////////////////////////////////////////////////////
        Console.WriteLine("\nDirectory = {0}\nFileName = {1}\nFileExtension = {2}\n", getDirectory, getFileName, getFileExtension);
        //VI.a Get "FileName" and get INDEPENDENT directory separator "Slash", from Linux and Windows users.
        /////////////////////////////////////////////////////////////
        char crossPlatformSlash = Path.DirectorySeparatorChar;  //if the code will be compiled on Linux or Mac it return '/' directory separator(Slash), else (on Windows) returned char is '\'
        int slashIndex = fileName.LastIndexOf(crossPlatformSlash);
        string getFileNameAgain = fileName.Substring(slashIndex + 1);
        /////////////////////////////////////////////////////////////
        Console.WriteLine("FileName = {0}", getFileNameAgain);

    }
}