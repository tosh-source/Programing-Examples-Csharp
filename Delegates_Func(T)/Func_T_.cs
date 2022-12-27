using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Func_T_
{
    class Func_T_
    {
        static void Main(string[] args)
        {
            //Simple using of predefined delegate "Func". 
            Func<int, bool> intFunc = (x) => x < 50;
            int[] values = { 45, 55, 20 };

            for (int i = 0; i < values.Length; i++)
            {
                if (intFunc(values[i]) == true)  //"intFunc" will take integer and return bool (if condition pass return true, else return false).
                {
                    Console.WriteLine($"{values[i]} is less than 50!");
                }
                else
                {
                    Console.WriteLine($"{values[i]} is bigger than 50!");
                }
            }
        }
    }
}

