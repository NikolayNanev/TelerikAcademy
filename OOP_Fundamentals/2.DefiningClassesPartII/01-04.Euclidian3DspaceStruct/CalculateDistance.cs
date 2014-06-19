
namespace Euclidian3Dspace
{
    using System;

    public static class CalculateDistance
    {
        public static double Distance(Point3D a, Point3D b)
        {
            double distance = 0;

            distance = Math.Sqrt(Math.Pow((double)(b.X - a.X), 2) + Math.Pow((double)(b.Y - a.Y), 2) + Math.Pow((double)(b.Z - a.Z), 2));

            return distance;
        }
    }
}
