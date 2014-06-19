using System;

class FindingIfThirdBitIsOneOrZero
{
    static void Main()
    {
        Console.WriteLine("Checking the third bit (counting from 0) to find if it is '1' or '0'.\n");
        Console.Write("Please type a integer number: ");
        int numberToCheck = int.Parse(Console.ReadLine());
        int resultOfBitwiseOperation = numberToCheck & 8;

        if (resultOfBitwiseOperation == 0)
        {
            Console.WriteLine("\nThe third bit (counting from 0) is '0'.");
        }
        else
        {
            Console.WriteLine("\nThe third bit (counting from 0) is '1'.");
        }
    }
}