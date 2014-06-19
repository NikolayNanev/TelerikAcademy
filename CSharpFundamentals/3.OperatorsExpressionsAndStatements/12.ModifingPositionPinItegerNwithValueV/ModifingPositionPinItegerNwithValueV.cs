using System;

class ModifingPositionPinItegerNwithValueV
{
    static void Main()
    {
        Console.WriteLine("Modifing position P in an iteger number N with a given value V (1 or 0).\n");
        Console.Write("Please type an integer number N: ");
        int nNumberToCheck = int.Parse(Console.ReadLine());
        Console.Write("Please type the bit positon P to modify: ");
        byte pPositionToModify = byte.Parse(Console.ReadLine());
        Console.Write("Please type the bit value V (1 or 0): ");
        byte vNewValueOfPositionP = byte.Parse(Console.ReadLine());

        if (vNewValueOfPositionP == 0)
        {
            nNumberToCheck = nNumberToCheck & (~(1 << pPositionToModify));
            Console.WriteLine("\nThe new modified value of N is \'{0}\'.", nNumberToCheck);
        }

        if (vNewValueOfPositionP == 1)
        {
            nNumberToCheck = nNumberToCheck | (1 << pPositionToModify);
            Console.WriteLine("\nThe new modified value of N is \'{0}\'.", nNumberToCheck);
        }
    }
}