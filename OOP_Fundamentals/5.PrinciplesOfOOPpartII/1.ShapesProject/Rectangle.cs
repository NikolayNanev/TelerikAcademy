namespace ShapesProject
{
    //Define classe Rectangle that return the surface of the figure (height*width for rectangle). 

    using System;

    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
            : base(height, width) { }
        
        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width;

            return surface;
        }
    }
}
