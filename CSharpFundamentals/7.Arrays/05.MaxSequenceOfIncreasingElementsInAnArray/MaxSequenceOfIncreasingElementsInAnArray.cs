using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSequenceOfEqualElementsInAnArray
{
    //Write a program that finds the maximal increasing sequence in an array. 
    //Example: {3, 2, 3, 4, 2, 2, 4} --->>> {2, 3, 4}.

    static long lengthOfArray;
    
    static void Main()
    {
        Console.WriteLine("Finding the maximal sequence of increasing elements in an array.\n{0}", new string('-', 64));

        InitializingLengthOfArray();

        long[] inputArray = InitializingElementsOfArray();

        int lengthOfMaxSequence;
        long valueOfLastNumberInSequence;

        AlgorithmForFindingMaximalSequenceOfIncreasingElements(inputArray, out lengthOfMaxSequence, out valueOfLastNumberInSequence);

        PrintingMaximalSequenceOfIncreasingElements(lengthOfMaxSequence, valueOfLastNumberInSequence);
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

        for (int i = 0; i < lengthOfArray; i++)
        {
            Console.Write("Input value in array[{0}]= ", i);
            inputArray[i] = long.Parse(Console.ReadLine());
        }
        return inputArray;
    }

    private static void AlgorithmForFindingMaximalSequenceOfIncreasingElements(long[] inputArray, out int lengthOfMaxSequence, out long valueOfLastNumberInSequence)
    {
        int lengthOfSequence = 1;
        lengthOfMaxSequence = 0;

        valueOfLastNumberInSequence = 0;

        for (int i = 0; i < lengthOfArray - 1; i++)
        {
            if (inputArray[i] == inputArray[i + 1] - 1)
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
                valueOfLastNumberInSequence = inputArray[i + 1];

            }
        }
    }

    private static void PrintingMaximalSequenceOfIncreasingElements(int lengthOfMaxSequence, long valueOfLastNumberInSequence)
    {
        if (lengthOfMaxSequence == 1)
        {
            Console.WriteLine("\nNo maximal sequence of increasing elements is available in the array.");
        }

        else
        {
            Console.WriteLine("\nThe maximal sequence of increasing elements in the array is:");

            for (int j = lengthOfMaxSequence - 1; j >= 0; j--)
            {
                Console.Write("{0} ", valueOfLastNumberInSequence - j);
            }
        }

        Console.WriteLine();
    }
}