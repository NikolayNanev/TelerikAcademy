using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class FindSequenceWithSumEquelToS
{
    //Write a program that finds in given array of integers a sequence of given sum S (if present). 
    //Example: {4, 3, 1, 4, 2, 5, 8}, S=11 --->> {4, 2, 5}

    static long lengthOfArray;
    static int startIndex;
    static int endIndex;

    static void Main()
    {
        Console.WriteLine("Finding the sequence wit sum equel to S in given array.\n{0}", new string('-', 55));

        InitializingLengthOfArray();

        Console.Write("Please input the value of the sum S: ");
        long valueOfSumS = long.Parse(Console.ReadLine());

        long[] inputArray = InitializingElementsOfArray();

        FindingSequenceWithSumEquelToS(valueOfSumS, inputArray);
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
    }

    private static long[] InitializingElementsOfArray()
    {
        Console.WriteLine();

        long[] inputArray = new long[lengthOfArray];

        //StreamReader reader = new StreamReader("Sample.txt");

        for (long index = 0; index < lengthOfArray; index++)
        {
            Console.Write("Value in array[{0}]= ", index);
            inputArray[index] = long.Parse(Console.ReadLine());

            //inputArray[index] = Convert.ToInt32(reader.ReadLine());
        }
        return inputArray;
    }

    private static void FindingSequenceWithSumEquelToS(long valueOfSumS, long[] inputArray)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            long sumOfElements = 0;

            for (int j = i; j < inputArray.Length; j++)
            {
                sumOfElements += inputArray[j];

                if (sumOfElements > valueOfSumS)
                {
                    break;
                }

                if (sumOfElements == valueOfSumS)
                {
                    startIndex = i;
                    endIndex = j;
                    goto ExitLoops;
                }
            }
        }
    ExitLoops:

        PrintingSequenceWithSumEquelToS(valueOfSumS, inputArray);
    }

    private static void PrintingSequenceWithSumEquelToS(long valueOfSumS, long[] inputArray)
    {
        if (endIndex == 0)
        {
            Console.WriteLine("\nThere is NO present sequence with sum  S={0} in the array.", valueOfSumS);
            Console.WriteLine("\n");
        }
        else
        {
            Console.WriteLine("\nSequence with sum S={0} in the array:", valueOfSumS);

            for (long i = startIndex; i <= endIndex; i++)
            {
                Console.Write("{0} ", inputArray[i]);
            }

            Console.WriteLine("\n");
        }
    }
}