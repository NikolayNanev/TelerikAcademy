using System;

class GreatestCommonDivisorOfTwoNumbers
{
    static void Main()
    {
        //Write a program that calculates the greatest common divisor of two numbers. Use the Euclidean algorithm.

        Console.WriteLine("Calculating the greatest common divisor of two numbers.\n");

        Console.WriteLine("Please input the information:");

        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine();

        if (firstNumber < secondNumber)
        {
            double tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;
        }

        double result;
        double resultRemainder;

        while (true)
        {
            result = firstNumber / secondNumber;
            resultRemainder = firstNumber % secondNumber;
            if (resultRemainder != 0)
            {
                Console.WriteLine("{0} : {1} = {2}  reminder = {3}", firstNumber, secondNumber, result, resultRemainder);
                firstNumber = secondNumber;
                secondNumber = resultRemainder;
            }
            else
            {
                Console.WriteLine("\nThe Greatest Common Divider is: {0}\n", secondNumber);
                break;
            }
        }
    }
}