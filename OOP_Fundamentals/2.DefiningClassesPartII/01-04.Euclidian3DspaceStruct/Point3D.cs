namespace Euclidian3Dspace
{
    using System;

    public struct Point3D
    {
        //Task 1
        private double x;
        private double y;
        private double z;

        //Task 2: Start of the coordinate system – the point O{0, 0, 0}. 
        private static readonly Point3D startOfCoordSystem = new Point3D(0, 0, 0);

        //Task 1
                
        public Point3D(double x, double y, double z) 
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        //Task 1
        public static Point3D StartOfCoordSystem
        {
            get { return startOfCoordSystem; }
        }

        //Task 2:
        public override string ToString()
        {
            string newReturnString = String.Format("[{0},{1},{2}]", this.X, this.Y, this.Z);

            return newReturnString;
        }
    }
}