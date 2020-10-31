using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class SimpleAbstraction
    {
        static void Main(string[] args)
        {
            int[] intsArr = { 1, 2, 3, 4, 5 };
            string[] stringsArr = {"AA", "BB", "CC", "DD" };
            IList<string> listOfStr = stringsArr.ToList();

            Console.WriteLine(PrintAnyCollections(intsArr));
            Console.WriteLine(PrintAnyCollections(stringsArr));
            Console.WriteLine(PrintAnyCollections(listOfStr));
        }

        public static string PrintAnyCollections<T>(IEnumerable<T> collection)  //Use more abstractive class/interface as IEnumerable<T>, ICollection<T> and etc., instead of List<T> and so on..
        {
            string result = string.Empty;
            foreach (var currentItem in collection)
            {
                result += currentItem + Environment.NewLine;  //Using directly Console.WriteLine() is not very abstractive! So return value as string is used instead! 
            }

            return result;
        }
    }
}
