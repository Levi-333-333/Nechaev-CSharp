using System;
using System.Diagnostics;
 
class Pixel
{
    private uint r, g, b, a;
    public Pixel(uint r, uint g, uint b, uint a)
    {
        this.r = r;
        this.g = g;
        this.b = b;
        this.a = a;
    }
    public override string ToString()
    {
        return $"{r}, {g}, {b}, {a}";
    }
}
class Source
{
    string whoIsMe = "я редиска";
    static void PixelWork(Pixel pixel)
    {
        Console.WriteLine($"Пиксель {pixel} работает...");
        Thread.Sleep( 1000 );
        Console.WriteLine("Пиксель отработал своё.");
    }
    static void Main(string[] args)
    {
        List<Pixel> pixels = new List<Pixel>(new[] { new Pixel(255, 255, 255, 255), new Pixel(134, 246, 54, 155), new Pixel(33, 65, 32, 1) });
        pixels.AddRange(new[] { new Pixel(153, 64, 2, 6), new Pixel(23, 4, 56, 2), new Pixel(46, 35, 76, 255) });
        foreach (Pixel pixel in pixels)
        {
            Console.WriteLine(pixel);
        }
        
        LinkedList<Pixel> list = new LinkedList<Pixel>(pixels);
        list.AddFirst(new Pixel(34, 34, 34, 34));
        for (var i = list.First; pixels != null;)
        {
            PixelWork(list.First.Value);
            list.RemoveFirst();
        }
    }
}