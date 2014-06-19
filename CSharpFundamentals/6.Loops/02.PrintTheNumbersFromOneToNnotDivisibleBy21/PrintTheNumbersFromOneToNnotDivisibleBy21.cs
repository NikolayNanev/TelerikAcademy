using System;

class PrintTheNumbersFromOneToNnotDivisibleBy21
{
    static void Main()
    {
        //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.


        Console.WriteLine("Printing all the numbers from 1 to n that aren't divisible by 3 and 7 at the same time.");

        Console.Write("Please input an integer n: ");
        int nMyNumberN = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int i = 1; i <= nMyNumberN; i++)
        {
            if (i % 21 != 0)
            {
                Console.Write(i + " ");
            }         
        }
        Console.WriteLine("\n");
    }
}