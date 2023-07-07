using System;

namespace App1.Part_2.Progi;
// 1. Enums
class Tuples
{
    public static void Init()
    {
        (string Name, int Score, int Level) score = GetScore();
        DisplayScore(score);

        (string N, int S, int L) GetScore() => ("R2D2", 1024, 5);

        void DisplayScore((string N, int S, int L) score )
        {
            Console.WriteLine($"Name {score.N} , Score: {score.S}, Level: {score.L}");
        }
    }

    public static void SimulaSoup()
    {
            Console.WriteLine($"Soup Types");
    }

    
}

