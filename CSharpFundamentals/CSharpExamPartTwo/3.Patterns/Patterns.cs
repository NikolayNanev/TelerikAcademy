using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Patterns
{
    static void Main()
    {
        int dimencionOfMatrix = int.Parse(Console.ReadLine());

        long[,] matrix = new long[dimencionOfMatrix, dimencionOfMatrix];

        for (int i = 0; i < dimencionOfMatrix; i++)
        {
            string curentLine = Console.ReadLine();

            string[] curentLineSplit = curentLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < curentLineSplit.Length; j++)
            {
                matrix[i, j] = Convert.ToInt64(curentLineSplit[j]);
            }
        }

        long bestSum = long.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 4; col++)
            {
                long A = matrix[row, col];
                long B = matrix[row, col + 1];
                long C = matrix[row, col + 2];

                long D = matrix[row + 1, col + 2];

                long E = matrix[row + 2, col + 2];
                long F = matrix[row + 2, col + 3];
                long G = matrix[row + 2, col + 4];

                long curentSum = long.MinValue;

                if (A+1==B && B+1==C && C+1==D && D+1==E && E+1==F && F+1==G)
                {
                    curentSum = A + B + C + D + E + F + G;
                }

                if (curentSum > bestSum)
                {
                    bestSum = curentSum;
                }
            }
        }

        if (bestSum == long.MinValue)
        {
            long diagonalSum = 0;

            for (int i = 0; i < dimencionOfMatrix; i++)
            {
                diagonalSum += matrix[i, i];
            }

            Console.WriteLine("NO {0}", diagonalSum);
        }

        else
        {
            Console.WriteLine("YES {0}", bestSum);
        }
    }
}