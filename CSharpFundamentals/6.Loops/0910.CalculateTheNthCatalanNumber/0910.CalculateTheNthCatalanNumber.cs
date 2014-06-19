using System; 

class CalculateTheNthCatalanNumber
{
    static double nMyNumberN;

    static void Main()
    {
        //Write a program to calculate the Nth Catalan number by given N.

        Console.WriteLine("Calculate the Nth Catalan number by given N:");

        bool myCheckIfNisInRange = true;

        while (myCheckIfNisInRange)
        {
            Console.Write("\nPlease input integer number N  in range N>=0: ");
            nMyNumberN = double.Parse(Console.ReadLine());

            if (nMyNumberN < 0)
            {
                Console.WriteLine("\nError! Number N must be in range N>=0 ");
            }
            else
            {
                myCheckIfNisInRange = false;
            }
        }

        double nFactorial = 1;
        double doubleNFactorial = 1;
        double nOneFactorial = 1;

        for (double i = 1; i <= nMyNumberN; i++)
        {
            nFactorial = nFactorial * i;
        }

        for (double i = 1; i <= 2 * nMyNumberN; i++)
        {
            doubleNFactorial = doubleNFactorial * i;
        }

        for (double i = 1; i <= nMyNumberN + 1; i++)
        {
            nOneFactorial = nOneFactorial * i;
        }

        Console.WriteLine("Cn={1}!/({2}!{3}!)={0}", doubleNFactorial / (nOneFactorial * nFactorial), 2 * nMyNumberN, nMyNumberN + 1, nMyNumberN);  
    }
}

