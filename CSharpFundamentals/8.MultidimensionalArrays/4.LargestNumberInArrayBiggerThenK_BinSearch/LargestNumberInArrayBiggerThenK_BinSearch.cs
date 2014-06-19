using System;

class LargestNumberInArrayBiggerThenK_BinSearch
{
    //Write a program, that reads from the console an array of N integers and an integer K
    //Sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

    static long lengthOfArray;
    static long valueOfK;

    static void Main()
    {
        InitializingLengthOfArrayAndValueOfK();

        long[] inputArray = InitializingElementsOfArray();
        
        int index = SortingAndPrintingArray(inputArray);

        index = FindingLargestNumberInArray(inputArray, index);     
    }

    static void InitializingLengthOfArrayAndValueOfK()
    {
        bool checkForLengthOfArray = true;
        
        while (checkForLengthOfArray)
        {
            Console.Write("Please input the length of the array N= ");
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
        Console.Write("Please input the value of K= ");
        valueOfK = long.Parse(Console.ReadLine());
    }

    static long[] InitializingElementsOfArray()
    {
        long[] inputArray = new long[lengthOfArray];

        //long[] inputArray = { 5, 7, -10, 14, 7, 18, 1, 25 };

        Console.WriteLine();

        for (long index = 0; index < lengthOfArray; index++)
        {
            Console.Write("Value in array[{0}]= ", index);
            inputArray[index] = long.Parse(Console.ReadLine());
        }
        return inputArray;
    }

    static int SortingAndPrintingArray(long[] inputArray)
    {
        Array.Sort(inputArray);

        int index = Array.BinarySearch(inputArray, valueOfK);

        Console.WriteLine("\nSorted array:");
        foreach (int element in inputArray)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        return index;
    }

    static int FindingLargestNumberInArray(long[] inputArray, int index)
    {
        if (inputArray[0] > valueOfK)
        {
            Console.WriteLine("\nNO value in array which is less or equel to K.");
        }
        else
        {
            if (index >= 0)
            {
                Console.WriteLine("\nThe largest number which is less or equel to K is \'{0}\'.", inputArray[index]);
                Console.WriteLine("It is with index \'{0}\' in the sorted array.\n", index);
            }
            else
            {
                index = ~index - 1;

                Console.WriteLine("\nThe largest number which is less or equel to K is \'{0}\'.", inputArray[index]);
                Console.WriteLine("It is with index \'{0}\' in the sorted array.\n", index);
            }
        }
        return index;
    }
}