using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class ArrayWithAllLettersFromAlphabet
{
    //Write a program that creates an array containing all letters from the alphabet (A-Z). 
    //Read a word from the console and print the index of each of its letters in the array.

    static void Main()
    {
        Console.WriteLine("Creates an array containing all letters from the alphabet.\nReading a word and print the index of each of it's letters.\n{0}",new string('-',59));

        char[] lettersFromAlphabet = InitializingLettersOfAlphabetInArray();

        Console.Write("Please input a word (in english/no symbols): ");
        string inputWord = Console.ReadLine();

        char[] inputWordInAnArray = InitializingLettersOfInputWordInArray(inputWord);

        for (int i = 0; i < inputWordInAnArray.Length; i++)
        {
            for (int j = 0; j < lettersFromAlphabet.Length; j++)
            {
                if (inputWordInAnArray[i] == lettersFromAlphabet[j])
                {
                    Console.WriteLine("{1} = {0}", Array.IndexOf(lettersFromAlphabet, lettersFromAlphabet[j]), inputWordInAnArray[i]);
                }
            }
        }
    }

    private static char[] InitializingLettersOfAlphabetInArray()
    {
        char[] lettersFromAlphabet = new char[52];

        for (int capitalLetters = 65, index = 0; capitalLetters < 91; capitalLetters++, index++)
        {
            lettersFromAlphabet[index] = (char)capitalLetters;
        }

        for (int smallLetters = 97, index = 26; smallLetters < 123; smallLetters++, index++)
        {
            lettersFromAlphabet[index] = (char)smallLetters;
        }
        return lettersFromAlphabet;
    }

    private static char[] InitializingLettersOfInputWordInArray(string inputWord)
    {
        char[] inputWordInAnArray = new char[inputWord.Length];

        using (StringReader readFirstString = new StringReader(inputWord))
        {
            readFirstString.Read(inputWordInAnArray, 0, inputWordInAnArray.Length);
        }
        return inputWordInAnArray;
    }
}