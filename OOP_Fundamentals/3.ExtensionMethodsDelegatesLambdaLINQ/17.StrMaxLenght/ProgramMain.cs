namespace _17.StrMaxLenght
{
    using System;
    using System.Linq;

    class ProgramMain
    {
        //Write a program to return the string with maximum length from an array of strings. Use LINQ.

        static void Main()
        {
            string[] arrayWithStrings = { "dasds", "kjh", "sad", "dasds", "rer", "fd", "64565646", "f26ds1" };

            var wordWithMaxLength =
                from word in arrayWithStrings
                orderby word.Length descending
                select word;

            Console.WriteLine("Longest string in array: \"{0}\"", wordWithMaxLength.ElementAt(0));
        }
    }
}
