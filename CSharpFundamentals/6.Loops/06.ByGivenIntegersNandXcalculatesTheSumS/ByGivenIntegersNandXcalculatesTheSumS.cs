using System;

class ByGivenIntegersNandXcalculatesTheSumS
{
    

    static void Main()
    {
        //Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

        Console.WriteLine("By given integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN");

        Console.Write("\nPlease input value for number N: ");
        double nMyNumberN = double.Parse(Console.ReadLine());

        Console.Write("Please input value for number X: ");
        double xMyNumberX = double.Parse(Console.ReadLine());

        double sumOfExpression = 1;
        double nFactorial = 1;
        double power=1;

        for (double i = 1; i <= nMyNumberN; i++, power++)
        {
            nFactorial = nFactorial*i;
            sumOfExpression = sumOfExpression + (nFactorial / (Math.Pow(xMyNumberX, power)));
        }

        Console.WriteLine("Sum of expressionS = 1 + 1!/{1} + 2!/{1}^2 +...+ {2}!/{1}^{2} = {0:0.000}\n", sumOfExpression, xMyNumberX, nMyNumberN);
    }
}