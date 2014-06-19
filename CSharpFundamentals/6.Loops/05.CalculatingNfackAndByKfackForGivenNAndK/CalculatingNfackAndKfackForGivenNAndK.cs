using System;

class CalculatingNfackAndKfackForGivenNAndK
{
    //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

    static uint nMyNumberN;
    static uint kMyNumberK;

    static void isKinRange()
    {
        bool myCheckIfKisInRange = true;

        while (myCheckIfKisInRange)
        {
       
            Console.Write("\nPlease input value for number K: ");
            kMyNumberK = uint.Parse(Console.ReadLine());

            if (kMyNumberK < 3)
            {
                Console.WriteLine("\nNumber K must be in range K>=3 .Please input K again.");
            }

            else
            {
                myCheckIfKisInRange = false;
            }
        }
    }

    static void isNinRange()
    {
        bool myCheckIfNisInRange = true;

        while (myCheckIfNisInRange)
        {
            Console.Write("Please input value for number N: ");
            nMyNumberN = uint.Parse(Console.ReadLine());

            if (nMyNumberN <= 1 || nMyNumberN >= kMyNumberK)
            {
                Console.WriteLine("\nNumber N must be in range 1 < N  <K .Please input N again.");
            }
  
            else
            {
                myCheckIfNisInRange = false;
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Calculates N!*K!/(K-N)! for given K and N (1<N<K)");

        decimal nFactorial = 1;
        decimal kFactorial = 1;
        decimal kМinusNFactorial = 1;

        isKinRange();
        isNinRange();

        for (int i = 1; i <= nMyNumberN; i++)
        {
            nFactorial = nFactorial * i;
        }

        for (int j = 1; j <= kMyNumberK; j++)
        {
            kFactorial = kFactorial * j;
        }

        for (int k = 1; k <= (kMyNumberK-nMyNumberN); k++)
        {
            kМinusNFactorial = kМinusNFactorial * k;
        }

        Console.WriteLine("\nK!={0}", kFactorial);
        Console.WriteLine("N!={0}", nFactorial);
        Console.WriteLine("(K-N)!={0}", kМinusNFactorial);
        Console.WriteLine("N!*K!/(K-N)!={0}", nFactorial * kFactorial / kМinusNFactorial);
    }
}