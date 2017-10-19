using System;


class Switch_Case
{
    static void Main()
    {
        while (true)
        { //I-ви вариянт.
          //Въвеждат се от потребителя дните от седмицата с цифри. НАпр: за Понеделник се въвежда 1, за Вторник се въвежда 2 и т.н.
            int dayOfweek = int.Parse(Console.ReadLine());

            switch (dayOfweek)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5: Console.WriteLine("Working days");
                    break;
                case 6:
                case 7: Console.WriteLine("The Holiday");
                    break;
                default: Console.WriteLine("Invalid day!");
                    break;
            }
        }
    }
}


//II-ри вариянт (на горната задача). 
//Важно!!! - Когато използвам "swich-case", като по-добра практика считам, че е добре цифрите(числата) да се въвеждат в данни от тип "string"(както е показано в този втори вариянт на задачата), a не, като "int" (както е в първия вариянт по-горе на задачата). 
//Обосновката е много проста, когато се въвеждат числа (от тип "string") и потребителя случайно сгреши и въведе произволна буква или специфичен знак, програмата няма да "гръмне"(да даде-Exeption), a просто ще премине към "default: case"-a. И ако там е посочено 
//например: "Грешна стойност", "Invalid value" и т.н., съответният символен низ ще се изведе на конзолата и програмата няма да "гръмне". Не така стоят нещата ако се въвеждат цифри/числа в тип "int". Тука ако потребителя обърка и въведе буква или някакъв знак,  
//програмата директно "гърми". Така в комбинация "string" и "swich-case" се прави и проверка на въведените данни, които ако се използва "int", за да работи коректно програмата се налага за проверка на данните да се добави и метода "int.TryParse", което излишно 
//ще усложни кога. 
//С две думи, по-мое мнение, по възможност да си използвачм "string" дори и при данни от тип "int" (говоря конкретно при работа с конструкцията "swich-case", не за всичко в програмирането!!).
//
//string dayOfweek = Console.ReadLine();
//switch (dayOfweek)
//{
//    case "1": 
//    case "2": 
//    case "3": 
//    case "4": 
//    case "5":  Console.WriteLine("Working days");
//        break;
//    case "6":
//    case "7": Console.WriteLine("The Holiday");
//        break;
//    default: Console.WriteLine("Invalid day!");
//        break;
//}


//string animal = Console.ReadLine();
//switch (animal)
//{
//    case "dog":
//    case "cat":
//    case "cow":
//        Console.WriteLine("Mammal");
//        break;
//    case "crocodile":
//    case "tortoise":
//    case "snake":
//        Console.WriteLine("Reptile");
//        break;
//    default: Console.WriteLine("There is NO sush animal!");
//        break;
//}        
