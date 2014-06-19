using System;
     
class QuickSorting
{
    //Write a program that sorts an array of strings using the quick sort algorithm 

    static int lengthOfArray;

    static void Main()
    {
        Console.WriteLine("Sorting an array of strings using the quick sort algorithm.\n{0}", new string('-', 59));

        InitializingLengthOfArray();

        string[] inputArray = InitializingElementsOfArray();

        QuickSort(inputArray, 0, inputArray.Length - 1);

        PrintSortedArray(inputArray);
    }

    private static void InitializingLengthOfArray()
    {
        bool checkForLengthOfArray = true;

        while (checkForLengthOfArray)
        {
            Console.Write("Please input the length of the array: ");
            lengthOfArray = int.Parse(Console.ReadLine());

            if (lengthOfArray < 0)
            {
                Console.WriteLine("The length of the array must be greater or equel to 0.Please input the length of the array again!\n");
            }
            else
            {
                checkForLengthOfArray = false;
            }
        }
    }

    private static string[] InitializingElementsOfArray()
    {
        Console.WriteLine();

        string[] inputArray = new string[lengthOfArray];

        //StreamReader reader = new StreamReader("Sample.txt");

        for (long index = 0; index < lengthOfArray; index++)
        {
            Console.Write("Value in array[{0}]= ", index);
            inputArray[index] = Console.ReadLine();
        }
        return inputArray;
    }

    static int Partition(string[] stringArr, int p, int r)
    {
        string x = stringArr[r];
        int i = p - 1;
        string temp = "";
        for (int j = p; j < r; j++)
        {
            if ( string.Compare(stringArr[j], x) < 0)
            {
                i = i + 1;
                //swap stringArr[i] with stringArr[j]
                temp = stringArr[i];
                stringArr[i] = stringArr[j];
                stringArr[j] = temp;
            }
        }
        //swap stringArr[i+1] with stringArr[r]
        temp = stringArr[i + 1];
        stringArr[i + 1] = stringArr[r];
        stringArr[r] = temp;
     
        return i + 1;
    }
     
    static void QuickSort(string[] stringArr, int p, int r)
    {
        if (p < r)
        {
            int q = Partition(stringArr, p, r);
            QuickSort(stringArr, p, q - 1);
            QuickSort(stringArr, q + 1, r);
        }
    }

    private static void PrintSortedArray(string[] inputArray)
    {
        Console.WriteLine();

        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write(inputArray[i] + " ");
        }
        Console.WriteLine();
    }
}
