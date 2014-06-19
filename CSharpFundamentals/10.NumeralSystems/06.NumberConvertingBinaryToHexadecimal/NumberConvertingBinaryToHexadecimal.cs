using System;

class NumberConvertingBinaryToHexadecimal
{
    //Write a program to convert binary numbers to hexadecimal numbers (directly).

    static void Main()
    {
        Console.Write("Binary number: ");
        string binaryNumber = Console.ReadLine();

        string hexadecimalNumber = ConvertingBinaryToHexadecimal(binaryNumber);

        Console.WriteLine("\nHexadecimal representation of \'{0}\': \'{1}\'.\n", binaryNumber, hexadecimalNumber);
    }

    static string ConvertingBinaryToHexadecimal(string binaryNum)
    {
        string hexadecimalStr = Convert.ToString(Convert.ToInt64(binaryNum, 2), 16);

        return hexadecimalStr;
    }
}
