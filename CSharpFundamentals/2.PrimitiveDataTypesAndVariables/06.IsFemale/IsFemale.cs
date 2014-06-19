using System;

class IsFemale
{
    static void Main()
    {
        bool isFemale;
        while (true)
        {
            Console.Write("Are you a female?(Y/N):");
            string isGenderFemale = Console.ReadLine();

            if (isGenderFemale == "Y" || isGenderFemale == "y")
            {
                isFemale = true;
                Console.WriteLine("\nThe statment:\"You're a Female!\" is:" + isFemale);
                break;
            }
            if (isGenderFemale == "N" || isGenderFemale == "n")
            {
                isFemale = false;
                Console.WriteLine("\nThe statment:\"You're a Female!\" is:" + isFemale);
                break;
            }
            else
            {
                Console.WriteLine("Answer only with Y or N!\n");
            }        
        }
    }
}