using System;

class SolvingQuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Finding real roots of a quadratic equation ax^2+bx+c=0.");
        Console.Write("\nInput value of 'a': ");
        float aNumber = float.Parse(Console.ReadLine());

        Console.Write("Input value of 'b': ");
        float bNumber = float.Parse(Console.ReadLine());

        Console.Write("Input value of 'c': ");
        float cNumber = float.Parse(Console.ReadLine());

        float discriminant = bNumber * bNumber - 4 * aNumber * cNumber;

        if (aNumber == 0 && bNumber == 0 && cNumber == 0)
        {
            Console.WriteLine("\nThere are an infinit number of real roots!");
        }

        else if (discriminant < 0 || (aNumber == 0 && bNumber == 0 && cNumber != 0))
        {
            Console.WriteLine("\nThere're no real roots of the quadratic equation.");
        }

        else if (aNumber == 0 && bNumber != 0)
        {
            float xOneRealRoot = -(cNumber / bNumber);
            Console.WriteLine("\nThe equation has one real root x={0}.", xOneRealRoot);
        }
        else
        {
            float xOneRealRoot = (float)((-bNumber - Math.Sqrt(discriminant)) / (2 * aNumber));
            float xTwoRealRoot = cNumber / (aNumber * xOneRealRoot);
            Console.WriteLine("\nThe equation has two real root x1={0} and x2={1}.", xOneRealRoot, xTwoRealRoot);
        }
    }
}