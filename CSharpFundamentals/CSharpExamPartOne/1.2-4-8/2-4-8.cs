using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TwoFourEight
{
    static void Main()
    {
        int numberA = int.Parse(Console.ReadLine());
        int numberB = int.Parse(Console.ReadLine());
        int numberC = int.Parse(Console.ReadLine());

        int? numberR = null;

        if (numberB == 2)
        {
            numberR = numberA % numberC;
        }

        else if (numberB == 4)
        {
            numberR = numberA + numberC;
        }

        else if (numberB == 8)
        {
            numberR = numberA * numberC;
        }

        if ((numberR % 4) == 0)
        {
            Console.WriteLine("{0}", numberR / 4);
        }

        else 
        {
            Console.WriteLine("{0}", numberR % 4);
        }

        Console.WriteLine("{0}",numberR);
    }
}