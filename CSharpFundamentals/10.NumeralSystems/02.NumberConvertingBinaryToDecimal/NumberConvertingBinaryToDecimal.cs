using System;

class NumberConvertingBinaryToDecimal
{
    //Write a program to convert binary numbers to their decimal representation.

    static void Main()
    {
        Console.Write("Binary number: ");
        string binaryNumber = Console.ReadLine();

        long decimalNumber = ConvertingBinaryToDecimal(binaryNumber);

        Console.WriteLine("\nDecimal representation of \'{0}\': \'{1}\'.\n", binaryNumber, decimalNumber);
    }

    static long ConvertingBinaryToDecimal(string binaryStr)
    {
        long decimalNum = Convert.ToInt64(binaryStr, 2);

        return decimalNum;
    }
}