using System;
using System.Linq;
using System.Text;

namespace PrintArrays_JaggedArrays_
{
    class JaggedArrays
    {
        static void Main(string[] args)
        {
            //Деклариране и присвояване на стойност на назъбен масив(Jagged Arrays)
            //I.1-ви вариянт
            int[][] myJaggedArr = new int[3][];
            myJaggedArr[0] = new int[2];
            myJaggedArr[1] = new int[2];
            myJaggedArr[2] = new int[2];
            myJaggedArr[0][0] = 4;
            myJaggedArr[0][1] = 1;

            myJaggedArr[1][0] = 3;
            myJaggedArr[1][1] = 5;

            myJaggedArr[2][0] = 1;
            myJaggedArr[2][1] = 10;

            //II.2-ри вариянт (с директно присвояване на стойност)
            int[][] myJaggedArrII =
            {
                new int[] {5,6,7},
                new int[] {76,2,0,11},
                new int[] {3,2}
            };
            //IIa.access to jagged array elements (достъп до елемнтите в назъбения масив е по същия начин както всеки друг вид масиви)
            Console.WriteLine(myJaggedArrII[1][3] + " " + myJaggedArr[2][1]);


            //III. Jagged array of multi-dimensional arrays (назъбен многоменрен масив)
            int[][,] myJaggedMulti_DimArr = new int[2][,];
            myJaggedMulti_DimArr[0] = new int[,] { { 22, 33, 44, 54, 556 }, { 39, 99, 54, 789, 06 } }; //При този вид масиви, елементите от съответното измерение трябва да са с ЕДНАКВА дължина. Напр: в това 1-во измерение те са 5,
            myJaggedMulti_DimArr[1] = new int[,] { { 42, 21, 4 }, { 87, 35, 9 } };                     //но в следващото (2-ро) измерение те са по 3 елемента в масив!


            //IV. Catch NUMBER of DIMENSIONS of "Multidimensional array - Matrix"
            //use command ".Rank"
            //two dim. matrix
            int[,] twoDimMatrix =
            {
                {1,2,3,4},
                {9,8,7,6},
                {5,6,2,1}
            };
            Console.WriteLine(twoDimMatrix.Rank); //Output: 2  //two-dimensional matrix 3x4 
            //three dim. matrix
            int[,,] threeDimMatrix = new int[5, 5, 2];
            Console.WriteLine(threeDimMatrix.Rank); //Output: 3  //three-dimensional matrix (cube) 5x5x2
            

            //IVa. Catch NUMBER of DIMENSIONS of Jagged Arrays
            Console.WriteLine("myJaggedArrII.Rank: " + myJaggedArrII.Rank);     //Output: 1  //Jagged Arrays has always one-dimension


            //V. Access to array "Length"  //Достъп до "дължините" на масива
            int[,] threeDim =
            {
                {35,234,67565,33 },
                {2343657,89756,34,2235 }
            };
            Console.WriteLine(threeDim.Length); //all elements = 8
            Console.WriteLine(threeDim.GetLength(0)); //two rows
            Console.WriteLine(threeDim.GetLength(1)); //four columns

            Console.WriteLine("myJaggedArrII.Length (rows): " + myJaggedArrII.Length); //Output: 3  //There is three rows in "myJaggedArrII"


            //VI. Create Array of "StringBuilders"
            int n = 5;
            ///////////////////////////////////////////////
            StringBuilder[] sbArray = new StringBuilder[n];
            for (int i = 0; i < n; i++)
            {
                sbArray[i] = new StringBuilder();
            }
            ///////////////////////////////////////////////
            //VIa.ANY elements, form ANY row(dimension) with text can be accessed, like a "Jagged Arrays"
            ////////////////////////////////////////
            sbArray[0].Append("my text here");
            Console.WriteLine("\n" + sbArray[0][3] 
                                   + sbArray[0][4] 
                                   + sbArray[0][5] 
                                   + sbArray[0][6]);
            ////////////////////////////////////////

        }
    }
}