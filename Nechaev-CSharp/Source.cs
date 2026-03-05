using System; // Системные классы и функции
using System.Collections.Generic; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    class Source
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[5, 5];
            uint[,] intArray2D =
            {
                {1, 2, 3, 4, 5 },
                {1, 2, 3, 4, 5 },
                {1, 2, 3, 4, 5 },
                {1, 2, 3, 4, 5 },
                {1, 2, 3, 4, 5 }
            };

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[i, j] = j;
                    Console.WriteLine($"({i}, {j})");
                }
            }

            for (int i = 0; i < intArray2D.GetLength(0); i++)
            {
                for (int j = 0; j< intArray2D.GetLength(1); j++)
                {
                    Console.Write($"{intArray2D[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}