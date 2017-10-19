using System;
using System.Collections.Generic;
using System.Linq;

namespace Matrix_withArrays
{
    class Program
    {
        static void Main()
        {
            //I.Print Matrix with multidimensional arrays
            ///////////////////////////////////////////////////////////////////
            //matrix depth
            Console.Write("Number of rows: ");
            int depthMatrixA = int.Parse(Console.ReadLine());
            Console.Write("Number of cols: ");
            int depthMatrixB = int.Parse(Console.ReadLine());
            //matrix
            int[,] matrix = new int[depthMatrixA, depthMatrixB];
            //input values of first (row) and second (col) dimension of matrix
            Console.WriteLine("Enter values of rows and cols..");
            for (int row = 0; row < matrix.GetLength(0); row++) //".GetLength(0)" --> GET the length on first dimension --> e.g: rows
            {
                for (int col = 0; col < matrix.GetLength(1); col++) //".GetLength(1)" --> GET the length on second dimension --> e.g: cols
                {
                    Console.Write("row{0}, col{1} = ", row + 1, col + 1);
                    int temp = int.Parse(Console.ReadLine());
                    matrix[row, col] = temp;
                }
                Console.WriteLine(new string('=', 12));
            }
            //print matrix
            Console.WriteLine("Print matrix..\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int printRow = 0; printRow < matrix.GetLength(0); printRow++)
            {
                for (int printCol = 0; printCol < matrix.GetLength(1); printCol++)
                {
                    Console.Write("{0, 2} ", matrix[printRow, printCol]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ResetColor();
            ///////////////////////////////////////////////////////////////////

        }
    }
}
