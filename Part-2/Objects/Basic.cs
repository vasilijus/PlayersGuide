using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Part_2.Objects;

public class Basic
{
    public static void Test()
    {
        object a = new object();
        object b = new object();
        Console.WriteLine($"{a.ToString()}, {a.ToString()}, {a.Equals(b)}");
        GameObject[] gameObjects = new GameObject[]
        {
            new Asteroid(), new Asteroid(),
            new Ship(), new Bullet()
        };
    }
}

public class Asteroid : GameObject
{
    public float Size { get; }
    public float RotationAngle { get; }
}
public class Ship : GameObject{}
public class Bullet : GameObject{}

// inheritance can be as deep as you need
public class Scout : Ship{}
public class Bomber: Ship{}

public class GameObject
{
    public float PositionX { get; set; }
    public float PositionY { get; set; }
    public float VelocityX { get; set; }
    public float VelocityY { get; set; }
    
    public void Update()
    {
        PositionX += VelocityX;
        PositionY += VelocityY;
    }
}

