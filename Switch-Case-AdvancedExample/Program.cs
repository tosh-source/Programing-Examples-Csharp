using System;


class Switch_Case_AdvancedExample
{
    static void Main()
    { //Това е доразвит вариянт на примера от лекциите, който съм поместил по-долу като коментар. Целта е като цяло да демонстрирам възможностите на кострукцията "switch-case".
        while (true)
        {
            string dayOfweek = Console.ReadLine();
            switch (dayOfweek)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    if ("1" == dayOfweek)
                    {
                        Console.WriteLine("Monday");
                    }
                    if ("2" == dayOfweek)
                    {
                        Console.WriteLine("Tuesday");
                    }
                    if ("3" == dayOfweek)
                    {
                        Console.WriteLine("Wednesday");
                    }
                    if ("4" == dayOfweek)
                    {
                        Console.WriteLine("Thursday");
                    }
                    if ("5" == dayOfweek)
                    {
                        Console.WriteLine("Friday");
                    }
                    Console.WriteLine("Working days");
                    break;
                case "6":
                case "7":
                    if ("6" == dayOfweek)
                    {
                        Console.WriteLine("Saturday");
                    }
                    if ("7" == dayOfweek)
                    {
                        Console.WriteLine("Sunday");
                    }
                    Console.WriteLine("The Holiday");
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        }
    }
}


//Примера от лекциите.
//
//int day = int.Parse(Console.ReadLine());
//switch (day)
//{  //Структора на тялото на "switch-case", след самия "case :", както показвам по-долу е без значение и може да бъде написана, както намери за добре програмиста.
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3: Console.WriteLine("Wednesday"); break;
//    case 4: Console.WriteLine("Thursday"); break;
//    case 5: Console.WriteLine("Friday"); break;
//    case 6: Console.WriteLine("Saturday"); break;
//    case 7: Console.WriteLine("Sunday"); break;
//    default: Console.WriteLine("Error!"); break;
//}
