using System; // Системные классы и функции
using System.Collections.Generic; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    class Greka
    {
        private string name;
        private int age;
        private float salary;
        private int workHours;
        private int cancerPerHour;
        // Практика 1
        private string HomeAdress {  get; set; }
        public bool HasPet { private get; set; }
        public int Scars { get; init; }
        // Практика 2
        private int fingersPerHand;
        private int hands;
        private int fingers;
        // Автоматическое св-во
        // Если поле применяет автоматическое свойство, то оно записывается с большой буквы
        // Одно из свойств поля при таком случе должно быть без модификатора доступа, иначе с полем невозможно проконтактировать.
        // Для автоматического свойства можно убрать get или set и приписать к одному из них модификатор доступа
        // Вместо части set для свойства можно использовать ключевое слово init. При этом можно записать значение в свойство, но только 1 раз и только с помощью конструктора, инициализатора или значения по умолчанию.
        public bool HasBoatDocuments { get; private set; }
        public bool Fingerprint { get; init; } = true;
        public bool IsAlife { get; set; } = true;

        public Greka()
        {
            name = "";
            age = 0;
            salary = 0;
            workHours = 0;
            cancerPerHour = 0;
        }
        public Greka(string name, int age, int workHours, int cancerPerHour, string HomeAdress, bool HasPet, int Scars, int fingersPerHand, int hands)
        {
            this.name = name;
            this.age = age;
            this.salary = workHours * cancerPerHour;
            this.workHours = workHours;
            this.cancerPerHour = cancerPerHour;
            this.HomeAdress = HomeAdress;
            this.HasPet = HasPet;
            this.Scars = Scars;
            this.fingersPerHand = fingersPerHand;
            this.hands = hands;
            this.fingers = fingersPerHand * hands;
        }
        // Деконстракт используется для того, чтобы записать значения всех полей в выходные переменные
        // Позволяет у грепи получить выходные переменные значения полей объекта класса
        public void Deconstruct(out string name, out int age, out float salary)
        {
            name = this.name;
            age = this.age;
            salary = this.salary;
        }
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
        public float Salary
        {
            get { return workHours * cancerPerHour; } 
        }
        public int WorkHours
        {
            get { return workHours; }
            set { workHours = value; }
        }
        public int CansetPerHour
        {
            get { return cancerPerHour; }
            set { cancerPerHour = value; }
        }
        public int Fingers
        {
            get { return fingersPerHand * hands; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя греки: {name}\n" +
                $"Возраст греки: {age}\n" +
                $"Зарабатывает: {salary}\n" +
                $"Трудится {workHours} часов в день\n" +
                $"Ловит {cancerPerHour} рака(-ов) в час\n" +
                $"Живёт на {HomeAdress}\n" +
                $"Имеет {fingers} пальцев");
            if (!HasBoatDocuments) Console.WriteLine("Не может водить лодку");
            if (!HasPet) Console.WriteLine("Нет питомцев");
            else Console.WriteLine("Есть питомец(-ы)");
            if (!IsAlife) Console.WriteLine("Ныне считается мёртвым");
        }
    }

    class Source
    {
        static void Main(string[] args)
        {
            
            Greka greka = new Greka("Грека", 43, 8, 3, "ул. Пушкина, д. 'Колотушкина'", false, 0, 5, 4);
            greka.PrintInfo();
        }
    }
}