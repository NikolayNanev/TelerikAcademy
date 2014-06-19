using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class CompareTwoArraysLexicographically
{
    //Write a program that compares two char arrays lexicographically (letter by letter).

    static void Main()
    {
        Console.WriteLine("Comparing two char arrays lexicographically\n{0}", new string('-', 43));

        char[] firstCharArray;
        char[] secondCharArray;
        InitializingLengthAndElementsOfArrays(out firstCharArray, out secondCharArray);

        AlgoForLexicographicalComparing(firstCharArray, secondCharArray);
    }

    private static void AlgoForLexicographicalComparing(char[] firstCharArray, char[] secondCharArray)
    {
        for (int i = 0; i < Math.Min(firstCharArray.Length, secondCharArray.Length); i++)
        {
            if (firstCharArray[i] < secondCharArray[i])
            {
                Console.WriteLine("\nThe first array is the \"earlier\" array.");
                break;
            }

            else if (firstCharArray[i] > secondCharArray[i])
            {
                Console.WriteLine("\nThe second array is the \"earlier\" array.");
                break;
            }

            else if (firstCharArray[firstCharArray.Length - 1] == secondCharArray[secondCharArray.Length - 1])
            {
                Console.WriteLine("\nThe two arrays're equal.");
                break;
            }

            if (firstCharArray.Length < secondCharArray.Length)
            {
                if (i == firstCharArray.Length - 1)
                {
                    Console.WriteLine("\nThe first array is the \"earlier\" array.");
                }
            }

            if (firstCharArray.Length > secondCharArray.Length)
            {
                if (i == secondCharArray.Length - 1)
                {
                    Console.WriteLine("\nThe second array is the \"earlier\" array.");
                }
            }
        }
    }

    private static void InitializingLengthAndElementsOfArrays(out char[] firstCharArray, out char[] secondCharArray)
    {
        Console.Write("Please input the chars of the first array as STRING: ");
        string firstInputString = Console.ReadLine();
        Console.Write("Please input the chars of the second array as STRING: ");
        string secondInputString = Console.ReadLine();

        firstCharArray = new char[firstInputString.Length];
        secondCharArray = new char[secondInputString.Length];

        using (StringReader readFirstString = new StringReader(firstInputString))
        {
            readFirstString.Read(firstCharArray, 0, firstCharArray.Length);
        }

        using (StringReader readSecondString = new StringReader(secondInputString))
        {
            readSecondString.Read(secondCharArray, 0, secondCharArray.Length);
        }
    }
}