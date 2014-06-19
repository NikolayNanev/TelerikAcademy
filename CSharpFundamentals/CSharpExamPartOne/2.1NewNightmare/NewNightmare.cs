using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NewNightmare
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        int lenghtOfString = inputString.Length;
        int sumOfNumbers = 0;
        int countOfOddNumbers = 0;

        char[] arreyWithChars = new char[lenghtOfString];
        int[] arreyWithNumbers = new int[lenghtOfString];

        for (int i = 0; i < lenghtOfString - 1; i++)
        {
            arreyWithChars[i] = inputString[i];
            arreyWithNumbers[i] = arreyWithChars[i] - '0';
        }

        for (int i = 1; i < lenghtOfString; i+=2)
        {
            sumOfNumbers += arreyWithNumbers[i];
            countOfOddNumbers++;
        }

        Console.WriteLine("{0} {1}", countOfOddNumbers, sumOfNumbers);
    }
}