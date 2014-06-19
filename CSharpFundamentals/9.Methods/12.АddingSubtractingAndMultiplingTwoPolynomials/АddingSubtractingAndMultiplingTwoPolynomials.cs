using System;

class АddingSubtractingAndMultiplingTwoPolynomials
{
    //Extend the program to support also subtraction and multiplication of polynomials.

    static decimal[] coefficientsOfFirstPolynom = new decimal[3];
    static decimal[] coefficientsOfSecondPolynom = new decimal[3];

    static decimal[] coefficientsOfResultPolynom;

    static void Main()
    {
        InitializingCoefficientsOfPolynoms();

        long codeOfAction = SpecifeingTypeOfAction();

        PrintingResultPolynom(codeOfAction);    
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

    static long SpecifeingTypeOfAction()
    {
        Console.Write("\nPlease specify type of action (1,2 or 3):\n   1.Sum the polynomials\n   2.Subtract the polynomials\n   3.Multiply the polynomials\n\nWaiting for code of action: ");
        long codeOfAction = long.Parse(Console.ReadLine());

        if (codeOfAction == 1)
        {
            coefficientsOfResultPolynom = new decimal[3];
            coefficientsOfResultPolynom = AddingTwoPolynomials(coefficientsOfFirstPolynom, coefficientsOfSecondPolynom);
        }

        else if (codeOfAction == 2)
        {
            coefficientsOfResultPolynom = new decimal[3];
            coefficientsOfResultPolynom = SubtractingTwoPolynomials(coefficientsOfFirstPolynom, coefficientsOfSecondPolynom);
        }

        else if (codeOfAction == 3)
        {
            coefficientsOfResultPolynom = new decimal[5];
            coefficientsOfResultPolynom = MultiplingTwoPolynomials(coefficientsOfFirstPolynom, coefficientsOfSecondPolynom);
        }

        else
        {
            Console.WriteLine("Invalid code!Please try again!");
            codeOfAction = SpecifeingTypeOfAction();
        }

        return codeOfAction;
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

    static decimal[] SubtractingTwoPolynomials(decimal[] firstArr, decimal[] secondArr)
    {
        decimal[] resultArr = new decimal[3];

        for (int index = 0; index < 3; index++)
        {
            resultArr[index] = firstArr[index] - secondArr[index];
        }

        return resultArr;
    }

    static decimal[] MultiplingTwoPolynomials(decimal[] firstArr, decimal[] secondArr)
    {
        decimal[] resultArr = new decimal[5];

        resultArr[0] = firstArr[0] * secondArr[0];
        resultArr[1] = firstArr[1] * secondArr[0] + firstArr[0] * secondArr[1];
        resultArr[2] = firstArr[2] * secondArr[0] + firstArr[1] * secondArr[1] + firstArr[0] * secondArr[2];
        resultArr[3] = firstArr[2] * secondArr[1] + firstArr[1] * secondArr[2];
        resultArr[4] = firstArr[2] * secondArr[2];

        return resultArr;
    }

    static void PrintingResultPolynom(long codeOfAction)
    {
        if (codeOfAction == 1 || codeOfAction == 2)
        {
            PrintingResultPolynomForAddAndSubtraction(coefficientsOfResultPolynom);
        }
        else if (codeOfAction == 3)
        {
            PrintingResultPolynomForMultiplication(coefficientsOfResultPolynom);
        }
    }

    static void PrintingResultPolynomForAddAndSubtraction(decimal[] array)
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

    static void PrintingResultPolynomForMultiplication(decimal[] array)
    {
        string resultA = array[4].ToString();
        string resultB = array[3].ToString();
        string resultC = array[2].ToString();
        string resultD = array[1].ToString();
        string resultE = array[0].ToString();

        if (array[3] >= 0)
        {
            resultB = " +" + array[3];
        }

        if (array[2] >= 0)
        {
            resultC = " +" + array[2];
        }

        if (array[1] >= 0)
        {
            resultD = " +" + array[1];
        }

        if (array[0] >= 0)
        {
            resultE = " +" + array[0];
        }

        Console.WriteLine("\nThe result polynom:\n{0}*x^4 {1}*x^3 {2}x^2 {3}x {4}= 0\n", resultA, resultB, resultC, resultD, resultE);
    }
}