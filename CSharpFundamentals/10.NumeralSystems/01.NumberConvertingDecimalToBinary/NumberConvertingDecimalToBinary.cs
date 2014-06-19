using System;

class NumberConvertingDecimalToBinary
{
    //Write a program to convert decimal numbers to their binary representation.

    static void Main()
    {
        Console.Write("Decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        string binaryNumber = ConvertingDecimalToBinary(decimalNumber);

        Console.WriteLine("\nBinary representation of \'{0}\': \'{1}\'.\n", decimalNumber, binaryNumber);
    }

    static string ConvertingDecimalToBinary(long decimalNum) 
    {
        string binaryStr = Convert.ToString(decimalNum, 2);

        return binaryStr;
    }
}