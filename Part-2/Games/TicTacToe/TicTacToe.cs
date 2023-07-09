namespace App1.Part_2.Games;

class TicTacToe
{
    
}

public class Point
{
    public float A {get;set;} = 0;
    public float B {get;set;} = 0;

    public Point() : this(0, 0){}

    public Point(float a, float b)
    {
        A = a;
        B = b;
    }
}