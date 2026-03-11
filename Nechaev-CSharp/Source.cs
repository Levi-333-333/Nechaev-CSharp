using System; // Системные классы и функции
using System.Collections.Generic; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    class Source
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите несколько слов, разделяя их проблом:");
            string userWords = Console.ReadLine();
            string[] words = userWords.ToLower().Split(' ');

            string longestWord = "";
            string[] unicalsWords = new string[words.Length];
            uint unicalsWordsCount = 0;

            bool canAdd = true;
            uint i = 0;

            foreach (string word in words)
            {
                if (longestWord.Length < word.Length) longestWord = word;

                canAdd = true;
                foreach (string unicalWord in unicalsWords) if (unicalWord == word)
                {
                    canAdd = false;
                    break;
                }
                if (canAdd) unicalsWords[i] = word;

                i++;
            }

            foreach (string unicalWord in unicalsWords) if (unicalWord != null) unicalsWordsCount++;

            Console.WriteLine($"Количество слов: {words.Length}. Самое длинное слово: {longestWord}. Количество уникальных слов: {unicalsWordsCount}");
		}
    }
}