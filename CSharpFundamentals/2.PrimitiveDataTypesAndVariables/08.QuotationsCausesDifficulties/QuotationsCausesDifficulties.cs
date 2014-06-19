using System;

class QuotationsCausesDifficulties
{
    static void Main()
    {
        string withoutQuotedString = "The \"use\" of quotations causes difficulties.";
        string quotedString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(withoutQuotedString);
        Console.WriteLine(quotedString);
    }
}