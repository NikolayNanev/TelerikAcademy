using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        ulong inputNumber = ulong.Parse(Console.ReadLine());

        var codeList = new string[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

        var numberIn9Base = ConvertNumTo9Base(inputNumber);

        var arrayWithResult = new string[numberIn9Base.Length];

        for (int i = 0; i < numberIn9Base.Length; i++)
        {
            int valueOnCurentIndex = numberIn9Base[i] - '0';
            arrayWithResult[i] = codeList[valueOnCurentIndex];
        }

        var result = string.Join("", arrayWithResult);
        var newResult = result.Trim();
        
        //string myString = string.Join("", result.ToArray());

        Console.WriteLine(newResult);

    }

    static string ConvertNumTo9Base(ulong decNum)
    {
        List<ulong> result = new List<ulong>();
        while (decNum > 0)
        {
            result.Add(decNum % 9);
            decNum /= 9;
        }
        result.Reverse();

        string myString = string.Join("", result.ToArray());

        //string dogCsv = string.Join(",", dogs.ToArray());

        return myString;
    }
}
