namespace Substring_ExtensionMethod
{
    using System;
    using System.Text;

    //Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder.
    //Has the same functionality as Substring in the class String.

    public static class SubstringExtensionMethod
    {
        public static StringBuilder Substring(this StringBuilder inputStringBilder, int index)
        {
            if (index >= inputStringBilder.Length || index < 0)
                throw new ArgumentOutOfRangeException("Invalid value of parameter 'index'");

            StringBuilder resultStringBilder = new StringBuilder();

            for (int i = index; i < inputStringBilder.Length; i++)
            {
                char nextChar = inputStringBilder[i];
                resultStringBilder.Append(nextChar);
            }

            return resultStringBilder;
        }

        public static StringBuilder Substring(this StringBuilder inputStringBilder, int index, int length) 
        {
            if (index >= inputStringBilder.Length || index < 0)
                throw new ArgumentOutOfRangeException("Invalid value of parameter 'index'");

            if (index + length > inputStringBilder.Length)
                throw new ArgumentOutOfRangeException("Invalid value of parameter 'length'");

            StringBuilder resultStringBilder = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                char nextChar = inputStringBilder[i];
                resultStringBilder.Append(nextChar);
            }

            return resultStringBilder;
        }      
    }
}