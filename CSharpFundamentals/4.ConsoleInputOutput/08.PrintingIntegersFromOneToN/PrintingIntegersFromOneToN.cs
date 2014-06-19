using System;

class PrintingIntegersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Printing integers from one to n [1...n] each on a single line.");
        Console.Write("Please input an integer n: ");
        uint nMyInteger = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= nMyInteger; i++)
        {
            Console.WriteLine(i);
        }
    }
}