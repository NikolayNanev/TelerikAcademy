namespace ShapesProject
{
    //Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 

    using System;

    public abstract class Shape : ICalculateSurface
    {
        private double height;
        private double width;

        protected Shape(double height, double width) 
        {
            this.Height = height;
            this.Width = width;
        }

        public abstract double CalculateSurface();

        public double Height 
        {
            get { return this.height; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive");
                }

                this.height = value;
            } 
        }

        public double Width 
        {
            get { return this.width; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be positive");
                }

                this.width = value;
            }  
        }
    }
}
