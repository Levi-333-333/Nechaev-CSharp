using System;
using System.Diagnostics;

// Абстрактный класс животного, определяющий функционал только для классов одной природы, то есть животных!
abstract class OutputDevice
{
    public abstract void Move();
    public abstract void ShowData();
    public abstract void TurnOff();
}

// Интерфейс, определяющий функционал для движимых объектов.
// ОНИ МОГУТ БЫТЬ РАЗНОЙ ПРИРОДЫ!
public interface IInputDevice
{
    public void Move();
    public void EnterData();
    public void TurnOff();
}

class ComputerMouse : IInputDevice
{
    public void Move() 
    {
        Console.WriteLine("Вы подвигали мышку.");
    }
    public void EnterData()
    {
        Console.WriteLine("Вы кликнули кнопкой мыши.");
    }
    public void TurnOff()
    {
        Console.WriteLine("Вы выключили мышь.");
    }
}

class Monitor : OutputDevice
{
    public override void Move()
    {
        Console.WriteLine("Монитор подвигали.");
    }
    public override void ShowData()
    {
        Console.WriteLine("Монитор выводит экран.");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Монитор выключен.");
    }
}

class Source
{
    static void Main(string[] args)
    {
        Monitor monitor = new Monitor();
        monitor.Move();
        monitor.ShowData();
        monitor.TurnOff();

        ComputerMouse computerMouse = new ComputerMouse();
        computerMouse.Move();
        computerMouse.EnterData();
        computerMouse.TurnOff();
    }
}


//      Абстрактные класс и интерфейсы
// Абстрактный класс - это такой, который не реализует функционал и позволяет наследуемым классам его задать или преопределить
// Более продвинутым способом определить некий шаблон является создание интерфейса.
// Главным смысловым отличием абстрактного класса от интерфейса является то, что первый используется для описания классов сущностей одной природы, а интерфейсы - однотипных, определяющих действия по отношению к сущностям.

//      Практика
// 1. С использованием имеющихся знаний попытаться применить реализованную функцию интерфейса IMovable в наследуемом классе ComputerMouse и вызвать ее в Main()
// 2. Создать абстрактный класс, который бы по сущности подходил к компьютерной периферии и объявлял 3 метода. Далее необходимо создать новый класс компьютерной периферии который наследуется от нового абстрактного класса. Продемонстрировать функционал в Main()
// 3. Создать интерфейс, который бы по сущности подходил к компьютерной периферии и объявлял 3 метода. Далее необходимо создать новый класс компьютерной периферии который наследуется от нового интферйеса. Продемонстрировать функционал в Main()
