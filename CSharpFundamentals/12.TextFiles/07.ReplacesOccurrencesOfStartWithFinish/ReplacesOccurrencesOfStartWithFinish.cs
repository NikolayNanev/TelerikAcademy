using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplacesOccurrencesOfStartWithFinish
{
    static string INPUT_FILE_PATH = @"..\..\Input.txt";
    static string OUTPUT_FILE_PATH = @"..\..\Output.txt";

    static string WORD_TO_REPlACES = "start";
    static string WORD_TO_REPlACES_WITH = "finish";

    static void Main()
    {
        //Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
        //Ensure it will work with large files (e.g. 100 MB).

        File.WriteAllText(OUTPUT_FILE_PATH, String.Empty);
        
        StreamReader inputReader = new StreamReader(INPUT_FILE_PATH);
        StreamWriter outputWriter = new StreamWriter(OUTPUT_FILE_PATH);

        StringBuilder result = new StringBuilder();
        using (outputWriter)
        using (inputReader)
        {
            while (inputReader.EndOfStream != true)
            {
                string oneLine = inputReader.ReadLine();
                int startIndex = 0;

                int indexOfStart = oneLine.IndexOf(WORD_TO_REPlACES, StringComparison.OrdinalIgnoreCase);
                
                if (indexOfStart < 0)
                {
                    result.Append(oneLine);
                }
                else
                {
                    while (indexOfStart >= 0)
                    {
                        string subStr = oneLine.Substring(startIndex, indexOfStart - startIndex);
                        startIndex = indexOfStart + 5;
                        indexOfStart = oneLine.IndexOf(WORD_TO_REPlACES, startIndex, StringComparison.OrdinalIgnoreCase);
                        result.Append(subStr);
                        result.Append(WORD_TO_REPlACES_WITH);
                    }

                    int lastIndexOfStart = oneLine.LastIndexOf(WORD_TO_REPlACES, StringComparison.OrdinalIgnoreCase);
                    string lastSubstring = oneLine.Substring(lastIndexOfStart + 5);
                    result.Append(lastSubstring);
                }
                outputWriter.WriteLine(result.ToString());
                result.Clear();
                outputWriter.Flush();
            }
        }

        Console.WriteLine("File is written!");
    }
}
