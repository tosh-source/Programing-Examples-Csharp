using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsCounter
{
    class ObjectsCounter
    {
        //Static field with current value, start from 0
        private static long currentValue = 0;

        //Private Constructor (unaccessible)
        private ObjectsCounter()
        {
            
        }

        //Increase value with one
        public static long NextValue()
        {
            currentValue++;
            return currentValue;
        }
        //Get current value
        public static long CurrentValue()
        {
            return currentValue;
        }
        //Reset value
        public static void Reset()
        {
            currentValue = 0;
        }
    }
}
