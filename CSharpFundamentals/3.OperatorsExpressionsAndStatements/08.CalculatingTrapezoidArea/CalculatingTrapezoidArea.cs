using System;

class CalculatingTrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Calculating a trapezoid's area by given sides a and b and height h.");
        Console.Write("Please type the length of side 'a': ");
        decimal aParallelSide = decimal.Parse(Console.ReadLine());
        Console.Write("Please type the length of side 'b': ");
        decimal bParallelSide = decimal.Parse(Console.ReadLine());
        Console.Write("Please type the length of the height 'h': ");
        decimal heightOfTrapezoid = decimal.Parse(Console.ReadLine());
        decimal areaOfTrapezoid = ((aParallelSide + bParallelSide)/2) * heightOfTrapezoid;
        Console.WriteLine("\nThe area of a trapezoid with a={0}, b={1} and h={2} is {3}.\n",aParallelSide,bParallelSide,heightOfTrapezoid,areaOfTrapezoid);
    }
}