using System; // Системные классы и функции
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.AccessControl; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    class SadException : Exception
    {
        private int[] array;
        public SadException(int[] array)
        {
            this.array = array;
        }
        public override string Message
        {
            get { return $"Массив не инициализирован!"; }
        }
    }

    class Source
    {
        static int Divide(int[]? array, int i, int j)
        {
            if (array == null) throw new SadException(array);
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
                //catch (NullReferenceException nullExeption)
                //{
                //    Console.WriteLine(nullExeption.Message);
                //}
                catch (IndexOutOfRangeException indexExeption)
                {
                    Console.WriteLine(indexExeption.Message);
                }
                catch (SadException divideException)
                {
                    Console.WriteLine(divideException.Message);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
                finally
                {
                    Console.WriteLine("Не смотря на все исключение деление отработало\n");
                }
            }
        }
    }
}