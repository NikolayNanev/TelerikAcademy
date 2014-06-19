using System;

class CalculatingRectanglesArea
{
    static void Main()
    {
        Console.WriteLine("Printig the area of a given rectangle.\n");
        Console.Write("Please type the Width of the rectangle: ");

        double widthOfRectangle = double.Parse(Console.ReadLine());
        Console.Write("Please type the Height of the rectangle: ");
        
        double heightOfRectangle = double.Parse(Console.ReadLine());
        double areaOfRectangle = widthOfRectangle * heightOfRectangle;
        
        Console.WriteLine("The area of the given rectangle is: {0}\n", areaOfRectangle);
    }
}