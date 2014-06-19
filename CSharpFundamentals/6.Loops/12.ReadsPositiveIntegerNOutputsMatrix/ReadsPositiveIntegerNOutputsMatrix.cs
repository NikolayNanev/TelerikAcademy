using System;

class ReadsPositiveIntegerNOutputsMatrix
{
    static double nMyNumberN;

    static void Main()
    {
        bool myCheckIfNisInRange = true;

        while (myCheckIfNisInRange)
        {
            Console.Write("\nPlease input integer number N  in range 0<=N<20: ");
            nMyNumberN = double.Parse(Console.ReadLine());

            if (nMyNumberN < 0 || nMyNumberN >= 20)
            {
                Console.WriteLine("\nError! Number N must be in range 0<=N<20 ");
            }
            else
            {
                myCheckIfNisInRange = false;
            }
        }

        Console.WriteLine();
        
        double newValueOfi = 1;
        
        for (double i = 1; i <= nMyNumberN; i++)
        {
            for (double j = newValueOfi; j <= nMyNumberN + newValueOfi - 1; j++)
            {
                Console.Write("{0,-3:0}",j);              
            }
            newValueOfi++;
            Console.WriteLine();   
        }
        Console.WriteLine();
    }
}