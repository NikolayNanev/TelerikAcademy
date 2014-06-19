namespace Euclidian3Dspace
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> paths = new List<Point3D>();

        public List<Point3D> Paths 
        {
            get { return this.paths; }
            set { value = this.paths; }
        }

        public void Add3DPoint(Point3D point) 
        {
            Paths.Add(point);          
        }

        public void PrintAllPaths() 
        {
            for (int i = 0; i < Paths.Count; i++)
            {
                //Console.WriteLine("{0}", Paths[i]);
                Console.WriteLine("[{0},{1},{2}]",Paths[i].X, Paths[i].Y, Paths[i].Z);
            }          
        }
    }
}
