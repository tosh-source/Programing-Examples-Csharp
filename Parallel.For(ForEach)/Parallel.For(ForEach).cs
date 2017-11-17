using System;
using System.Threading.Tasks; //<- this library should be activated!

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
        Parallel.For(0, n, i => {
            Console.WriteLine(i);
        });
        //////////////////////////

        Console.WriteLine("\nParallel.ForEach..");
        //////////////////////////////////////
        int[] numbs = { 1, 2, 3, 4, 5, 6, 7 };
        Parallel.ForEach(numbs, item => {
            Console.WriteLine(item);
        });
        //////////////////////////////////////
    }
}

//For more information: https://msdn.microsoft.com/en-us/library/ff963552.aspx
