using System; // Системные классы и функции
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Threading.Channels; // Коллекции, на подобие List, Dictionary и так далее

enum Comands
{
    Move = 0,
    Scan = 1,
    ReplenishEnergy = 2,
    Help = 3,
    Exit = 4
}

namespace Nechaev_CSharp // Пространство имён
{
    class LowEnergyException : Exception
    {
        override public string Message
        {
            get { return "Недостаточно энергии."; }
        }
    }
    class IncorrectComandException : Exception
    {
        override public string Message
        {
            get { return "Неверная команда."; }
        }
    }
    class Rover
    {
        public Rover(int x, int y, int z, string name)
        {
            coordinates = new int[] { x, y, z };
            scanned = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            ;
            energy = 5;
            this.name = name;
        }

        public int[] Coordinates
        {
            get { return coordinates; } 
        }
        public int[] Scanned
        {
            get { return scanned; }
        }
        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }
        public string Name
        {
            get { return name; }
        }

        public void Move(int x, int y, int z)
        {
            if (energy > 0)
            {
                coordinates[0] = x; 
                coordinates[1] = y; 
                coordinates[2] = z;
                energy--;
            }
            else throw new LowEnergyException();

        }
        public void Scan()
        {
            if (energy - 2 >= 0)
            {
                for (int i = 0; ; ++i)
                {
                    if (scanned[i] == 0)
                    {
                        scanned[i] = rnd.Next();
                        break;
                    }
                    else continue;
                } 
                energy -= 2;
                Console.WriteLine($"Робот {name} просканировал территорию.");
            }
            else throw new LowEnergyException();
        }
        public void ReplenishEnergy()
        {
            energy = 5;
            Console.WriteLine($"Робот {name} полностью заряжен.");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"\nРовер {name}. Заряд: {energy}/5.\nМестонахождение (x,y,z): ({coordinates[0]},{coordinates[1]},{coordinates[2]})\n\nНапишите 'Help' для вывода списка команд");
        }
        public void Help()
        {
            Console.WriteLine("\nДоступные команды:\nMove - перемещает ровера на заданные позже координаты. Тратит одну энергию.\nScan - Сканирует объект и добавляет его в свою базу данных. Тратит 2 энергии.\nReplenishEnergy - Восполняет энергию до максимума.\nHelp - выводит список команд.\nExit - Завершить программу.\n");
        }

        private string name;
        private int[] coordinates;
        private int[] scanned;
        private int energy; // 5 max

        Random rnd = new Random();
    }
    class Source
    {
        static void Main(string[] args)
        {
            Rover rover = new Rover(0, 0, 0, "Никита");

            string? userInput = null;
            string? nestedUserInput = null;

            do
            {
                try
                {                 
                    rover.PrintInfo();
                    userInput = Console.ReadLine();

                    if (userInput == "Move")
                    {
                        Console.Write("Введите координату X:");
                        nestedUserInput = Console.ReadLine();
                        int X = int.Parse(nestedUserInput);
                        nestedUserInput = null;

                        Console.Write("Введите координату Y:");
                        nestedUserInput = Console.ReadLine();
                        int Y = int.Parse(nestedUserInput);
                        nestedUserInput = null;

                        Console.Write("Введите координату Z:");
                        nestedUserInput = Console.ReadLine();
                        int Z = int.Parse(nestedUserInput);
                        nestedUserInput = null;

                        rover.Move(X, Y, Z);
                        userInput = null;
                    }
                    else if (userInput == "Scan")
                    {
                        rover.Scan();
                        userInput = null;
                    }
                    else if (userInput == "ReplenishEnergy")
                    {
                        rover.ReplenishEnergy();
                        userInput = null;
                    }
                    else if (userInput == "Help")
                    {
                        rover.Help();
                        userInput = null;
                    }
                    else if (userInput == "Exit")
                    {
                        Console.WriteLine("Удачного дня!");
                    }
                    else
                    {
                        userInput = null;
                        throw new IncorrectComandException();
                    }
                }
                catch (LowEnergyException ex) 
                {
                    Console.WriteLine(ex.Message); 
                }
                catch (IncorrectComandException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный ввод координат.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"Место на диске у {rover.Name} закончилось.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                }
            } while (userInput != "Exit");
        }
    }
}