using System;

class ExchangingBits
{
    static void Main()
    {
        Console.WriteLine("Exchangeing the  3,4 and 5 bits of a given integer with it's 24, 25 and 26 bits.\n");
        Console.Write("Please type an integer number: ");
        uint number = uint.Parse(Console.ReadLine());

        byte firstPosition3 = 3;
        byte secondPosition24 = 24;

        uint maskBeginning1 = 7u << firstPosition3;
        uint maskEnd1 = 7u << secondPosition24;

        uint getBeginningNumbers = number & maskBeginning1;
        uint getEndNumbers = number & maskEnd1;
        uint changeNumbers = (number & ~maskBeginning1) & ~maskEnd1;

        uint maskBeginning2 = (getBeginningNumbers >> firstPosition3) << secondPosition24;
        uint maskEnd2 = (getEndNumbers >> secondPosition24) << firstPosition3;
        uint newExchangedNumber = (changeNumbers | maskBeginning2) | maskEnd2;

        Console.WriteLine("\nThe new integer number with exchanged bits is \'{0}\'.", newExchangedNumber);
    }
}