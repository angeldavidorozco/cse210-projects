using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>{};
        shapes.Add(new Square("Red", 10));
        shapes.Add(new Rectangle("Green", 8, 7));
        shapes.Add(new Circle("Black", 9));

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} is the color");
            Console.WriteLine($"{Math.Round(shape.GetArea(), 2)} is the Area");
        }
    }
}