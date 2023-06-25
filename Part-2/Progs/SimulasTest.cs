using System;

namespace App1.Part_2.Progi;
class SimulasTest
{
    public static void Init() {
        string[] exit = {"q","quit", "end"};
        bool quit = false;

        Console.WriteLine("Part 2 - Simulas Test");
        ChestState chestState = ChestState.Lock;

        while(true)
        {
            Console.WriteLine($"The chest is {chestState}. What do you want to do? ");

            string input = Console.ReadLine();
            if(chestState == ChestState.Lock && input == "unlock") chestState = ChestState.Close; 
            if(chestState == ChestState.Close && input == "open") chestState = ChestState.Open; 
            if(chestState == ChestState.Open && input == "close") chestState = ChestState.Close; 
            if(chestState == ChestState.Close && input == "lock") chestState = ChestState.Lock; 
        }

        Console.WriteLine("");
    }

    
}

