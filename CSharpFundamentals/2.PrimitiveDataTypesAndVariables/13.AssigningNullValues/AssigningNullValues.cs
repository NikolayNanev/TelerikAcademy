using System;

class AssigningNullValues
{
    static void Main()
    {
        int? nullInteger = null;
        double? nullDouble = null;
        string nullString = "null";
        Console.WriteLine("{0}\n{0}\n{2} ",nullInteger,nullDouble,nullString);
    }
}