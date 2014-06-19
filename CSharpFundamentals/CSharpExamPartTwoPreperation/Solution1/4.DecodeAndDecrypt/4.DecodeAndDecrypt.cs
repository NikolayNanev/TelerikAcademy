using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecodeAndDecrypt
{
    //
    //

    //BKOXHI\EQOGX[YSOFTWARE8	TELERIKACADEMY
    //ABBAA6BA7	                AAABB
    //KKICXDE3P5	            JOHNY

    static void Main()
    {
        string inputString = "ABBAA6BA7";// Console.ReadLine();

        int lengthOfCypher = inputString[inputString.Length - 1] - '0';

        var bilderForLength = new StringBuilder(inputString);
        string stringToDecode = bilderForLength.Remove(inputString.Length - 1, 1).ToString();

        Console.WriteLine("{0}  {1}", lengthOfCypher, stringToDecode);

        string resultFromDecode = Decode(stringToDecode);

        Console.WriteLine(resultFromDecode);

        var bilderForDecryptedMessage = new StringBuilder(resultFromDecode);
        string decryptedMessage = bilderForDecryptedMessage.Remove(resultFromDecode.Length - lengthOfCypher, lengthOfCypher).ToString();

        var bilderForCypher = new StringBuilder(resultFromDecode);
        string cypher = bilderForCypher.Remove(0, resultFromDecode.Length - lengthOfCypher).ToString();


        Console.WriteLine("msg " + decryptedMessage);
        Console.WriteLine("cpr " + cypher);

        //string originalMessage = Decrypt(decryptedMessage, cypher)
    }

    static string Decode(string text) 
    {
        var listWithCode = new List<char>();

        for (int i = 0; i < text.Length; i++)
        {
            int numberAsInt = 0;
            string numberAsString = new string(text[i], 1);

            bool isItANumber = int.TryParse(numberAsString, out numberAsInt);

            if (isItANumber)       //if true
            {
                for (int j = 0; j < numberAsInt; j++)
                {
                    listWithCode.Add(text[i + 1]);
                }

                i += 1;
            }
            else
            {
                listWithCode.Add(text[i]);
            }
        }

        //string dogCsv = string.Join(",", dogs.ToArray())

        string str = string.Join("", listWithCode.ToArray());

        return str;
    }

    static string Decrypt(string text, string cypher)
    {
        //TODO
        string str = "0";
        return str;
    }
}
