using System;

class Program
{
    static void Main(string[] args)
    {
        Square sShape = new Square("Blue", 5);

        Circle cShape = new Circle("Gold", 10);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sShape);
        shapes.Add(cShape);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The {s.GetColor()} shape has an area of {s.GetArea()}.");

        }

    }
}