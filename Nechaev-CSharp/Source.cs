using System;
using System.Diagnostics;

struct Pen 
{
    string corpusMaterial, writingMaterial;
    public Pen(string corpusMaterial, string writingMaterial) 
    {
        this.corpusMaterial = corpusMaterial;
        this.writingMaterial = writingMaterial;
    }
    public void Draw() => Console.WriteLine($"Ручка из {corpusMaterial} материалом {writingMaterial} нарисовала пенис");
}

class Source
{
    static void Main(string[] args)
    {
        Pen p = new Pen("пластик", "чернила");
        p.Draw();
    }
}