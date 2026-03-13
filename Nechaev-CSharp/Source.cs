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
                Console.WriteLine("Введите старый пин-код");
                int tempPinCode = int.Parse(Console.ReadLine());
                if (tempPinCode == pinCode) contents = value;
                else Console.WriteLine("Отказано в доступе. Неверный пин-код.");
            }
        }
        Safe (int pinCode)
        {
            this.pinCode = pinCode;
        }
        public void ChangePinCode(int NewpinCode)
        {
            // Доделать
        }
    }
    class Source
    {
        static void Main(string[] args)
        {
            
        }
    }
}