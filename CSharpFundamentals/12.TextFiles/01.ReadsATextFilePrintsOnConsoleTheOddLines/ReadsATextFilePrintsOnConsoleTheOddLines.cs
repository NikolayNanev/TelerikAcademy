using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReadsATextFilePrintsOnConsoleTheOddLines
{
    static void Main()
    {
        string FILE_PATH = @"..\..\ReadingFiles.txt";

        StreamReader reader = new StreamReader(FILE_PATH, Encoding.Default);
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 != 0)
                {
                  Console.WriteLine("Line {0}: {1}", lineNumber, line);               
                }
                line = reader.ReadLine();
            }
        }
    }
}