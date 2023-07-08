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
    private float _width;
    private float _height;

    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
    }

    public float GetWidth() => _width;
    public float GetHeight() => _height;
    public float GetArea() => _width * _height;

    public void SetWidth(float width) => _width = width;
    public void SetHeight(float height) => _height = height;
}