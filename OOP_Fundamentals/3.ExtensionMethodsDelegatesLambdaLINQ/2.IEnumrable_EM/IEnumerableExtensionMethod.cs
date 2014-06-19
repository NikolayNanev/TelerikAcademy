namespace IEnumrable_ExtensionMethod
{
    //Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
    //  -sum
    //  -product
    //  -min
    //  -max
    //  -average

    using System;
    using System.Collections.Generic;

    public static class IEnumerableExtensionMethod
    {
        public static T Sum<T>(this IEnumerable<T> item)
        {
            dynamic sum = 0;
            foreach (var nextElement in item)
            {
                sum += nextElement;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> item)
        {
            dynamic product = 1;
            foreach (var nextElement in item)
            {
                product *= nextElement;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> item)
        {
            dynamic min = ulong.MaxValue; 

            foreach (var nextElement in item)
            {
                if (nextElement < min)
                {
                    min = nextElement;
                }
            }
            
            return min;
        }

        public static T Max<T>(this IEnumerable<T> item)
        {
            dynamic max = ulong.MinValue;

            foreach (var nextElement in item)
            {
                if (nextElement > max)
                {
                    max = nextElement;
                }
            }

            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> item)
        {
            int count = 0;
            dynamic sum = 0;

            foreach (var nextElement in item)
            {
                count++;
                sum += nextElement;
            }

            decimal average = (decimal)sum/count;

            return average;
        }
    }
}