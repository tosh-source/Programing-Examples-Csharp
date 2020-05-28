using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMobilePhone
{
    public class Call
    {
        //Fields
        private DateTime date;
        private DateTime time;
        private string dialedPhoneNumber;
        private decimal duration;  //duration in seconds

        //Property
        public string Date
        {
            get
            {
                return this.date.ToString("dd-MM-yyyy");
            }
        }

        public string Time
        {
            get
            {
                return this.time.ToString("HH.mm:ss");
            }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            set
            {
                this.dialedPhoneNumber = value;
            }
        }

        public decimal Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        //Def. constructor
        public Call()
        {
            this.date = DateTime.Now; //When create new instance of Call, date and time is set now.
            this.time = DateTime.Now;
        }

        public override string ToString()
        {
            string result = string.Empty;

            if (DialedPhoneNumber != null)
            {
                result += "Dialed phone number: " + this.DialedPhoneNumber + Environment.NewLine;
            }

            if (Duration != 0)
            {
                result += "Call duration: " + this.Duration + Environment.NewLine;
            }

            result += "Call date: " + this.Date + Environment.NewLine;
            result += "Call time: " + this.Time + Environment.NewLine;

            return result;
        }
    }
}
