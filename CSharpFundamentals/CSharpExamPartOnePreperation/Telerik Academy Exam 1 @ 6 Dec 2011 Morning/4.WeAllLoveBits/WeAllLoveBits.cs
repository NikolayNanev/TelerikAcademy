using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WeAllLoveBits
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberN; i++)
        {
            long nextNumber = long.Parse(Console.ReadLine());



            Console.WriteLine("{0}",nextNumber);
        }

        //Console.WriteLine((19^12)&25);
    }
}
