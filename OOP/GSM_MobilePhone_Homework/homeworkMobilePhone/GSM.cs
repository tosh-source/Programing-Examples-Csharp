using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace HomeworkMobilePhone
{
    public class GSM
    {
        //Fields
        private static GSM iPhone4S;
        private string model;
        private string manufacturer;
        private string price;
        private string owner;
        private Battery batterySpec;
        private Display displaySpec;
        private List<Call> callHistory;

        //Properties
        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public string Model
        {
            get { return model; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                manufacturer = value;
            }
        }

        public string Price
        {
            get { return price; }

            set
            {
                if (value == null)  //this is only to prevent "ArgumentNullException"
                {

                }
                else if (!(Regex.IsMatch(value, @"\d")))  //check if there is no digit
                {
                    throw new ArgumentException();
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get { return owner; }

            set
            {
                if (value == string.Empty)  //In C# when value(string) == null, the "if" statement will simply return false. Unlike Java, same condition will throw an exception!!
                {
                    throw new ArgumentException();
                }

                this.owner = value;
            }
        }

        public Battery BatterySpec
        {
            get { return batterySpec; }

            set
            {
                this.batterySpec = value;
            }
        }

        public Display DisplaySpec
        {
            get { return displaySpec; }

            set
            {
                this.displaySpec = value;
            }
        }

        public List<Call> CallHistory  //See video (time 1:06:57) "OOP 2015 -> Съботен Workshop -> Домашно - Дефиниране на класове - част 1 - 21 март 2015 - Евлоги.mp4"
        {                              //or follow link (time 1:06:57) : https://my.telerikacademy.com/Courses/LectureResources/Video/6115/%d0%92%d0%b8%d0%b4%d0%b5%d0%be-21-%d0%bc%d0%b0%d1%80%d1%82-2015-%d0%95%d0%b2%d0%bb%d0%be%d0%b3%d0%b8
            get
            {
                return new List<Call>(this.callHistory); //This technique is ENCAPSULATION, and is needed to prevent direct access to the object, when we get information. Unless we have a special method for this operation, created by us (e.g.: Add, Adding, AddCallInfo and so on).
            }
            set
            {
                if (this.callHistory == null)
                {
                    this.callHistory = new List<Call>(); //if null, create an empty object " List<Call>()"
                }

                this.callHistory.Clear();  //then, if there is previous elements, clear it..
                this.callHistory = value;  //after that, assign the value
            }
        }

        //Constructors
        static GSM()  //This is a static constructor, for IPhone4S field & property.
        {
            iPhone4S = new GSM("IPhone 4S", "Apple", "500$", "Me",
                                new Battery { BatteryModel = "Apple 1430 mAh battery", BatteryType = BatteryType.LiIon, HoursIdle = 200, HoursTalk = 8 },
                                new Display { DisplaySize = "3.5-inch (diagonal) Multi-Touch display", DisplayColors = "16M" });
        }

        public GSM(string model, string manufacturer) : this(model, manufacturer, null, null, null, null)
        {

        }
        public GSM(string model, string manufacturer, string price = null, string owner = null, Battery batterySpec = null, Display displaySpec = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.BatterySpec = batterySpec;
            this.DisplaySpec = displaySpec;
            this.CallHistory = new List<Call>(); //The List of objects (List<Call>) can NOT be null, so we need to initialize it here.
        }

        //Methods
        public static void Main(string[] args)
        {

        }

        public void AddCalls(params Call[] calls) //Adding information to CallHistory
        {
            foreach (var call in calls)
            {
                this.callHistory.Add(call);
            }
        }
        public void DeleteCalls(string numberForDeleting)
        {
            Call tempCall = new Call();
            tempCall.DialedPhoneNumber = numberForDeleting;

            bool isMatch = false;

            for (int index = 0; index < this.callHistory.Count; index++)
            {
                isMatch = this.callHistory[index].DialedPhoneNumber == tempCall.DialedPhoneNumber;

                if (isMatch == true)
                {
                    this.callHistory.Remove(this.callHistory[index]);
                }
            }
        }
        public void ClearCallHistory()  //Clear CallHistory information
        {
            this.callHistory.Clear();
        }

        public decimal CalculateTotalPrice(decimal pricePerMinute = 0.37m)
        {
            decimal totalPrice = 0;
            foreach (var call in this.callHistory)
            {
                totalPrice += (pricePerMinute / 60) * call.Duration;  //Note that "Duration" is in seconds
            }                                                         //EXAMPLE: if price per minute is: 0.25$ (0.25/60 = 0.00416$ per second)

            return decimal.Round(totalPrice, 3);
        }

        public string CallHistoryToString()
        {
            string result = string.Empty;
            result = string.Join("", this.CallHistory);   //or use "foreach" loop intead of string.Join()

            return result;
        }

        //Override methods
        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("Model: " + this.Model);
            result.AppendLine("Manufacturer: " + this.Manufacturer);
            result.AppendLine("Price: " + this.Price);
            result.AppendLine("Owner: " + this.Owner);
            result.AppendLine("Battery Specification: " + this.BatterySpec);
            result.AppendLine("Display Specification: " + this.DisplaySpec);
            result.AppendLine("Call history information: " + string.Join("", this.CallHistory));

            return result.ToString();
        }
    }
}
