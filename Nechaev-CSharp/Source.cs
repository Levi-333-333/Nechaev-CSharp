using System; // Системные классы и функции
using System.Collections.Generic; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    class Source
    {
        static void Main(string[] args)
        {
            string userName = "Default";
            string userPassword = "Default";
            int errorCounts = 0;

            int userChoice = 0;
            do
            {
                Console.WriteLine("Вы входите в систему. Для продолжения введите 1. Для выхода введите 0");
				userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 0) break;

                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string password = Console.ReadLine();

                if (name == userName && password == userPassword)
                {
                    Console.WriteLine("Вы вошли в систему. Вы лопух");
                    break;
                }
                else
                {
                    errorCounts++;
                    if (errorCounts == 3)
                    {
                        Console.WriteLine("Ты олух");
                        break;
                    }
                    Console.WriteLine($"Неверный логин или пароль. У вас осталось {3 - errorCounts}");
                }
            } while (userChoice != 0);
        }
    }
}