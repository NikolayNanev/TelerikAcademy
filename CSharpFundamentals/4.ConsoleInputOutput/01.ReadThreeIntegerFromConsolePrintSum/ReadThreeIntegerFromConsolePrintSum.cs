using System;

class ReadThreeIntegerFromConsolePrintSum
{
    static void Main()
    {
        Console.Write("Please input the first integer number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please input the second integer number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Please input the third integer number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int sumOfNumbers = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("\n{0} + {1} + {2} = {3}",firstNumber,secondNumber,thirdNumber, sumOfNumbers);
    }
}