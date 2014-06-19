using System;

class Square3x3WithMaximalSum
{
    //Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

    static int valueOfN;
    static int valueOfM;

    static long[,] rectangularMatrix;

    static long bestSum = long.MinValue;
    static int bestRow;
    static int bestColumn;

    static void Main()
    {
        InitializingSizeOfMatrix();

        FindingSquare3x3WithMaximalSum();
    }

    static void InitializingSizeOfMatrix()
    {
        bool checkForN = true;
        bool checkForM = true;

        while (checkForN)
        {
            Console.Write("Please input rows of matrix N= ");
            valueOfN = int.Parse(Console.ReadLine());

            if (valueOfN < 0)
            {
                Console.WriteLine("Number N must be greater or equel to 0 (N>=0) Please input N again.\n");
            }
            else
            {
                checkForN = false;
            }
        }

        while (checkForM)
        {
            Console.Write("Please input columns of matrix M= ");
            valueOfM = int.Parse(Console.ReadLine());

            if (valueOfM < 0)
            {
                Console.WriteLine("Number M must be greater or equel to 0 (M>=0) Please input M again.\n");
            }
            else
            {
                checkForM = false;
            }
        }

        Console.WriteLine();
    }

    static long[,] InitializingElementsOfRectangularMatrix()
    {
        long[,] rectangularMatrix = new long[valueOfN, valueOfM];

        /*long[,] rectangularMatrix = 
        { 
        {-50, 100, 154, -50, 310, -78},
        {156, -10, 100, 180, -99, 125},
        {122, -98, -77, 153, 189, -92} 
        };*/

        for (int row = 0; row < valueOfN; row++)
        {
            for (int column = 0; column < valueOfM; column++)
            {
                Console.Write("Element [{0},{1}]= ", row, column);
                rectangularMatrix[row, column] = long.Parse(Console.ReadLine());
            }
        }

        return rectangularMatrix;
    }

    static void FindingSquare3x3WithMaximalSum()
    {
        if (valueOfN < 3 || valueOfM < 3)
        {
            Console.WriteLine("Matrix's size is {0}x{1}! There is no square 3x3.\n", valueOfN, valueOfM);
        }
        else
        {
            rectangularMatrix = InitializingElementsOfRectangularMatrix();

            Console.WriteLine("\nPrinting input matrix({0}x{1}):", valueOfN, valueOfM);
            PrintingMatrix(rectangularMatrix);

            for (int row = 0; row < rectangularMatrix.GetLength(0) - 2; row++)
            {
                for (int column = 0; column < rectangularMatrix.GetLength(1) - 2; column++)
                {
                    long sum = 0;

                    for (int i = row; i < row + 3; i++)
                    {
                        for (int j = column; j < column + 3; j++)
                        {
                            sum += rectangularMatrix[i, j];
                        }
                    }

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestColumn = column;
                    }
                }
            }
            PrintingSquareWithMaximalSum();
        }
    }

    static void PrintingMatrix(long[,] array)
    {
        for (int row = 0; row < valueOfN; row++)
        {
            for (int column = 0; column < valueOfM; column++)
            {
                Console.Write("{0,-4} ", array[row, column]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void PrintingSquareWithMaximalSum()
    {
        Console.WriteLine("\nThe maximal sum is {0}.\nThe square (3x3) that has maximal sum:", bestSum);

        for (int row = bestRow; row < bestRow + 3; row++)
        {
            for (int column = bestColumn; column < bestColumn + 3; column++)
            {
                Console.Write("{0,-4} ", rectangularMatrix[row, column]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
