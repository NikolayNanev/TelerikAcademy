using System;

class FirstNnumbersOfFibonacciSequence
{
    static uint nMyNumberN;

    static void Main()
    {
        //Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci.

        Console.WriteLine("Printing the first N members of the Fibonacci sequence:");
 
        bool myCheckIfNisInRange = true;

        while (myCheckIfNisInRange)
        {    
            Console.Write("\nPlease input integer number N  in range N>=1: ");
            nMyNumberN = uint.Parse(Console.ReadLine());

            if (nMyNumberN < 1)
            {
                Console.WriteLine("\nError! Number N must be in range N>=1 ");
            }
            else
            {
                myCheckIfNisInRange = false;
            }
        }
    
        decimal firstFibonacciNumber = 0;
        decimal secondFibonacciNumber = 1;
        decimal nextFibonacciNumber;

        Console.WriteLine("F(0)={0}\nF(1)={1} ", firstFibonacciNumber, secondFibonacciNumber);

        for (uint i = 2; i <= nMyNumberN; i++)
        {
            nextFibonacciNumber = firstFibonacciNumber + secondFibonacciNumber;
            Console.WriteLine("F({1})={0}", nextFibonacciNumber, i);
            firstFibonacciNumber = secondFibonacciNumber;
            secondFibonacciNumber = nextFibonacciNumber;
        }
        Console.WriteLine();

    }
}