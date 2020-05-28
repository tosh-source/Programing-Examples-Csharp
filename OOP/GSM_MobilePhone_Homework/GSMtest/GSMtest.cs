using HomeworkMobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GSMtest
{
    class GSMtest
    {
        static void Main(string[] args)
        {
            //Define array of devices (GSMs)
            var gsm = new GSM[2];

            //First GSM
            gsm[0] = new GSM("S 7 Edge", "Samsung", "500$", owner: "Frank", batterySpec: new Battery(), displaySpec: new Display());
            Console.WriteLine("First GSM\n" + gsm[0].ToString());

            //Second GSM
            gsm[1] = new GSM("S 7 Edge", "Samsung", "500$", owner: "Frank",
                                batterySpec: new Battery { BatteryModel = "Samsung 3600mAh battery", HoursIdle = 96, HoursTalk = 27, BatteryType = BatteryType.LiIon },
                                displaySpec: new Display());
            Console.WriteLine("\nSecond GSM\n" + gsm[1].ToString());

            //Third GSM
            Console.WriteLine("\n" + GSM.IPhone4S);

            //Manipulate Call (history) class
            Call call = new Call();
            call.DialedPhoneNumber = "0888997766";
            Console.WriteLine(call.Date);
            Console.WriteLine(call.DialedPhoneNumber);

            gsm[1].AddCalls(call);                  //add call
            Console.WriteLine(gsm[1].CallHistoryToString());
            gsm[1].DeleteCalls("0888997766");       //delete call by given number
            Console.WriteLine(gsm[1].CallHistoryToString());
            gsm[1].ClearCallHistory();              //delete all calls from history

            //Check ENCAPSULATION in CallHistory property (in GSM class)
            //========================================
            //gsm[1].CallHistory.Add(new Call());
            //foreach (var item in gsm[1].CallHistory)
            //{
            //    Console.WriteLine(item);
            //}
            //========================================
            //Note: replace "return new List<Call>(this.callHistory);" with -> "return this.callHistory;" in CallHistory property and run above commented code again.

        }
    }
}
