using System;
using System.Diagnostics;
using Departament_namespace;
using Worker_namespace;

class Source
{
    static void Main(string[] args)
    {
        Departament it = new Departament("IT");
        Departament marketing = new Departament("Marketing");

        Worker kira = new Worker("Kirill", 6000, 6);

        it.AddWorker(new Worker("Petya", 6000, 6));
        it.AddWorker(kira);
        it.AddWorker(new Worker("Vasily", 6000, 6));

        marketing.AddWorker(new Worker("Anastasiya", 3002, 2));
        marketing.AddWorker(new Worker("Ivan", 3002, 2));
        marketing.AddWorker(new Worker("Vasilisa", 3002, 2));

        it.PrintWorkers();
        marketing.PrintWorkers();

        it.FireWorker(kira);
        Console.WriteLine();
        it.PrintWorkers();
    }
}