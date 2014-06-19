using System;

class АddingTwoPolynomials
{
    //Write a method that adds two polynomials.
    //Example below: x^2 + 5 = 1x^2 + 0x + 5 --->> {5 0 1}  InitializingCoefficientsOfPolynoms

    static decimal[] coefficientsOfFirstPolynom = new decimal[3];
    static decimal[] coefficientsOfSecondPolynom = new decimal[3];

    static void Main()
    {
        InitializingCoefficientsOfPolynoms();

        decimal[] coefficientsOfResultPolynom = AddingTwoPolynomials(coefficientsOfFirstPolynom, coefficientsOfSecondPolynom);

        PrintingResultPolynom(coefficientsOfResultPolynom);
    }

    static void InitializingCoefficientsOfPolynoms()
    {
        Console.WriteLine("Please input \'a\',\'b\' and \'c\' in first polynom (a*x^2 + b*x + c):");
        Console.Write("a= "); coefficientsOfFirstPolynom[2] = decimal.Parse(Console.ReadLine());
        Console.Write("b= "); coefficientsOfFirstPolynom[1] = decimal.Parse(Console.ReadLine());
        Console.Write("c= "); coefficientsOfFirstPolynom[0] = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nPlease input \'m\',\'n\' and \'p\' in second polynom (m*x^2 + n*x + p):");
        Console.Write("m= "); coefficientsOfSecondPolynom[2] = decimal.Parse(Console.ReadLine());
        Console.Write("n= "); coefficientsOfSecondPolynom[1] = decimal.Parse(Console.ReadLine());
        Console.Write("p= "); coefficientsOfSecondPolynom[0] = decimal.Parse(Console.ReadLine());
    }

    static decimal[] AddingTwoPolynomials(decimal[] firstArr, decimal[] secondArr) 
    {
        decimal[] resultArr = new decimal[3];

        for (int index = 0; index < 3; index++)
        {
            resultArr[index] = firstArr[index] + secondArr[index];
        }

        return resultArr;
    }

    static void PrintingResultPolynom(decimal[] array)
    {
        string resultA = array[2].ToString();
        string resultB = array[1].ToString();
        string resultC = array[0].ToString();

        if (array[1] >= 0)
        {
            resultB = " +" + array[1];
        }

        if (array[0] >= 0)
        {
            resultC = " +" + array[0];
        }

        Console.WriteLine("\nThe result polynom:\n{0}*x^2 {1}*x {2} = 0\n", resultA, resultB, resultC);
    }
}