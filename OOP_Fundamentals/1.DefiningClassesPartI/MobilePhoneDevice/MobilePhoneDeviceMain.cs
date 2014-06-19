using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    public class MobilePhoneDeviceMain
    {
        static void Main()
        {
            //Task 4
            GSMOverrideMethodToString();

            //Task 6 & 7
            InformationAboutIPhone4S();

            //Task 7:
            GSMTest.arrayWithGSMinstances[0].ToString();
            GSMTest.arrayWithGSMinstances[1].ToString();
            GSMTest.arrayWithGSMinstances[2].ToString();                   
        }

        //Task 4: Initializing class GSM and using ToString() to print information for instance "mySamsungMobileDevice"
        private static void GSMOverrideMethodToString()
        {
            GSM mySamsungMobileDevice = new GSM("Samsung Galaxy Duos", "Samsung", 349.99m, "Petur Petrov");

            mySamsungMobileDevice.battery.ModelOfBattery = "CL-8974656";
            mySamsungMobileDevice.battery.HoursIdle = 150;
            mySamsungMobileDevice.battery.HoursTalk = 20;
            mySamsungMobileDevice.battery.TypeOfBattery = BatteryType.NiCd;


            mySamsungMobileDevice.display.SizeOfDisplay = 3;
            mySamsungMobileDevice.display.NumberOfColors = 10;


            mySamsungMobileDevice.ToString();
            Console.WriteLine("\nNext task:\n");
        }

        //Task 6: Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S
        private static void InformationAboutIPhone4S()
        {
            GSM IPhone4S = GSM.IPhone4S;
            IPhone4S.Owner = "Ideal Petrov";

            IPhone4S.ToString();
        }       
    }
}