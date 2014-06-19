using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ComparingTwoArraysElementByElement
{
    //Write a program that reads two arrays from the console and compares them element by element.

    static int lengthOfArray;

    static void Main()
    {
        Console.WriteLine("Reading two arrays from the console and compares them element by element.\n{0}", new string('-', 50));

        InitializingLengthOfArray();

        double[] firstArray;
        double[] secondArray;

        InitializingElementsOfArrays(out firstArray, out secondArray);

        AlgoForComparingTwoArrays(firstArray, secondArray);

        Console.WriteLine();
    }

    public static void InitializingLengthOfArray()
    {
        bool checkForLengthOfArray = true;

        while (checkForLengthOfArray)
        {
            Console.Write("Please input the length of the arrays: ");
            lengthOfArray = int.Parse(Console.ReadLine());

            if (lengthOfArray < 0)
            {
                Console.WriteLine("The length of the arrays must be greater or equel to 0.Please input the length of the array again!\n");
            }
            else
            {
                checkForLengthOfArray = false;
            }
        }
    }

    private static void InitializingElementsOfArrays(out double[] firstArray, out double[] secondArray)
    {
        firstArray = new double[lengthOfArray];
        secondArray = new double[lengthOfArray];

        Console.WriteLine();

        for (int i = 0; i < lengthOfArray; i++)
        {
            Console.Write("Input firstArray[{0}]= ", i);
            firstArray[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        for (int j = 0; j < lengthOfArray; j++)
        {
            Console.Write("Input secondArray[{0}]= ", j);
            secondArray[j] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine();
    }

    private static void AlgoForComparingTwoArrays(double[] firstArray, double[] secondArray)
    {
        for (int k = 0; k < lengthOfArray; k++)
        {
            if (firstArray[k] == secondArray[k])
            {
                Console.WriteLine("Equel     --->>> firstArray[{0}]={1}  secondArray[{0}]={2}", k, firstArray[k], secondArray[k]);
            }
            else
            {
                Console.WriteLine("NOT equel --->>> firstArray[{0}]={1}  secondArray[{0}]={2} ", k, firstArray[k], secondArray[k]);
            }
        }
    }
}