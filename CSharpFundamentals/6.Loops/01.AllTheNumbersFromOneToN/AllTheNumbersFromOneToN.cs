using System;

class AllTheNumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Printing all the numbers from 1 to n [1...n]");

        Console.Write("Please input an integer n: ");
        ulong nMyNumberN = ulong.Parse(Console.ReadLine());

        for (ulong i = 1; i <= nMyNumberN; i++)
        {
            Console.Write(i + " ");          
        }
        Console.WriteLine("\n");
    }
}