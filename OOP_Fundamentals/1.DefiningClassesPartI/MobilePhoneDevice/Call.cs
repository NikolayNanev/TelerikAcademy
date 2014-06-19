using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    //Task 8:Create a class Call to hold a call performed through a GSM. 
    //It should contain date, time, dialed phone number and duration (in seconds).

    public class Call
    {
        private const double priceOfCall = 0.33;

        private DateTime? dateAndTime;
        private string dialedPhoneNumber;
        private int? duration;

        public DateTime? DateAndTime
        {
            get { return this.dateAndTime; }
            set { dateAndTime = value; }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set { dialedPhoneNumber = value; }
        }

        public int? Duration
        {
            get { return this.duration; }
            set { duration = value; }
        }

        public Call()
        {
            this.DateAndTime = null;
            this.Duration = null;
            this.DialedPhoneNumber = null;
        }

        public Call(DateTime dateAndTimeNow, int duration, string dialedPhoneNumber)
        {
            this.DateAndTime = dateAndTimeNow;
            this.Duration = duration;
            this.DialedPhoneNumber = dialedPhoneNumber;
        }

        //Task 11:Add a method that calculates the total price of the calls in the call history. 
        //Assume the price per minute is fixed and is provided as a parameter

        public double CalculatePrice() 
        {
            return ((double)Duration) / 60 * priceOfCall;
        }
    }
}
