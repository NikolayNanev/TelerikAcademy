using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    //Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm.

    static int lengthOfArray;
    static int valueOfSearchedElement;

    static void Main()
    {
        Console.WriteLine("Using the binary search to find the index of given element in a sorted array.\n{0}", new string('-', 77));
        InitializingLengthOfArray();

        int[] inputArray = InitializingElementsOfArray();
        Array.Sort(inputArray);

        Console.WriteLine("\nSorted array:");
        foreach (int elementInSortedArray in inputArray)
        {
            Console.Write(elementInSortedArray + " ");
        }

        Console.Write("\n\nPlease input the value of the searched element: ");
        valueOfSearchedElement = int.Parse(Console.ReadLine());

        BinarySearchAlgo(inputArray, 0, inputArray.Length - 1, valueOfSearchedElement);
    }

    static void InitializingLengthOfArray()
    {
        bool checkForLengthOfArray = true;

        while (checkForLengthOfArray)
        {
            Console.Write("Please input the length of the array: ");
            lengthOfArray = int.Parse(Console.ReadLine());

            if (lengthOfArray < 0)
            {
                Console.WriteLine("The length of the array must be greater or equel to 0.Please input the length of the array again!\n");
            }
            else
            {
                checkForLengthOfArray = false;
            }
        }
    }

    static int[] InitializingElementsOfArray()
    {
        Console.WriteLine();

        int[] inputArray = new int[lengthOfArray];

        for (int index = 0; index < lengthOfArray; index++)
        {
            Console.Write("Value in array[{0}]= ", index);
            inputArray[index] = int.Parse(Console.ReadLine());
        }
        return inputArray;
    }

    static void BinarySearchAlgo(int[] array, int startIndex, int endIndex, int searchedElement)
    {
        if (endIndex < startIndex)
        {
            Console.WriteLine("\nNo element \'{0}\' in array.\n", valueOfSearchedElement);
            return;
        }

        int median = startIndex + (endIndex - startIndex) / 2;

        if (array[median] == searchedElement)
        {
            Console.WriteLine("\nIndex of searched element = {0}\n", median);
            return;
        }

        else if (array[median] > searchedElement)
        {
            BinarySearchAlgo(array, startIndex, median - 1, searchedElement);
        }

        else if (array[median] < searchedElement)
        {
            BinarySearchAlgo(array, median + 1, endIndex, searchedElement);
        }
    }
}