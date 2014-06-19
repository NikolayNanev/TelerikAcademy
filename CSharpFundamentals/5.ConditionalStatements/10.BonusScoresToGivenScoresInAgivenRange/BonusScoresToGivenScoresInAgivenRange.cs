using System;

class BonusScoresToGivenScoresInAgivenRange
{
    static int myScore;

    static void Main()
    {
        Console.WriteLine("The program reads an integr and applies bonus scores in the range [1..9]");
        Console.WriteLine("\nIf the digit is between 1 and 3 multiplies by 10 \nIf the digit is between 4 and 6 multiplies by 100\nIf the digit is between 7 and 9 multiplies by 1000\nIf the digit is zero or is not a digit report an error.\n");
        
        bool myCheckToBreakWhile = true;
       
        while (myCheckToBreakWhile)
        {
            Console.Write("Please type an integer number: ");
            bool myCheckIfItIsAnInteger = int.TryParse(Console.ReadLine(), out myScore);

            if (myCheckIfItIsAnInteger == false)
            {
                Console.WriteLine("\nNot a valid integer number.Please try again!");
            }
            else
            {
                myCheckToBreakWhile = false;
            }
        }

        switch (myScore)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("\nNew calculated value of the score: {0}",myScore*10); break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("\nNew calculated value of the score: {0}",myScore*100); break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("\nNew calculated value of the score: {0}",myScore*1000); break;
            default:
                Console.WriteLine("Error"); break;
        }       
    }
}