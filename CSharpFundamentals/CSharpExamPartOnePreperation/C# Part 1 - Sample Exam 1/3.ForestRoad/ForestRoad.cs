using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ForestRoad
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberN; i++)
        {
            for (int j = 1; j <= numberN; j++)
            {
                if (j==i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }   
            }
            Console.WriteLine();
        }

        for (int i = 1; i <= numberN-1; i++)
        {
            for (int j = 1; j <= numberN; j++)
            {
                if (i == numberN-j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}