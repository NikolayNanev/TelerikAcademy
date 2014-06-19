using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Please type a integer to check if it is ODD or EVEN: ");
        int numberToCheck = int.Parse(Console.ReadLine());

        if (numberToCheck % 2 == 0 )
        {
            Console.WriteLine("\nThe typed integer is: EVEN\n");
        }
        else
        {
            Console.WriteLine("\nThe typed integer is: ODD\n");
        }
    }
}