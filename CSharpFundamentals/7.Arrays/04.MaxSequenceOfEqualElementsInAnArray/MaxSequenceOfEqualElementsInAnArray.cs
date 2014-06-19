using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class MaxSequenceOfEqualElementsInAnArray
{
    //Write a program that finds the maximal sequence of equal elements in an array.
    //Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} --->>> {2, 2, 2}.

    static long lengthOfArray;
    static int lengthOfSequence = 1;
    static int lengthOfMaxSequence = 0;
    static long valueOfNumberInMaxSequence = 0;

    static void Main()
    {
        Console.WriteLine("Finding the maximal sequence of equal elements in an array.\n{0}", new string('-', 59));

        InitializingLengthOfArray();

        long[] inputArray = InitializingElementsOfArray();

        AlgoForMaxSequenceOfEqualElementsInArray(inputArray);

        PrintingMembersOfSequence();
    }

    public static void InitializingLengthOfArray()
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

        //StreamReader reader = new StreamReader("Sample.txt");

        for (int i = 0; i < lengthOfArray; i++)
        {
            Console.Write("Input value in array[{0}]= ", i);
            inputArray[i] = long.Parse(Console.ReadLine());

            //inputArray[i] = Convert.ToInt32(reader.ReadLine());
        }
        return inputArray;
    }

    private static void AlgoForMaxSequenceOfEqualElementsInArray(long[] inputArray)
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

    private static void PrintingMembersOfSequence()
    {
        if (lengthOfMaxSequence == 1)
        {
            Console.WriteLine("\nNo maximal sequence of equal elements is available in the array.");
        }
        else
        {
            Console.WriteLine("\nThe maximal sequence of equal elements in the array is:");

            for (int j = 0; j < lengthOfMaxSequence; j++)
            {
                Console.Write(valueOfNumberInMaxSequence + " ");
            }
        }

        Console.WriteLine();
    }
}