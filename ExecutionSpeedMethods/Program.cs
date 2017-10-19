using System;
using System.Collections.Generic;
using System.Diagnostics; //this library is needed to use "Stopwatch"
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //I.Check execution speed with "DateTime" method
        //NOTE: this method is good for basic needs
        int value = 35000;
        BigInteger factorial = 1;
        ///////////////////////////////////
        DateTime timeStart = DateTime.Now;
        for (int i = 1; i <= value; i++)
        {
            factorial = factorial * i;
        }
        DateTime timeStop = DateTime.Now;
        ///////////////////////////////////
        Console.WriteLine("Execution time from 1th example is: {0}", (timeStop - timeStart));


        //II.Check execution speed with "Stopwatch" method
        //NOTE: this method is more appropriate way for testing execution time
        factorial = 1;
        /////////////////////////////////////////////
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        for (int i = 1; i <= value; i++)
        {
            factorial = factorial * i;
        }
        //Use structure "TimeSpan" to get result from "Stopwatch.Elapsed" (with this property we get result of current execution time).
        TimeSpan swResult = stopWatch.Elapsed;
        //Or if you wont ONLY Milliseconds use ".ElapsedMilliseconds". 
        long swResultInMillis = stopWatch.ElapsedMilliseconds;
        //NOTE: The result will always be the same as ".Elapsed"!!!
        /////////////////////////////////////////////

        Console.WriteLine("Execution time from 2nd example is: {0}", swResult);
        Console.WriteLine("Execution time from 2nd example is: {0} seconds", (swResultInMillis / 1000.0));


    }
}

//NOTE: There is no need to use "Environment.TickCount" method to calculate 
//execution time, because the actual precision of it is about 15.6 ms !!!

//NOTE: for more details about different techniques, visit: https://stackoverflow.com/questions/243351/environment-tickcount-vs-datetime-now
