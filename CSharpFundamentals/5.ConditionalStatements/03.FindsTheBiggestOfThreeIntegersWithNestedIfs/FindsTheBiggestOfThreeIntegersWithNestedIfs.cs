using System;

class FindsTheBiggestOfThreeIntegersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Finds the biggest of three integers using nested if statements.\n");
        Console.WriteLine("Please input three integer numbers:");

        Console.Write("Value of first integer number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Value of second integer number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Value of third integer number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        string biggestIntegerNumber = "null";

        if (firstNumber == secondNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("\nAll numbers are equal.\n");
            biggestIntegerNumber = "all are equal";
        }
        if (firstNumber == secondNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("\nThe first number and the second number are equal and bigger then the third number.\n");
            biggestIntegerNumber = "the first number and the second number";
        }

        if (firstNumber == secondNumber && secondNumber < thirdNumber)
        {
            Console.WriteLine("\nThe third number is the biggest number.\n");
            biggestIntegerNumber = "the third number";
        }

        if (firstNumber == thirdNumber && firstNumber > secondNumber)
        {
            Console.WriteLine("\nThe first number and the third number are equal and bigger then the second number.\n");
            biggestIntegerNumber = "the first number and the third number";
        }
        if (firstNumber == thirdNumber && firstNumber < secondNumber)
        {
            Console.WriteLine("\nThe second number is the biggest number.\n");
            biggestIntegerNumber = "the second number";
        }

        if (secondNumber == thirdNumber && secondNumber > firstNumber)
        {
            Console.WriteLine("\nThe second number and the third number are equal and bigger then the first number.\n");
            biggestIntegerNumber = "the second number and the third number";
        }
        if (secondNumber == thirdNumber && secondNumber < firstNumber)
        {
            Console.WriteLine("\nThe first number is the biggest number.\n");
            biggestIntegerNumber = "the first number";
        }

        if (biggestIntegerNumber == "null")
        {
            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    biggestIntegerNumber = "The first number is the biggest number.";
                }
                else
                {
                    biggestIntegerNumber = "The third number is the biggest number.";
                }
            }

            else if (secondNumber > thirdNumber)
            {
                biggestIntegerNumber = "The second number is the biggest number.";
            }

            else if (secondNumber < thirdNumber)
            {
                biggestIntegerNumber = "The third number is the biggest number.";
            }

            Console.WriteLine("\n{0}\n", biggestIntegerNumber);        
        }
    }
}