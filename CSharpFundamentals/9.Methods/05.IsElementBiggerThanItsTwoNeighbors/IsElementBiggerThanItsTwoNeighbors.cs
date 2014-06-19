using System;

class IsElementBiggerThanItsTwoNeighbors
{
    //Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors.

    static long lengthOfArray;

    static void Main()
    {
        InitializingLengthOfArray();

        long[] inputArray = InitializingElementsOfArray();

        Console.Write("Please input position (index in the array) which neighbors would be checked: ");
        int positinOfCheckedNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();

        CheckingNeighbors(inputArray, positinOfCheckedNumber);

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
                Console.WriteLine("The length of the array must be greater or equel to 0 N>=0.\nPlease input the length of the array again!\n");
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

        //long[] inputArray = { 5, 5, -10, 14, 7, 18, 1, -789 };

        Console.WriteLine();

        for (long index = 0; index < lengthOfArray; index++)
        {
            Console.Write("Value in array[{0}]= ", index);
            inputArray[index] = long.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nPrinting elements in array:");
        foreach (long item in inputArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");
        return inputArray;
    }

    static void CheckingNeighbors(long[] arrayWithIntegers, long indexOfNumber) 
    {
        if (indexOfNumber < 0 || indexOfNumber > arrayWithIntegers.Length - 1)
        {
            Console.WriteLine("No such element exists!");
        }

        else if (arrayWithIntegers[indexOfNumber] == arrayWithIntegers[0])
        {
            if (arrayWithIntegers[indexOfNumber] > arrayWithIntegers[indexOfNumber + 1])
            {
                Console.WriteLine("Number on position \'{0}\' is bigger than its one neighbor.", indexOfNumber);
            }
            else
            {
                Console.WriteLine("Number on position \'{0}\' is NOT bigger than its one neighbor.", indexOfNumber);
            }
        }

        else if (arrayWithIntegers[indexOfNumber] == arrayWithIntegers[arrayWithIntegers.Length - 1])
        {
            if (arrayWithIntegers[indexOfNumber] > arrayWithIntegers[indexOfNumber -1])
            {
                Console.WriteLine("Number on position \'{0}\' is bigger than its one neighbor.", indexOfNumber);
            }
            else
            {
                Console.WriteLine("Number on position \'{0}\' is NOT bigger than its one neighbor.", indexOfNumber);
            }
        }

        else 
        {
            if (arrayWithIntegers[indexOfNumber] > arrayWithIntegers[indexOfNumber - 1] 
                && arrayWithIntegers[indexOfNumber] > arrayWithIntegers[indexOfNumber + 1])
            {
                Console.WriteLine("Number on position \'{0}\' is bigger than its two neighbors.", indexOfNumber);
            }
            else
            {
                Console.WriteLine("Number on position \'{0}\' is NOT bigger than its two neighbors.", indexOfNumber);
            }
        }
         
    }
}