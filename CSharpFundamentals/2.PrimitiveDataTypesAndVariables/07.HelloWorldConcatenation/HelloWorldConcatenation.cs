using System;

class HelloWorldConcatenation
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object concatenation = firstString + " " + secondString;
        string thirdString = (string)concatenation;
        Console.WriteLine(thirdString);
    }
}