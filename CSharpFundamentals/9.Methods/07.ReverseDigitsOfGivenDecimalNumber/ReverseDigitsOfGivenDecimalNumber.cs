using System;
using System.IO;

class ReverseDigitsOfGivenDecimalNumber
{
    //Write a method that reverses the digits of given decimal number. Example: 256 --->> 652

    static string inputNumberAsString;

    static void Main()
    {
        IsInputNumberValid();
    }

    static void IsInputNumberValid()
    {
        Console.Write("Please input value of number which digits will be reverse: ");
        inputNumberAsString = Console.ReadLine();

        decimal inputNumberAsDecimal;
        bool isNumberValid = decimal.TryParse(inputNumberAsString, out inputNumberAsDecimal);

        //If input number is valid returns number with reversed digits.
        if (isNumberValid)
        {
            decimal outputNumberAsDecimal = ReversingDigitsOfNumber(inputNumberAsString);
            Console.WriteLine("\nThe input number with reversed digits is: \'{0}\'\n", outputNumberAsDecimal);
        }

        //If input number is NOT valid ask for a new input number.
        else
        {
            Console.WriteLine("Invalid input number!Please try again!\n");
            IsInputNumberValid();
        }
    }

    static decimal ReversingDigitsOfNumber(string inputString) 
    {
        char[] charArray = new char[inputString.Length];

        using (StringReader readString = new StringReader(inputString))
        {
            readString.Read(charArray, 0, charArray.Length);
        }

        Array.Reverse(charArray);

        string reversedString = new string(charArray);

        decimal reversedNumber = decimal.Parse(reversedString);

        return reversedNumber;
    }
}
