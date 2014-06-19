using System;

class FindingIfBitOnPositonPIsOne
{
    static void Main()
    {
        Console.WriteLine("Checking if bit on position P(counting from 0) in an integer number V is '1'.\n");
        Console.Write("Please type an integer number V: ");
        int vNumberToCheck = int.Parse(Console.ReadLine());
        Console.Write("Please type the bit positon P: ");
        byte pPositionToCheck = byte.Parse(Console.ReadLine());
        int numberToThePowerOfP = (int)Math.Pow(2, pPositionToCheck);
        int resultOfBitwiseOperation = vNumberToCheck & numberToThePowerOfP;

        if (resultOfBitwiseOperation != 0)
        {
            Console.WriteLine("\nThe bit P(counting from 0) is '1'.");
        }
        else
        {
            Console.WriteLine("\nThe bit P(counting from 0) is NOT '1'.");
        }
    }
}