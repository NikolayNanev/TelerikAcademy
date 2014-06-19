using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger firstNumber = new BigInteger(long.Parse(Console.ReadLine()));
        BigInteger secondNumber = new BigInteger(long.Parse(Console.ReadLine()));
        BigInteger thirdNumber = new BigInteger(long.Parse(Console.ReadLine()));

        decimal numberN = decimal.Parse(Console.ReadLine());
        BigInteger theNthNumber = 0;

        if (numberN == 1)
        {
            theNthNumber = firstNumber;
        }
        else if (numberN == 2)
        {
            theNthNumber = secondNumber;
        }
        else if (numberN == 3)
        {
            theNthNumber = thirdNumber;
        }

        else
	    {
            for (int i = 4; i <= numberN; i++)
            {
                theNthNumber = firstNumber + secondNumber + thirdNumber;

                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = theNthNumber;
            }
	    }
        

        Console.WriteLine("{0}", theNthNumber);
    }
}