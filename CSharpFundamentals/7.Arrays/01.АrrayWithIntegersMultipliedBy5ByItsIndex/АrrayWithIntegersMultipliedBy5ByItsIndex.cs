using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class АrrayWithIntegersMultipliedBy5ByItsIndex
{
    //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
    //Print the obtained array on the console.

    static void Main()
    {
        int[] myIntegerArray = new int[20];

        for (int index = 0; index < myIntegerArray.Length; index++)
        {
            myIntegerArray[index] = 5 * index;
            Console.WriteLine(myIntegerArray[index]);
        }     
    }
}