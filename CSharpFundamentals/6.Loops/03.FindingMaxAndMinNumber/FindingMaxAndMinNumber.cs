using System;

class FindingMaxAndMinNumber
{
    static long currentNumber;
    static long minNumber;
    static long maxNumber;

    static void Main()
    {
        Console.WriteLine("Reads a sequence of n integer numbers and return minimal and maximal of them.");
        Console.Write("Please input value for n: ");
        long nMyNumberN = long.Parse(Console.ReadLine());

        Console.WriteLine();

        for (long i = 1; i <= nMyNumberN; i++)
        {
            Console.Write("Enter the {0} number: ", i);
            currentNumber = long.Parse(Console.ReadLine());

            if (maxNumber < currentNumber)
            {
                maxNumber = currentNumber;
            }

            if (minNumber > currentNumber)
            {
                minNumber = currentNumber;
            }
        }
        Console.WriteLine("\nThe minimal number is:{0}", minNumber);
        Console.WriteLine("The maximal number is:{0}\n", maxNumber);
    }
}