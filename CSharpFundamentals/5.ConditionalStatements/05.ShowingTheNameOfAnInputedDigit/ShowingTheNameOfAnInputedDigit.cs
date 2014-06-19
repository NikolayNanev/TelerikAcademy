using System;

class ShowingTheNameOfAnInputedDigit
{
    static void Main()
    {
        Console.WriteLine("Input a digit and depending on the input shows the name of that digit.");
        bool myCheckForDigit = true;
        long? myNewDigit = null;

        while (myCheckForDigit)
        {
            Console.Write("Please type a digit [0-9]: ");
            long myDigit = long.Parse(Console.ReadLine());

            if (myDigit < 0 || myDigit > 9)
	        {
                Console.WriteLine("\nNot a digit.Please try again.");
	        }
            else
            {
                myCheckForDigit = false;
                myNewDigit = myDigit;
            }
        }

        switch (myNewDigit)
        {
            case 0:
                    Console.WriteLine("\nZero");break;
            case 1:
                Console.WriteLine("\nOne");break;
            case 2:
                Console.WriteLine("\nTwo"); break;
            case 3:
                Console.WriteLine("\nThree"); break;
            case 4:
                Console.WriteLine("\nFour"); break;
            case 5:
                Console.WriteLine("\nFive"); break;
            case 6:
                Console.WriteLine("\nSix"); break;
            case 7:
                Console.WriteLine("\nSeven"); break;
            case 8:
                Console.WriteLine("\nEight"); break;
            case 9:
                Console.WriteLine("\nNine"); break;
            default:
                Console.WriteLine("\nHow did you print this?!?What is my mistake?");break;
        }       
    }
}