using System;

class DividedBySevenAndFive
{
    static void Main()
    {
        Console.Write("Please type a integer to check if it is divided by '5' and '7' at the same time without a remainder: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 35 == 0)
        {
            Console.WriteLine("\nThe typed integer is divided by '5' and '7' at the same time without a remainder.\n");
        }
        else
        {
            Console.WriteLine("\nThe typed integer couldn't be divided by '5' and '7' at the same time without a remainder.\n");
        }
    }
}