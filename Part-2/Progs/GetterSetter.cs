using System;

namespace App1.Part_2.Progi;
// 1. Enums

class GetterSetter
{
    public GetterSetter()
    {
        Console.WriteLine("Getter Setter");
        Rectangle rectangle = new Rectangle(2,4);
        Console.WriteLine(rectangle.Area);
        // Circle circle = new Circle();
        // circle.Radius = 5;
        // circle.X = -3;
        // C# provides - object initializer syntax , when initializing object
        Circle circle = new Circle() { Radius = 5, X = -3 };
        // Or because - get; init; , we can do
        Circle circle2 = new Circle { Radius = 4, X = -2, Y = 3 }; 
    }
}

public class Rectangle
{
    public float Width { get; set; }
    public float Height { get; set; }
    public float Area => Height * Width;
    // public float GetArea() => _width * _height;
    // public float GetWidth() => _width;
    // public float GetHeight() => _height;
    // public void SetWidth(float width) => _width = width;
    // public void SetHeight(float height) => _height = height;

    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }


}

public class Player
{
    public string Name { get; } = "Player 1"; // Can only assign on constructor
    // OR do readonly
    // public readonly string _name;

    public Player(string name)
    {
        Name = name;
    }
}

public class Circle
{
    public float X { get; init; }
    public float Y { get; init; }
    public float Radius { get; init; } = 0;
}
