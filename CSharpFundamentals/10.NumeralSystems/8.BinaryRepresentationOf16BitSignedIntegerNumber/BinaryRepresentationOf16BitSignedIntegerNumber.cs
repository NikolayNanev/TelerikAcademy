using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryRepresentationOf16BitSignedIntegerNumber
{
    //Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

    static int my16BitSignedNumber;
    static string binaryRepresentation;

    static void Main()
    {
        ValidatingInputNumber();

        Console.WriteLine("The binary representation of \'{0}\' is \'{1}\'", my16BitSignedNumber, binaryRepresentation);
    }

    static void ValidatingInputNumber()
    {
        Console.Write("Please input a number of type short ( between -32768 and 32767 ): ");
        bool isItValid = int.TryParse(Console.ReadLine(), out my16BitSignedNumber);

        int[] arrayItDigits = new int[16];

        if (isItValid && my16BitSignedNumber > -32767 && my16BitSignedNumber < 32768)
        {
            int dividedNumber;
            int curentPosition = 15;

            if (my16BitSignedNumber >= 0)
            {
                arrayItDigits[0] = 0;
                dividedNumber = my16BitSignedNumber;

                while (dividedNumber > 0)
                {
                    arrayItDigits[curentPosition] = dividedNumber % 2;
                    dividedNumber = dividedNumber / 2;
                    curentPosition--;
                }
                
                binaryRepresentation = String.Join("", new List<int>(arrayItDigits).ConvertAll(i => i.ToString()).ToArray());
            }
            else
            {
                dividedNumber = 32768 - Math.Abs(my16BitSignedNumber);
                arrayItDigits[0] = 1;

                while (dividedNumber > 0)
                {
                    arrayItDigits[curentPosition] = dividedNumber % 2;
                    dividedNumber = dividedNumber / 2;
                    curentPosition--;
                }

                binaryRepresentation = String.Join("", new List<int>(arrayItDigits).ConvertAll(i => i.ToString()).ToArray());
            }
        }
        else
        {
            Console.WriteLine("\nNot a valid input!");
            ValidatingInputNumber();
        }
    }
}
