using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateSurfaceOfTriangle
{
    //Write methods that calculate the surface of a triangle by given:Use System.Math.
    //  - Side and an altitude to it; 
    //  - Three sides; 
    //  - Two sides and an angle between them. 

    public class SurfaceOfTriangle
    {
        private double valueOfSide_1;
        private double altitudeToSide;
        private double surfaceOfTriangle;

        private double valueOfSide_2;
        private double valueOfSide_3;

        private double valueAngleBetweenSides;

        public SurfaceOfTriangle(double valueOfSide_1, double altitudeToSide)
        {
            this.valueOfSide_1 = valueOfSide_1;
            this.altitudeToSide = altitudeToSide;
            this.surfaceOfTriangle = valueOfSide_1 * altitudeToSide / 2;
        }

        public SurfaceOfTriangle(double valueOfSide_1, double valueOfSide_2, double valueOfSide_3)
        {
            this.valueOfSide_1 = valueOfSide_1;
            this.valueOfSide_2 = valueOfSide_2;
            this.valueOfSide_3 = valueOfSide_3;
        }

    }

    static void Main()
    {
        Console.Write("Please input value of first side: ");
        double firstSide = double.Parse(Console.ReadLine());

        Console.Write("Please input value of second side: ");
        double secondSide = double.Parse(Console.ReadLine());

        Console.Write("Please input value of third side: ");
        double thirdSide = double.Parse(Console.ReadLine());

        Console.Write("Please input value of third side: ");
        double altitude = double.Parse(Console.ReadLine());

        SurfaceOfTriangle TriangleSurfaceWithSideAndAltitude = new SurfaceOfTriangle(firstSide, altitude);
        
        Math.

        //double surfaceWithSideAndAltitude = TriangleSurfaceWithSideAndAltitude.;

        //SurfaceOfTriangle TriangleSurfaceWithThreeSides = new SurfaceOfTriangle(firstSide, secondSide, thirdSide);
    }
}
