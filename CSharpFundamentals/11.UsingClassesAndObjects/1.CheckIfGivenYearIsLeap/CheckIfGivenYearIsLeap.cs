using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckIfGivenYearIsLeap
{
    static void Main()
    {
        IsItALeapYear();
    }

    static void IsItALeapYear()
    {
        Console.Write("Please input year to check if is a leap year: ");
        int inputYear;

        bool isNumberValid = int.TryParse(Console.ReadLine(), out inputYear);

        if (isNumberValid)
        {
            bool isItALeapYear= DateTime.IsLeapYear(inputYear);

            if (isItALeapYear == true)
            {
                Console.WriteLine("\nThe year \'{0}\' is a leap year.", inputYear);
            }
            else
            {
                Console.WriteLine("\nThe year \'{0}\' is NOT a leap year.", inputYear);
            }
        }
        else
        {
            Console.WriteLine("Invalid input!Please try again!\n");
            IsItALeapYear();
        }
    }
}