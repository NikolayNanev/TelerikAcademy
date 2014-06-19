using System;

class PrintsTheGreaterOfTwoNumbersNoIfStatement
{
    static void Main()
    {
        Console.WriteLine("Printing the greater of two numbers without using an if statement.");
        Console.Write("Value of first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Value of second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        double greaterOfTwoNumbers = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater of the two numbers \'{0}\' and \'{1}\' is \'{2}\'.", firstNumber, secondNumber, greaterOfTwoNumbers);
    }
}