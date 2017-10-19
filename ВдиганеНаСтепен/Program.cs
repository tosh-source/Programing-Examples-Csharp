using System;


class ВдиганеНаСтепен
{
    static void Main()
    {
        Console.WriteLine("Вдигане на степен, вкарайте число, последвано от ентер и степен, последвано от ентер");

        int a = int.Parse(Console.ReadLine()); //кратък вариант, директно подаване на стойност в декларираната променлива "int", посредством "int.Parse"

        int b;
        string TextValueB = Console.ReadLine(); //по-дълъг вариант, подаване на текстов низ (string), присвояване с "int.Parse" и подаване към декларираната променлива "int"
        b = int.Parse(TextValueB);

        //и двата описани варианта за подаване на стойност от потребителя "int a" и "int b" са взаимно заменяеми и допълващи се!!!

        Console.WriteLine(Math.Pow(a, b));
    }
}


/* Накратко, нещата биха изглеждали така, (ако например, трябва да повдигнем  2 ^ 3 (две на степен три)):
 *      double mathPowerResult = Math.Pow(2, 3);
 *      Console.WriteLine(mathPowerResult);
 */
