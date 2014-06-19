using System;

class First100MembersOfFibonacciSequence
{
    static void Main()
    {
        Console.WriteLine("Printing the first 100 members of the Fibonacci sequence:");

        decimal firstFibonacciNumber = 0;
        decimal secondFibonacciNumber = 1;
        decimal nextFibonacciNumber;

        Console.WriteLine("F(0)={0}\nF(1)={1} ", firstFibonacciNumber, secondFibonacciNumber);

        for (int i = 2; i <= 99; i++)
        {
            nextFibonacciNumber = firstFibonacciNumber + secondFibonacciNumber;
            Console.WriteLine("F({1})={0}", nextFibonacciNumber,i);
            firstFibonacciNumber = secondFibonacciNumber;
            secondFibonacciNumber = nextFibonacciNumber;
        }
    }
}