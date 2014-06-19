using System;
using System.IO;

class AddingTwoBigPositiveIntegerNumbers
{
    //Write a method that adds two positive integer numbers represented as arrays of digits. 
    //Each array element arr[i] contains a digit; the last digit is kept in arr[0]. 
    //Each of the numbers that will be added could have up to 10 000 digits.

    static bool addingOne;
    static char[] sumOfNumbersArray;

    static void Main()
    {
        Console.Write("Please input the first integer number (NO letters): ");
        string firstIntegerNumber = Console.ReadLine();
        char[] firstNumberAsArrayReversed = ConvertingStringToArrayAndReversingIt(firstIntegerNumber);

        Console.Write("Please input the second integer number (NO letters): ");
        string secondIntegerNumber = Console.ReadLine();
        char[] secondNumberAsArrayReversed = ConvertingStringToArrayAndReversingIt(secondIntegerNumber);

        if (firstIntegerNumber.Length >= secondIntegerNumber.Length)
        {
            sumOfNumbersArray = AlgorithmForSum(firstNumberAsArrayReversed, secondNumberAsArrayReversed);
        }
        else
        {
            sumOfNumbersArray = AlgorithmForSum(secondNumberAsArrayReversed, firstNumberAsArrayReversed);
        }
        
        Array.Reverse(sumOfNumbersArray);

        string sumOfNumbersString = new string(sumOfNumbersArray);

        Console.WriteLine("\n{0} + {1} = {2}\n",firstIntegerNumber, secondIntegerNumber, sumOfNumbersString);
    }

    static char[] ConvertingStringToArrayAndReversingIt(string inputString)
    {
        char[] charArray = new char[inputString.Length];

        using (StringReader readString = new StringReader(inputString))
        {
            readString.Read(charArray, 0, charArray.Length);
        }

        Array.Reverse(charArray);

        return charArray;
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
}