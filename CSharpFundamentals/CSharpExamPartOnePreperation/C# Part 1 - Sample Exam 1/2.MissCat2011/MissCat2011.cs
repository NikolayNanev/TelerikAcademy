using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MissCat2011
{
    static int cat01 = 0;
    static int cat02 = 0;
    static int cat03 = 0;
    static int cat04 = 0;
    static int cat05 = 0;
    static int cat06 = 0;
    static int cat07 = 0;
    static int cat08 = 0;
    static int cat09 = 0;
    static int cat10 = 0;

    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberN; i++)
        {
            int pointForACat = int.Parse(Console.ReadLine());

            switch (pointForACat)
            {
                case 1:cat01++; break;
                case 2:cat02++; break;
                case 3:cat03++; break;
                case 4:cat04++; break;
                case 5:cat05++; break;
                case 6:cat06++; break;
                case 7:cat07++; break;
                case 8:cat08++; break;
                case 9:cat09++; break;
                case 10:cat10++; break;

                default: break;
            }
        }

        int[] arreyWithAllCats = { cat01, cat02, cat03, cat04, cat05, cat06, cat07, cat08, cat09, cat10 };

        int votesForMaxVotedCat = arreyWithAllCats.Max();
        int theMissCat2011 = 1 + arreyWithAllCats.ToList().IndexOf(votesForMaxVotedCat);

        Console.WriteLine("{0}",theMissCat2011);
    }
}