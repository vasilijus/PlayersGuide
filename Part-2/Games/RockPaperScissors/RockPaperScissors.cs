namespace App1.Part_2.Games;

class RockPaperScissors
{
    private int player = 1;
    private int games = 0, won1 = 0, won2 = 0;

    public void Draw()
    {
        while (true)
        {
            Hand p1 = GetHand(1);
            Hand p2 = GetHand(2);

            int won = Challenge(p1, p2);
            // Count Player scores
            games++;
            if (won == 1) won1++;
            if (won == 2) won2++;
            Console.WriteLine($"Player {won} WON. Total Games: {games}, 1st {won1}, 2nd {won2}");
        }
    }

    private Hand? GetHand(int player)
    {
        Console.WriteLine($"Player {player} turn.");
        Console.WriteLine($"1.Rock, 2.Paper, 3.Scissor");
        
        int number = 0;
        Hand hand = Hand.Paper;
        while(number < 1 || number > 3)
        {
            number = int.Parse(Console.ReadLine());
            hand = number switch
            {
                1 => Hand.Rock,
                2 => Hand.Paper,
                3 => Hand.Scissor,
                _ => Hand.Paper
            };
        }
        return hand;
    }

    public int Challenge(Hand p1, Hand p2)
    {
        // rock bet scissor
        if(p1 == Hand.Rock && p2 == Hand.Paper) return 2;
        else if(p1 == Hand.Paper && p2 == Hand.Scissor) return 2;
        else if(p1 == Hand.Scissor && p2 == Hand.Rock) return 2;
        else 
            return 1;
    }

    
}

enum Hand
{
    Rock,
    Paper,
    Scissor
}