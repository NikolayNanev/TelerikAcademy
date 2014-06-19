using System;

class PrintAllCardsFromAstandardDeck
{
    //Write a program that prints all possible cards from a standard deck of 52 cards.

    static string hearts = " of Hearts";
    static string diamonds = " of Diamonds";
    static string clubs = " of Clubs";
    static string spades = " of Spades";

    static int checkTypeOfCard;
    static int checkNameOfCard;
    static string myCurentString;

    static void checkForTypeOFCard ()
    {
        if (checkTypeOfCard == 0) { myCurentString = hearts; }
        if (checkTypeOfCard == 1) { myCurentString = diamonds; }
        if (checkTypeOfCard == 2) { myCurentString = clubs; }
        if (checkTypeOfCard == 3) { myCurentString = spades; }
    }

    static void checkForNameOfCard()
    {
        Console.WriteLine("Ace" + myCurentString);

        for (checkNameOfCard = 2; checkNameOfCard <= 10; checkNameOfCard++)
        {
            switch (checkNameOfCard)
            {
                case 2: Console.WriteLine("Two" + myCurentString); break;
                case 3: Console.WriteLine("Three" + myCurentString); break;
                case 4: Console.WriteLine("Four" + myCurentString); break;
                case 5: Console.WriteLine("Five" + myCurentString); break;
                case 6: Console.WriteLine("Six" + myCurentString); break;
                case 7: Console.WriteLine("Seven" + myCurentString); break;
                case 8: Console.WriteLine("Eight" + myCurentString); break;
                case 9: Console.WriteLine("Nine" + myCurentString); break;
                case 10: Console.WriteLine("Ten" + myCurentString); break;

                default: break;
            }
        }

        Console.WriteLine("Knave" + myCurentString);
        Console.WriteLine("Queen" + myCurentString);
        Console.WriteLine("King" + myCurentString + "\n");
    }

    static void Main()
    {
        for (checkTypeOfCard = 0; checkTypeOfCard <= 3; checkTypeOfCard++)
        {
            checkForTypeOFCard();
            checkForNameOfCard();
        }
    }
}