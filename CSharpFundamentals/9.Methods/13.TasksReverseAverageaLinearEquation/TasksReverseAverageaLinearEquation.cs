using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class TasksReverseAverageaLinearEquation
{
    //Write a program that can solve these tasks:
    //   -Reverses the digits of a number
    //   -Calculates the average of a sequence of integers
    //   -Solves a linear equation a * x + b = 0
	//Create appropriate methods.Provide a simple text-based menu for the user to choose which task to solve.
	//Validate the input data:The decimal number should be non-negative,The sequence should not be empty,a should not be equal to 0

    static decimal inputNumber;
    static decimal reversedNumber;

    static long lengthOfArray;

    static decimal valueOfA;

    static void Main()
    {
        long codeOfAction = SpecifeingTypeOfAction();
    }

    static long SpecifeingTypeOfAction()
    {
        Console.Write("Please specify type of action (1,2 or 3):\n   1.Reverse the digits of a number\n   2.Calculate the average of a sequence of integers\n   3.Solve a linear equation a * x + b = 0\n\nWaiting for code of action: ");
        long codeOfAction = long.Parse(Console.ReadLine());

        if (codeOfAction == 1)
        {
            //Reverses the digits of a number

            decimal inputNumber = ValidatingTheDecimalNumberN();

            Console.WriteLine("\nThe reversed number of {0} is: {1}\n", inputNumber, reversedNumber);
        }

        else if (codeOfAction == 2)
        {
            //Calculates the average of a sequence of integers

            ValidatingLengthOfArray();
            long[] inputArray = InitializingElementsOfArray();

            decimal averageOfNumbersInArray = CalculatingAverageOfNumbers(inputArray);

            Console.WriteLine("\nThe average of the numbers in the array is: {0:0.00}", averageOfNumbersInArray);
        }

        else if (codeOfAction == 3)
        {
            //Solves a linear equation a * x + b = 0

            decimal valueOfA = ValidatingNumberA();

            Console.Write("Please input number \'b\' in the linear equation: ");
            decimal valueOfB = decimal.Parse(Console.ReadLine());

            decimal valueOfX = SolvingALinearEquation(valueOfA, valueOfB);

            Console.WriteLine("\nThe value of x is: {0:0.00}\n", valueOfX);
        }

        else
        {
            Console.WriteLine("Invalid code!Please try again!\n");
            codeOfAction = SpecifeingTypeOfAction();
        }

        return codeOfAction;
    }

    static decimal ValidatingTheDecimalNumberN()
    {
        Console.Write("\nPlease input number N you wish to be reversed(N>=0): ");
        inputNumber = decimal.Parse(Console.ReadLine());

        if (inputNumber >= 0)
        {
            string inputNumberAsString = inputNumber.ToString();
            reversedNumber = ReversingDigitsOfNumber(inputNumberAsString);
        }
        else
        {
            Console.WriteLine("Invalid input!Please try again!");
            ValidatingTheDecimalNumberN();
        }
        return inputNumber;
    }

    static decimal ReversingDigitsOfNumber(string inputString)
    {
        char[] charArray = new char[inputString.Length];

        using (StringReader readString = new StringReader(inputString))
        {
            readString.Read(charArray, 0, charArray.Length);
        }

        Array.Reverse(charArray);

        string reversedString = new string(charArray);

        decimal reversedNumber = decimal.Parse(reversedString);

        return reversedNumber;
    }

    static void ValidatingLengthOfArray()
    {
        bool checkForLengthOfArray = true;

        while (checkForLengthOfArray)
        {
            Console.Write("Please input the length of the array: ");
            lengthOfArray = long.Parse(Console.ReadLine());

            if (lengthOfArray <= 0)
            {
                Console.WriteLine("The length of the array must be greater than 0.\nPlease input the length of the array again!\n");
            }
            else
            {
                checkForLengthOfArray = false;
            }
        }
    }

    static long[] InitializingElementsOfArray()
    {
        long[] inputArray = new long[lengthOfArray];

        //long[] inputArray = { 8, 51, -11, 15, 21, 51, -25, -51 };

        Console.WriteLine();

        for (long index = 0; index < lengthOfArray; index++)
        {
            Console.Write("Value in array[{0}]= ", index);
            inputArray[index] = long.Parse(Console.ReadLine());
        }
        return inputArray;
    }

    static decimal CalculatingAverageOfNumbers(params long[] array)
    {
        long sum = 0;

        foreach (long element in array)
        {
            sum += element;
        }

        decimal average = (decimal)sum / array.Length;

        return average;
    }

    static decimal ValidatingNumberA() 
    {
        Console.Write("\nPlease input number \'a\' in the linear equation (a != 0): ");
        valueOfA = decimal.Parse(Console.ReadLine());

        if (valueOfA == 0)
        {
            Console.WriteLine("Invalid input!Please try again!");
            ValidatingNumberA();
        }

        return valueOfA;
    }

    static decimal SolvingALinearEquation(decimal a, decimal b) 
    {
        decimal value = -(b / a);

        return value;
    }
}