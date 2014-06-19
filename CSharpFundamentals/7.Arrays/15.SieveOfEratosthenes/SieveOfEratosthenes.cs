using System;

class SieveOfEratosthenes
{
    //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm

    static void Main()
    {
        bool[] isNumberPrime = InitializingBoolArrayIsNumberPrime();

        ImplementingEratosthenesAlgorithm(isNumberPrime);

        PrintingAllPrimeNumbers(isNumberPrime);
    }
    private static bool[] InitializingBoolArrayIsNumberPrime()
    {
        bool[] isNumberPrime = new bool[10000000];

        for (int index = 2; index < isNumberPrime.Length; index++)
        {
            isNumberPrime[index] = true;
        }
        return isNumberPrime;
    }

    private static void ImplementingEratosthenesAlgorithm(bool[] isNumberPrime)
    {
        for (int i = 0; i < Math.Sqrt(isNumberPrime.Length); i++)
        {
            if (isNumberPrime[i] == true)
            {
                for (int j = i * i; j < isNumberPrime.Length; j += i)
                {
                    isNumberPrime[j] = false;
                }
            }
        }
    }

    private static void PrintingAllPrimeNumbers(bool[] isNumberPrime)
    {
        int countPrimeNumber = 1;

        for (int index = 2; index < isNumberPrime.Length; index++)
        {
            if (isNumberPrime[index] == true)
            {
                Console.WriteLine("Prime number[{1}] = {0} ", index, countPrimeNumber);
                countPrimeNumber++;
            }          
        }
    }
}