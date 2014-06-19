using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReadStringReverseItAndPrintsResult
{
    //Write a program that reads a string, reverses it and prints the result at the console.
    //Example: "sample" -->> "elpmas".

    static void Main()
    {
        ReadStringReverseItAndPrintingIt();

    }

    static void ReadStringReverseItAndPrintingIt()
    {
        Console.Write("Please input a string to be reversed: ");
        string inputString = Console.ReadLine();

        char[] stringAsArrayOfChars = new char[inputString.Length];

        stringAsArrayOfChars = inputString.ToCharArray();

        Array.Reverse(stringAsArrayOfChars);

        string outputString = new string(stringAsArrayOfChars);

        Console.WriteLine("{0}", outputString);
    }
}
