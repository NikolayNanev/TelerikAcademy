using System;

class PrintingMatrixB
{
    //Write a program that fills and prints a matrix of size (n, n):
    //1 8  9 16
    //2 7 10 15
    //3 6 11 14
    //4 5 12 13 

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

        for (int row = 0, indexOne = 2 * sizeOfMatrix - 1, indexTwo = 1; row < sizeOfMatrix; row++, indexOne -= 2, indexTwo += 2)
        {
            int[] tempArray = new int[sizeOfMatrix];

            for (int column = 0; column < sizeOfMatrix; column++)
            {
                if (column == 0)
                {
                    Console.Write("{0,-4}", row + 1);
                    tempArray[0] = row + 1;
                }
                else
                {
                    if (column % 2 == 1)
                    {
                        Console.Write("{0,-4}", tempArray[column - 1] + indexOne);
                        tempArray[column] = tempArray[column - 1] + indexOne;
                    }
                    else if (column % 2 == 0)
                    {
                        Console.Write("{0,-4}", tempArray[column - 1] + indexTwo);
                        tempArray[column] = tempArray[column - 1] + indexTwo;
                    }
                } 
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}