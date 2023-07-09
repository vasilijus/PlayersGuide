namespace App1.Part_2.Games;

class AsteroidDriftingSystem
{
    public Asteroid[] asteroids { get; set; } = new Asteroid[0];
    public void Update(Asteroid[] asteroids)
    {
        foreach (Asteroid asteroid in AsteroidsGame.Current.Asteroids)
        {
            asteroid.PosX += asteroid.VelocityX;
            asteroid.PosY += asteroid.VelocityY;
        }
    }
}