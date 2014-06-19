using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicWords
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        var listWithWords = new List<string>(numberN);

        for (int i = 0; i < numberN; i++)
        {
            var nextWord = Console.ReadLine();
            listWithWords.Add(nextWord);
        }

        for (int i = 0; i < numberN; i++)
		{
            var valueOfCurentPosition = listWithWords[i];
            var nextPosition = listWithWords[i].Length % (numberN + 1);

            listWithWords.Insert(nextPosition, valueOfCurentPosition);

            if (nextPosition < i)
            {
                listWithWords.RemoveAt(i + 1);
            }
            else
            {
                listWithWords.RemoveAt(i);
            }
		}

        int lengthOfLongestWord = 0;

        foreach (var word in listWithWords)
        {
            int lengthOfCurentWord = word.Length;

            if (lengthOfCurentWord > lengthOfLongestWord)
            {
                lengthOfLongestWord = lengthOfCurentWord;
            }
               
        }

        var bilder = new StringBuilder();

        for (int i = 0; i < lengthOfLongestWord; i++)
        {
            foreach (var word in listWithWords)
            {
                if (word.Length > i)
                {
                    bilder.Append(word[i]);
                }
                else
                {
                    bilder.Append(String.Empty);
                }
            }
        }


        Console.WriteLine(bilder);
    }
}