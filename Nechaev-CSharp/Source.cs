using System;
using System.Diagnostics;

// Интерфейс, определяющий функционал для движимых объектов.
// ОНИ МОГУТ БЫТЬ РАЗНОЙ ПРИРОДЫ!
public interface IAnimal
{
    public void Move();
    public void CollisionDetect() // пример-функция столкновения
    {
        Console.WriteLine("Объект столкнулся с другим объектом.");
    }
    public string Name { get; }
    public void PrintName() => Console.WriteLine($"Животное кличас {Name}");
}

class Racoon : IAnimal
{
    private string name;
    public Racoon(string name) => this.name = name;
    public string Name { get { return name; } }
    public void Move() => Console.WriteLine("Енот движется");
    public void Pet() => Console.WriteLine($"Вы гладите {name}");
}

class Source
{
    static void Main(string[] args)
    {
        IAnimal[] zoo = new IAnimal[] { new Racoon("Бандит"), new Racoon("Ракета"), new Racoon("Болт") };

        bool isSucsess = false;
        Console.Write("Введите имя енота, которого хотите погладить: ");
        string userInput = Console.ReadLine();
        foreach (Racoon racoon in zoo)
        {
            if (racoon.Name == userInput)
            {
                racoon.Pet();
                isSucsess = true;
                break;
            }
        }
        if (!isSucsess) Console.WriteLine("Нет такого енота в зоопарке");
    }
}

//      Практика
// 1. Дополнить программу новым интерфейсом функционала клички. В интерфейсе должны быть поле имени с определенными get и set свойствами и функция, которая бы в консоль выводила кличку животного в консоли.
// 2. В Main создать массив зоопарка, который должен хранить в себе объекты интерфейсов.
// 3. Дополнить классы животных функцией Pet(), которая выводит в консоль о том, что пользователь гладит животное + имя
// 4. Просить пользователя ввести имя животного, которое он хочет погладить.
// 5. В цикле перебирать каждое животное и сравнивать его имя со вводом пользователя. Если есть совпадение, то вызывать функцию Pet() от перечисляемого объекта.