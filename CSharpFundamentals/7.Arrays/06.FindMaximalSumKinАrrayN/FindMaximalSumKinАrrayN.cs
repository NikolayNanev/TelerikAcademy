using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindMaximalSumKinАrrayN
{
    //Write a program that reads two integer numbers N and K and an array of N elements from the console. 
    //Find in the array those K elements that have maximal sum.

    static long valueOfN;
    static long valueOfK;

    static void InitializingNandK()
    {
        bool checkForN = true;
        bool checkForK = true;

        while (checkForN)
        {
            Console.Write("Please input value of N: ");
            valueOfN = long.Parse(Console.ReadLine());

            if (valueOfN < 0)
            {
                Console.WriteLine("Number N must be greater or equel to 0.  N>=0 Please input N again.\n");
            }
            else
            {
                checkForN = false;
            }
        }

        while (checkForK)
        {
            Console.Write("Please input value of K: ");
            valueOfK = long.Parse(Console.ReadLine());

            if (valueOfK > valueOfN || valueOfK < 0)
            {
                Console.WriteLine("Number K must be less or equel to N and greater or equel to 0.  N>=K>=0 Please input K again.\n");
            }
            else
            {
                checkForK = false;
            }
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Finding the maximal sum of K elements in an array with N elements.\n{0}", new string('-', 66));

        InitializingNandK();

        long[] inputArray = new long[valueOfN];

        for (int index = 0; index < valueOfN; index++)
        {
            Console.Write("Value in array[{0}]= ", index);
            inputArray[index] = long.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        //Sorting array "myArray" and initializing new sorted array "newArray"
        long[] sortedArray = inputArray.OrderBy(x => x).ToArray<long>();

        long sumOfMaxKelements = 0;

        for (long index = valueOfN - valueOfK, numb = 1; index < valueOfN; index++, numb++)
        {
            Console.WriteLine("MaxElement_{0} = {1}", numb, sortedArray[index]);
            sumOfMaxKelements += sortedArray[index];
        }

        Console.WriteLine("\nMaximum sum={0}", sumOfMaxKelements);
    }
}