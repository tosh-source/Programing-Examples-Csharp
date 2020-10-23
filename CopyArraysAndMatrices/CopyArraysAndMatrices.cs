using System;
using System.Linq;
using System.Collections;

namespace CopyArraysAndMatrices
{
    class CopyArraysAndMatrices
    {
        static void Main(string[] args)
        {
            //How to really copy arrays and matrices.
            //NOTE: Copy as separate objects, not shallow/reference copy.

            //First variant.
            int[,] matrix =
            {
                {11, 33},
                {34, 78}
            };
            int[,] copyOfMatrix = (int[,])matrix.Clone();  //equal to --> matrix.Clone() as int[,]
            copyOfMatrix[0, 0] = 0;                        //change first element of new array

            PrintArrays(copyOfMatrix);
            PrintArrays(matrix);        //There is NO change on FIRST elemnt of the original array/matrix!


            //Second variant.
            int[][] jaggMatrix =
            {
                new int[] {23, 76},
                new int[] {56, 12}
            };

            int[][] copyOfjaggMatrix = jaggMatrix.Select(x => x.ToArray()).ToArray();  //Lambda can copy ONLY one dimensional array or jagged arrays!
            copyOfjaggMatrix[1][0] = 0;                                                //change some element of new array
            //int[][] copyOfjaggMatrix2 = jaggMatrix.Clone() as int[][];  //equal to --> (int[][])jaggMatrix.Clone()

            PrintJaggArrays(copyOfjaggMatrix);
            PrintJaggArrays(jaggMatrix);       //There is NO changed elemnts of the original array/matrix!
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

        public static void PrintJaggArrays(int[][] arrayToPrint)
        {
            for (int rows = 0; rows < arrayToPrint.Length; rows++)
            {
                for (int cols = 0; cols < arrayToPrint[rows].Length; cols++)
                {
                    Console.Write(arrayToPrint[rows][cols] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
