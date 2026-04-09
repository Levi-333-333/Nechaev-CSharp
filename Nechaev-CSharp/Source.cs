using System;
using System.Diagnostics;

abstract class OutputDevice
{
    public abstract void Move();
    public abstract void ShowData();
    public abstract void TurnOff();
    public abstract string Model { get; set; }
}

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

    public override string Model
    {
        get { return model; }
        set { model = value; }
    }

    private string model;
}
class Printer : OutputDevice
{
    public override void Move()
    {
        Console.WriteLine("Принтер подвигали.");
    }
    public override void ShowData()
    {
        Console.WriteLine("Принтер печатает.");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Принтер выключен.");
    }

    public override string Model
    {
        get { return model; }
        set { model = value; }
    }

    private string model;
}

class Source
{
    static void Main(string[] args)
    {
        Monitor monitor = new Monitor();
        monitor.Model = "ViewSonic";

        Printer printer = new Printer();
        printer.Model = "HP";

        OutputDevice[] devices = new OutputDevice[] { monitor, printer };

        Console.Write("Каким девайсом вы хотите воспользоваться? (ViewSonic/HP)");
        string userInput = Console.ReadLine();

        for (int i = 0; i < devices.Length; i++)
        {
            if (devices[i].Model == userInput) devices[i].ShowData();
        }
    }
}