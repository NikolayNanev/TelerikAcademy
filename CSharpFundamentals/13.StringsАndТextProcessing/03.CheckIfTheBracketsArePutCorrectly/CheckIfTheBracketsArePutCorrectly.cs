using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckIfTheBracketsArePutCorrectly
{
    //Write a program to check if in a given expression the brackets are put correctly.
    //Example of correct expression: ((a+b)/5-d).
    //Example of incorrect expression: )(a+b)).

    static void Main()
    {
        string firstString = "(7+(4+45) + 78 - (78 -7) - 90 + 74*(4 + 7 ))";
        string secondString = ")7 + 7(";
        string thirdString = ")7+(12-7)*(48 - 48) + 40)";
        string example1 = "((a+b)/5-d)";
        string example2 = ")(a+b))";

        PrintingResults(firstString);
        PrintingResults(secondString);
        PrintingResults(thirdString);

        PrintingResults(example1);
        PrintingResults(example2);

    }

    static bool CheckingBrackets(string str) 
    {
        int countOpenClousedBracket = 0;

        if (str[0] == ')')
        {
            return false;
        }

        foreach (char item in str)
        {
            if (item == '(')
            {
                countOpenClousedBracket++;
            }

            else if (item == ')')
            {
                countOpenClousedBracket--;
            }
        }

        if (countOpenClousedBracket == 0)
        {
            return true;
        }
        else
        {
            return false;
        }        
    }

    static void PrintingResults(string inputString) 
    {
        bool valueOfCheckForBrackets = CheckingBrackets(inputString);

        if (valueOfCheckForBrackets)
        {
            Console.WriteLine("The expression \'{0}\' is valid.", inputString);
        }
        else
        {
            Console.WriteLine("The expression \'{0}\' is NOT valid.", inputString);
        }
    }
}
