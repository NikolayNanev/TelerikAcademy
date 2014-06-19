using System;

public class PrintNameMethod
{
    //Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
    //Write a program to test this method.

    static void Main()
    {
        Console.Write("Please write your name: ");
        string inputName = Console.ReadLine();
        HelloMethod(inputName);
    }

    public static string HelloMethod(string name)
    {
        name = "Hello," + name + ".";
        Console.WriteLine(name);
        return name;
    }
}