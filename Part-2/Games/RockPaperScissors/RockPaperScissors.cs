namespace App1.Part_2.Games;

class RockPaperScissors
{
    private int player = 1;

    public void Draw()
    {
        Console.WriteLine($"1.Rock, 2.Paper, 3.Scissor");
        Console.WriteLine($"Player {player}:");
        var p1 = int.Parse(Console.ReadLine());
        var p2 = int.Parse(Console.ReadLine());
        Challenge(p1, p2);
    }
    public void Challenge(int p1, int p2)
    {
        // rock bet scissor
        if(p1 == 1 && p2 == 2){
            Console.WriteLine($"Player {p2} won ");
        }
        else
        {
            Console.WriteLine($"Player {p1} won ");
        }
        
        if(p1 == 2 && p2 == 3){
            Console.WriteLine($"Player {p2} won ");
        }
        else
        {
            Console.WriteLine($"Player {p1} won ");
        }

        if(p1 == 3 && p2 == 1){
            Console.WriteLine($"Player {p2} won ");
        }
        else
        {
            Console.WriteLine($"Player {p1} won ");
        }
    }

    
}

enum Hand
{
    Rock,
    Paper,
    Scissor
}