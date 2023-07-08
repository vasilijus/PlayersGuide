using System;

namespace App1.Part_2.Progi;
// 1. Enums

class GetterSetter
{
    public GetterSetter()
    {
        Console.WriteLine("Getter Setter");
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