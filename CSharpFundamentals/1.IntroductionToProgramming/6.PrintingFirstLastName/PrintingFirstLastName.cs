using System;

class PrintingFirstLastName
{
    static void Main()
    {
        string firstName;
        string lastName;
        Console.Write("Моля,напишете собственото си име:");
        firstName = Console.ReadLine();
        Console.Write("Моля,напишете фамилията си:");
        lastName = Console.ReadLine();
        Console.WriteLine("Здравей,{0} {1}.",firstName,lastName);
    }
}