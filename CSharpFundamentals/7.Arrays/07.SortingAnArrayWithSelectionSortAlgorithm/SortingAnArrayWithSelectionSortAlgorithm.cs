using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingAnArrayWithSelectionSortAlgorithm
{
    //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
    //Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
    //find the smallest from the rest, move it at the second position, etc.

    static long lengthOfArray;

    static void Main()
    {
        Console.WriteLine("Sorting an array using the \"selection sort\" algorithm.\n{0}", new string('-', 54));

        InitializingLengthOfArray();

        long[] inputArray = InitializingElementsOfArray();

        SortingElementsOfArray(inputArray);
        PrintingSortedElementsOfArray(inputArray);
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
                Console.WriteLine("The length of the array must be greater or equel to 0.Please input the length of the array again!\n");
            }
            else
            {
                checkForLengthOfArray = false;
            }
        }

        Console.WriteLine();
    }

    static long[] InitializingElementsOfArray()
    {
        long[] inputArray = new long[lengthOfArray];

        for (long index = 0; index < lengthOfArray; index++)
        {
            Console.Write("Value in array[{0}]= ", index);
            inputArray[index] = long.Parse(Console.ReadLine());
        }
        return inputArray;
    }

    static void SortingElementsOfArray(long[] inputArray)
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

    static void PrintingSortedElementsOfArray(long[] inputArray)
    {
        Console.WriteLine("\nPrinting the sorted array: ");

        foreach (long item in inputArray)
        {
            Console.Write(item + " ");
        }
    }
}