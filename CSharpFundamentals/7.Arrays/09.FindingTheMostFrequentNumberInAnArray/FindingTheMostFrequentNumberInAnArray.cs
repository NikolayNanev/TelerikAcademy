using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindingTheMostFrequentNumberInAnArray
{
    //Write a program that finds the most frequent number in an array. 
    //Example:{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} --->> 4 (5 times)

    static long lengthOfArray;
    static int lengthOfSequence = 1;
    static int lengthOfMaxSequence = 0;
    static long valueOfNumberInMaxSequence = 0;

    static void Main()
    {
        Console.WriteLine("Finding the most frequent number in an array.\n{0}", new string('-', 45));

        InitializingLengthOfArray();

        long[] inputArray = InitializingElementsOfArray();

        SortingElementsOfArray(inputArray);
        AlgoForMaxSequenceOfEqualElementsInAnArray(inputArray);
        PrintingMostFrequentNumber();

        Console.WriteLine();
    }

    private static void InitializingLengthOfArray()
    {
        bool checkForLengthOfArray = true;

        while (checkForLengthOfArray)
        {
            Console.Write("Please input the length of the array: ");
            lengthOfArray = long.Parse(Console.ReadLine());

            if (lengthOfArray < 0)
            {
                Console.WriteLine("The length of the array must be greater or equel to 0.Please input the length of the array again!\n");
            }
            else
            {
                checkForLengthOfArray = false;
            }
        }

        Console.WriteLine();
    }

    private static long[] InitializingElementsOfArray()
    {
        long[] inputArray = new long[lengthOfArray];

        for (long index = 0; index < lengthOfArray; index++)
        {
            Console.Write("Value in array[{0}]= ", index);
            inputArray[index] = long.Parse(Console.ReadLine());
        }
        return inputArray;
    }

    private static void SortingElementsOfArray(long[] inputArray)
    {
        for (int i = 0; i < lengthOfArray; i++)
        {
            for (int j = i + 1; j < lengthOfArray; j++)
            {
                long curentMinElement = inputArray[i];

                if (inputArray[j] <= curentMinElement)
                {
                    long tempNumber = inputArray[i];
                    inputArray[i] = inputArray[j];
                    inputArray[j] = tempNumber;
                }
            }
        }
    }

    private static void AlgoForMaxSequenceOfEqualElementsInAnArray(long[] inputArray)
    {
        for (int i = 0; i < lengthOfArray - 1; i++)
        {
            if (inputArray[i] == inputArray[i + 1])
            {
                lengthOfSequence++;
            }

            else
            {
                lengthOfSequence = 1;
            }

            if (lengthOfSequence > lengthOfMaxSequence)
            {
                lengthOfMaxSequence = lengthOfSequence;
                valueOfNumberInMaxSequence = inputArray[i];
            }
        }
    }

    private static void PrintingMostFrequentNumber()
    {
        if (lengthOfMaxSequence == 1)
        {
            Console.WriteLine("\nNO most frequent number in the array. All numbers are different.");
        }
        else
        {
            Console.WriteLine("\nThe most frequent number in the array is:{0} ({1} times)", valueOfNumberInMaxSequence, lengthOfMaxSequence);
        }
    } 
}