using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PascalTriangle  //V0.2
{
    static void Main(string[] args)
    {
        //colored console area
        Console.ForegroundColor = ConsoleColor.Yellow;
        //input
        Console.Write("Please enter value for HEIGHT of the Pascal triangle (from 1 <-> to 24) : ");
        int triangleHeight = 0;
        if ((int.TryParse(Console.ReadLine(), out triangleHeight)) == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid parameters!!! Restart programs!");
            return;
        }
        //calc and print
        int coefficient = 2;
        bool bigTriangle = false;
        if (triangleHeight >= 15) //If triangle have height, more than 15, change printing settings.
        {
            coefficient = 4;
            bigTriangle = true;
        }

        int temp = 0;
        int temp2 = 0;
        int valueToPtint = 0;
        List<int> previousRow = new List<int>();
        previousRow.Add(1);
        List<int> currentRow = new List<int>();

        for (int row = 0; row <= triangleHeight; row++)
        {
            Console.Write(new string(' ', (triangleHeight - row) * coefficient)); //console whitespaces //За по-добра визуализация, при по-голяма височина на триъгълника се налага бедрата му да са по наклонени, което се постига с променливата "coefficient".
            for (int col = 0; col < triangleHeight - (triangleHeight - row) + 1; col++)
            {
                if ((col - 1) < 0) //if less than index[0]
                {
                    temp = 0;
                }
                else
                {
                    temp = previousRow[col - 1];
                }

                if (col >= previousRow.Count) //if overflow index length
                {
                    temp2 = 0;
                }
                else
                {
                    temp2 = previousRow[col];
                }
                valueToPtint = temp + temp2;
                currentRow.Add(valueToPtint);
                //print
                string lessWhiteSpace = "{0,4}"; //If triangle have height, LESS than 15 -> 4 whitespaces
                string moreWhiteSpace = "{0,8}"; //If triangle have height, MORE than 15 -> 8 whitespaces
                Console.Write((bigTriangle ? moreWhiteSpace : lessWhiteSpace), valueToPtint);
            }
            previousRow.RemoveRange(0, previousRow.Count); //clear all elements
            previousRow.AddRange(currentRow);
            currentRow.RemoveRange(0, currentRow.Count);
            Console.WriteLine();
        }
    }
}


//Pascal triangle with jagged array (v1) 
////////////////////////////////////////////////////////////////////////////
//int height = 13;  //Pascal triangle height
//int number = 1;
//int[][] triangleNumbers = new int[height + 1][];
//triangleNumbers[0] = new int[1];  //Very first element, before triangle. Only for calculation (and to prevent "OverFlowExeption" too).
//        //calculation
//        for (int row = 0; row<height; row++)
//        {
//            triangleNumbers[row + 1] = new int[row + 1];
//            Console.Write("".PadLeft((height - row) * 2));  //the number "2" is like "coefficient for padding": 2 / 4 / 8 ..
//            for (int col = 0; col<row + 1; col++)
//            {
//                if (col == 0 || col == triangleNumbers[row + 1].Length - 1)  //(row + 1) is == triangleNumbers[row + 1][col].Lenght
//                {
//                    triangleNumbers[row + 1][col] = 1;
//                }
//                else
//                {
//                    triangleNumbers[row + 1][col] = triangleNumbers[row][col - 1] + triangleNumbers[row][col];
//                }
//                number = triangleNumbers[row + 1][col];
//                //print
//                Console.Write("{0,4}", number);  //coefficient padding * 2 ==> padding: 4 / 8 / 16 ..
//            }
//            Console.WriteLine();
//        }
////////////////////////////////////////////////////////////////////////////



//Pascal triangle (with mathematical formula)
//////////////////////////////////////////////////////////////////////////
//int n = 13;
//int number = 1;

//for (int row = 0; row<n; row++)
//{
//    Console.Write("".PadLeft((n - row) * 2));  //padding: 2 / 4 / 8 ..
//    number = 1;
//    for (int col = 0; col<row + 1; col++)
//    {
//        Console.Write("{0,4}", number);  //padding: 4 / 8 / 16 ..
//        number = (number* (row - col)) / (col + 1);
//    }
//    Console.WriteLine();
//}
//////////////////////////////////////////////////////////////////////////
//The pseudo code, for this case, is taken from internet