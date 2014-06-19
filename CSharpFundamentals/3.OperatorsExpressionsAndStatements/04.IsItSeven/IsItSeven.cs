using System;

class IsItSeven
{
    static void Main()
    {
        Console.WriteLine("Determining if the third digit is '7'.");
        Console.Write("Please type a integer:");
        int number = int.Parse(Console.ReadLine());
        number = number / 100;
        if ((number % 10) == 7)
        {
            Console.WriteLine("YES, it is '7'.\n");
        }
        else
        {
            Console.WriteLine("NO, it isn't '7'.\n");
        }
    }
}