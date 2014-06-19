using System;

class NumberConvertingHexadecimalToDecimal
{
    //Write a program to convert hexadecimal numbers to their decimal representation.

    static void Main()
    {
        Console.Write("Hexadecimal number: ");
        string hexadecimalNumber = Console.ReadLine();

        long decimalNumber = ConvertingHexadecimalToDecimal(hexadecimalNumber);

        Console.WriteLine("\nDecimal representation of \'{0}\': \'{1}\'.\n", hexadecimalNumber, decimalNumber);
    }

    static long ConvertingHexadecimalToDecimal(string hexadecimalStr)
    {
        long decimalNum = Convert.ToInt64(hexadecimalStr, 16);

        return decimalNum;
    }
}
