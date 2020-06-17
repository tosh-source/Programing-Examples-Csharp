using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput_Techniques_Console_SetIn
{
    class Program
    {
        static void Main(string[] args)
        {
            //INFO: How to simulate the input data  //Как да симилиране на входните данни в цонзолата
            ////////////////////////////////////////////////////
            //ВАЖНО - Този метод симулира ВЕЧЕ въведени данни(от потребител) в конзолата.
            //БЕЛЕЖКА - Много подходящо за използване при тестове. Т.е., преди изпълнението на всеки друг 
            //код, метод и т.н., за да се избегне постоянно въвеждане на едни и същи данни при тестване. 

            //I.Using Console.SetIn
            ////////////////////////////////////////////////////
            var reader = new StringReader("Toshko\nChupov\n31");  //Може да се използва и цитиран низ @""
            Console.SetIn(reader);
            ////////////////////////////////////////////////////

            //Ia. Manipulate strings
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine(firstName + " " + lastName + " " + userAge);
            
        }
    }
}
