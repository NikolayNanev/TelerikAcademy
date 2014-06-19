using System;

class FindsLongestSequenceOfEqualStringsInMatrix
{
    //We are given a matrix of strings of size N x M. 
    //Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
    //Write a program that finds the longest sequence of equal strings in the matrix. 

    static int valueOfN;
    static int valueOfM;

    static string[,] rectangularMatrix;

    static int bestSequences = 1;
    static int bestRow = 0;
    static int bestColumn = 0;

    static string type;
    static string[] typeOfSequences = { "row sequence", "column sequence", "diagonal (right) sequence", "diagonal (left) sequence" };

    static void Main()
    {
        InitializingSizeOfMatrix();

        rectangularMatrix = InitializingElementsOfRectangularMatrixAndPrintingIt();

        AlgorithmForFindingLongestSequenceInMatrix();

        PrintingResults();      
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

    static string[,] InitializingElementsOfRectangularMatrixAndPrintingIt()
    {
        string[,] rectangularMatrix = new string[valueOfN, valueOfM];

        /*string[,] rectangularMatrix = 
        { 
        {"abv", "lka", "abv", "fff", "lka"},
        {"aaa", "lka", "lka", "fff", "sss"},
        {"abv", "lka", "fff", "fff", "asd"},
        {"fff", "sss", "sss", "fff", "lka"},
        {"fff", "sss", "abv", "fff", "fff"},
        {"sss", "sss", "abv", "fff", "asd"}   
        };*/

        for (int row = 0; row < valueOfN; row++)
        {
            for (int column = 0; column < valueOfM; column++)
            {
                Console.Write("Element [{0},{1}]= ", row, column);
                rectangularMatrix[row, column] = Console.ReadLine();
            }
        }

        Console.WriteLine("\nPrinting input matrix({0}x{1}):", valueOfN, valueOfM);
        PrintingMatrix(rectangularMatrix);

        return rectangularMatrix;
    }

    static void PrintingMatrix(string[,] array) 
    {
        for (int row = 0; row < valueOfN; row++)
        {
            for (int column = 0; column < valueOfM; column++)
            {
                Console.Write("{0,-4} ",array[row, column]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void AlgorithmForFindingLongestSequenceInMatrix()
    {
        for (int row = 0; row < valueOfN; row++)
        {
            for (int colomn = 0; colomn < valueOfM; colomn++)
            {
                int curentSequences = 1;
                int curentRow = row;
                int curentColumn = colomn;

                CheckForRowSequence(row, colomn, curentSequences, curentRow, curentColumn);

                CheckForColumnSequence(row, colomn, curentSequences, curentRow, curentColumn);

                CheckForDiagonalRightSequence(row, colomn, curentSequences, curentRow, curentColumn);

                CheckForDiagonalLeftSequence(row, colomn, curentSequences, curentRow, curentColumn);
            }
        }
    }

    static void CheckForRowSequence(int row, int colomn, int curentSequences, int curentRow, int curentColumn)
    {
        while (curentRow < valueOfN && curentColumn < valueOfM - 1)
        {
            if (rectangularMatrix[curentRow, curentColumn] == rectangularMatrix[curentRow, curentColumn + 1])
            {
                curentColumn++;

                curentSequences++;
                if (curentSequences > bestSequences)
                {
                    bestSequences = curentSequences;
                    bestRow = row;
                    bestColumn = colomn;
                    type = typeOfSequences[0];
                }
            }
            else
            {
                break;
            }
        }
    }

    static void CheckForColumnSequence(int row, int colomn, int curentSequences, int curentRow, int curentColumn)
    {
        while (curentRow < valueOfN - 1 && curentColumn < valueOfM)
        {
            if (rectangularMatrix[curentRow, curentColumn] == rectangularMatrix[curentRow + 1, curentColumn])
            {
                curentRow++;

                curentSequences++;
                if (curentSequences > bestSequences)
                {
                    bestSequences = curentSequences;
                    bestRow = row;
                    bestColumn = colomn;
                    type = typeOfSequences[1];
                }
            }
            else
            {
                break;
            }
        }
    }

    static void CheckForDiagonalRightSequence(int row, int colomn, int curentSequences, int curentRow, int curentColumn)
    {
        while (curentRow < valueOfN - 1 && curentColumn < valueOfM - 1)
        {
            if (rectangularMatrix[curentRow, curentColumn] == rectangularMatrix[curentRow + 1, curentColumn + 1])
            {
                curentRow++;
                curentColumn++;

                curentSequences++;
                if (curentSequences > bestSequences)
                {
                    bestSequences = curentSequences;
                    bestRow = row;
                    bestColumn = colomn;
                    type = typeOfSequences[2];
                }
            }
            else
            {
                break;
            }
        }
    }

    static void CheckForDiagonalLeftSequence(int row, int colomn, int curentSequences, int curentRow, int curentColumn)
    {
        while (curentRow < valueOfN - 1 && curentColumn > 0)
        {
            if (rectangularMatrix[curentRow, curentColumn] == rectangularMatrix[curentRow + 1, curentColumn - 1])
            {
                curentRow++;
                curentColumn--;

                curentSequences++;
                if (curentSequences > bestSequences)
                {
                    bestSequences = curentSequences;
                    bestRow = row;
                    bestColumn = colomn;
                    type = typeOfSequences[3];
                }
            }
            else
            {
                break;
            }
        }
    }

    static void HighlightingLongestSequenceInMatrixAndPrintingIt()
    {
        string[,] longestSequenceMatrix = (string[,])rectangularMatrix.Clone();

        if (type == typeOfSequences[0])
        {
            for (int row = bestRow; row < bestRow + 1; row++)
            {
                for (int column = bestColumn; column < bestColumn + bestSequences; column++)
                {
                    longestSequenceMatrix[row, column] = rectangularMatrix[row, column].ToUpper();
                }
            }
        }

        else if (type == typeOfSequences[1])
        {
            for (int row = bestRow; row < bestRow + bestSequences; row++)
            {
                for (int column = bestColumn; column < bestColumn + 1; column++)
                {
                    longestSequenceMatrix[row, column] = rectangularMatrix[row, column].ToUpper();
                }
            }
        }

        else if (type == typeOfSequences[2])
        {
            int row = bestRow;
            int column = bestColumn;

            for (int nextElement = 1; nextElement <= bestSequences; nextElement++)
            {
                longestSequenceMatrix[row, column] = rectangularMatrix[row, column].ToUpper();

                row++;
                column++;
            }
        }

        else if (type == typeOfSequences[3])
        {
            int row = bestRow;
            int column = bestColumn;

            for (int nextElement = 1; nextElement <= bestSequences; nextElement++)
            {
                longestSequenceMatrix[row, column] = rectangularMatrix[row, column].ToUpper();

                row++;
                column--;
            }
        }

        Console.WriteLine("Printing matrix with longest sequence highlighted in ALLCAPS:");
        PrintingMatrix(longestSequenceMatrix);
    }

    static void PrintingResults()
    {
        if (bestSequences == 1)
        {
            Console.WriteLine("All elements're different.No longest sequence!\n");
        }
        else
        {
            Console.WriteLine("The longest sequence in the input matrix is a \"{0}\".", type);
            Console.WriteLine("It starts from element with index [{0},{1}] and has length of \'{2}\' elements.\n", bestRow, bestColumn, bestSequences);

            HighlightingLongestSequenceInMatrixAndPrintingIt();
        }
    }
}