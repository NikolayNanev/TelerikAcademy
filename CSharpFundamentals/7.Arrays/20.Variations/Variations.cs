using System;

class Variations
{
    //Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
    //Example:N = 3, K = 2 --->> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

    //Simulating nested loops!!!

    static long valueOfN;
    static long valueOfK;
    static long[] nextSetArray;

    static void Main()
    {
        Console.WriteLine("Generating all the variations of K elements from the set [1..N]\n{0}",new string('-',63));
        
        InitializingNandK();

        nextSetArray = new long[valueOfK];

        CalculatingVariations(0);
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

            if (valueOfK < 0)
            {
                Console.WriteLine("Number K must be greater or equel to 0.  K>=0 Please input K again.\n");
            }
            else
            {
                checkForK = false;
            }
        }

        Console.WriteLine();
    }

    static void CalculatingVariations(int curentVariation)
    {
        if (curentVariation == valueOfK)
        {
            PrintingSetsWithVariations();
            return;
        }

        for (int element = 1; element <= valueOfN; element++)
        {
            nextSetArray[curentVariation] = element;
            CalculatingVariations(curentVariation + 1);
        }
    }

    static void PrintingSetsWithVariations()
    {
        for (int i = 0; i < valueOfK; i++)
        {
            Console.Write(nextSetArray[i] + " ");
        }
        Console.WriteLine();
    }
}