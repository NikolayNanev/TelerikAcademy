using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConcatenatesTwoTextFilesIntoNewTextFile
{
    //Write a program that concatenates two text files into another text file.

    static string FIRST_FILE_PATH = @"..\..\Files1.txt";
    static string SECOND_FILE_PATH = @"..\..\Files2.txt";
    static string TARGET_FILE_PATH = @"..\..\TargetFile.txt";

    static void Main()
    {
        //Clear the text in the 'Target' fail.
        File.WriteAllText(TARGET_FILE_PATH, String.Empty);

        //Writes in 'Target' fail with append the text in  'Files1' and 'Files2'
        ReadingFromFileAndAppendingInAnotherFile(FIRST_FILE_PATH, TARGET_FILE_PATH);
        ReadingFromFileAndAppendingInAnotherFile(SECOND_FILE_PATH, TARGET_FILE_PATH);

        Console.WriteLine("File is written!");
    }

    static void ReadingFromFileAndAppendingInAnotherFile(string path1,string path2)
    {
        StreamReader reader = new StreamReader(path1, Encoding.Default);
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                line = reader.ReadLine();

                StreamWriter writer = new StreamWriter(path2,true);
                using (writer)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}