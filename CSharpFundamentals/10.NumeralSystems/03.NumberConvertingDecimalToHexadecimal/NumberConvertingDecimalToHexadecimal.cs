using System;

class NumberConvertingDecimalToHexadecimal
{
    //Write a program to convert decimal numbers to their hexadecimal representation.

    static void Main()
    {
        Console.Write("Decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        string binaryNumber = ConvertingDecimalToHexadecimal(decimalNumber);

        Console.WriteLine("\nHexadecimal representation of \'{0}\': \'{1}\'.\n", decimalNumber, binaryNumber);
    }

    static string ConvertingDecimalToHexadecimal(long decimalNum)
    {
        string binaryStr = Convert.ToString(decimalNum, 16);

        return binaryStr;
    }
}