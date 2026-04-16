using System;
using System.Diagnostics;
using System.Numerics;

struct Point {
    float x, y;
    public Point(float x, float y) {
        this.x = x;
        this.y = y;
    }
    public void Draw() => Console.WriteLine($"Всем привет я точка ({x}:{y})");
}

class Source
{
    static void Main(string[] args)
    {
        Point p = new Point(3, 6);
        p.Draw();
    }
}