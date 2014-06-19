namespace Euclidian3Dspace
{
    using System;

    public class ProgramMain
    {
        public static void Main()
        {
            //Task 1: Hold a 3D-coordinate {X, Y, Z} 
            Point3D pointA = new Point3D(-10, -7, 9);

            Console.WriteLine("Task 1: Hold a 3D-coordinate {X, Y, Z}");
            Console.WriteLine("Point A(x,y,z) = {0}",pointA);
            Console.WriteLine();

            //Task 2: Hold the start of the coordinate system – the point O{0, 0, 0}
            Point3D pointO = Point3D.StartOfCoordSystem;

            Console.WriteLine("Task 2: Hold the start of the coordinate system – the point O{0, 0, 0}");
            Console.WriteLine("Point O(x,y,z) = {0}", pointO);
            Console.WriteLine();

            //Task 3: Static method to calculate the distance between two points
            double distanceAO = CalculateDistance.Distance(pointA, pointO);

            Console.WriteLine("Task 3: Static method to calculate the distance between two points");
            Console.WriteLine("Sao = {0:0.000} metres", distanceAO);
            Console.WriteLine();

            //Task 4: Hold a sequence of points in the 3D space 
            Path listOfPaths = new Path();

            listOfPaths.Add3DPoint(pointA);
            listOfPaths.Add3DPoint(pointO);
            listOfPaths.Add3DPoint(new Point3D(-7, 4, 1));
            listOfPaths.Add3DPoint(new Point3D(100, 100, 100));

            Console.WriteLine("Task 4: Hold a sequence of points in the 3D space");
            listOfPaths.PrintAllPaths();
            Console.WriteLine();

            //Task 4: Static methods to save and load paths from a text file

            string FILE_TO_WRITE = @"..\..\WriteFile.txt";
            string FILE_TO_READ = @"..\..\ReadFile.txt";

            //Save paths from a text file
            PathStorage.SavePathsToFile(listOfPaths,FILE_TO_WRITE);

            //Load paths from a text file
            Path newPathToFill = PathStorage.LoadPathsFromFile(FILE_TO_READ);

            Console.WriteLine("Task 4: Load paths from a text file");
            newPathToFill.PrintAllPaths();
            Console.WriteLine();
        }
    }
}