using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class KaspichaniaBoats
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberN; i++)
        {
            if (i==0)
	        {
		        Console.WriteLine("{0}*{0}", new string('.', numberN-i));
	        }

            if (i!=0)
            {
                Console.WriteLine("{0}{1}{2}*{2}{1}{0}", new string('.', numberN - i), new string('*', 1), new string('.', i-1));
            }
        }

        Console.WriteLine("{0}", new string('*', 2*numberN + 1));

        for (int i = 0; i < (numberN - 9)/2 + 4; i++)
        {
            Console.WriteLine("{0}{1}{2}*{2}{1}{0}", new string('.', i + 1), new string('*', 1), new string('.', numberN - i - 2));
        }

        Console.WriteLine("{0}{1}{0}", new string('.', (numberN+1)/2), new string('*', numberN));
    }
}