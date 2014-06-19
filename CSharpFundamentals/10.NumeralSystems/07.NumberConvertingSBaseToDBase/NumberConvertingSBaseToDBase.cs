using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberConvertingSBaseToDBase
{
    //Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

    static void Main()
    {
        Console.Write("Plese specify base S:");
        int valueOfBaseS = int.Parse(Console.ReadLine());

        Console.Write("Plese specify base D:");
        int valueOfBaseD = int.Parse(Console.ReadLine());

        Console.Write("\nPlease input number in a valid format ({0}): ", valueOfBaseS);
        string numberInBaseS = Console.ReadLine();

        string numberInBaseD = ConvertingFromBaseSToBaseD(valueOfBaseS, valueOfBaseD, numberInBaseS);

        Console.WriteLine("\n\'{0}\'({1}) --->> \'{2}\'({3}).\n", numberInBaseS, valueOfBaseS, numberInBaseD, valueOfBaseD);
    }

    static string ConvertingFromBaseSToBaseD(int baseS, int baseD, string stringInBaseS) 
    {
        string stringInBaseD = Convert.ToString(Convert.ToInt64(stringInBaseS, baseS), baseD);

        return stringInBaseD;
    }
}