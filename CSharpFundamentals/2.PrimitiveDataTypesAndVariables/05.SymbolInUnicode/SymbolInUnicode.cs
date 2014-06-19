using System;

class SymbolInUnicode
{
    static void Main()
    {
        char symbolUniCodeInHex = '\u0048';
        Console.WriteLine(symbolUniCodeInHex);

        char symbolCasting = (char)72;
        Console.WriteLine(symbolCasting);

        char symbolCastingInHex = (char)0x048;
        Console.WriteLine(symbolCastingInHex);
    }
}