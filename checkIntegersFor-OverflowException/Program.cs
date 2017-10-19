using System;


class checkIntegersFor_OverflowException
{
    static void Main()
    {
        double d = 5e9d; // 5 * 10^9
        Console.WriteLine(d); // 5000000000
       
        int i = checked((int)d); // System.OverflowException
        Console.WriteLine(i);
    }
}

/* Втори вариянт:
        checked  //Метод за проверка "checked"(спира приложението и показва "Exeptions"), тъй като в случая прехвърляме с 1-ца максималният допустим обем от стойности на 32-битовия "int". 
        {
            int maxNumPlus1 = int.MaxValue;
            maxNumPlus1++;  //"++" означава, че увеличаваме с единица
            Console.WriteLine(maxNumPlus1); 
            
        }
 */