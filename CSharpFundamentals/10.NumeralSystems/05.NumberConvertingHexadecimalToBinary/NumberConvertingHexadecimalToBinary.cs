using System;

class NumberConvertingHexadecimalToBinary
{
    //Write a program to convert hexadecimal numbers to binary numbers (directly).

    static void Main()
    {
        Console.Write("Hexadecimal number: ");
        string hexadecimalNumber = Console.ReadLine();

        string binaryNumber = ConvertingHexadecimalToBinary(hexadecimalNumber);

        Console.WriteLine("\nBinary representation of \'{0}\': \'{1}\'.\n", hexadecimalNumber, binaryNumber);
    }
    
    static string ConvertingHexadecimalToBinary(string hexadecimalStr)
    {
        string binaryNum = Convert.ToString(Convert.ToInt64(hexadecimalStr, 16), 2);

        return binaryNum;
    }
}
