using System;

class ComparingTwoFloatingPointNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter a second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        bool comparing = (Math.Abs(firstNumber - secondNumber) < 0.000001m);
        Console.WriteLine("The statement:\"The two numbers are equal with precision 0.000001 is:{0}:\"", comparing);        
    }
}