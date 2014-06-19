namespace MatrixOperations
{
    using System;

    public class ProgramMain
    {
        static void Main()
        {
            //Task 8
            int[,] intMatrix = 
            {
                {1, 2, -8},
                {7, -5, 8},
                {-7, 2, 0}
            };

            decimal[,] decimalMatrix = 
            {
                {7.3m, -2.5m, 7.8m},
                {6.7m, 3.5m, 4.8m},
                {7.9m, 7.5m, 1.8m}
            };

            double[,] doubleMatrix = 
            {
                {7.5, 5.9, 11.1},
                {10.3, 5.0, 12.4},
                {4.9, 4.5, 10.0}
            };

            //Task 8
            Matrix<int> matrixWithIntegers = new Matrix<int>(intMatrix);
            Matrix<decimal> matrixWithDecimal = new Matrix<decimal>(decimalMatrix);
            Matrix<double> matrixWithDouble = new Matrix<double>(doubleMatrix);

            //Task 8:
            PrintingMatrix(matrixWithIntegers);

            //Task 9: Implement an indexer this[row, col] to access the inner matrix cells.
            Console.WriteLine("{0}", matrixWithIntegers[1, 2]);
            Console.WriteLine("{0}\n", matrixWithIntegers[0, 1]);

            //Task 10: Implement the operators "+" (addition matrices of the same size)

            Matrix<int> additionOfMatrices = new Matrix<int>(matrixWithIntegers.RowCount, matrixWithIntegers.ColumeCount);
            
            additionOfMatrices = matrixWithIntegers + matrixWithIntegers;
            PrintingMatrix(additionOfMatrices);

            //Task 10: Implement the operators "-" (subtraction matrices of the same size)

            Matrix<decimal> subtractionOfMatrices = new Matrix<decimal>(matrixWithDecimal.RowCount, matrixWithDecimal.ColumeCount);
            
            subtractionOfMatrices = matrixWithDecimal - matrixWithDecimal;
            PrintingMatrix(subtractionOfMatrices);

            //Task 10: Implement the operators "*" (matrix multiplication)

            int[,] firstMatrix = 
            {
                {3, 5, 7},
                {2, 3, 2}
            };

            int[,] secondMatrix = 
            {
                {1, 5},
                {2, 4},
                {7, 2}
            };

            Matrix<int> first = new Matrix<int>(firstMatrix);
            Matrix<int> second = new Matrix<int>(secondMatrix);

            Matrix<int> multiplyOfMatrices = new Matrix<int>(first.RowCount, second.ColumeCount);

            multiplyOfMatrices = first * second;
                        
            PrintingMatrix(multiplyOfMatrices);

            //Task 10: Implement the operators "true" (check for non-zero elements)

            if (matrixWithIntegers)
            {
                Console.WriteLine("Matrix has all non-zero elements.");
            }
            else
            {
                Console.WriteLine("Matrix has zero elements.");
            }
        }

        private static void PrintingMatrix<T>(Matrix<T> inputMatrix) 
            where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
        {
            Console.WriteLine("Values of matrix:");

            for (int row = 0; row < inputMatrix.ThisMatrix.GetLength(0); row++)
            {
                for (int columne = 0; columne < inputMatrix.ThisMatrix.GetLength(1); columne++)
                {
                    Console.Write("{0} ", inputMatrix[row, columne]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
