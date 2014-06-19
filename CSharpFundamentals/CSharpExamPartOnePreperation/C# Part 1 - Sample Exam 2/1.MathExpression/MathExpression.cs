using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MathExpression
{
    static void Main()
    {
        decimal numberN = decimal.Parse(Console.ReadLine());
        decimal numberM = decimal.Parse(Console.ReadLine());
        decimal numberP = decimal.Parse(Console.ReadLine());

        decimal secondPowerOfN = numberN * numberN;
        decimal productOfMandP = numberM * numberP;
        decimal productOfBigNumberandP = 128.523123123m * numberP;
        decimal valueOfSin = (decimal)Math.Sin(((int)numberM % 180));

        decimal valueOfExpression = ((secondPowerOfN + (1.0m / productOfMandP) + 1337m) / (numberN - productOfBigNumberandP)) + valueOfSin;

        Console.WriteLine("{0:F6}",valueOfExpression);
    }
}