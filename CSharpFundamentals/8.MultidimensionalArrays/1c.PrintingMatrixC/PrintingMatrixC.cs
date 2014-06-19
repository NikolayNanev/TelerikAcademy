using System;

class PrintingMatrixC
{
    //Write a program that fills and prints a matrix of size (n, n):
    //7 11 14 16
    //4  8 12 15
    //2  5  9 13
    //1  3  6 10 

    static int sizeOfMatrix;
    static int[,] matrix;

    static void Main()
    {
        Console.WindowWidth = Console.LargestWindowWidth;
        Console.WindowHeight = Console.LargestWindowHeight;

        Console.WriteLine("Prints a matrix of size (n, n) with a certain pattern.\n{0}", new string('-', 54));

        InitializingSizeOfMatrix();

        InitializingElementsOfMatrix();

        PrintingMatrix(matrix);
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

    static void InitializingElementsOfMatrix()
    {
        matrix = new int[sizeOfMatrix, sizeOfMatrix];

        int curentRow = 0;
        int curentColumn = 0;
        int valueOfElement = 1;

        //Initializing values from the main diagonal and under the main diagonal of the matrix
        for (int nextRow = sizeOfMatrix - 1; nextRow >= 0; nextRow--)
        {
            curentRow = nextRow;
            curentColumn = 0;

            while (curentRow < sizeOfMatrix && curentColumn < sizeOfMatrix)
            {
                matrix[curentRow++, curentColumn++] = valueOfElement++;
            }
        }

        //Initializing values over the main diagonal of the matrix
        for (int nextColumn = 1; nextColumn < sizeOfMatrix; nextColumn++)
        {
            curentRow = 0;
            curentColumn = nextColumn;

            while (curentRow < sizeOfMatrix && curentColumn < sizeOfMatrix)
            {
                matrix[curentRow++, curentColumn++] = valueOfElement++;
            }      
        }
    }

    static void PrintingMatrix(int[,] matrix)
    {
        for (int row = 0; row < sizeOfMatrix; row++)
        {
            for (int column = 0; column < sizeOfMatrix; column++)
            {
                Console.Write("{0,-3} ", matrix[row, column]);
            }

            Console.WriteLine();
        }
    }
}