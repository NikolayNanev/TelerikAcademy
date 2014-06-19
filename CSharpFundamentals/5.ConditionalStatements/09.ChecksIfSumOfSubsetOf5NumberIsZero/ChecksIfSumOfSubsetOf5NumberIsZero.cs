using System;

class ChecksIfSumOfSubsetOf5NumberIsZero
{
    static void Main()
    {
        Console.WriteLine("Checking if the sum of some subset of implemented integer numbers is 0.\n");
        
        bool subsetEqualToZeroIsFound = false;
        int countOfSubsetEqualToZero = 0;

        //Console.WriteLine("Please input the following information:");
        //Console.Write("Value of first number: ");
        //int firstNumber = int.Parse(Console.ReadLine());

        //Console.Write("Value of second number: ");
        //int secondNumber = int.Parse(Console.ReadLine());

        //Console.Write("Value of  third number: ");
        //int thirdNumber = int.Parse(Console.ReadLine());

        //Console.Write("Value of fourth number: ");
        //int fourthNumber = int.Parse(Console.ReadLine());

        //Console.Write("Value of fifth number: ");
        //int fifthNumber = int.Parse(Console.ReadLine());

        int[] myArreyOfNumbers ={firstNumber,secondNumber,thirdNumber,fourthNumber,fifthNumber};

        for (int nextSubset = 1; nextSubset < Math.Pow(2, 5); nextSubset++)
        {
            int sumOfSubset = 0;
            for (int positionInSubset = 0; positionInSubset < 5; positionInSubset++)
            {

                bool isOne = ((nextSubset >> positionInSubset) & 1) == 1;
                if (isOne == true)
                {
                    sumOfSubset += myArreyOfNumbers[positionInSubset];
                }
            }
            if (sumOfSubset == 0)
            {
                subsetEqualToZeroIsFound = true;
                countOfSubsetEqualToZero++;
            }
        }
        if (subsetEqualToZeroIsFound)
        {
            Console.WriteLine("\nThere are {0} subset which sum is equal to zero.", countOfSubsetEqualToZero);
        }
        else
        {
            Console.WriteLine("\nThere are no subsets with sum equal to zero.");
        }
    }
}