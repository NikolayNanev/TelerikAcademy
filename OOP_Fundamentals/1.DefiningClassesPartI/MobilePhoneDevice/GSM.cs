using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        
        public Battery battery = new Battery();
        public Display display = new Display();

        //Task 9
        private List<Call> callHistory;

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("\n\nNot a valid model of Mobile device\n");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("\n\nNot a valid manufacturer of Mobile device\n");
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("\n\nPrice must have positive value.\n");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set { owner = value; }
        }

        //Task 9
        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

        //Task 10
        public void RemoveCall(Call call) 
        {
            //CallHistory.Remove

            foreach (var item in CallHistory)
            {
                if (item.DateAndTime == call.DateAndTime)
	            {
                    CallHistory.Remove(item);
                    break;
	            }
            }
        }

        //Task 10
        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        //Task 10
        public void ClearHistory() 
        {
            CallHistory.Clear();
        }

        //Task 11:Add a method that calculates the total price of the calls in the call history. 
        //Assume the price per minute is fixed and is provided as a parameter
        public double CalculateHistoryPrice()
        {
            double result = 0;

            foreach (var item in CallHistory)
            {
                result += item.CalculatePrice();
            }

            return result;
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;           
        }

        public GSM(string model, string manufacturer, decimal? price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;

        }

        public GSM(string model, string manufacturer, decimal? price, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.battery = battery;
            this.display = display;
        }
       
        //Task 4: Overriding ToString() method
        public override string ToString()
        {
            Console.WriteLine("Information for GSM instance:");
            Console.WriteLine(" -Model: {0}", Model);
            Console.WriteLine(" -Manufacturer: {0}", Manufacturer);
            Console.WriteLine(" -Price: {0} lv.", Price);
            Console.WriteLine(" -Owner: {0}", Owner);

            Console.WriteLine("\nInformation for Battery:");
            Console.WriteLine(" -Model of battery: {0}", battery.ModelOfBattery);
            Console.WriteLine(" -HoursIdle time: {0} hour(s)", battery.HoursIdle);
            Console.WriteLine(" -HoursTalk time: {0} hour(s)", battery.HoursTalk);
            Console.WriteLine(" -Type of battery: {0}", battery.TypeOfBattery);

            Console.WriteLine("\nInformation for Display:");
            Console.WriteLine(" -Size of display: {0} inch(es)", display.SizeOfDisplay);
            Console.WriteLine(" -Colors of display: {0} million(s)", display.NumberOfColors);

            return base.ToString();
        }

        //Task 6:Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S
        private static GSM iPhone4S = new GSM("IPhone4S", "Apple", 599.99m, new Battery("CL-8974656",200,14,BatteryType.LiPo), new Display(3.5,16));

        public static GSM IPhone4S 
        {
            get { return iPhone4S; }
        }
     
    }
}