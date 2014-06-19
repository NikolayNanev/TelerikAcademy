using System;

class GetNumbersAndCalculateTheirSum
{
    static void Main()
    {
        Console.Write("Input first number n: ");
        decimal firstNumberToInput = decimal.Parse(Console.ReadLine());
        decimal sumOfNumbers = firstNumberToInput;

        while (true)
        {
            Console.Write("\nInput next number n: ");
            decimal numberToInput = decimal.Parse(Console.ReadLine());
            sumOfNumbers = sumOfNumbers + numberToInput;

            Console.WriteLine("The SUM of numbers n so far is:{0}",sumOfNumbers);
        }       
    }
}