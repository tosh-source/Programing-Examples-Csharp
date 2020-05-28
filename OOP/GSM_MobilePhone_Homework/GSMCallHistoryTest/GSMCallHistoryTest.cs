using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkMobilePhone;

namespace GSMCallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main(string[] args)
        { //Problem 12. Call history test

            //12.1 Create an instance of the GSM class.
            GSM s8 = new GSM("Galaxy S8 Plus", "Samsung", "600$", owner: "Ben",
                                batterySpec: new Battery { BatteryModel = "Samsung 3500mAh battery", HoursIdle = 96, HoursTalk = 27, BatteryType = BatteryType.LiIon },
                                displaySpec: new Display());

            //12.2 Add few calls.
            int countOfCalls = 7;
            Call[] allCalls = new Call[countOfCalls];
            int clientPhoneNumber = 889977550;

            //set calls and their duration time//
            for (int index = 0; index < countOfCalls; index++)
            {
                clientPhoneNumber = clientPhoneNumber + index;                //simple random number adding
                allCalls[index] = new Call();
                allCalls[index].DialedPhoneNumber = "0" + clientPhoneNumber;

                allCalls[index].Duration = 10 + index * 2;                       //duration is in seconds (start from 10 seconds for first call and increase for the next one)
            }

            s8.AddCalls(allCalls);

            //12.3 Display the information about the calls.
            Console.WriteLine(s8.CallHistoryToString());

            //12.4 Calculate and print the total price of the calls in the history. (the price per minute is 0.37$)
            Console.WriteLine("Total price of calls: " +
                               s8.CalculateTotalPrice(pricePerMinute: 0.37m) +
                               "$");

            //12.5 Remove the longest call from the history and calculate the total price again.

            //manually set duration time for testing purpose//
            allCalls[0].Duration = 480;  //set first call(889977550) to 8 min (this call duration, should be the longest one)

            //order by duration time (with lambda expression)
            var orderedCall = allCalls.OrderBy(x => x.Duration);
            var longestCall = orderedCall.Last();

            allCalls = orderedCall.ToArray();

            //add new ordered call history and delete the longest one
            s8.ClearCallHistory();
            s8.AddCalls(allCalls);
            s8.DeleteCalls(longestCall.DialedPhoneNumber);

            //calculate the total price 
            Console.WriteLine("Total price of calls: " +
                               s8.CalculateTotalPrice() +
                               "$ (new calculation)");

            //12.6 Finally clear the call history
            s8.ClearCallHistory();
        }
    }
}
