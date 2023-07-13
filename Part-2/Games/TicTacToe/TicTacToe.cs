namespace App1.Part_2.Games;

class TicTacToe
{
    private string[] player = new string[2];
    private string[] board = new string[8];
    
    
    public TicTacToe()
    {   
        int playerStart = 0;
        Console.WriteLine("TicTacToe constructor");
        GetPlayerNames();
        SetupBoard();

        // Point ttt1 = new Point(2,3);
        while(true)
        {
            Console.WriteLine($"{player[playerStart]} turn.");
            if(playerStart == 0) playerStart = 1;
            else playerStart = 0;

            int selection = int.Parse(Console.ReadLine());
            int index = selection-1;

            // board[index] = playerStart == 0 ? "X":"O";
            SetupBoard(board);
        }
    }

    private void SetupBoard()
    {
        for (int i = 0; i < board.Length; i++)
        {
            board[i] = " ";
        }
        var template = $" 1 | 2 | 3 \n"+
                        "---+---+---\n"+
                        " 4 | 5 | 6 \n"+
                        "---+---+---\n"+
                        " 7 | 8 | 9 \n";
        Console.WriteLine(template);
    }

    private void SetupBoard(string[] a)
    {
        Console.WriteLine("template");
        var template = $" {a[0]} | {a[1]} | {a[2]}\n"+
                                "---+---+---"+
                        $" {a[3]} | {a[4]} | {a[5]}\n"+
                                "---+---+---"+
                        $" {a[6]} | {a[7]} | {a[8]}\n";
        Console.WriteLine(template);
    }

    private void GetPlayerNames()
    {
        // throw new NotImplementedException();
        for (int index = 0; index < player.Length; index++)
        {
            Console.WriteLine($"Enter player's {index+1} name.");
            player[index] = Console.ReadLine();
        }
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