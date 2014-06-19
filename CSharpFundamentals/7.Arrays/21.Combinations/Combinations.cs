using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Combinations
{
    //Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
    //Example: N = 5, K = 2 --->> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

    static long valueOfN;
    static long valueOfK;
    static long[] nextSetArray;

    static void Main()
    {
        Console.WriteLine("Generating all the combinations of K distinct elements from set [1...N].\n{0}", new string('-', 72));
        
        InitializingNandK();

        nextSetArray = new long[valueOfK];

        CalculatingCombinations(0, 1);

    }

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

    static void CalculatingCombinations(int curentCombination, int currentNumber)
    {
        if (curentCombination == valueOfK)
        {
            PrintingSetsWithCombinations();
            return;
        }

        for (int element = currentNumber; element <= valueOfN; element++)
        {
            nextSetArray[curentCombination] = element;
            CalculatingCombinations(curentCombination + 1, element + 1);
        }
    }

    static void PrintingSetsWithCombinations()
    {
        for (int i = 0; i < valueOfK; i++)
        {
            Console.Write(nextSetArray[i] + " ");
        }
        Console.WriteLine();
    }
}