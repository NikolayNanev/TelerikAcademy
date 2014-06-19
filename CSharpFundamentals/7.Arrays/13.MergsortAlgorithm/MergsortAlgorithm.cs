using System;

class MergeSortAlgorithm
{
    //Write a program that sorts an array of integers using the merge sort algorithm

    static int lengthOfArray;

    static void Main()
    {
        Console.WriteLine("Sorting an array of integers with the Mergesort algorithm.\n{0}",new string('-',58));
        InitializingLengthOfArray();

        int[] inputArray = InitializingElementsOfArray();

        int[] sortedArray = MergeSort(inputArray);

        PrintSortedArray(sortedArray);
    }

    private static void InitializingLengthOfArray()
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

    private static int[] InitializingElementsOfArray()
    {
        Console.WriteLine();

        int[] inputArray = new int[lengthOfArray];

        //StreamReader reader = new StreamReader("Sample.txt");

        for (long index = 0; index < lengthOfArray; index++)
        {
            Console.Write("Value in array[{0}]= ", index);
            inputArray[index] = int.Parse(Console.ReadLine());

            //inputArray[index] = Convert.ToInt32(reader.ReadLine());
        }
        return inputArray;
    }

    static int[] MergeSort(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int middle = array.Length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[array.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            leftArray[i] = array[i];
        }

        for (int i = middle, j = 0; i < array.Length; i++, j++)
        {
            rightArray[j] = array[i];
        }

        leftArray = MergeSort(leftArray);
        rightArray = MergeSort(rightArray);

        return MergeArrays(leftArray, rightArray);
    }

    static int[] MergeArrays(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];

        int leftIncrease = 0;
        int rightIncrease = 0;

        for (int i = 0; i < result.Length; i++)
        {
            if (rightIncrease == right.Length || ((leftIncrease < left.Length) && (left[leftIncrease] <= right[rightIncrease])))
            {
                result[i] = left[leftIncrease];
                leftIncrease++;
            }
            else if (leftIncrease == left.Length || ((rightIncrease < right.Length) && (right[rightIncrease] <= left[leftIncrease])))
            {
                result[i] = right[rightIncrease];
                rightIncrease++;
            }
        }

        return result;
    }

    static void PrintSortedArray(int[] array)
    {
        Console.WriteLine("\nSorted array:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}