using System;

namespace Matrix_MaximalPlatform
{
    class Matrix_MaximalPlatform
    {
        static void Main(string[] args)
        { //condition: from "Fundamentals-of-Computer-Programming-with-CSharp" -> 251 page: "Maximal Platform in a Matrix – Example"
            //initialize the matrix
            Console.Write("Change the matrix or continue(Y/n): ");
            int[,] matrix = {
                    {0,2,4,0,9,5},
                    {7,1,3,3,2,1},
                    {1,3,9,8,5,6},
                    {4,6,7,9,1,0}
            };
            Console.ForegroundColor = ConsoleColor.Green;
            string userChoice = Console.ReadLine();
            Console.ResetColor();
            if ((userChoice == "Y") || (userChoice == "y"))
            {
                Console.Write("Please enter \"matrix height\": ");
                int matrixHeight = int.Parse(Console.ReadLine());
                Console.Write("Please enter \"matrix width\": ");
                int matrixWidth = int.Parse(Console.ReadLine());
                //define new matrix
                matrix = new int[matrixHeight, matrixWidth];
                for (int rowInput = 0; rowInput < matrixHeight; rowInput++)
                {
                    for (int colInput = 0; colInput < matrixWidth; colInput++)
                    {
                        Console.Write("matrix[{0},{1}] = ", rowInput, colInput);
                        matrix[rowInput, colInput] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("You use predefined matrix with this parameters: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"  
  0,2,4,0,9,5
  7,1,3,3,2,1
  1,3,9,8,5,6
  4,6,7,9,1,0
                                  ");
                Console.ResetColor();
            }

            Console.Write("Please enter \"platform height\": ");
            int platformHeight = int.Parse(Console.ReadLine());
            Console.Write("Please enter \"platform width\": ");
            int platformWidth = int.Parse(Console.ReadLine());
            long bestSum = long.MinValue;
            long currentSum = 0;
            int bestRowIndex = 0;
            int bestColIndex = 0;
            //calc
            MaxPlatformMethod(matrix, platformWidth, platformHeight, ref bestSum, ref currentSum, ref bestRowIndex, ref bestColIndex);
            //print
            Console.WriteLine("Best platform: ");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintMaxPlatform(matrix, platformWidth, platformHeight, bestRowIndex, bestColIndex);
            Console.ResetColor();
            Console.Write("Best platform sum: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(bestSum);
            Console.ResetColor();
        }

        private static void PrintMaxPlatform(int[,] matrix, int platformWidth, int platformHeight, int bestRowIndex, int bestColIndex)
        {
            for (int printRow = bestRowIndex; printRow < bestRowIndex + platformHeight; printRow++)
            {
                for (int printCol = bestColIndex; printCol < bestColIndex + platformWidth; printCol++)
                {
                    Console.Write(matrix[printRow, printCol] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void MaxPlatformMethod(int[,] matrix, int platformWidth, int platformHeight, ref long bestSum, ref long currentSum, ref int bestRowIndex, ref int bestColIndex)
        {
            //iterate through matrix
            for (int row = 0; row < (matrix.GetLength(0) - (platformHeight - 1)); row++)
            {
                for (int col = 0; col < (matrix.GetLength(1) - (platformWidth - 1)); col++)
                {
                    //iterate through defined platform (submatrix)
                    for (int subRow = row; subRow < platformHeight + row; subRow++)
                    {
                        for (int subCol = col; subCol < platformWidth + col; subCol++)
                        {
                            currentSum += matrix[subRow, subCol];
                        }
                    }
                    //check bestSum
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRowIndex = row;
                        bestColIndex = col;
                    }
                    currentSum = 0;
                }
            }
        }
    }
}
