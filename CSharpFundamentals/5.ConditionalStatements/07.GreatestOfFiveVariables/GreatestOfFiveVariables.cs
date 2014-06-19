using System;

class GreatestOfFiveVariables
{
    static void Main()
    {
        Console.WriteLine("Printing the greatest of given 5 variables.\n");
        Console.WriteLine("Please input the following  information:");

        Console.Write("Value of first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());

        Console.Write("Value of second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        Console.Write("Value of  third number: ");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());

        Console.Write("Value of fourth number: ");
        decimal fourthNumber = decimal.Parse(Console.ReadLine());

        Console.Write("Value of fifth number: ");
        decimal fifthNumber = decimal.Parse(Console.ReadLine());

        decimal maxNumber = Math.Max(Math.Max(Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber), fourthNumber), fifthNumber);

        Console.WriteLine("\nThe greatest of the 5 given variables is \'{0}\'.", maxNumber);
    }
}