namespace BitArray64Project
{
    //Define a class BitArray64 to hold 64 bit values inside an ulong value. 
    //Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

    using System;

    class MainProgram
    {
        static void Main()
        {
            ulong ulongNumber = 123478;

            BitArray64 number = new BitArray64(ulongNumber);

            int[] numberArray = number.Bits;

            foreach (var bit in numberArray)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }
    }
}