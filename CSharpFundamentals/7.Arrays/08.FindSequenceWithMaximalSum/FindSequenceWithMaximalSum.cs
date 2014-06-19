using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class FindSequenceWithMaximalSum
{
    //Write a program that finds the sequence of maximal sum in given array. 
    //Example:{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} --->> {2, -1, 6, 4}

    static long lengthOfArray;
    static long startIndex = 0;
    static long endIndex = 0;

    static void Main()
    {
        Console.WriteLine("Finding the sequence with maximal sum in given array.\n{0}",new string('-',51));

        InitializingLengthOfArray();

        long [] inputArray = InitializingElementsOfArray();

        KadanAlgorithm(inputArray);

        PrintingSequenceWithMaximalSum(inputArray);
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

        //StreamReader reader = new StreamReader("Sample.txt");

        for (long index = 0; index < lengthOfArray; index++)
        {
            Console.Write("Value in array[{0}]= ", index);
            inputArray[index] = long.Parse(Console.ReadLine());

            //inputArray[index] = Convert.ToInt32(reader.ReadLine());
        }
        return inputArray;
    }

    private static void KadanAlgorithm(long[] inputArray)
    {
        long tempStartIndex = 0;
        long currentSum = inputArray[0];
        long maxSum = inputArray[0];

        for (int i = 1; i < inputArray.Length; i++)
        {
            currentSum += inputArray[i];

            //Ако моментния елемент е по-голям от моментната сума: 
            //  -ЗАПОЧВА нова сума = на моментния елемент 
            //  -ПРИСВОЯВА моментния начален индекс на сума = на моментния индекс
            if (inputArray[i] > currentSum)
            {
                currentSum = inputArray[i];
                tempStartIndex = i;
            }

            //Ако моментната сума е по-голям от сегашната макс сума:
            //  -ПРИСВОЯВА макс сума = на моментната сума 
            //  -ПРИСВОЯВА начален индекс на макс сума = на моментния начален индекс 
            //  -ПРИСВОЯВА краен индекс на макс сума = на моментния индекс
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = tempStartIndex;
                endIndex = i;
            }
        }
    }

    private static void PrintingSequenceWithMaximalSum(long[] inputArray)
    {
        Console.WriteLine("\nSequence with maximal sum in the array:");

        for (long i = startIndex; i <= endIndex; i++)
        {
            Console.Write("{0} ", inputArray[i]);
        }

        Console.WriteLine("\n");
    }
}