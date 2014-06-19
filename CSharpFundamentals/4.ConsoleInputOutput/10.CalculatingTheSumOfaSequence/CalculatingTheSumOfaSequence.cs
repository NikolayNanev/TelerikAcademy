using System;

class CalculatingTheSumOfaSequence
{
    static void Main()
    {
        double nextMemberOfSequence = 0;
        double sumOfSequence = 1;

        for (double i = 2; 1 / i >= 0.001; i++)
        {
            if (i % 2 == 0)
            {
                nextMemberOfSequence = 1 / i;
            }

            else
            {
                nextMemberOfSequence  = -1 / i;
            }

            sumOfSequence += nextMemberOfSequence;
        }

        Console.WriteLine("The sum of the sequence is {0:0.000}.", sumOfSequence);
    }
}