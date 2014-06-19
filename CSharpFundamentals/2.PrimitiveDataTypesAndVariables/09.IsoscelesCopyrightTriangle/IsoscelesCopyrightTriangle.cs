using System;

class IsoscelesCopyrightTriangle
{
    static void Main()
    {
        char copyright = '\u00A9';
        Console.WriteLine(@"   {0}
  {0} {0}
 {0}   {0}
{0} {0} {0} {0}", copyright);    
    }
}