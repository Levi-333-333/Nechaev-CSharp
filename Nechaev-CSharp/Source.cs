using System;
using System.Diagnostics;
using System.Numerics;

public abstract class IPizza
{
    public abstract string Name { get; }
    public abstract string Topping { get; }
    public abstract double Price { get; }
    public abstract bool IsEatable { get; }
    public abstract bool IsNull { get; }
}

public class PeperoniPizza : IPizza
{
    public override string? Name { get; }
    public override string? Topping { get; }
    public override double Price { get; }
    public override bool IsEatable { get; }

    public override bool IsNull => false;

    public PeperoniPizza(string name, string topping, double price, bool isEatable)
    {
        Name = name;
        Topping = topping;
        Price = price;
        IsEatable = isEatable;
    }
}

public class NullPeperoniPizza : IPizza
{
    public override string Name => "Я пицца";
    public override string Topping => "без начинки";
    public override double Price => 0.0;
    public override bool IsEatable => false;

    public override bool IsNull => true;

}

public class Order
{
    public string Name { get; set; }
    public IPizza Pizza { get; set; }

    public Order(string name, IPizza? pizza)
    {
        Name = name;
        Pizza = pizza ?? new NullPeperoniPizza();
    }
}

class Source
{
    static void Main(string[] args)
    {
        Order order = new Order("Пицца 0", null);
        Console.WriteLine(order.Pizza.Name);

        Order order1 = new Order("Пицца 1", new PeperoniPizza("Давид", "В ананасе", 1.0, false));
        Console.WriteLine(order1.Pizza.Name);
    }
}

//      Практика
// Продемонстрировать введение нулевого объекта на примере наследования от абстрактного класса:
// 1. Создать абстрактный класс пиццы с полями названия, стоимости и начинки;
// 2. Создать наследуемый конкретный класс пиццы;
// 3. Создать класс заказа и продемонстрировать работу с оператором ?? при инициализации поля заказа;
// 4. В Main создать пару объектов с нулем и с настоящим объектом.