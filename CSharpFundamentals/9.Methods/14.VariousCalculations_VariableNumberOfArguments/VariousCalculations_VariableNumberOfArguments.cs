using System;

class VariousCalculations_VariableNumberOfArguments
{
    //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
    //Use variable number of arguments.

    static long lengthOfArray;

    static void Main()
    {
        InitializingLengthOfArray();

        long[] inputArray = InitializingElementsOfArray();

        long minimumNumberInArray = CalculatingMinimumNumber(inputArray);
        long maximumNumberInArray = CalculatingMaximumNumber(inputArray);
        long sumOfNumbersInArray = CalculatingSumOfNumbers(inputArray);
        decimal averageOfNumbersInArray = CalculatingAverageOfNumbers(inputArray);
        long productOfNumbersInArray = CalculatingProductOfNumbers(inputArray);

        PrintingArrayAndAnswers(inputArray, minimumNumberInArray, maximumNumberInArray, sumOfNumbersInArray, averageOfNumbersInArray, productOfNumbersInArray);

    }

    static void InitializingLengthOfArray()
    {
        bool checkForLengthOfArray = true;

        while (checkForLengthOfArray)
        {
            Console.Write("Please input the length of the array: ");
            lengthOfArray = long.Parse(Console.ReadLine());

            if (lengthOfArray < 0)
            {
                Console.WriteLine("The length of the array must be greater or equel to 0.\nPlease input the length of the array again!\n");
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

    static long CalculatingMinimumNumber(params long[] array) 
    {
        long minNum = long.MaxValue;

        foreach (long element in array)
        {
            if (element < minNum)
            {
                minNum = element;
            }
        }

        return minNum;
    }

    static long CalculatingMaximumNumber(params long[] array) 
    {
        long maxNum = long.MinValue;

        foreach (long element in array)
        {
            if (element > maxNum)
            {
                maxNum = element;
            }
        }

        return maxNum;
    }

    static long CalculatingSumOfNumbers(params long[] array) 
    {
        long sum = 0;

        foreach (long element in array)
        {
            sum += element;
        }

        return sum;
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

    static long CalculatingProductOfNumbers(params long[] array)
    {
        long product = 1;

        foreach (long element in array)
        {
            product *= element;
        }

        return product;
    }

    static void PrintingArrayAndAnswers(long[] inputArray, long minimumNumberInArray, long maximumNumberInArray, long sumOfNumbersInArray, decimal averageOfNumbersInArray, long productOfNumbersInArray)
    {
        Console.WriteLine("\nValues in array:");
        foreach (long item in inputArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("\nAnswers to various calculations:");
        Console.WriteLine("Minimum number: {0}", minimumNumberInArray);
        Console.WriteLine("Maximum number: {0}", maximumNumberInArray);
        Console.WriteLine("Sum of numbers: {0}", sumOfNumbersInArray);
        Console.WriteLine("Average of numbers: {0:0.000}", averageOfNumbersInArray);
        Console.WriteLine("Product of numbers: {0}\n", productOfNumbersInArray);
    }
}
