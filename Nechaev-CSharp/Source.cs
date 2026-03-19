using System; // Системные классы и функции
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.AccessControl; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    class Source
    {
        static int Divide(int[]? array, int i, int j)
        {
            return array[i] / array[j];
        }

        static void Main(string[] args)
        {
            int[]? array1 = null;
            int[]? array2 = { 2, 0 };
            int[]? array3 = { 4, 5 };

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    if (i == 0) Console.WriteLine($"Деление выполено: {Divide(array1, 0, 1)}");
                    else if (i == 1) Console.WriteLine($"Деление выполено: {Divide(array2, 0, 1)}");
                    else if (i == 2) Console.WriteLine($"Деление выполено: {Divide(array3, 0, 2)}");
                }
                catch (DivideByZeroException zeroExeption)
                {
                    Console.WriteLine(zeroExeption.Message);
                }
                catch (NullReferenceException nullExeption)
                {
                    Console.WriteLine(nullExeption.Message);
                }
                catch (IndexOutOfRangeException indexExeption)
                {
                    Console.WriteLine(indexExeption.Message);
                }
            }
        }
    }
}