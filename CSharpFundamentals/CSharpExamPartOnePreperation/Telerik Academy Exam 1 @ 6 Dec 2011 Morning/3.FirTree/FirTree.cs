using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirTree
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', numberN - 2));

        for (int i = numberN-3, j=3; i >= 0; i--,j+=2)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', j));
        }

        Console.WriteLine("{0}*{0}", new string('.', numberN - 2));

    }
}