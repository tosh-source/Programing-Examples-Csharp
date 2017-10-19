using System;
using System.Threading;
using System.Globalization;

class dateTime
{
    static void Main()
    {
        //standart (RegionalSettings)
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //////////////////////////////////////////////////////////////////
        DateTime date1 = DateTime.Now;
        Console.WriteLine(date1); //текуща дата
        Console.WriteLine(date1.ToString("dd-MM-yyyy hh:mm:ss tt")); //Датата във форматиран низ (ден-месец-год. час:мин:сек разделител AM/PM). ВАЖНО! - "MM" е форматът за месеци, а "mm" за минути. Лесно се бъркат!
        Console.WriteLine(date1.Day); //показва само деня от текуща дата
        Console.WriteLine(date1.DayOfYear);  //дните от началото на годината
        Console.WriteLine(date1.DayOfWeek);  //ден от седмицата
        Console.WriteLine(date1.AddDays(3)); //добавяне на 3 дена към текущата дата (на променливата "date1")
        Console.WriteLine(date1.IsDaylightSavingTime()); //лятно часово време ли е или не (резултат от тип "bool")
        Console.WriteLine(DateTime.IsLeapYear(int.Parse(date1.Year.ToString()))); //показва дали подадената година е високосна (резултат от тип "bool")

        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US"); //американски (RegionalSettings)
        Console.WriteLine(date1);
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG"); //български (RegionalSettings)
        Console.WriteLine(date1);
        //////////////////////////////////////////////////////////////////

        //II.Parsing DateTime with Culture info
        Console.WriteLine(new string('-', 20));
        //////////////////////////////////////////////////////////////////
        CultureInfo myCultureInfoUS = new CultureInfo("en-US"); //Това деклариране на нова култура има отношение САМО за парсването на стринга към "DateTime" (DateTime.Parse(someDate)), ако все пак резултата 
        CultureInfo myCultureInfoBG = new CultureInfo("bg-BG"); //трябва да се изпише, конзолата ползва културата на компютъра или ръчно зададената и такава (napr: "Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture").
        string someDate = "10, 26, 2019 10:34 PM"; //month, date, year --> US culture
        DateTime test1 = DateTime.Parse(someDate, myCultureInfoUS);
        Console.WriteLine(test1);
        string someDate2 = "26, 10, 2019 22:34"; //date, month, year --> BG culture (ЗАБЕЛЕЖКА-за часовете няма голямо значение формата, компилатора ги приема и в американски и в български вариант, но не така стоят нещата за подредбата на самата дата)
        DateTime test2 = DateTime.Parse(someDate2, myCultureInfoBG);
        Console.WriteLine(test2);
        //////////////////////////////////////////////////////////////////
        Console.WriteLine(new string('-', 20));
    }
}
