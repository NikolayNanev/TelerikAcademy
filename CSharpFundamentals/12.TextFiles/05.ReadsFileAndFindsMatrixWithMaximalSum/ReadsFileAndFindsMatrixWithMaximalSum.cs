using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReadsFileAndFindsMatrixWithMaximalSum
{
    //Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area 
    //of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. 
    //Each of the next N lines contain N numbers separated by space. 
    //The output should be a single number in a separate text file. 

    static string FILE_PATH = @"..\..\File.txt";

    static int[,] matrix;

    static void Main()
    {
        ReadingInputFile();

        FindingMaxSumAndPrintingIt();
    }

    static void ReadingInputFile()
    {
        StreamReader inputReader = new StreamReader(FILE_PATH);
        using (inputReader)
        {
            string line = inputReader.ReadLine();
            int matrixSize = int.Parse(line);

            matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                line = inputReader.ReadLine();
                string[] elements = line.Split(' ');

                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = int.Parse(elements[j]);
                }
            }
        }
    }

    static void FindingMaxSumAndPrintingIt()
    {
        int maxSum = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int currentSum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                }
            }

        }
        Console.WriteLine("The max sum is: {0}", maxSum);
    }
}