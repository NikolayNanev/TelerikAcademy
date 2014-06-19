using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ChangesTextInRegionsSurroundedByTagsUpcase
{
    //You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and 
    //</upcase> to uppercase. The tags cannot be nested.

    static string FILE_PATH = @"../../File1.txt";
    
    static void Main()
    {
        StreamReader reader = new StreamReader(FILE_PATH);

        using (reader)
        {
            //line = reader.ReadLine();
        }
    }
}