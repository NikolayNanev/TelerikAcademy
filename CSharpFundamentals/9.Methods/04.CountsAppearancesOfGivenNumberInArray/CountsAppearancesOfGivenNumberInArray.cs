using System;
 
class CountsAppearancesOfGivenNumberInArray
{
    //Write a method that counts how many times given number appears in given array. 

    static int numberToCheck;
    static int curentIndex;

    static void Main()
    {
        Console.Write("Please input the number you wish to chek: ");
        numberToCheck = int.Parse(Console.ReadLine());

        int[] testArray1 = new int[] { 5, 2, 45, 5, 45, 5, 1, 1, 9, 10 };
        int[] testArray2 = new int[] { 1, 2, 3, 4, 5, 45, 4, 11, 8, 1 };
        int[] testArray3 = new int[] { 100, 11, -70, 45, 78, 98, 1, 45, 1, -8 };

        Console.WriteLine();
        CountingGivenNumberInArray(numberToCheck, testArray1);
        Console.WriteLine();

        CountingGivenNumberInArray(numberToCheck, testArray2);
        Console.WriteLine();

        CountingGivenNumberInArray(numberToCheck, testArray3);
        Console.WriteLine();
    }

    static void CountingGivenNumberInArray(int number, int[] array) 
    {
        Array.Sort(array);
        int indexOfSearchedNumber = Array.BinarySearch(array, number);

        if (indexOfSearchedNumber < 0)
        {
            Console.WriteLine("The number you wish to chek is not present in the array.");
        }
        else
        {
            if (indexOfSearchedNumber == 0)
            {
                curentIndex = indexOfSearchedNumber;
            }

            else if (array[indexOfSearchedNumber] == array[indexOfSearchedNumber - 1])
            {
                while (array[indexOfSearchedNumber] == array[indexOfSearchedNumber - 1])
                {
                    if (indexOfSearchedNumber - 1 == 0)
                    {
                        indexOfSearchedNumber--;
                        break;
                    }
                    else
                    {
                        indexOfSearchedNumber--;
                    }                  
                }

                curentIndex = indexOfSearchedNumber;
            }
            else
            {
                curentIndex = indexOfSearchedNumber;
            }

            int count = 1;
            while (curentIndex != array.Length - 1 && array[curentIndex] == array[curentIndex + 1])
            {
                count++;
                curentIndex++;
            }

            Console.WriteLine("Number \'{0}\' appears {1} time(s) in the given array.", number, count);
        }
    }
}