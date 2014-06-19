using System;

class SortingStringArrayByLengthOfElements
{
    //You are given an array of strings. Write a method that sorts the array by the length of its elements.

    static long lengthOfArray;

    static void Main()
    {
        InitializingLengthOfArray();

        string[] inputArray = InitializingElementsOfArray();

        inputArray = SortingArrayByLengthOfElements(inputArray);

        //Array.Sort(inputArray, (x, y) => x.Length.CompareTo(y.Length));

        Console.WriteLine("\nSorted array:");

        foreach (var item in inputArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");
    }

    static void InitializingLengthOfArray()
    {
        bool checkForLengthOfArray = true;

        while (checkForLengthOfArray)
        {
            Console.Write("Please input the length of the array N= ");
            lengthOfArray = long.Parse(Console.ReadLine());

            if (lengthOfArray < 0)
            {
                Console.WriteLine("The length of the array must be greater or equel to 0 N>=0.\nPlease input the length of the array again!\n");
            }
            else
            {
                checkForLengthOfArray = false;
            }
        }
    }

    static string[] InitializingElementsOfArray()
    {
        string[] inputArray = new string[lengthOfArray];

        //string[] inputArray = { "kashkaval", "aaval", "val", "supa", "gorski", "zismo", "doktorite", "amonqk" };

        Console.WriteLine();
        
        for (int index = 0; index < lengthOfArray; index++)
        {
            Console.Write("Value in array[{0}]= ", index);
            inputArray[index] = Console.ReadLine();
        }
        return inputArray;
    }

    static string[] SortingArrayByLengthOfElements(string[] array)
    {
        for (int i = 0; i < lengthOfArray; i++)
        {
            for (int j = i + 1; j < lengthOfArray; j++)
            {
                string curentMinElement = array[i];

                if (array[j].Length <= curentMinElement.Length)
                {
                    string tempNumber = array[i];
                    array[i] = array[j];
                    array[j] = tempNumber;
                }
            }
        }

        return array;
    }
}