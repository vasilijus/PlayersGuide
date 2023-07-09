namespace App1.Part_2.Games;

class TicTacToe
{
    public TicTacToe()
    {
        Console.WriteLine("TicTacToe constructor");
        Point ttt1 = new Point(2,3);
    }
}

public class Point
{
    public int A {get; private set;} = 0;
    public int B {get; private set;} = 0;

    public Point() : this(0, 0){}

    public Point(int a, int b)
    {
        Console.WriteLine($"Point: ({a},{b})");
        A = a;
        B = b;
    }
}