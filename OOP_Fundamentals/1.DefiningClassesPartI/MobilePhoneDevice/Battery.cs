using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MobilePhoneDevice
{
    //Task 3:Add an enumeration BatteryType
    public enum BatteryType 
    {
        [Description("Li-Ion")]
        LiIon, 
        NiMH, 
        NiCd,
        LiPo
    }

    //Task 1 :Define a class that holds information about battery characteristics
    public class Battery
    {
        private string modelOfBattery;
        private ushort? hoursIdle;
        private ushort? hoursTalk;

        public string ModelOfBattery 
        {
            get 
            {
                return this.modelOfBattery;
            }
            set 
            {
                this.modelOfBattery = value;
            }
        }

        public ushort? HoursIdle 
        {
            get { return this.hoursIdle; }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("\n\nHoursIdle time must have positive value.\n");
                }

                this.hoursIdle = value;
            }
        }

        public ushort? HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("\n\nHoursTalk time must have positive value.\n");
                }

                this.hoursTalk = value;
            }
        }

        //Task 3: New field for the batteries
        public BatteryType? TypeOfBattery { get; set; }

        //Task 2:Define several constructors
        public Battery()
        {

        }

        //Task 2:Define several constructors
        public Battery(string modelOfBattery, ushort? hoursIdle, ushort? hoursTalk, BatteryType? typeOfBattery)
        {
            this.ModelOfBattery = modelOfBattery;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.TypeOfBattery = typeOfBattery;
        }
    }
}