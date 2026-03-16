using System; // Системные классы и функции
using System.Collections.Generic; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    class Safe
    {
        private string contents;
        private int pinCode;

        public int PinCode
        {
            private get { return pinCode; }
            init { pinCode = value; }
        }
        public string Contents
        {
            get
            {
                Console.WriteLine("Введите пароль");
                int tempPinCode = int.Parse(Console.ReadLine());
                if (tempPinCode == pinCode) return contents;
                else 
                {
                    Console.WriteLine("Отказано в доступе. Неверный пин-код.");
                    return null;
                }
            }
            set
            {
                Console.WriteLine("Введите пин-код");
                int tempPinCode = int.Parse(Console.ReadLine());
                if (tempPinCode == pinCode) contents += ", " + value;
                else Console.WriteLine("Отказано в доступе. Неверный пин-код.");
            }
        }
        public Safe (int pinCode)
        {
            this.pinCode = pinCode;
        }
        public void ChangePinCode(int NewpinCode)
        {
            Console.WriteLine("Введите старый пин-код");
            int tempPinCode = int.Parse(Console.ReadLine());
            if (tempPinCode == this.pinCode) this.pinCode = NewpinCode;
            else Console.WriteLine("Отказано в доступе. Неверный пин-код.");
        }
    }
    class Source
    {
        static void Main(string[] args)
        {
            Safe safe = new Safe(1488);

            Console.WriteLine("Добавление предмета");
            safe.Contents = "Крутые очки";
            Console.WriteLine("Просмотр предметов");
            Console.WriteLine(safe.Contents);
            Console.WriteLine("Изменение пароль");
            safe.ChangePinCode(1337);
            Console.WriteLine("Просмотр предметов");
            Console.WriteLine(safe.Contents);
            Console.WriteLine("Добавление предмета");
            safe.Contents = "Супер крутые очки";
            Console.WriteLine("Просмотр предметов");
            Console.WriteLine(safe.Contents);
        }
    }
}