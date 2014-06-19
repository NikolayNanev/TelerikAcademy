using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubsetSums
{
    static int countOfSubsetEqualToS = 0;

    static void Main()
    {
        long valueOfS = long.Parse(Console.ReadLine());
        byte nNumbersToInput = byte.Parse(Console.ReadLine());

        bool subsetEqualToSIsFound = false;

        long[] myArreyOfNumbers = new long[nNumbersToInput];

        for (int i = 0; i < nNumbersToInput; i++)
			{
                myArreyOfNumbers[i] = long.Parse(Console.ReadLine());
			}

        for (int nextSubset = 1; nextSubset < Math.Pow(2, nNumbersToInput); nextSubset++)
        {
            long sumOfSubset = 0;
            for (int positionInSubset = 0; positionInSubset < nNumbersToInput; positionInSubset++)
            {
                bool isOne = ((nextSubset >> positionInSubset) & 1) == 1;
                if (isOne == true)
                {
                    sumOfSubset += myArreyOfNumbers[positionInSubset];
                }
            }
            if (sumOfSubset == valueOfS)
            {
                subsetEqualToSIsFound = true;
                countOfSubsetEqualToS++;
            }
        }
        if (subsetEqualToSIsFound)
        {
            Console.WriteLine(countOfSubsetEqualToS);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}