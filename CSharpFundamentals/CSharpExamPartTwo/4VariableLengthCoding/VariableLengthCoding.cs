using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

public class AlphanumComparatorFast : IComparer
{
    public int Compare(object x, object y)
    {
        string s1 = x as string;
        if (s1 == null)
        {
            return 0;
        }
        string s2 = y as string;
        if (s2 == null)
        {
            return 0;
        }

        int len1 = s1.Length;
        int len2 = s2.Length;
        int marker1 = 0;
        int marker2 = 0;

        // Walk through two the strings with two markers.
        while (marker1 < len1 && marker2 < len2)
        {
            char ch1 = s1[marker1];
            char ch2 = s2[marker2];

            // Some buffers we can build up characters in for each chunk.
            char[] space1 = new char[len1];
            int loc1 = 0;
            char[] space2 = new char[len2];
            int loc2 = 0;

            // Walk through all following characters that are digits or
            // characters in BOTH strings starting at the appropriate marker.
            // Collect char arrays.
            do
            {
                space1[loc1++] = ch1;
                marker1++;

                if (marker1 < len1)
                {
                    ch1 = s1[marker1];
                }
                else
                {
                    break;
                }
            } while (char.IsDigit(ch1) == char.IsDigit(space1[0]));

            do
            {
                space2[loc2++] = ch2;
                marker2++;

                if (marker2 < len2)
                {
                    ch2 = s2[marker2];
                }
                else
                {
                    break;
                }
            } while (char.IsDigit(ch2) == char.IsDigit(space2[0]));

            // If we have collected numbers, compare them numerically.
            // Otherwise, if we have strings, compare them alphabetically.
            string str1 = new string(space1);
            string str2 = new string(space2);

            int result;

            if (char.IsDigit(space1[0]) && char.IsDigit(space2[0]))
            {
                int thisNumericChunk = int.Parse(str1);
                int thatNumericChunk = int.Parse(str2);
                result = thisNumericChunk.CompareTo(thatNumericChunk);
            }
            else
            {
                result = str1.CompareTo(str2);
            }

            if (result != 0)
            {
                return result;
            }
        }
        return len1 - len2;
    }
}

class VariableLengthCoding
{
    static void Main()
    {
        string firstLine = Console.ReadLine();

        string[] firstLineSplit = firstLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var firstLineInBinary = new string[firstLineSplit.Length];

        for (int i = 0; i < firstLineSplit.Length; i++)
        {
            firstLineInBinary[i] = ConvertNumToNBinaryBase(firstLineSplit[i]);
        }

        var bilder = new StringBuilder();

        for (int j = 0; j < firstLineInBinary.Length; j++)
        {
            bilder.Append(firstLineInBinary[j]);
        }

        string concatenatedStringWithBinary = bilder.ToString();

        int numberOfLines = int.Parse(Console.ReadLine());

        var arrayWithLinesInCodeTable = new string[numberOfLines];

        for (int i = 0; i < numberOfLines; i++)
        {
            arrayWithLinesInCodeTable[i] = Console.ReadLine();
        }

        string[] copyArray = (string[])arrayWithLinesInCodeTable.Clone();

        //var bilder2 = new StringBuilder(arrayWithLinesInCodeTable);


        string[] newArray = new string[numberOfLines];

        for (int i = 0; i < numberOfLines; i++)
        {
            var bilder2 = new StringBuilder(arrayWithLinesInCodeTable[i]);

            char valueOfChar = arrayWithLinesInCodeTable[i][0];

            bilder2.Remove(0, 1);
            bilder2.Append(valueOfChar);

            newArray[i] = bilder2.ToString();
        }

        var values = new string[numberOfLines];

        for (int i = 0; i < numberOfLines; i++)
        {
            values[i] = (i + 1).ToString() + (char)i;
        }

        Array.Sort(newArray, new AlphanumComparatorFast());

        

        string[] encoding = new string[numberOfLines];

        var bilder3 = new StringBuilder();

        for (int i = 0; i < numberOfLines; i++)
        {
            encoding[i] = bilder3.Append('1').ToString().Trim();
        }

        string replaced = concatenatedStringWithBinary;

        for (int i = numberOfLines; i > 0; i--)
        {
            replaced = replaced.Replace(encoding[i - 1], newArray[i - 1][1].ToString());
        }

        replaced = replaced.Replace("0","");


        Console.WriteLine(replaced);

    }

    static string ConvertNumToNBinaryBase(string number)
    {
        int numberAsInt = Convert.ToInt32(number);

        List<int> result = new List<int>();

        while (numberAsInt > 0)
        {
            result.Add(numberAsInt % 2);
            numberAsInt /= 2;
        }
        result.Reverse();

        string myString = string.Join("", result.ToArray());

        //TODO
        //HAs to be int to make it String
        //string s = myString.ToString("D8");

        return myString;
    }


}