using System; // Системные классы и функции
using System.Collections.Generic; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    class Source
    {
        static void Main(string[] args)
        {
			uint[,] array2D =
			{
				{5, 6, 7, 8, 9 },
				{70, 2, 3, 4, 5 },
				{1, 80, 3, 4, 5 },
				{1, 40, 3, 4, 5 },
				{1, 2, 25, 4, 5 },
			};
			uint maxValue = 0;

			for (uint i = 0; i < array2D.GetLength(0); i++)
			{
				for (uint j = 0; j < array2D.GetLength(1); j++)
				{
					if (maxValue < array2D[i, j]) maxValue = array2D[i, j];
				}
                Console.WriteLine($"Максимальное значение в {i}-й строке - {maxValue}");
				maxValue = 0;
			}
		}
    }
}