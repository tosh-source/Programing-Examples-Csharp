using System;

namespace Arrays_JaggedArrays__Example
{
    class JaggedArrays_Example
    {
        static void Main(string[] args)
        { //Task - Dividing set of numbers to "n" and group their reminders.  //Задача - Деление на поредица от числа на "n" и групиране на получ. резултат(деление с остатък).
          //From course "Multidimensonal Arrays" -> presentation(.pptx) 2015 -> slide 16 and 17. 
          //Напр: ако делим числата(действие деление с остатък) на 3, ще имамаме ресултат с остатък 0, 1 и 2. 

            //input
            Console.Write("Use default settings for \"N\" or input new one? Y/n: ");
            string defaultSettingsOrNot = Console.ReadLine();
            int n = 3;
            if(defaultSettingsOrNot == "Y") n = int.Parse(Console.ReadLine());

            int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
            int[] sizeReminders = new int[n];
            int reminder;

            //Calculate the size for each reminder. If n = 3 => reminders are: 0, 1 and 2.
            foreach (var currentNumber in numbers)
            {
                reminder = currentNumber % n;
                sizeReminders[reminder]++;
            }
            //Create groups
            int[][] numbersGroupedByReminders = new int[n][];
            for (int i = 0; i < numbersGroupedByReminders.Length; i++)
            {
                numbersGroupedByReminders[i] = new int[sizeReminders[i]];
            }
            //Grouping reminders
            int[] offsets = new int[n];
            int currentOffset = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                reminder = numbers[i] % n;
                currentOffset = offsets[reminder];

                numbersGroupedByReminders[reminder][currentOffset] = numbers[i];
                offsets[reminder]++;
            }

            //print
            for (int currentGroup = 0; currentGroup < numbersGroupedByReminders.Length; currentGroup++)
            {
                Console.Write($"Numbers with reminder({currentGroup}): "
                            + string.Join(", ", numbersGroupedByReminders[currentGroup])
                            + "\n");
            }
        }
    }
}
