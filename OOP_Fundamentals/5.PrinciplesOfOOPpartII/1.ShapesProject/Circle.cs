namespace ShapesProject
{
    //Define class Circle and suitable constructor so that at initialization height must be kept equal to width.
    //Implement the CalculateSurface() method. 

    //WARNING: diameter==height==width

    using System;
    
    public class Circle : Shape
    {
        public Circle(double diameter)
            : base(diameter, diameter) { }

        public override double CalculateSurface()
        {
            double surface = Math.PI * Math.Pow(this.Height / 2,2);

            return surface; 
        }
    }
}







//Math.PI * Math.Pow(this.Width, 2)