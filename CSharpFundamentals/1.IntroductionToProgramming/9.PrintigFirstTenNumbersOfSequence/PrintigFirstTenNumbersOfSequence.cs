using System;

class PrintigFirstTenNumbersOfSequence
{
    static void Main()
    {        
        byte members = 0;
        for (int i = 2; members<10; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i+ ",");
                members++;
            }
            else 
            {
                Console.Write(-i +",");
                members++;
            }            
        }
    }
}
