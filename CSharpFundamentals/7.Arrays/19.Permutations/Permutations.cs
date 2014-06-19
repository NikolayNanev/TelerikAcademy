using System;

class Permutations
{
    //Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
    //Example:n = 3 --->> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

    static int valueOfN;

    static void Main()
    {
        Console.WriteLine("Reads a number N and generates all permutations of the numbers [1...N].\n{0}", new string('-', 71));

        InitializingN();

        int[] arrayOfNumbers = new int[valueOfN];

        for (int i = 1; i <= valueOfN; i++)
        {
            arrayOfNumbers[i - 1] = i;
        }

        CalculatingPermutations(arrayOfNumbers, 0, arrayOfNumbers.Length - 1);
    }

    static void InitializingN()
    {
        bool checkForN = true;

        while (checkForN)
        {
            Console.Write("Please input value of N: ");
            valueOfN = int.Parse(Console.ReadLine());

            if (valueOfN < 0)
            {
                Console.WriteLine("Number N must be greater or equel to 0.  N>=0 Please input N again.\n");
            }
            else
            {
                checkForN = false;
            }
        }
    }

    static void Swap(ref int firstNumber, ref int secondNumber)
    {
        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
    }

    static void CalculatingPermutations(int[] array, int current, int length)
    {
        if (current == length)
        {
            for (int i = 0; i <= length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = current; i <= length; i++)
            {
                Swap(ref array[i], ref array[current]);
                CalculatingPermutations(array, current + 1, length);
                Swap(ref array[i], ref array[current]);
            }
        }   
    }
}