using System;

class ExchangingTwoIntegersIfFirstOneIsGreater
{
    static void Main()
    {
        Console.WriteLine("Exchanging two integer's values if the first one is greater.\n");
        Console.WriteLine("Please input two integer numbers:");

        Console.Write("Value of first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Value of second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int tempNumber;

        if (firstNumber > secondNumber)
        {
            tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;
        }

        Console.WriteLine("\nfirstNumber={0}\nsecondNumber={1}", firstNumber,secondNumber);
    }
}