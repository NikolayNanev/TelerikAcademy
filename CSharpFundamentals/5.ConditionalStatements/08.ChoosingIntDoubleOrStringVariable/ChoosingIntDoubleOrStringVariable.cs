using System;

class ChoosingIntDoubleOrStringVariable
{
    static long myInputIntegerNumber;
    static void Main()
    {
        int myIntValue;
        double myDoubleValue;
        string myStringValue;

        Console.WriteLine("Choosing int, double or string variable and printing it.\n");
        bool myCheckForDigit = true;

        while (myCheckForDigit)
        {
            Console.Write("1-Int value\n2-Double value\n3-String value\n\nPlease type a digit [1,2 or 3]: ");
            myInputIntegerNumber = long.Parse(Console.ReadLine());

            if (myInputIntegerNumber < 1 || myInputIntegerNumber > 3)
            {
                Console.WriteLine("\nNot a permited number.Please try again!\n");
            }
            else
            {
                myCheckForDigit = false;
            }
        }

        switch (myInputIntegerNumber)
        {
            case 1:
                Console.Write("\nPlease input an integer number: ");
                myIntValue = int.Parse(Console.ReadLine());
                Console.WriteLine("Integer value plus one:{0}\n", myIntValue + 1);break;
            case 2:
                Console.Write("\nPlease input a double number: ");
                myDoubleValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Double value plus one:{0}\n", myDoubleValue + 1);break;
            case 3:
                Console.Write("\nPlease input a string value: ");
                myStringValue = Console.ReadLine();
                Console.WriteLine("String value plus '*':{0}*\n", myStringValue);break;
            default:
                break;
        }
    }
}