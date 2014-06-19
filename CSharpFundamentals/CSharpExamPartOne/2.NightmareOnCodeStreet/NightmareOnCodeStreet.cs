using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NightmareOnCodeStreet
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        int inputNumber;
        bool result = int.TryParse(inputString, out inputNumber);

        int digitsOfNumber = inputString.Length;
        int sumOfNumbers = 0;
        int countOddNumbers = 0;
        int tepmNumber = 0;
        
        if ((digitsOfNumber % 2) == 0)
        {
            for (int i = 1, j = 1; i <= digitsOfNumber; i += 2, j *= 100)
            {
                tepmNumber = inputNumber / j;
                sumOfNumbers += (tepmNumber % 10);
                countOddNumbers++;
            }
        }

        else if ((digitsOfNumber % 2) != 0)
        {
            for (int i = 2, j = 10; i <= digitsOfNumber; i += 2, j *= 100)
            {
                tepmNumber = inputNumber / j;
                sumOfNumbers += (tepmNumber % 10);
                countOddNumbers++;
            }
        }

        Console.WriteLine("{0} {1}", countOddNumbers, sumOfNumbers);
    }
}