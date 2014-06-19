using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintingNumberOfRandomValuesInAGivenRange
{
    //Write a program that generates and prints to the console 10 random values in the range [100, 200].

    const int NUMBER_OF_NUMBERS = 10;
    static double[] arrayWithRandomNumb = new double[NUMBER_OF_NUMBERS];
    

    static void Main()
    {
        UsingRandomClass();

        PrintingResult();
    }

    static void UsingRandomClass()
    {
        Random randomNum = new Random();

        for (int index = 0; index < NUMBER_OF_NUMBERS; index++)
        {
            arrayWithRandomNumb[index] = randomNum.Next(100, 200);
        }
    }

    static void PrintingResult()
    {
        Console.WriteLine("Ten random numbers:");
        foreach (double element in arrayWithRandomNumb)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}