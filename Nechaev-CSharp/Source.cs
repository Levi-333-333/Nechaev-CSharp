using System; // Системные классы и функции
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Threading.Channels; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    class LowEnergyException : Exception
    {

    }
    class Rover
    {
        public Rover(int x, int y, int z)
        {
            coordinates = new int[] { x, y, z };
            scanned = new int[] { };
            energy = 5;
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

        public void Move(string name, int x, int y, int z)
        {
            if (energy != 0)
            {
                this.name = name;
                coordinates[0] = x; 
                coordinates[1] = y; 
                coordinates[2] = z;
                energy--;
            }
            else Console.WriteLine("Недостаточно заряда!!!");

        }
        public void Scan()
        {
            if (energy - 2 > 0)
            {
                scanned[scanned.Length] = rnd.Next();
                energy -= 2;
            }
            else Console.WriteLine("Недостаточно энергии!!!");
        }
        public void ReplenishEnergy()
        {
            energy = 5;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Ровер {name}. Заряд: {energy}/5.\nМестонахождение (x,y,z): ({coordinates[0]},{coordinates[1]},{coordinates[2]})\n\nНапишите 'Help' для вывода списка команд");
        }
        public void Help()
        {
            Console.WriteLine("Доступные команды:\nMove - перемещает ровера на заданные позже координаты. Тратит одну энергию.\nScan - Сканирует объект и добавляет его в свою базу данных. Тратит 2 энергии.\nReplenishEnergy - Восполняет энергию до максимума.\nHelp - выводит список команд.\nExit - Завершить программу.\n");
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
            
        }
    }
}