namespace ShapesProject
{
    //Define classe Triangle that return the surface of the figure (height*width/2 for triangle).

    using System;

    public class Triangle : Shape
    {
        public Triangle(double height, double width)
            : base(height, width) { }
        
        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width / 2;

            return surface;
        }
    }
}
