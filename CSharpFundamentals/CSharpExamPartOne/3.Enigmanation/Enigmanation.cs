using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Enigmanation
{
    static int Operators (char X, int A, int B)
    {
        int value = 0;
        if (X == '+') { value = A + B; }
        if (X == '-') { value = A - B; }
        if (X == '*') { value = A * B; }
        if (X == '%') { value = A % B; }

        return value;
    } 
    
    static void Main()
    {
        string inputString = Console.ReadLine();
        int lenghtOfString = inputString.Length;
        int valueOfExpresion = 0;

        char[] arreyWithChars = new char[inputString.Length];

        int firstArgument = 0;
        int secondArgument = 0;
        int valueOFBrackets = 0;


        for (int i = 0; i < inputString.Length; i++)
        {
            arreyWithChars[i] = inputString[i];
            Console.WriteLine(arreyWithChars[i]);
        }

        for (int i = 0; i < inputString.Length; i++)
        {
            if (arreyWithChars[i] == '(')
            {
                firstArgument = arreyWithChars[i + 1] - '0';
                secondArgument = arreyWithChars[i + 3] - '0';
                valueOFBrackets = Operators(arreyWithChars[i + 2], firstArgument, secondArgument);
            }


        }


        //Console.WriteLine("{0:F3}",valueOfExpresion);
    }

        
}
