using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    //Write a class GSMTest to test the GSM class:
    //  -Create an array of few instances of the GSM class.
    //  -Display the information about the GSMs in the array.
    //  -Display the information about the static property IPhone4S. 

    //WARNING: 
    //  !!!The information about the static property IPhone4S is put in the MAIN method!!!


    public class GSMTest
    {
        //GSM info
        static string[] modelsOfGSM = { "Samsung Galaxy 5 ", "Lumia 525", "IPhone 3" };
        static string[] manufacturersOfGSM = { "Samsung Group", "Nokia Oyj", "Apple Inc." };
        static decimal[] pricesOfGSM = { 400m, 450m, 500m };

        //Battery info
        static string[] modelsOfBatterys = { "CL-8988856", "CL-7831656", "CL-8264653" };
        static byte[] hoursIdle = { 140, 150, 170 };
        static byte[] hoursTalk = { 14, 15, 17 };

        //Display info
        static double[] sizeOfDisplay = { 2.9, 3.2, 3.4 };
        static byte[] numberOfColorsOfDisplay = { 12, 13, 14 };

        static public GSM[] arrayWithGSMinstances = new GSM[3]
        {
            new GSM(modelsOfGSM[0],manufacturersOfGSM[0],pricesOfGSM[0],new Battery(modelsOfBatterys[0],hoursIdle[0],hoursTalk[0],BatteryType.LiPo),new Display(sizeOfDisplay[0],numberOfColorsOfDisplay[0])),
            new GSM(modelsOfGSM[1],manufacturersOfGSM[1],pricesOfGSM[1],new Battery(modelsOfBatterys[1],hoursIdle[1],hoursTalk[1],BatteryType.NiMH),new Display(sizeOfDisplay[1],numberOfColorsOfDisplay[1])),
            new GSM(modelsOfGSM[2],manufacturersOfGSM[2],pricesOfGSM[2],new Battery(modelsOfBatterys[2],hoursIdle[2],hoursTalk[2],BatteryType.NiCd),new Display(sizeOfDisplay[2],numberOfColorsOfDisplay[2]))
        };
    }
}