using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ComparesTwoTextFilesLineByLine
{
    //Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. 
    //Assume the files have equal number of lines.

    static string FIRST_FILE_PATH = @"..\..\Files1.txt";
    static string SECOND_FILE_PATH = @"..\..\Files2.txt";

    static void Main()
    {
        StreamReader firstReader = new StreamReader(FIRST_FILE_PATH);
        StreamReader secondReader = new StreamReader(SECOND_FILE_PATH);

        int equalLines = 0;
        int differantLines = 0;

        using (firstReader)
        using (secondReader)
        {
            while (firstReader.EndOfStream != true || secondReader.EndOfStream != true)
            {
                string firstStr = firstReader.ReadLine();
                string secondStr = secondReader.ReadLine();

                if (firstStr == secondStr)
                {
                    equalLines++;
                }
                else
                {
                    differantLines++;
                }
            }
        }
        Console.WriteLine("The number of the same lines is: {0}", equalLines);
        Console.WriteLine("The number of the diferent lines is: {0}", differantLines);
    }
}