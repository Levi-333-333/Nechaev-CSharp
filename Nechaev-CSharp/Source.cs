using System; // Системные классы и функции
using System.Collections.Generic; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    class Source
    {
        static void Main(string[] args)
        {
            string nameLeft = "Лево";
            string nameRight = new String(new char[] { 'П', 'р', 'а', 'в', 'о' });
            string nameAAAAAA = new String('A', 6);
			string nameRightExtended = new String(new char[] { 'П', 'р', 'а', 'в', 'о' }, 1, 3); // рав
            string greka2D =
                """
                Ехал Грека через реку
                Видит Ррека - в реке рак
                Сунул Грека руку в реку
                Рак за руку Греку цап
                """;

            string name = "Андрей";
            string lublu = "C++";
            Console.WriteLine("Моё имя: {0}. Я люблю: {1}", name, lublu);


		}
    }
}