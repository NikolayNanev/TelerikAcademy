using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MultiverseCommunication
{
    static void Main()
    {
        List<string>  codeList = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };

        string inputString = Console.ReadLine();

        long decimalRepresentation = 0;

        for (int i = 0; i < inputString.Length; i += 3)
        {
            var valueOfSubString = inputString.Substring(i, 3);
            var indexOfSubString = codeList.IndexOf(valueOfSubString);
            
            decimalRepresentation *= 13;
            decimalRepresentation += indexOfSubString;
        }

        Console.WriteLine("{0}", decimalRepresentation);
    }
}
