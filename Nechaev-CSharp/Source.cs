using System; // Системные классы и функции
using System.Collections.Generic; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    class Source
    {
        static void Main(string[] args)
        {
            byte[] bytes = new byte[10];
            for (int i = 0; i < bytes.Length; i++)
            {
                byte temp = Convert.ToByte(i * 2);
                if (temp == 8)
                {
                    Console.WriteLine("Это говно (8) я вписывать не буду");
                    continue;
                }
				bytes[i] = temp;
                if (bytes[i] == 16)
                {
                    Console.WriteLine("Обнаружено 16. Я обиделся");
                    break;
                }
                Console.WriteLine($"{i}-й элемент = {bytes[i]}");
            }
        }
    }
}