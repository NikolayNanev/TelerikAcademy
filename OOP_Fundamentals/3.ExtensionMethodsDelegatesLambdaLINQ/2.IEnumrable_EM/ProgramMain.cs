namespace IEnumrable_ExtensionMethod
{
    using System;
    using System.Collections.Generic;

    public class ProgramMain
    {
        static void Main()
        {
            //Test of Sum()
            var list = new List<decimal>() { 4,7,8,9,7,4.0m,7.1524m,745.114m };
            decimal sumDecimal = list.Sum();
            Console.WriteLine("Sum:" + sumDecimal);

            //Test of Product()
            int[] arrayInt = { 4, 7, 8, 9, 7};
            decimal productInt = arrayInt.Product();
            Console.WriteLine("Product:" + productInt);

            //Test of Min()
            decimal[] arrayDouble = { 4.2m, 7.5m, 1.8m, 0.9m, 47 };
            decimal minDouble = arrayDouble.Min();
            Console.WriteLine("Min:" + minDouble);

            //Test of Max()
            var listFloat = new List<float> { -94.2f, 7.5f, -979.7f, 100.9f, 47 };
            float maxFloat = listFloat.Max();
            Console.WriteLine("Max:" + maxFloat);

            //Test of Average()
            var listShort = new List<short> { -94, 7, -79, 10, 47 };
            decimal averageShort = listShort.Average();
            Console.WriteLine("Average:" + averageShort);
        }
    }
}