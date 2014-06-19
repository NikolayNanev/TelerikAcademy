using System;

class GetFromAGivenIntegerТheValueOfGivenBit
{
    static void Main()
    {
        Console.WriteLine("Determining the bit value of a given bit position B in a given integer number I.\n");
        Console.Write("Please type an integer number I: ");
        int iNumberToCheck = int.Parse(Console.ReadLine());
        Console.Write("Please type the bit positon B: ");
        byte bPositionToCheck = byte.Parse(Console.ReadLine());

        int myBitwiseNumber = 1;
        int mask = myBitwiseNumber << bPositionToCheck;
        int valueOfBitOnPositionB = ((iNumberToCheck & mask) != 0 ? 1 : 0);

        Console.WriteLine("The bit on position \'{1}\' in the integer number \'{2}\' has value of \'{0}\'.", valueOfBitOnPositionB, bPositionToCheck, iNumberToCheck);
    }
}