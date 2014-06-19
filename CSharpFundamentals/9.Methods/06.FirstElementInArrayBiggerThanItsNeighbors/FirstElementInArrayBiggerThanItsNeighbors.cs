using System;

class FirstElementInArrayBiggerThanItsNeighbors
{
    //Write a method that returns the index of the first element in array that is bigger than its neighbors
    //Returns  -1, if there’s no such element.

    static long lengthOfArray;
    static long indexOfFirstFoundNumber;

    static void Main()
    {
        InitializingLengthOfArray();

        long[] inputArray = InitializingElementsOfArray();

        for (long curentPosition = 1; curentPosition < inputArray.Length - 1; curentPosition++)
        {
            indexOfFirstFoundNumber = CheckingNeighbors(inputArray, curentPosition);

            if (indexOfFirstFoundNumber >= 0 )
            {
                break;
            }
        }

        Console.WriteLine("The index of the first element that is bigger than its neighbors is: {0}", indexOfFirstFoundNumber);
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

        //long[] inputArray = { 7, 7, 7, 7, 7, 7, 7, 8 };

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

    static long CheckingNeighbors(long[] arrayWithIntegers, long indexOfNumber)
    {
        if (arrayWithIntegers[indexOfNumber] > arrayWithIntegers[indexOfNumber - 1]
                && arrayWithIntegers[indexOfNumber] > arrayWithIntegers[indexOfNumber + 1])
        {
            return indexOfNumber;
        }
        else
        {
            return -1;
        }
    }
}