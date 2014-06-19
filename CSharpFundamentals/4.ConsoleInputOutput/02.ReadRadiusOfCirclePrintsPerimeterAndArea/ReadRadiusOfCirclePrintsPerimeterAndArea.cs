using System;

class ReadRadiusOfCirclePrintsPerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Printing the perimeter and area of a circle after inputting is's radius R.");

        Console.Write("Please input the radius R: ");
        double radiusOfCircle = double.Parse(Console.ReadLine());

        double perimeterOfCircle = 2 * radiusOfCircle * Math.PI;
        double areaOfCircle = Math.Pow(radiusOfCircle, 2) * Math.PI;

        Console.WriteLine("\nThe perimeter of the circle is {0:0.0000}", perimeterOfCircle);
        Console.WriteLine("The area of the circle is {0:0.0000}\n", areaOfCircle);
    }
}