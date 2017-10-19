using System;

namespace Array_Matrices
{
    class Array_Matrices
    {
        static void Main(string[] args)
        {
            //I.Matrix of Multidimensional array
            ////////////////////////////////////////////////////////
            byte n = 2; //matrix size 2x2
                        //declare array
            int[,] matrix = new int[n, n];
            //assign values
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = (row + col) + 1;
                }
            }
            //print
            int counter = 0;
            foreach (var col in matrix)  //NOTE: The Enumerator in C# catch element by element from multidimensional array, unlike Java, where the Enumerator do that, line by line.
            {
                if (counter > (matrix.Length / matrix.Rank) - 1)  //formula to found "NewLine"
                {
                    counter = 0;
                    Console.WriteLine();
                }
                Console.Write("{0} ", col);
                counter++;
            }
            Console.WriteLine("\n");
            ////////////////////////////////////////////////////////


            //II.Matrix of Jagged array
            ////////////////////////////////////////////////////////
            byte m = 2; //matrix size 2x2
                        //declare array
            int[][] matrixOfJaggArr = new int[m][];
            //assign values
            for (int row = 0; row < matrixOfJaggArr.Length; row++)
            {
                matrixOfJaggArr[row] = new int[m];  //<-declare array (matrix 2x2)
                for (int col = 0; col < matrixOfJaggArr[row].Length; col++)
                {
                    matrixOfJaggArr[row][col] = (row + col) + 1;
                }
            }
            //print
            for (int row = 0; row < matrixOfJaggArr.Length; row++)
            {
                foreach (var col in matrixOfJaggArr[row])
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            ////////////////////////////////////////////////////////
        }
    }
}
