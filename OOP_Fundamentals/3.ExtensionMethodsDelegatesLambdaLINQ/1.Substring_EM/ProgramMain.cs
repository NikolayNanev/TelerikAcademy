namespace Substring_ExtensionMethod
{
    using System;
    using System.Text;

    public class ProgramMain
    {
        static void Main()
        {
            //Printing original string
            StringBuilder myStringBilder = new StringBuilder("0123456789");
            Console.WriteLine("Printing original string: {0}", myStringBilder);

            //Printing string after applying Substring(index, length)
            var subString = myStringBilder.Substring(2, 5);
            Console.WriteLine("Printing string after applying Substring(index, length): {0}", subString);

            //Printing string after applying Substring(index)
            var newSubString = myStringBilder.Substring(2);
            Console.WriteLine("Printing string after applying Substring(index): {0}", newSubString);
        }
    }
}