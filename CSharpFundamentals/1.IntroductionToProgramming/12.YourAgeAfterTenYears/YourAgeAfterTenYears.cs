using System;

class YourAgeAfterTenYears
{
    static void Main()
    {
        int yearOfBirth;

        while (true)
        {
            Console.Write("Please enter the year you were born:");
            yearOfBirth = int.Parse(Console.ReadLine());
            if (yearOfBirth >= 1898 && yearOfBirth < DateTime.Now.Year)
            {
                break;
            }

            if (yearOfBirth < 1900)
                {
                    Console.WriteLine("The oldest living person is 115.You aren't {0} years old.\n", DateTime.Now.Year - yearOfBirth);
                }

            if (yearOfBirth > DateTime.Now.Year)
                {
                    Console.WriteLine("You're NOT born?!?\n");
                }            
        }
        int yourAgeNow = DateTime.Now.Year - yearOfBirth;
        Console.WriteLine("Your age now is {0} and you will be {1} years old after 10 years.\n", yourAgeNow, yourAgeNow+10);
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