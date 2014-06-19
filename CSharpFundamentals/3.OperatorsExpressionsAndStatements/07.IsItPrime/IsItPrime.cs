using System;

class IsItPrime
{
    static void Main()
    {
        Console.WriteLine("Checking if a given integer number is a prime number.");
        Console.Write("Please enter an integer number: ");
        int numberToCheck = int.Parse(Console.ReadLine());
        int divider = 2;
        bool theNumberIsPrime = true;
        while (theNumberIsPrime && (divider <= (int)Math.Sqrt(numberToCheck)))
        {
            if (numberToCheck % divider == 0)
            {
                theNumberIsPrime = false;
            }
            divider++;
        }
        if (theNumberIsPrime == false)
        {
            Console.WriteLine("The number \'{0}\' is NOT prime.", numberToCheck);
        }
        if (theNumberIsPrime == true)
        {
            Console.WriteLine("The number \'{0}\' IS prime.", numberToCheck);
        }
    }
}

/*
 Console.WriteLine("How old are you?");
        string inputYears = Console.ReadLine();
        int yearsNow;
        while(!int.TryParse(inputYears, out yearsNow))
        {
            Console.WriteLine("Try again!");
            inputYears = Console.ReadLine();
            
        }
        int after10Years = yearsNow + 10;
        Console.WriteLine("In 10 years you will be {0} years old.", after10Years);
    }
 */