using System;
using System.Linq;

namespace CopyArraysAndMatrices
{
    class CopyArraysAndMatrices
    {
        static void Main(string[] args)
        {
            //How to really copy arrays and matrices. Not shallow/reference copy.
            int[,] matrix =
            {
                {11, 33},
                {34, 78}
            };

            int[,] copyOfMatrix = matrix.Clone() as int[,];  //equal to --> (int[,])copyOfMatrix.Clone()
            copyOfMatrix[0, 0] = 0;

            PrintArrays(copyOfMatrix);
            PrintArrays(matrix);        //There is NO change on FIRST elemnt of the original array/matrix!
        }

        public static void PrintArrays(int[,] arrayToPrint)
        {
            for (int rows = 0; rows < arrayToPrint.GetLength(0); rows++)
            {
                for (int cols = 0; cols < arrayToPrint.GetLength(1); cols++)
                {
                    Console.Write(arrayToPrint[rows, cols] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
