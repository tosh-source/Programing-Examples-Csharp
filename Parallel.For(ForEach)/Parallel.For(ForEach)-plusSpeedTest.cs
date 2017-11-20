using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks; //<- this library should be activated for static method "Parallel"!

class Parallel_For_ForEach
{
    static void Main(string[] args)
    {
        //Parallel.For(ForEach), a multi-thread variant of loop
        ///////////////////////////////////////////////////////
        //NOTE: "Parallel.Loops" is faster than traditional loop.
        //NOTE: "Parallel.Loops" will NOT execute in sequence order. So the output result will be different any time!

        Console.WriteLine("Parallel.For..");
        //////////////////////////
        int n = 7;
        Parallel.For(0, n, i =>
        {
            Console.WriteLine(i);
        });
        //////////////////////////

        Console.WriteLine("\nParallel.ForEach..");
        //////////////////////////////////////
        int[] numbs = { 1, 2, 3, 4, 5, 6, 7 };
        Parallel.ForEach(numbs, item =>
        {
            Console.WriteLine(item);
        });
        //////////////////////////////////////


        //II.Multi-thread variant of "foreach" in ORDERED sequence
        Console.WriteLine("\nForeach in ORDERED sequence..");
        //////////////////////////////////////////////////////////////////////
        foreach (var item in Enumerable.Range(0, 10).AsParallel().AsOrdered())  //Parallel in Mono will NOT work (for now)! The speed is like normal "foreach"!
        {
            Console.WriteLine(item);
        }
        //////////////////////////////////////////////////////////////////////


        //IIa.Speed Test of ORDERED foreach loop
        Stopwatch sw = new Stopwatch();
        long plus = 1;
        long plus2 = 1;

        Console.WriteLine("\nSpeed test (about 30 sec)..");
        sw.Start();
        foreach (var item in Enumerable.Range(0, 2000000000).AsParallel().AsOrdered())  //Parallel in Mono will NOT work (for now)! The speed is like normal "foreach" (see next loop)!
        {
            plus += plus;
        }
        Console.WriteLine(sw.Elapsed);

        sw.Start();
        foreach (var item in Enumerable.Range(0, 2000000000))
        {
            plus2 += plus2;
        }
        Console.WriteLine(sw.Elapsed);
    }
}

//For more information: https://msdn.microsoft.com/en-us/library/ff963552.aspx
