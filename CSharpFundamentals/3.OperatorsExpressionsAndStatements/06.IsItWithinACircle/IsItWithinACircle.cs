using System;

class IsItWithinACircle
{
    static void Main()
    {
        Console.WriteLine("Determining if a point(X,Y) is within a circle(0,0 Radius=5).\n");
        Console.Write("Please type the X of the point: ");
        double xCoordinateOfPoint = double.Parse(Console.ReadLine());
        Console.Write("Please type the Y of the point: ");
        double yCoordinateOfPoint = double.Parse(Console.ReadLine());

        if (Math.Sqrt(Math.Pow(xCoordinateOfPoint - 0, 2) + Math.Pow(yCoordinateOfPoint - 0, 2)) <= 5)
        {
            Console.WriteLine("\nThe point is WITHIN the circle.\n");
        }
        else
        {
            Console.WriteLine("\nThe point is NOT WITHIN the circle.\n");
        }               
    }
}