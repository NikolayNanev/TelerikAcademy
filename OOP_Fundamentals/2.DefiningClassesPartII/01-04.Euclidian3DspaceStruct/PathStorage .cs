namespace Euclidian3Dspace
{
    using System;
    using System.IO;
    using System.Text;

    public static class PathStorage 
    {

        public static void SavePathsToFile(Path pathData, string pathLocation)
        {
            File.WriteAllText(pathLocation, String.Empty);
            
            int count = 0;

            string nextLine;

            while (count < pathData.Paths.Count)
            {
                nextLine = pathData.Paths[count].ToString();

                StreamWriter write = new StreamWriter(pathLocation, true, Encoding.Unicode);

                using (write)
                {
                    write.WriteLine(nextLine);
                }

                count++;
            }
        }

        public static Path LoadPathsFromFile(string pathLocation)
        {
            Path loadedPath = new Path();

            StreamReader read = new StreamReader(pathLocation, Encoding.Default);

            using (read)
            {
                //int count = 0;
                char[] splitElements = { ' ', ',', '[', ']' };

                string line = read.ReadLine();

                while (line != null)
                {
                    string[] pointXYZ = line.Split(splitElements, StringSplitOptions.RemoveEmptyEntries);

                    double x = double.Parse(pointXYZ[0]);
                    double y = double.Parse(pointXYZ[1]);
                    double z = double.Parse(pointXYZ[2]);

                    loadedPath.Add3DPoint(new Point3D(x, y, z));

                    line = read.ReadLine();
                }              
            }

            return loadedPath;
        }
    }
}