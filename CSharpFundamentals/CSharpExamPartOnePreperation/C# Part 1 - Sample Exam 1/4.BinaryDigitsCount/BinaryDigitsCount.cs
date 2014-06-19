using System;



class BinaryDigitsCountProgram
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        uint bit = 0;
        uint mask = 0;

        if (b == 1 || b == 0)
        {

            for (int j = 0; j < n; j++)
            {

                uint p = uint.Parse(Console.ReadLine());
                uint count1 = 0;
                uint count0 = 0;

                for (int i = 0; i < 32; i++)
                {

                    mask = (uint)(1 << i);
                    bit = (uint)((p & mask) >> i);

                    if (bit == 1)
                    {

                        count1++;
                    }
                    else if (bit == 0 && mask < p)
                    {
                        count0++;
                    }

                }
                if (b == 1)
                {
                    Console.WriteLine("{0}", count1);
                }
                else
                {
                    Console.WriteLine("{0}", count0);
                }
            }
        }
    }
}