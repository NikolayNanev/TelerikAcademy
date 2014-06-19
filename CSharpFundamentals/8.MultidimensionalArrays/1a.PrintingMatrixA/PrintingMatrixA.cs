using System;

class PrintingMatrixA
{
    //Write a program that fills and prints a matrix of size (n, n):
    //1 5 9 13
    //2 6 10 14
    //3 7 11 15
    //4 8 12 16 

    static int sizeOfMatrix;

    static void Main()
    {
        Console.WindowWidth = Console.LargestWindowWidth;
        Console.WindowHeight = Console.LargestWindowHeight;

        Console.WriteLine("Prints a matrix of size (n, n) with a certain pattern.\n{0}", new string('-', 54));

        InitializingSizeOfMatrix();

        PrintingMatrix();
    }

    static void InitializingSizeOfMatrix()
    {
        bool checkForN = true;

        while (checkForN)
        {
            Console.Write("Please input size(n,n) of matrix n= ");
            sizeOfMatrix = int.Parse(Console.ReadLine());

            if (sizeOfMatrix < 0)
            {
                Console.WriteLine("Number n must be greater or equel to 0 (n>=0) Please input n again.\n");
            }
            else
            {
                checkForN = false;
            }
        }

        Console.WriteLine();
    }

    static void PrintingMatrix()
    {
        int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

        for (int row = 0, index = 1; row < matrix.GetLength(0); row++, index++)
        {
            for (int column = 0, step = index; column < matrix.GetLength(1); column++, step += 4)
            {
                Console.Write("{0,-2} ", step);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}