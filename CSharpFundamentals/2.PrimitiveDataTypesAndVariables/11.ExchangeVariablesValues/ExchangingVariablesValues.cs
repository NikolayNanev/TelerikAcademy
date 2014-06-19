using System;

class ExchangingVariablesValues
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;
        Console.WriteLine("Starting values of the two variables:\nfirstNumber={0}\nsecondNumber={1}\n",firstNumber,secondNumber);
        int temporary;
        temporary = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temporary;
        Console.WriteLine("Values of the two variables after their exchange:\nfirstNumber={0}\nsecondNumber={1}\n", firstNumber, secondNumber);
    }
}