using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixKey_PairedWithGenericMatrixValue_Dictionary_Tuple_
{
    class KeyValuePairMatrices
    {
        static void Main()
        {
            //1.Crate Matrix paired with integer values.
            var integerValues = new int[,]
                {
                { 11, 22, 33 },
                { 44, 55, 66 },
                { 77, 88, 99 }
                };

            var matrixWithIntValues = CreateMatrixPairedWithValues<int>(integerValues);
            //1a. Key as "matrix[row,col]"
            Console.WriteLine(matrixWithIntValues[Tuple.Create(2, 2)]);

            //2.Crate Matrix paired with integer values.
            var stringValues = new string[,]
                {
                { "Abbey", "Kabili", "Fabio" },
                { "Jabari", "Earnest", "Gabriel" },
                { "Zahari", "Adrianne", "Vadin" }
                };

            var matrixWithStrValues = CreateMatrixPairedWithValues<string>(stringValues);
            //2a. Key as "matrix[row,col]"
            Console.WriteLine(matrixWithStrValues[Tuple.Create(2, 2)]);
            Console.WriteLine(matrixWithStrValues[Tuple.Create(1, 1)]);
        }

        private static Dictionary<Tuple<int, int>, T> CreateMatrixPairedWithValues<T>(T[,] values)
        {
            var query =
                from row in Enumerable.Range(0, values.GetLength(0))
                from col in Enumerable.Range(0, values.GetLength(1))
                select new KeyValuePair<Tuple<int, int>, T>
                    (
                        Tuple.Create(row, col),
                        values[row, col]
                    );

            var matrixWithValue = query.ToDictionary(keyValuePair => keyValuePair.Key, keyValuePair => keyValuePair.Value);

            return matrixWithValue;
        }
    }
}

//https://stackoverflow.com/questions/15252768/storing-matrix-in-a-c-sharp-dictionary