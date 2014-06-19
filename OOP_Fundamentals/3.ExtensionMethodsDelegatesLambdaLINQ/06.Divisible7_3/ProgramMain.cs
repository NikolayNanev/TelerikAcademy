namespace DivisibleBySevenandThree
{
    using System;
    using System.Linq;

    class ProgramMain
    {
        //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
        //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.


        static void Main()
        {
            const int ZERO = 0;
            const int THREE = 3;
            const int SEVEN = 7;
            const int TWENTY_ONE = 21;

            long[] arrayWithIntegers = { 21, 2, 420, 4, 12, 105, 147 };

            //Usning built-in extension methods and lambda expressions

            long[] numbersDevisBy3and7 = arrayWithIntegers.Where(x => (x % THREE) == ZERO && (x % SEVEN) == ZERO).ToArray();
            long[] numbersDevisBy21 = Array.FindAll(arrayWithIntegers, x => (x % TWENTY_ONE) == ZERO);

            PrintArray(numbersDevisBy3and7);
            PrintArray(numbersDevisBy21);

            //Usning LINQ
            var numbersDevisBy3and7LINQ =
                from number in arrayWithIntegers
                where (number % THREE) == ZERO
                where (number % SEVEN) == ZERO
                select number;

            PrintArray(numbersDevisBy3and7LINQ);

        }

        private static void PrintArray(dynamic array)
        {
            foreach (var number in array)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
