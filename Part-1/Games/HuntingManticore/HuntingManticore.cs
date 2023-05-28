using System;

namespace App1.Part_1.Games.ManticoreHunt;

class HuntingManticore
{
    static int cityLife = 15;
    static int manticoreLife = 10;
    static int manticoreDistance = 0;
    static int damage = 1;
    //<summary>
    //Level 14
    //</summary>
    public static void Init()   
    {
        Console.WriteLine("Welcome To Manticore Hunt!");
        Console.Write("Player 1 please place the Manticore's distane ( 1 - 100 ): ");
        manticoreDistance = Convert.ToInt32(Console.ReadLine());
        Seperator();
        Console.WriteLine("Player 2, it's your turn. ");
        string outcome = Status();
        Console.WriteLine(outcome);
    }

    public static void Seperator() {
        Console.WriteLine("-----------------------------------------------------------");
    }

    public static string ShotHitTarget(int distance)
    {
        if( distance < manticoreDistance ) return "Fell Short";
        else if (distance > manticoreDistance) return "Overshot";
        else return "DIRECT HIT!";
    }

    public static int DamagePowerCompute(int round)
    {
        if(round % 5 == 0 && round % 3 == 0) return 10;
        else if(round % 5 == 0 || round % 3 == 0) return 3;
        else
            return 1;
    }
    public static string Status()
    {
        bool GameWon = false;
        bool StillPlaying = true;
        int shot = 0;
        int round = 1;
        
        
        while (StillPlaying)
        {
            damage = DamagePowerCompute(round);
            string result = "";

            result += $"STATUS: Round: {round} City: 15/{cityLife} Manticore: 10/{manticoreLife}";
            result += $"\nThe cannon is expected to deal {damage} damage this round.";
            result += $"\nEnter desired cannon range: ";
            Console.Write(result);
            shot = Convert.ToInt32(Console.ReadLine());
            result = $"That round {ShotHitTarget(shot)} the target.";
            Console.WriteLine(result);
            Seperator();

            if(shot == manticoreDistance) 
                manticoreLife -= damage;

            if(manticoreLife <= 0) {
                GameWon = true;
                StillPlaying = false;
            }

            round++;
            cityLife--;
            
            if(cityLife == 0)
                StillPlaying = false;
        }


        if (GameWon)
           return "Congrats, you've found and killed the Manticore.";
        else 
            return "Game Over. Your City was destroyed.";
        
    }

}