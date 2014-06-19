namespace ExceptionProject
{
    using System;

    class TestProgram
    {
        static void Main()
        {
            try
            {
                PrintNumber();
                PrintDate();
            }
            catch (Exception exeption)
            {
                Console.WriteLine("Error!" + exeption.Message);
            }
        }

        static void PrintNumber()
        {
            //If I enter number bigger or smaller than this range the method throw exeption
            int minValue = 0;
            int maxValue = 100;

            Console.WriteLine("Enter number:[{0}:{1}]", minValue, maxValue);

            int number = int.Parse(Console.ReadLine());

            if (number < minValue || number > maxValue)
            {
                throw new InvalidRangeExeption<int>(minValue, maxValue);
            }
            else
            {
                Console.WriteLine("The number {0} has valid value!", number);
            }
        }

        static void PrintDate()
        {
            //If i enter date before or after tha dates in the given range the method throws exeption

            DateTime minValue = new DateTime(1980, 1, 1);
            DateTime maxValue = new DateTime(2013, 12, 31);

            Console.WriteLine("Enter date in range {0} - {1}", minValue, maxValue);

            DateTime date = DateTime.Parse(Console.ReadLine());

            if (date < minValue || date > maxValue)
            {
                throw new InvalidRangeExeption<DateTime>(minValue, maxValue);
            }
            else
            {
                Console.WriteLine("The date {0} is valid!", date);
            }
        }
    }
}