using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InsertsLineNumbersInFrontOfEachLine
{
    //Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

    static string FULL_FILE_PATH = @"..\..\Files1.txt";
    static string TARGET_FILE_PATH = @"..\..\TargetFile.txt";

    static void Main()
    {
        //Clear the text in the 'Target' file.
        File.WriteAllText(TARGET_FILE_PATH, String.Empty);

        StringBuilder stringBuilder = new StringBuilder();

        ReadingAndChangingTestFile(stringBuilder, FULL_FILE_PATH);
        WritingChangedFile(stringBuilder, TARGET_FILE_PATH);

        Console.WriteLine("File is written!");
    }

    static void ReadingAndChangingTestFile(StringBuilder stringBuilder, string path)
    {
        StreamReader reader = new StreamReader(path, Encoding.Default);

        using (reader)
        {
            int countLine = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                stringBuilder.Append(countLine);
                stringBuilder.Append("   ");
                stringBuilder.Append(line);
                stringBuilder.Append("\r\n");
                line = reader.ReadLine();
                countLine++;
            }
        }
    }

    static void WritingChangedFile(StringBuilder stringBuilder, string path)
    {
        StreamWriter writer = new StreamWriter(path);
        using (writer)
        {
            writer.Write(stringBuilder.ToString());
        }
    }
}