using System;
using System.Linq;

class Sorting3RealValuesInDescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Sorting three real values of numbers in descending order.\n");
        Console.WriteLine("Please input three real numbers:");

        Console.Write("Value of first real number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Value of second real number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Value of third real number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double[] myArreyOfNumbers = { firstNumber, secondNumber, thirdNumber };

        double firstSmallestNumber = myArreyOfNumbers.Min();
        double? secondSmallestNumber = null;
        double? thirdSmallestNumber = null;
      
        if (firstSmallestNumber == firstNumber)
        {
            if (secondNumber<thirdNumber)
            {
                secondSmallestNumber = secondNumber;
                thirdSmallestNumber = thirdNumber;
            }
            else
            {
                secondSmallestNumber = thirdNumber;
                thirdSmallestNumber = secondNumber;   
            }
        }

        if (firstSmallestNumber == secondNumber)
        {
            if (firstNumber < thirdNumber)
            {
                secondSmallestNumber = firstNumber;
                thirdSmallestNumber = thirdNumber;
            }
            else
            {
                secondSmallestNumber = thirdNumber;
                thirdSmallestNumber = firstNumber;
            }
        }

        if (firstSmallestNumber == thirdNumber)
        {
            if (firstNumber < secondNumber)
            {
                secondSmallestNumber = firstNumber;
                thirdSmallestNumber = secondNumber;
            }
            else
            {
                secondSmallestNumber = secondNumber;
                thirdSmallestNumber = firstNumber;
            }
        }

        Console.WriteLine("The values of the numbers in descending order are: {0} {1} {2}",firstSmallestNumber, secondSmallestNumber, thirdSmallestNumber);
    }
}