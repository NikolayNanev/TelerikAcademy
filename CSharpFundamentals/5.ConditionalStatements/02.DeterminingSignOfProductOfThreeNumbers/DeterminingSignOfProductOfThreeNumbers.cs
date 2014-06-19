using System;

class DeterminingSignOfProductOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Shows the sign(+ or -) of the product of three real numbers.\n");
        Console.WriteLine("Please input three real numbers:");

        Console.Write("Value of first real number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Value of second real number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Value of third real number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (((firstNumber > 0) && (secondNumber > 0) && (thirdNumber > 0)) 
            || ((firstNumber < 0) && (secondNumber < 0) && (thirdNumber > 0)) 
                || ((firstNumber > 0) && (secondNumber < 0) && (thirdNumber < 0)) 
                    || ((firstNumber < 0) && (secondNumber > 0) && (thirdNumber < 0)))
        {
            Console.WriteLine("\nThe sign of the product of the three real numbers is \'+\'.");
        }

        if (((firstNumber < 0) && (secondNumber > 0) && (thirdNumber > 0)) 
            || ((firstNumber > 0) && (secondNumber < 0) && (thirdNumber > 0)) 
                || ((firstNumber > 0) && (secondNumber > 0) && (thirdNumber < 0)) 
                    || ((firstNumber < 0) && (secondNumber < 0) && (thirdNumber < 0)))
        {
            Console.WriteLine("\nThe sign of the product of the three real numbers is \'-\'.");
        }

        if ((firstNumber == 0) || (secondNumber == 0) || (thirdNumber == 0))
        {
            Console.WriteLine("\nThe product of the three real numbers is \'0\'.");
        }
    }
}