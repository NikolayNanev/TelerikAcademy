namespace ShapesProject
{
    //Tests the behavior of  the CalculateSurface() method for different shapes stored in an array.

    using System;

    public class TestProgram
    {
        static void Main()
        {
            Shape[] arrayWithShapes = new Shape[] 
            {
                new Rectangle(2.5,10.5),
                new Circle(13.64),
                new Triangle(25.23,13.454)
            };

            foreach (Shape shape in arrayWithShapes)
            {
                double valueOfSurface = shape.CalculateSurface();
                Console.WriteLine("{0:0.000}", valueOfSurface);
            }
        }
    }
}