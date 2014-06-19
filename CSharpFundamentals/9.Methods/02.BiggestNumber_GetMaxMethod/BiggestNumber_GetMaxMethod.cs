using System;

class BiggestNumber_GetMaxMethod
{
    static void Main()
    {
        int firstNumber;
        int secondtNumber;
        int thirdNumber;

        InitializingValuesOfNumbers(out firstNumber, out secondtNumber, out thirdNumber);

        int maxNumber = GetMax(GetMax(firstNumber,secondtNumber),thirdNumber);

        Console.WriteLine("\nThe biggest number has value \'{0}\'.", maxNumber);
    }

    static void InitializingValuesOfNumbers(out int firstNumber, out int secondtNumber, out int thirdNumber)
    {
        Console.WriteLine("Please input 3 integer numbers:");

        Console.Write("Please input first number: ");
        firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please input second number: ");
        secondtNumber = int.Parse(Console.ReadLine());

        Console.Write("Please input third number: ");
        thirdNumber = int.Parse(Console.ReadLine());
    }

    static int GetMax(int numberOne, int numberTwo)
    {
        int biggerNumber = numberTwo;

        if (numberOne > numberTwo)
        {
            biggerNumber = numberOne;
        }
        
        return biggerNumber;
    }
}