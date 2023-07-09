using System;

namespace App1.Part_2.Games;

class AsteroidsGame
{
    public Asteroid[] _asteroids;

    public AsteroidsGame()
    {
        _asteroids = new Asteroid[5];
        _asteroids[0] = new Asteroid(100, 24, 52, 33);
        _asteroids[1] = new Asteroid(10,71,22,35);
        _asteroids[2] = new Asteroid(15, 24, 65, 23);
        _asteroids[3] = new Asteroid(10,32,22,35);
        _asteroids[4] = new Asteroid(53, 55, 12, 63);
    }

    public AsteroidsGame(Asteroid[] startingAsteroids)
    {
        _asteroids = startingAsteroids;
    }

    public void Run()
    {
       Console.WriteLine("Run Game");
       while (true)
       {
        foreach (var asteroid in _asteroids)
        {
            asteroid.Update();
        }
       }
    }
}

public class Asteroid
{
    public float PosX { get; private set; }
    public float PosY { get; private set; }
    public float VelocityX { get; private set; }
    public float VelocityY { get; private set; }

    public Asteroid(float px, float py, float vx, float vy)
    {
        PosX = px;
        PosY = py;
        VelocityX = vx;
        VelocityY = vy;
    }

    public void Update()
    {
        PosX += VelocityX;
        PosY += VelocityY;
        Console.WriteLine($"Position: x:{PosX}, y:{PosY}");
    }
    
}