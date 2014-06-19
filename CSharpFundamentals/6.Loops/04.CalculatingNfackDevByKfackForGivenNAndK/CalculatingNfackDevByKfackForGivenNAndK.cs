using System;
using System.Numerics;

class CalculatingNfackDevByKfackForGivenNAndK
{
    static BigInteger nMyNumberN;
    static BigInteger kMyNumberK;

    static void isNequalToZeroOrOne()
    {
        bool myCheckIfNisZeroOrOne = true;
        while (myCheckIfNisZeroOrOne)
        {
            Console.Write("\nPlease input value for number N: ");
            nMyNumberN = BigInteger.Parse(Console.ReadLine());

            if (nMyNumberN ==  0 || nMyNumberN == 1)
            {
                Console.WriteLine("Number N must be in range N>1 .Please input N again.");
            }
            else
            {
                myCheckIfNisZeroOrOne = false;
            }
        }
    }

    static void isKinRange()
    {
        bool myCheckIfKisInRange = true;
        while (myCheckIfKisInRange)
        {
            Console.Write("Please input value for number K: ");
            kMyNumberK = BigInteger.Parse(Console.ReadLine());

            if (kMyNumberK >= nMyNumberN || kMyNumberK == 0)
            {
                Console.WriteLine("\nNumber K must be in range 1 < K  <N .Please input K again.");
            }
            else
            {
                myCheckIfKisInRange = false;
            }
        }
    }
   
    static void Main()
    {
        Console.WriteLine("Calculates N!/K! for given N and K (1<K<N).");

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;

        isNequalToZeroOrOne();
        isKinRange();

        for (int i = 1; i <= nMyNumberN; i++)
        {
            nFactorial = nFactorial * i;
        }

        for (int j = 1; j <= kMyNumberK; j++)
        {
            kFactorial = kFactorial * j;
        }

        Console.WriteLine("\nN!={0}", nFactorial);
        Console.WriteLine("K!={0}", kFactorial);
        Console.WriteLine("N!/K!={0}\n", nFactorial / kFactorial);
    }
}