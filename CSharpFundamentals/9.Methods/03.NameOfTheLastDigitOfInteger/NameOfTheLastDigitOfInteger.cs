using System;

class NameOfTheLastDigitOfInteger
{
    //Write a method that returns the last digit of given integer as an English word. 
    //Examples: 512 --->> "two"
    //         1024 --->> "four", 
    //        12309 --->> "nine"


    static void Main()
    {
        Console.Write("Please input an integer number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        ReturningLastDigit(inputNumber);     
    }

    static void ReturningLastDigit(int numberToCheck)
    {
        int lastDigit = Math.Abs(numberToCheck % 10);

        string[] arrayWithNamesOfDigits = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        Console.Write("\nThe last digit is: {0}\n\n", arrayWithNamesOfDigits[lastDigit]);

        /*
        switch (lastDigit)
        {
            case 0:
                Console.WriteLine("Zero"); break;
            case 1:
                Console.WriteLine("One"); break;
            case 2:
                Console.WriteLine("Two"); break;
            case 3:
                Console.WriteLine("Three"); break;
            case 4:
                Console.WriteLine("Four"); break;
            case 5:
                Console.WriteLine("Five"); break;
            case 6:
                Console.WriteLine("Six"); break;
            case 7:
                Console.WriteLine("Seven"); break;
            case 8:
                Console.WriteLine("Eight"); break;
            case 9:
                Console.WriteLine("Nine"); break;
            default:
                Console.WriteLine("How did you print this?!?"); break;
        }
         */
    }
}