using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trapezoid
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}", new string('.', numberN), new string('*', numberN));

        for (int i = numberN-1; i >= 1; i--)
        {
            Console.WriteLine("{0}*{1}*", new string('.', i), new string('.', 2 * numberN - 2 - i));
        }

        Console.WriteLine("{0}", new string('*', 2*numberN));
    }
}