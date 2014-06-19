using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class CalculateNFactorialWithMyBigInteger
{
    //Write a program to calculate n! for each n in the range [1..100]. 
    //Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

    static long inputNumber;
    static string inputNumberAsString;

    static bool addingOne;

    static void Main()
    {
        inputNumberAsString = ValidatingTheNumberN();

        CalculatingNFactorial();
    }

    static string ValidatingTheNumberN()
    {
        Console.Write("Please input value of n to caculate n! ( n>=1 and n<=100 ): ");
        inputNumber = long.Parse(Console.ReadLine());

        if (inputNumber >= 1 && inputNumber <= 100)
        {
            inputNumberAsString = inputNumber.ToString();
        }
        else
        {
            Console.WriteLine("Invalid input!Please try again!\n");
            ValidatingTheNumberN();
        }
        return inputNumberAsString;
    }

    static char[] AlgorithmForSum(char[] longArray, char[] shortArray)
    {
        char[] arrayWithResult = new char[longArray.Length + 1];

        int value = 0;
        addingOne = false;

        //Sums all the digits with same index(FROM index '0' to index == 'Length of SHORT string') from the long and short string . 
        //Subtracts '10' from sum of digits and adds '1' to next if sum of digits >=10
        for (int index = 0; index < shortArray.Length; index++)
        {
            if (addingOne)
            {
                value = (longArray[index] - '0') + (shortArray[index] - '0') + 1;
            }
            else
            {
                value = (longArray[index] - '0') + (shortArray[index] - '0');
            }

            if (value > 9)
            {
                value -= 10;
                addingOne = true;
            }
            else
            {
                addingOne = false;
            }

            arrayWithResult[index] = (char)(value + (int)'0');
        }

        //Sums all the digits with same index(FROM index 'Length of short string' to index == Length of LONG string) from the long and short string . 
        //Subtracts '10' from sum of digits and adds '1' to next if sum of digits >=10
        for (int index = shortArray.Length; index < arrayWithResult.Length - 1; index++)
        {
            if (addingOne)
            {
                value = (longArray[index] - '0') + 1;
            }
            else
            {
                value = (longArray[index] - '0');
            }

            if (value > 9)
            {
                value -= 10;
                addingOne = true;
            }
            else
            {
                addingOne = false;
            }

            arrayWithResult[index] = (char)(value + (int)'0');
        }

        //Adds '1' in case '99 + 1'  ( Without this '99 + 1 = 00')
        if (addingOne)
        {
            arrayWithResult[arrayWithResult.Length - 1] = (char)(1 + (int)'0');
        }



        if (arrayWithResult[arrayWithResult.Length - 1] != '1')
        {
            char[] newArrayWithResult = new char[arrayWithResult.Length - 1];
            Array.Copy(arrayWithResult, 0, newArrayWithResult, 0, arrayWithResult.Length - 1);

            return newArrayWithResult;
        }
        else
        {
            return arrayWithResult;
        }
    }

    static void CalculatingNFactorial()
    {
        char[] valueOfFactoriel = { '1' };
        char[] curentArray = { '1' };

        for (int counter = 1; counter < inputNumber; counter++)
        {
            int steps = 0;
            while (steps < counter)
            {
                valueOfFactoriel = AlgorithmForSum(valueOfFactoriel, curentArray);
                steps++;
            }

            curentArray = valueOfFactoriel;
        }

        Array.Reverse(valueOfFactoriel);

        string valueOfNFactoriel = new string(valueOfFactoriel);

        Console.WriteLine("\nThe value of {0}! is: {1}\n", inputNumber, valueOfNFactoriel);
    }
}