using System;


class checking_Input_Values_withLoop
{
    static void Main()
    {
        //I.Variant 1. A great way to check input values in range 1 <> uint.MaxValue in loop.
        /////////////////////////////////////////////////////////////////////////////////
        uint n = 0;
        uint checkCounter = 0;
        do
        {
            checkCounter++;
            if (checkCounter > 1) //При първото въвеждане от потребителя този "If" ще бъде прескочен, както и надписът "Invalid arguments!". Но ако цъкълът се повтори, това значи, че са въведени ГРЕШНИ параметри и потребителят ще бъде подканен да въведе правилните.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid arguments! Please enter correct value of N: ");
                Console.ResetColor();
            }
            else
            {
                Console.Write("Please enter value of N: ");
            }
        } while (((uint.TryParse(Console.ReadLine(), out n)) == false) || (n < 1));
        /////////////////////////////////////////////////////////////////////////////////

        //II.Variant 2. A simple way to check input values. You should be entered value as integer in range 0 <> 500. Any other symbols, real number, bigger integer and etc. will keep program in loop.
        /////////////////////////////////////////////////////////////////////////////////
        int numberA;
        do
        {
            Console.Write("Please enter number A in range (0…500): ");
        } while (((int.TryParse(Console.ReadLine(), out numberA)) == false) || (numberA < 0 || numberA > 500));
        /////////////////////////////////////////////////////////////////////////////////

    }
}
//A simple and intelligent way to check FLOATING point values. The program check the length of input value to be less than 16 characters.  
/////////////////////////////////
//double value = 0;
//string valueAsString = null;
//do
//{
//    Console.Write("Enter first number: ");
//    valueAsString = Console.ReadLine();
//} while (((double.TryParse(valueAsString, out value)) == false) || ((valueAsString.Length < 16) == false));
///////////////////////////////////