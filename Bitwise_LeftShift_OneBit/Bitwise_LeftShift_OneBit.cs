using System;

namespace Bitwise_LeftShift_OneBit
{
    class Bitwise_LeftShift_OneBit
    {
        static void Main(string[] args)
        {
            //Побитово изместване на ляво и показване на стойността в десетична и двоична бройна система
            int bit = 1;

            for (int i = 0; i < 32; i++)
            {
                Console.ReadLine();
                int currentValue = bit << i;
                Console.WriteLine($"{currentValue,-11} : " + Convert.ToString(currentValue, 2).PadLeft(32, '0'));
                bit = 1;
            }
        }
    }
}
