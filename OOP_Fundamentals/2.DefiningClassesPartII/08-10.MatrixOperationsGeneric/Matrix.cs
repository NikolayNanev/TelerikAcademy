namespace MatrixOperations
{
    using System;

    //Task 8
    public class Matrix<T>
        where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        public Matrix(int rows, int columes)
        {
            this.RowCount = rows;
            this.ColumeCount = columes;
            this.ThisMatrix = new T[RowCount, ColumeCount];
        }

        public Matrix(T[,] matrix)
        {
            //TODO
            this.RowCount = matrix.GetLength(0);
            //TODO
            this.ColumeCount = matrix.GetLength(1);
            this.ThisMatrix = new T[RowCount, ColumeCount];

            for (int row = 0; row < RowCount; row++)
            {
                for (int colume = 0; colume < ColumeCount; colume++)
                {
                    this.ThisMatrix[row, colume] = matrix[row, colume];
                }
            }
        }

        public T[,] ThisMatrix { get; set; }
        public int RowCount { get; set; }
        public int ColumeCount { get; set; }

        //Task 9: Implement an indexer this[row, col] to access the inner matrix cells.
        public dynamic this[int row, int colume] 
        {
            get 
            {
                if (row < 0 || colume < 0 || row >= this.RowCount || colume >= this.ColumeCount)
                {
                    throw new ArgumentException("Not a valid value of row/colume");
                }
                
                return this.ThisMatrix[row, colume]; 
            }
            set 
            {
                if (row < 0 || colume < 0 || row >= RowCount || colume >= ColumeCount)
                {
                    throw new ArgumentException("Not a valid value of row/colume");
                }

                this.ThisMatrix[row, colume] = value; 
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2) 
        {
            if (matrix1.RowCount != matrix2.RowCount || matrix1.ColumeCount != matrix2.ColumeCount)
            {
                throw new ArgumentException("The size of the two matrixes is different");
            }

            Matrix<T> newMatrix = new Matrix<T>(matrix1.RowCount, matrix1.ColumeCount);

            for (int row = 0; row < matrix1.RowCount; row++)
            {
                for (int col = 0; col < matrix1.ColumeCount; col++)
                {
                    newMatrix[row, col] = matrix1[row, col] + matrix2[row, col];
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.RowCount != matrix2.RowCount || matrix1.ColumeCount != matrix2.ColumeCount)
            {
                throw new ArgumentException("The size of the two matrixes is different");
            }

            Matrix<T> newMatrix = new Matrix<T>(matrix1.RowCount, matrix1.ColumeCount);

            for (int row = 0; row < matrix1.RowCount; row++)
            {
                for (int col = 0; col < matrix1.ColumeCount; col++)
                {
                    newMatrix[row, col] = matrix1[row, col] - matrix2[row, col];
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.ColumeCount != matrix2.RowCount)
            {
                throw new ArgumentException("Number of columes in first matrix is different from number of rows in second matrix");
            }

            Matrix<T> newMatrix = new Matrix<T>(matrix1.RowCount, matrix2.ColumeCount);

            for (int row = 0; row < matrix1.RowCount; row++)
            {
                for (int col = 0; col < matrix2.ColumeCount; col++)
                {
                    dynamic sum = 0;

                    for (int index = 0; index < matrix1.ColumeCount; index++)
                    {
                        sum += matrix1[row, index] * matrix2[index, col];
                    }
                    newMatrix[row, col] = sum;
                }
            }
            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            dynamic ZERO = 0;
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumeCount; j++)
                {
                    if (matrix[i, j] == ZERO)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            dynamic ZERO = 0;
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumeCount; j++)
                {
                    if (matrix[i, j] == ZERO)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }   
}