using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Action_T_
{
    class Action_T_
    {
        static void Main(string[] args)
        {
            //Simple using of predefined delegate "Action". 
            Action<int> print = s => Console.WriteLine(s);

            for (int num = 0; num < 10; num++)
            {
                print(num);
            }
        }
    }
}
