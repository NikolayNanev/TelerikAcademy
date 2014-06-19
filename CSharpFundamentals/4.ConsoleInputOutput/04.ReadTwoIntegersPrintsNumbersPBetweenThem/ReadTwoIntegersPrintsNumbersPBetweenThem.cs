using System;

class ReadTwoIntegersPrintsNumbersPBetweenThem
{
    static void Main()
    {
        Console.WriteLine("Prints how many numbers P exist between two positive integer numbers \nthat the reminder of the division by 5 is 0 (inclusive).\n");
        Console.WriteLine("Please input the two positive integer numbers:");

        Console.Write("Value of first number: ");
        uint firstNumber = uint.Parse(Console.ReadLine());

        Console.Write("Value of second number: ");
        uint secondNumber = uint.Parse(Console.ReadLine());

        uint pNumbersBetween = 0;
        uint tempNumber;
        int iterations = 0;

        if (firstNumber > secondNumber)
        {
            tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;
        }

        for (uint i = firstNumber; firstNumber <= secondNumber; firstNumber++)
        {
            iterations++;
            if (firstNumber % 5 == 0)
            {
                pNumbersBetween++;
            }
        }
        Console.WriteLine("p({1},{2}) = {0}", pNumbersBetween, firstNumber - iterations, secondNumber);
    }
}