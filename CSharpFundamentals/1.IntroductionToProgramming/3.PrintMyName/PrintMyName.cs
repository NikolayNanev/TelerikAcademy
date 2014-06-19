using System;

class PrintMyName
{
    static void Main()
    {
        Console.Write("Моля,въведете името си:");
        string name = Console.ReadLine();
        Console.WriteLine("Здравей,{0}.",name);
    }
}