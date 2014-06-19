using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CartesianCoordinateSystem
{
    static void Main()
    {
        double valueOfX = double.Parse(Console.ReadLine());
        double valueOfY = double.Parse(Console.ReadLine());

        if (valueOfX == 0 || valueOfY == 0)
        {
            if (valueOfX == 0 && valueOfY == 0)
            {
                Console.WriteLine("0");
            }

            else if (valueOfX == 0 && valueOfY != 0)
            {
                Console.WriteLine("5");
            }

            else if (valueOfX != 0 && valueOfY == 0)
            {
                Console.WriteLine("6");
            }   
        }

        if (valueOfX > 0 && valueOfY > 0)
        {
            Console.WriteLine("1");
        }

        if (valueOfX > 0 && valueOfY < 0)
        {
            Console.WriteLine("4");
        }

        if (valueOfX < 0 && valueOfY > 0)
        {
            Console.WriteLine("2");
        }

        if (valueOfX < 0 && valueOfY < 0)
        {
            Console.WriteLine("3");
        }
    }
}