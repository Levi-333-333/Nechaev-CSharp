using System; // Системные классы и функции
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.AccessControl; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    enum Rarity
    {
        Common = 0,
        Uncommon = 1,
        Epic = 2,
        Legendary = 3,
        Champion = 4
    }
    class Unit
    {
        public delegate string BattleCryDelegate();
        public delegate string RarityCollorDelegate();

        private string unitName;
        private int x, y;
        private uint health, elixirCost, attackDamage;
        private Rarity rarity;

        public void Move(BattleCryDelegate battleCryDelegate, int x, int y)
        {
            //ProcessStartInfo processStartInfo = new ProcessStartInfo();
            //processStartInfo.Arguments = "D:\\Nechaev\\Nechaev_CSharp\\Nechaev-CSharp\\niggers.mp3";
            //processStartInfo.FileName = "cmd.exe";
            //processStartInfo.UseShellExecute = true;

            //Process process = new Process();
            //process.StartInfo = processStartInfo;
            //process.Start();

            Console.WriteLine($"{unitName} кричит {battleCryDelegate.Invoke()}");
            this.x = x;
            this.y = y;
            Process.Start("cmd.exe", "D:\\Nechaev\\Nechaev_CSharp\\Nechaev-CSharp\\niggers.mp3");
        }
        public void Attack(Unit other)
        {
            other.TakeDamage(attackDamage);
        }
        public void TakeDamage(uint damage)
        {
            health -= damage;
        }
        public void ChangeCollor(RarityCollorDelegate rarityCollorDelegate, Rarity rarity)
        {
            Console.WriteLine($"Текущий цвет юнита {unitName}: {rarityCollorDelegate.Invoke()}");
            this.rarity = rarity;
            Console.WriteLine($"Изменённый цвет юнита {unitName}: {rarityCollorDelegate.Invoke()}");
        }

        public Unit(int x, int y, uint health, uint elixirCost, uint attackDamage, string unitName, Rarity rarity)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            this.elixirCost = elixirCost;
            this.attackDamage = attackDamage;
            this.unitName = unitName;
            this.rarity = rarity;
        }

        public string Scream()
        {
            return "Hooog riideeeer!";
        }
        public string Cry()
        {
            return "Snickers";
        }
        public string GetCollor()
        {
            switch (rarity)
            {
                case Rarity.Common:
                    return "Голубой";
                case Rarity.Uncommon:
                    return "Оранжевый";
                case Rarity.Epic:
                    return "Фиолетовый";
                case Rarity.Legendary:
                    return "Призматический";
                case Rarity.Champion:
                    return "Золотой";
                default:
                    return "null";
            }
        }
        public string GetCollor2()
        {
            switch (rarity)
            {
                case Rarity.Common:
                    return "Голубой";
                case Rarity.Uncommon:
                    return "Оранжевый";
                case Rarity.Epic:
                    return "Фиолетовый";
                case Rarity.Legendary:
                    return "Призматический";
                case Rarity.Champion:
                    return "Золотой";
                default:
                    return "null";
            }
        }
    }
    class Source
    {
        

        static void Main(string[] args)
        {
            Unit hogRider = new Unit(0, 0, 2046, 4, 383, "Всадник на кабане", Rarity.Uncommon);
            Unit skeletons = new Unit(0, 0, 89, 1, 89, "Скелеты", Rarity.Common);

            hogRider.ChangeCollor(hogRider.GetCollor, Rarity.Legendary);
            skeletons.ChangeCollor(skeletons.GetCollor2, Rarity.Champion);
        }
    }
}
//		Практика
// 1. Создать поле делегата у класса Unit, которое бы в дальнейшем принимало на себя задачу по смене цвета карты юнита. Например, у хог райдера - оранжевый, у скелетиков - голубой.
// 2. Создать функцию смены цвета юнита, которая бы принимала объект делегата
// 3. Создать две функции с типом возвращаемого значения string, которые бы в зависимости от поля rarity в конструкции switch, возвращали строку с цветом юнита.