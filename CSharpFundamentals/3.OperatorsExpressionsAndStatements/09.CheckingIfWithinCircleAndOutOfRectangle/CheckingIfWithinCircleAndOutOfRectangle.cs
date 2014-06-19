using System;

class CheckingIfWithinCircleAndOutOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Determining if a point P(X,Y) is within a circle(1,1 Radius=3).\nDetermining if a point P(X,Y) is out of a rectangle(1,-1 width=6, height=2).\n");
        Console.Write("Please type the X of the point: ");
        double xCoordinateOfPoint = double.Parse(Console.ReadLine());
        Console.Write("Please type the Y of the point: ");
        double yCoordinateOfPoint = double.Parse(Console.ReadLine());

        bool isWithinCircle = Math.Sqrt(Math.Pow(xCoordinateOfPoint - 1, 2) + Math.Pow(yCoordinateOfPoint - 1, 2)) <= 3;

        if (isWithinCircle)
        {
            Console.WriteLine("\nThe given point P({0},{1}) is WITHIN the circle.", xCoordinateOfPoint, yCoordinateOfPoint);
        }
        else
        {
            Console.WriteLine("\nThe given point P({0},{1}) is OUT of the circle.", xCoordinateOfPoint, yCoordinateOfPoint);
        }

        bool isOutOfRectangle = ((xCoordinateOfPoint > 7) || (xCoordinateOfPoint < 1)) || ((yCoordinateOfPoint < -3) || (yCoordinateOfPoint > -1));

        if (isOutOfRectangle)
        {
            Console.WriteLine("The given point P({0},{1}) is OUT of the rectangle.\n", xCoordinateOfPoint, yCoordinateOfPoint);
        }
        else
        {
            Console.WriteLine("The given point P({0},{1}) is WITHIN the rectangle.\n", xCoordinateOfPoint, yCoordinateOfPoint);
        }
    }
}