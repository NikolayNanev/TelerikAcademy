using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddNumber
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        long currentNumber;
        long result = 0;

        for (int i = 0; i < numberN; i++)
        {
            currentNumber = long.Parse(Console.ReadLine());
            result = result ^ currentNumber;
        }
        
        Console.WriteLine(result);
    }
}